using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDobotVisionForm.Models;
using MyDobotVisionForm.CameraControl;
using MathNet.Numerics.LinearAlgebra.Double;
using HomographySharp.Double;
using OpenCvSharp;

namespace MyDobotVisionForm.Views
{
    public partial class DobotExecute : UserControl
    {
        public SettingsObj _obj;

        private DobotControl.DobotDllWrapper _dobot = new DobotControl.DobotDllWrapper();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DobotExecute()
        {
            InitializeComponent();

            this.buttonNavSettings.Click += ButtonNavSettings_Click;
            this.buttonExecute.Click += ButtonExecute_Click;
            this.buttonEvacuation.Click += ButtonEvacuation_Click;
            this.buttonHome.Click += ButtonHome_Click;
            this._dobot.OnWorkEvent += (sender, e) =>
            {
                // 作業履歴を表示
                this.textBoxExecuteHistory.AppendText(e+"\r\n");
            };
        }

        /// <summary>
        /// 引数つきコンストラクタ
        /// </summary>
        /// <param name="obj"></param>
        public DobotExecute(SettingsObj obj) : this()
        {
            _obj = obj;
        }

        /// <summary>
        /// 設定画面へ遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNavSettings_Click(object sender, EventArgs e)
        {
            (Parent as MyDobotVisionForm).Navigate(typeof(DobotSettings), this._obj);
        }

        /// <summary>
        /// 処理実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            var cameraControl = new WebCameraControl();
            var val = cameraControl.Execute(this._obj);
            if (val == null)
            {
                MessageBox.Show("対象物を検出できませんでした");
                return;
            }
            // 画像表示
            this.pictureBox.Image = val.CameraImage;

            // 対象物のロボット座標系の位置取得
            (double target_x, double target_y) = Utils.Methods.GetTargetRobotCoordinate(this._obj, val.Blob);

            // 作業開始
            this._dobot.WorkStart(target_x, target_y, this._obj);
        }

        /// <summary>
        /// 一時退避
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEvacuation_Click(object sender, EventArgs e)
        {
            this._dobot.Evacuation();
        }

        /// <summary>
        /// ホーミング
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            this._dobot.Homing();
        }

        /*
        /// <summary>
        /// 処理実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            //var cameraControl = new WebCameraControl();
            //var observableVal = cameraControl.Execute(this._obj);
            //observableVal.Subscribe(
            //    val => {
            //        // 画面に表示
            //        this.Invoke(this, delegate {
            //            this.pictureBox.Image = val.CameraImage;
            //        });

            //        // 座標変換
            //    },
            //    ex => { MessageBox.Show(ex.ToString()); },
            //    () => { }
            // );
        }

        /// <summary>
        /// 必要に応じてUIスレッド上で処理を実施します。
        /// </summary>
        /// <param name="target">処理を実行するUIを備えたコントロール。</param>
        /// <param name="invoker">処理。</param>
        public void Invoke(Control target, MethodInvoker invoker)
        {
            try
            {
                if (target.IsDisposed) return;

                if (target.InvokeRequired)
                {
                    target?.Invoke(invoker);
                }
                else
                {
                    invoker.DynamicInvoke();
                }
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex);
                //throw ex;
            }
        }
        */
    }
}
