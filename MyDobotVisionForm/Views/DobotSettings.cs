using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyDobotVisionForm.Models;
using Newtonsoft.Json;

namespace MyDobotVisionForm.Views
{
    public partial class DobotSettings : UserControl
    {
        private SettingsObj _obj;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public DobotSettings()
        {
            InitializeComponent();

            this.buttonOpenCalibFile.Click += ButtonOpenCalibFile_Click;
            this.buttonNavExecute.Click += ButtonNavExecute_Click;
            this.buttonSave.Click += ButtonSave_Click;
            this.buttonRoadPreviousValue.Click += ButtonRoadPreviousValue_Click;
        }

        /// <summary>
        /// 引数つきコンストラクタ
        /// </summary>
        /// <param name="obj"></param>
        public DobotSettings(SettingsObj obj): this()
        {
            // データを画面に設定
            SetSettingObjData(obj);
        }

        /// <summary>
        /// カメラキャリブレーションファイルのパスを設定します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenCalibFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog()
            {
                FileName = "Folder Selection",
                Filter = "Calibration Files (.yml)|*.yml|All Files (*.*)|*.*",
                ValidateNames = false,
                CheckFileExists = true,
                CheckPathExists = true,
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxCalibFilePath.Text = ofd.FileName;
                }
            }
        }

        /// <summary>
        /// 画面設定値をjsonファイルに保存します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ValidateControls(out SettingsObj obj))
            {
                MessageBox.Show("どこかの設定値に誤りがあります");
                return;
            }

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            using (var sw = new StreamWriter(@"settingData.json", false, System.Text.Encoding.UTF8))
            {
                // JSON データをファイルに書き込み
                sw.Write(json);
            }
        }

        /// <summary>
        /// jsonファイルから画面設定値を読み取り、設定します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRoadPreviousValue_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"settingData.json"))
            {
                MessageBox.Show("ファイルないよ");
                return;
            }

            // UTF-8 で開く
            using (var sr = new StreamReader(@"settingData.json", System.Text.Encoding.UTF8))
            {
                // 変数 json にファイルの内容を代入 
                var json = sr.ReadToEnd();

                // デシリアライズして obj にセット
                var obj = JsonConvert.DeserializeObject<SettingsObj>(json);

                // 読み込んだデータを画面に設定
                SetSettingObjData(obj);
            }
        }

        /// <summary>
        /// 実行画面へ遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNavExecute_Click(object sender, EventArgs e)
        {
            if (ValidateControls(out this._obj)) {
                MessageBox.Show("どこかの設定値に誤りがあります");
                return;
            }

            (Parent as MyDobotVisionForm).Navigate(typeof(DobotExecute), _obj);
        }

        /// <summary>
        /// コントロールのバリデーション
        /// </summary>
        /// <returns></returns>
        private bool ValidateControls(out SettingsObj obj)
        {
            obj = new SettingsObj();

            if (string.IsNullOrEmpty(textBoxCalibFilePath.Text))
            {
                textBoxCalibFilePath.BackColor = Color.Yellow;
                return true;
            }
            obj.CalibratinFilePath = textBoxCalibFilePath.Text;

            double topLeftArPoseX = 0;
            if (string.IsNullOrEmpty(textBoxTopLeftArPoseX.Text)
                || !double.TryParse(textBoxTopLeftArPoseX.Text, out topLeftArPoseX))
            {
                textBoxTopLeftArPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.TopLeftArPoseX = topLeftArPoseX;

            double topLeftArPoseY = 0;
            if (string.IsNullOrEmpty(textBoxTopLeftArPoseY.Text)
                || !double.TryParse(textBoxTopLeftArPoseY.Text, out topLeftArPoseY))
            {
                textBoxTopLeftArPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.TopLeftArPoseY = topLeftArPoseY;

            double topRightArPoseX = 0;
            if (string.IsNullOrEmpty(textBoxTopRightArPoseX.Text)
                || !double.TryParse(textBoxTopRightArPoseX.Text, out topRightArPoseX))
            {
                textBoxTopRightArPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.TopRightArPoseX = topRightArPoseX;

            double topRightArPoseY = 0;
            if (string.IsNullOrEmpty(textBoxTopRightArPoseY.Text)
                || !double.TryParse(textBoxTopRightArPoseY.Text, out topRightArPoseY))
            {
                textBoxTopRightArPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.TopRightArPoseY = topRightArPoseY;

            double bottomRightArPoseX = 0;
            if (string.IsNullOrEmpty(textBoxBottomRightArPoseX.Text)
                || !double.TryParse(textBoxBottomRightArPoseX.Text, out bottomRightArPoseX))
            {
                textBoxBottomRightArPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomRightArPoseX = bottomRightArPoseX;

            double bottomRightArPoseY = 0;
            if (string.IsNullOrEmpty(textBoxBottomRightArPoseY.Text)
                || !double.TryParse(textBoxBottomRightArPoseY.Text, out bottomRightArPoseY))
            {
                textBoxBottomRightArPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomRightArPoseY = bottomRightArPoseY;

            double bottomLeftArPoseX = 0;
            if (string.IsNullOrEmpty(textBoxBottomLeftArPoseX.Text)
                || !double.TryParse(textBoxBottomLeftArPoseX.Text, out bottomLeftArPoseX))
            {
                textBoxBottomLeftArPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomLeftArPoseX = bottomLeftArPoseX;

            double bottomLeftArPoseY = 0;
            if (string.IsNullOrEmpty(textBoxBottomLeftArPoseY.Text)
                || !double.TryParse(textBoxBottomLeftArPoseY.Text, out bottomLeftArPoseY))
            {
                textBoxBottomLeftArPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomLeftArPoseY = bottomLeftArPoseY;

            double topLeftDobotPoseX = 0;
            if (string.IsNullOrEmpty(textBoxTopLeftDobotPoseX.Text)
                || !double.TryParse(textBoxTopLeftDobotPoseX.Text, out topLeftDobotPoseX))
            {
                textBoxTopLeftDobotPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.TopLeftDobotPoseX = topLeftDobotPoseX;

            double topLeftDobotPoseY = 0;
            if (string.IsNullOrEmpty(textBoxTopLeftDobotPoseY.Text)
                || !double.TryParse(textBoxTopLeftDobotPoseY.Text, out topLeftDobotPoseY))
            {
                textBoxTopLeftDobotPoseY.BackColor = Color.Yellow;                
                return true;
            }
            obj.TopLeftDobotPoseY = topLeftDobotPoseY;

            double topRightDobotPoseX = 0;
            if (string.IsNullOrEmpty(textBoxTopRightDobotPoseX.Text)
                || !double.TryParse(textBoxTopRightDobotPoseX.Text, out topRightDobotPoseX))
            {
                textBoxTopRightDobotPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.TopRightDobotPoseX = topRightDobotPoseX;

            double topRightDobotPoseY = 0;
            if (string.IsNullOrEmpty(textBoxTopRightDobotPoseY.Text)
                || !double.TryParse(textBoxTopRightDobotPoseY.Text, out topRightDobotPoseY))
            {
                textBoxTopRightDobotPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.TopRightDobotPoseY = topRightDobotPoseY;

            double bottomRightDobotPoseX = 0;
            if (string.IsNullOrEmpty(textBoxBottomRightDobotPoseX.Text)
                || !double.TryParse(textBoxBottomRightDobotPoseX.Text, out bottomRightDobotPoseX))
            {
                textBoxBottomRightDobotPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomRightDobotPoseX = bottomRightDobotPoseX;

            double bottomRightDobotPoseY = 0;
            if (string.IsNullOrEmpty(textBoxBottomRightDobotPoseY.Text)
                || !double.TryParse(textBoxBottomRightDobotPoseY.Text, out bottomRightDobotPoseY))
            {
                textBoxBottomRightDobotPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomRightDobotPoseY = bottomRightDobotPoseY;

            double bottomLeftDobotPoseX = 0;
            if (string.IsNullOrEmpty(textBoxBottomLeftDobotPoseX.Text)
                || !double.TryParse(textBoxBottomLeftDobotPoseX.Text, out bottomLeftDobotPoseX))
            {
                textBoxBottomLeftDobotPoseX.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomLeftDobotPoseX = bottomLeftDobotPoseX;

            double bottomLeftDobotPoseY = 0;
            if (string.IsNullOrEmpty(textBoxBottomLeftDobotPoseY.Text)
                || !double.TryParse(textBoxBottomLeftDobotPoseY.Text, out bottomLeftDobotPoseY))
            {
                textBoxBottomLeftDobotPoseY.BackColor = Color.Yellow;
                return true;
            }
            obj.BottomLeftDobotPoseY = bottomLeftDobotPoseY;

            double pedestalZ = 0;
            if (string.IsNullOrEmpty(textBoxPedestalZ.Text)
                || !double.TryParse(textBoxPedestalZ.Text, out pedestalZ))
            {
                textBoxPedestalZ.BackColor = Color.Yellow;
                return true;
            }
            obj.PedestalZ = pedestalZ;

            double objectHeight = 0;
            if (string.IsNullOrEmpty(textBoxObjectHeight.Text)
                || !double.TryParse(textBoxObjectHeight.Text, out objectHeight))
            {
                textBoxObjectHeight.BackColor = Color.Yellow;
                
                return true;
            }
            obj.ObjectHeight = objectHeight;

            int hueMin = 0;
            if (string.IsNullOrEmpty(textBoxHueMin.Text)
                || !int.TryParse(textBoxHueMin.Text, out hueMin))
            {
                textBoxHueMin.BackColor = Color.Yellow;
                return true;
            }
            obj.HueMin = hueMin;

            int hueMax = 0;
            if (string.IsNullOrEmpty(textBoxHueMax.Text)
                || !int.TryParse(textBoxHueMax.Text, out hueMax))
            {
                textBoxHueMax.BackColor = Color.Yellow;
                return true;
            }
            obj.HueMax = hueMax;

            int saturationMin = 0;
            if (string.IsNullOrEmpty(textBoxSaturationMin.Text)
                || !int.TryParse(textBoxSaturationMin.Text, out saturationMin))
            {
                textBoxSaturationMin.BackColor = Color.Yellow;
                return true;
            }
            obj.SaturationMin = saturationMin;

            int saturationMax = 0;
            if (string.IsNullOrEmpty(textBoxSaturationMax.Text)
                || !int.TryParse(textBoxSaturationMax.Text, out saturationMax))
            {
                textBoxSaturationMax.BackColor = Color.Yellow;
                return true;
            }
            obj.SaturationMax = saturationMax;

            int valueMin = 0;
            if (string.IsNullOrEmpty(textBoxValueMin.Text)
                || !int.TryParse(textBoxValueMin.Text, out valueMin))
            {
                textBoxValueMin.BackColor = Color.Yellow;
                return true;
            }
            obj.ValueMin = valueMin;

            int valueMax = 0;
            if (string.IsNullOrEmpty(textBoxValueMax.Text)
                || !int.TryParse(textBoxValueMax.Text, out valueMax))
            {
                textBoxValueMax.BackColor = Color.Yellow;
                return true;
            }
            obj.ValueMax = valueMax;

            double placePoseXCoordinate = 0;
            if (string.IsNullOrEmpty(textBoxPlacePoseXCoordinate.Text)
                || !double.TryParse(textBoxPlacePoseXCoordinate.Text, out placePoseXCoordinate))
            {
                textBoxPlacePoseXCoordinate.BackColor = Color.Yellow;
                return true;
            }
            obj.PlacePoseXCoordinate = placePoseXCoordinate;

            double placePoseYCoordinate = 0;
            if (string.IsNullOrEmpty(textBoxPlacePoseYCoordinate.Text)
                || !double.TryParse(textBoxPlacePoseYCoordinate.Text, out placePoseYCoordinate))
            {
                textBoxPlacePoseYCoordinate.BackColor = Color.Yellow;
                return true;
            }
            obj.PlacePoseYCoordinate = placePoseYCoordinate;

            double placePoseZCoordinate = 0;
            if (string.IsNullOrEmpty(textBoxPlacePoseZCoordinate.Text)
                || !double.TryParse(textBoxPlacePoseZCoordinate.Text, out placePoseZCoordinate))
            {
                textBoxPlacePoseZCoordinate.BackColor = Color.Yellow;
                return true;
            }
            obj.PlacePoseZCoordinate = placePoseZCoordinate;

            return false;
        }

        /// <summary>
        /// 画面に設定します
        /// </summary>
        /// <param name="obj"></param>
        private void SetSettingObjData(SettingsObj obj)
        {
            textBoxCalibFilePath.Text  = obj.CalibratinFilePath;

            textBoxTopLeftArPoseX.Text = obj.TopLeftArPoseX.ToString();

            textBoxTopLeftArPoseY.Text = obj.TopLeftArPoseY.ToString();

            textBoxTopRightArPoseX.Text = obj.TopRightArPoseX.ToString();

            textBoxTopRightArPoseY.Text = obj.TopRightArPoseY.ToString();

            textBoxBottomRightArPoseX.Text = obj.BottomRightArPoseX.ToString();

            textBoxBottomRightArPoseY.Text = obj.BottomRightArPoseY.ToString();

            textBoxBottomLeftArPoseX.Text = obj.BottomLeftArPoseX.ToString();

            textBoxBottomLeftArPoseY.Text = obj.BottomLeftArPoseY.ToString();

            textBoxTopLeftDobotPoseX.Text = obj.TopLeftDobotPoseX.ToString();

            textBoxTopLeftDobotPoseY.Text = obj.TopLeftDobotPoseY.ToString();

            textBoxTopRightDobotPoseX.Text = obj.TopRightDobotPoseX.ToString();

            textBoxTopRightDobotPoseY.Text = obj.TopRightDobotPoseY.ToString();

            textBoxBottomRightDobotPoseX.Text = obj.BottomRightDobotPoseX.ToString();

            textBoxBottomRightDobotPoseY.Text = obj.BottomRightDobotPoseY.ToString();

            textBoxBottomLeftDobotPoseX.Text = obj.BottomLeftDobotPoseX.ToString();

            textBoxBottomLeftDobotPoseY.Text = obj.BottomLeftDobotPoseY.ToString();

            textBoxPedestalZ.Text = obj.PedestalZ.ToString();

            textBoxObjectHeight.Text = obj.ObjectHeight.ToString();

            textBoxHueMin.Text = obj.HueMin.ToString();

            textBoxHueMax.Text = obj.HueMax.ToString();

            textBoxSaturationMin.Text = obj.SaturationMin.ToString();

            textBoxSaturationMax.Text = obj.SaturationMax.ToString();

            textBoxValueMin.Text = obj.ValueMin.ToString();

            textBoxValueMax.Text = obj.ValueMax.ToString();

            textBoxPlacePoseXCoordinate.Text = obj.PlacePoseXCoordinate.ToString();

            textBoxPlacePoseYCoordinate.Text = obj.PlacePoseYCoordinate.ToString();

            textBoxPlacePoseZCoordinate.Text = obj.PlacePoseZCoordinate.ToString();
        }
    }
}
