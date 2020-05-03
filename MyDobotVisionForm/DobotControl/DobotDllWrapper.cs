using DobotClientDemo.CPlusDll;
using MyDobotVisionForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyDobotVisionForm.DobotControl
{
    /// <summary>
    /// DobotDllのラッパークラス
    /// </summary>
    public class DobotDllWrapper
    {
        private byte _isJoint = 0;
        private bool _isConnectted = false;
        private JogCmd _currentCmd;
        private Pose _pose = new Pose();
        private System.Timers.Timer _posTimer = new System.Timers.Timer();

        /// <summary>
        /// 作業状況通知用イベント
        /// </summary>
        public event OnWorkingSituation OnWorkEvent;
        public delegate void OnWorkingSituation(object sender, string situation);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DobotDllWrapper()
        {
            StartGetPose();

            StartDobot();
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~DobotDllWrapper()
        {
            this.DisconnectDobot();
        }

        /// <summary>
        /// 作業を開始します
        /// </summary>
        public void WorkStart(double target_x, double target_y , SettingsObj obj)
        {
            // 作業をクリア
            DobotDll.SetQueuedCmdClear();
            // コマンド開始
            DobotDll.SetQueuedCmdStartExec();
            OnWorkEvent?.Invoke(this, "作業開始");

            // 現在位置を取得
            var pose = GetCurrentPose();
            OnWorkEvent(this, $"現在位置を取得:");
            OnWorkEvent?.Invoke(this, $"X:{pose.x}, Y:{pose.y}, Z:{pose.z}, R:{pose.rHead}");

            // 対象の上部まで移動(Z座標は適当)
            var cmdIndex = ptp((byte)2, (float)target_x, (float)target_y, (float)0.0, pose.rHead);
            OnWorkEvent?.Invoke(this, "対象の上部まで移動:");
            OnWorkEvent?.Invoke(this, $"X:{(float)target_x}, Y:{(float)target_y}, Z:{(float)0.0}, R:{pose.rHead}");

            // 対象物のZ座標計算
            var object_z = obj.PedestalZ + obj.ObjectHeight;
            OnWorkEvent?.Invoke(this, "対象物のZ座標:");
            OnWorkEvent?.Invoke(this, $"Z:{object_z}");

            // 対象の位置まで下がる
            cmdIndex = ptp((byte)2, (float)target_x, (float)target_y, (float)object_z, pose.rHead);
            OnWorkEvent?.Invoke(this, "対象物までアームを降ろす:");
            OnWorkEvent?.Invoke(this, $"X:{(float)target_x}, Y:{(float)target_y}, Z:{(float)object_z}, R:{pose.rHead}");
            // 下がったらサクションカップONしてつかむ
            DobotDll.SetEndEffectorSuctionCup(true, true, true, ref cmdIndex);
            OnWorkEvent?.Invoke(this, "サクションカップでつかむ");

            // いったん上に持ち上げる
            cmdIndex = ptp((byte)2, (float)target_x, (float)target_y, (float)0.0, pose.rHead);
            OnWorkEvent?.Invoke(this, $"持ち上げる:");
            OnWorkEvent?.Invoke(this, $"X:{(float)target_x}, Y:{(float)target_y}, Z:{(float)0.0}, R:{pose.rHead}");

            // 持っていく場所に移動
            cmdIndex = ptp((byte)2, (float)obj.PlacePoseXCoordinate, (float)obj.PlacePoseYCoordinate, (float)obj.PlacePoseZCoordinate, pose.rHead);
            OnWorkEvent?.Invoke(this, $"持っていく場所に移動:");
            OnWorkEvent?.Invoke(this, $"X:{(float)obj.PlacePoseXCoordinate}, Y:{(float)obj.PlacePoseYCoordinate}, Z:{(float)obj.PlacePoseZCoordinate}, R:{pose.rHead}");

            // 下がったらサクションカップOFFして放す
            DobotDll.SetEndEffectorSuctionCup(false, false, false, ref cmdIndex);
            OnWorkEvent?.Invoke(this, "サクションカップOFFして放す");

            // 上がって終わり
            cmdIndex = ptp((byte)2, (float)obj.PlacePoseXCoordinate, (float)obj.PlacePoseYCoordinate, (float)0.0 ,pose.rHead);
            OnWorkEvent?.Invoke(this, "アームを上にあげる");

            // コマンド終了
            DobotDll.SetQueuedCmdStopExec();

            OnWorkEvent?.Invoke(this, "作業終了");
        }

        /// <summary>
        /// 一時退避
        /// </summary>
        public void Evacuation()
        {
            var cmdIndex = ptp((byte)2, (float)0.0, (float)-200.0, (float)0.0, (float)0.0);
        }

        /// <summary>
        /// ホーミング
        /// </summary>
        public void Homing()
        {
            HOMECmd homeCmd = new HOMECmd();
            ulong cmdIndex = 0;
            DobotDll.SetHOMECmd(ref homeCmd, false, ref cmdIndex);
        }

        /// <summary>
        /// ロボットの現在位置を返します
        /// </summary>
        /// <returns></returns>
        public Pose GetCurrentPose() => this._pose;


        /// <summary>
        /// 切断処理
        /// </summary>
        public void DisconnectDobot() => DobotDll.DisconnectDobot();

        /// <summary>
        /// StartPeriodic
        /// </summary>
        private void StartGetPose()
        {
            _posTimer.Elapsed += new System.Timers.ElapsedEventHandler(PosTimer_Tick);
            _posTimer.Interval = 600;
            _posTimer.Start();
        }

        /// <summary>
        /// タイマーで定期的に現在位置を取得します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PosTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!_isConnectted)
                return;

            DobotDll.GetPose(ref _pose);

            // コンソール出力
            Console.WriteLine($"x:{_pose.x}");
            Console.WriteLine($"y:{_pose.y}");
            Console.WriteLine($"z:{_pose.z}");
            Console.WriteLine($"R:{_pose.rHead}");
        }

        /// <summary>
        /// StartDobot
        /// </summary>
        private void StartDobot()
        {
            StringBuilder fwType = new StringBuilder(60);
            StringBuilder version = new StringBuilder(60);
            int ret = DobotDll.ConnectDobot("", 115200, fwType, version);
            // start connect
            if (ret != (int)DobotConnect.DobotConnect_NoError)
            {
                Console.WriteLine("Connect error", Utils.MsgInfoType.Error);
                return;
            }
            Console.WriteLine("Connect success", Utils.MsgInfoType.Info);

            _isConnectted = true;
            DobotDll.SetCmdTimeout(3000);

            // Must set when sensor is not exist
            //DobotDll.ResetPose(true, 45, 45);

            // Get name
            string deviceName = "Dobot Magician";
            DobotDll.SetDeviceName(deviceName);

            StringBuilder deviceSN = new StringBuilder(64);
            DobotDll.GetDeviceName(deviceSN, 64);

            SetParam();
        }

        /// <summary>
        /// 初期パラメータ設定
        /// </summary>
        private void SetParam()
        {
            UInt64 cmdIndex = 0;
            JOGJointParams jsParam;
            jsParam.velocity = new float[] { 200, 200, 200, 200 };
            jsParam.acceleration = new float[] { 200, 200, 200, 200 };
            DobotDll.SetJOGJointParams(ref jsParam, false, ref cmdIndex);

            JOGCommonParams jdParam;
            jdParam.velocityRatio = 100;
            jdParam.accelerationRatio = 100;
            DobotDll.SetJOGCommonParams(ref jdParam, false, ref cmdIndex);

            PTPJointParams pbsParam;
            pbsParam.velocity = new float[] { 200, 200, 200, 200 };
            pbsParam.acceleration = new float[] { 200, 200, 200, 200 };
            DobotDll.SetPTPJointParams(ref pbsParam, false, ref cmdIndex);

            PTPCoordinateParams cpbsParam;
            cpbsParam.xyzVelocity = 100;
            cpbsParam.xyzAcceleration = 100;
            cpbsParam.rVelocity = 100;
            cpbsParam.rAcceleration = 100;
            DobotDll.SetPTPCoordinateParams(ref cpbsParam, false, ref cmdIndex);

            PTPJumpParams pjp;
            pjp.jumpHeight = 20;
            pjp.zLimit = 100;
            DobotDll.SetPTPJumpParams(ref pjp, false, ref cmdIndex);

            PTPCommonParams pbdParam;
            pbdParam.velocityRatio = 30;
            pbdParam.accelerationRatio = 30;
            DobotDll.SetPTPCommonParams(ref pbdParam, false, ref cmdIndex);
        }

        /// <summary>
        /// Point To Point Move
        /// </summary>
        /// <param name="style"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private UInt64 ptp(byte style, float x, float y, float z, float r)
        {
            PTPCmd pdbCmd;
            UInt64 cmdIndex = 0;

            pdbCmd.ptpMode = style;
            pdbCmd.x = x;
            pdbCmd.y = y;
            pdbCmd.z = z;
            pdbCmd.rHead = r;
            while (true)
            {
                int ret = DobotDll.SetPTPCmd(ref pdbCmd, true, ref cmdIndex);
                if (ret == 0)
                    break;
            }

            while (true)
            {
                UInt64 retIndex = 0;
                int ind = DobotDll.GetQueuedCmdCurrentIndex(ref retIndex);
                if (ind == 0 && cmdIndex <= retIndex)
                {
                    break;
                }
            }

            float waitTime = 500;
            WAITCmd waitcmd;
            waitcmd.timeout = (uint)waitTime;
            DobotDll.SetWAITCmd(ref waitcmd, false, ref cmdIndex);

            return cmdIndex;
        }
    }
}
