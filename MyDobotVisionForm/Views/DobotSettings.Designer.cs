namespace MyDobotVisionForm.Views
{
    partial class DobotSettings
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenCalibFile = new System.Windows.Forms.Button();
            this.textBoxCalibFilePath = new System.Windows.Forms.TextBox();
            this.labelCalibration = new System.Windows.Forms.Label();
            this.buttonNavExecute = new System.Windows.Forms.Button();
            this.labelArMarker = new System.Windows.Forms.Label();
            this.labelDobotPose = new System.Windows.Forms.Label();
            this.textBoxTopLeftArPoseX = new System.Windows.Forms.TextBox();
            this.textBoxTopLeftDobotPoseY = new System.Windows.Forms.TextBox();
            this.textBoxTopRightDobotPoseX = new System.Windows.Forms.TextBox();
            this.textBoxTopRightArPoseX = new System.Windows.Forms.TextBox();
            this.textBoxBottomRightDobotPoseX = new System.Windows.Forms.TextBox();
            this.textBoxBottomRightArPoseX = new System.Windows.Forms.TextBox();
            this.textBoxBottomLeftDobotPoseX = new System.Windows.Forms.TextBox();
            this.textBoxBottomLeftArPoseX = new System.Windows.Forms.TextBox();
            this.labelObjectHeight = new System.Windows.Forms.Label();
            this.textBoxObjectHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxValueMax = new System.Windows.Forms.TextBox();
            this.textBoxValueMin = new System.Windows.Forms.TextBox();
            this.textBoxSaturationMax = new System.Windows.Forms.TextBox();
            this.textBoxSaturationMin = new System.Windows.Forms.TextBox();
            this.textBoxHueMax = new System.Windows.Forms.TextBox();
            this.textBoxHueMin = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelSaturation = new System.Windows.Forms.Label();
            this.labelHue = new System.Windows.Forms.Label();
            this.labelPedestalBottom = new System.Windows.Forms.Label();
            this.textBoxPedestalZ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.labelTopRight = new System.Windows.Forms.Label();
            this.labelBottomRight = new System.Windows.Forms.Label();
            this.labelBottomLeft = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRoadPreviousValue = new System.Windows.Forms.Button();
            this.groupBoxPlacePose = new System.Windows.Forms.GroupBox();
            this.textBoxPlacePoseXCoordinate = new System.Windows.Forms.TextBox();
            this.textBoxPlacePoseYCoordinate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTopLeftDobotPoseX = new System.Windows.Forms.TextBox();
            this.textBoxTopLeftArPoseY = new System.Windows.Forms.TextBox();
            this.textBoxTopRightArPoseY = new System.Windows.Forms.TextBox();
            this.textBoxBottomRightArPoseY = new System.Windows.Forms.TextBox();
            this.textBoxBottomLeftArPoseY = new System.Windows.Forms.TextBox();
            this.textBoxTopRightDobotPoseY = new System.Windows.Forms.TextBox();
            this.textBoxBottomRightDobotPoseY = new System.Windows.Forms.TextBox();
            this.textBoxBottomLeftDobotPoseY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlacePoseZCoordinate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPlacePose.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenCalibFile
            // 
            this.buttonOpenCalibFile.Location = new System.Drawing.Point(629, 15);
            this.buttonOpenCalibFile.Name = "buttonOpenCalibFile";
            this.buttonOpenCalibFile.Size = new System.Drawing.Size(43, 23);
            this.buttonOpenCalibFile.TabIndex = 0;
            this.buttonOpenCalibFile.Text = "・・・";
            this.buttonOpenCalibFile.UseVisualStyleBackColor = true;
            // 
            // textBoxCalibFilePath
            // 
            this.textBoxCalibFilePath.Location = new System.Drawing.Point(126, 17);
            this.textBoxCalibFilePath.Name = "textBoxCalibFilePath";
            this.textBoxCalibFilePath.Size = new System.Drawing.Size(487, 19);
            this.textBoxCalibFilePath.TabIndex = 1;
            // 
            // labelCalibration
            // 
            this.labelCalibration.AutoSize = true;
            this.labelCalibration.Location = new System.Drawing.Point(3, 20);
            this.labelCalibration.Name = "labelCalibration";
            this.labelCalibration.Size = new System.Drawing.Size(117, 12);
            this.labelCalibration.TabIndex = 2;
            this.labelCalibration.Text = "キャリブレーションファイル";
            // 
            // buttonNavExecute
            // 
            this.buttonNavExecute.Location = new System.Drawing.Point(629, 529);
            this.buttonNavExecute.Name = "buttonNavExecute";
            this.buttonNavExecute.Size = new System.Drawing.Size(121, 34);
            this.buttonNavExecute.TabIndex = 3;
            this.buttonNavExecute.Text = "実行画面へ行くお";
            this.buttonNavExecute.UseVisualStyleBackColor = true;
            // 
            // labelArMarker
            // 
            this.labelArMarker.AutoSize = true;
            this.labelArMarker.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelArMarker.Location = new System.Drawing.Point(185, 58);
            this.labelArMarker.Name = "labelArMarker";
            this.labelArMarker.Size = new System.Drawing.Size(96, 20);
            this.labelArMarker.TabIndex = 5;
            this.labelArMarker.Text = "ARマーカー";
            // 
            // labelDobotPose
            // 
            this.labelDobotPose.AutoSize = true;
            this.labelDobotPose.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDobotPose.Location = new System.Drawing.Point(535, 15);
            this.labelDobotPose.Name = "labelDobotPose";
            this.labelDobotPose.Size = new System.Drawing.Size(99, 20);
            this.labelDobotPose.TabIndex = 6;
            this.labelDobotPose.Text = "Dobot位置";
            // 
            // textBoxTopLeftArPoseX
            // 
            this.textBoxTopLeftArPoseX.Location = new System.Drawing.Point(126, 93);
            this.textBoxTopLeftArPoseX.Name = "textBoxTopLeftArPoseX";
            this.textBoxTopLeftArPoseX.Size = new System.Drawing.Size(133, 19);
            this.textBoxTopLeftArPoseX.TabIndex = 7;
            // 
            // textBoxTopLeftDobotPoseY
            // 
            this.textBoxTopLeftDobotPoseY.Location = new System.Drawing.Point(596, 49);
            this.textBoxTopLeftDobotPoseY.Name = "textBoxTopLeftDobotPoseY";
            this.textBoxTopLeftDobotPoseY.Size = new System.Drawing.Size(143, 19);
            this.textBoxTopLeftDobotPoseY.TabIndex = 8;
            // 
            // textBoxTopRightDobotPoseX
            // 
            this.textBoxTopRightDobotPoseX.Location = new System.Drawing.Point(425, 92);
            this.textBoxTopRightDobotPoseX.Name = "textBoxTopRightDobotPoseX";
            this.textBoxTopRightDobotPoseX.Size = new System.Drawing.Size(165, 19);
            this.textBoxTopRightDobotPoseX.TabIndex = 11;
            // 
            // textBoxTopRightArPoseX
            // 
            this.textBoxTopRightArPoseX.Location = new System.Drawing.Point(126, 135);
            this.textBoxTopRightArPoseX.Name = "textBoxTopRightArPoseX";
            this.textBoxTopRightArPoseX.Size = new System.Drawing.Size(133, 19);
            this.textBoxTopRightArPoseX.TabIndex = 10;
            // 
            // textBoxBottomRightDobotPoseX
            // 
            this.textBoxBottomRightDobotPoseX.Location = new System.Drawing.Point(425, 134);
            this.textBoxBottomRightDobotPoseX.Name = "textBoxBottomRightDobotPoseX";
            this.textBoxBottomRightDobotPoseX.Size = new System.Drawing.Size(165, 19);
            this.textBoxBottomRightDobotPoseX.TabIndex = 14;
            // 
            // textBoxBottomRightArPoseX
            // 
            this.textBoxBottomRightArPoseX.Location = new System.Drawing.Point(126, 178);
            this.textBoxBottomRightArPoseX.Name = "textBoxBottomRightArPoseX";
            this.textBoxBottomRightArPoseX.Size = new System.Drawing.Size(133, 19);
            this.textBoxBottomRightArPoseX.TabIndex = 13;
            // 
            // textBoxBottomLeftDobotPoseX
            // 
            this.textBoxBottomLeftDobotPoseX.Location = new System.Drawing.Point(425, 177);
            this.textBoxBottomLeftDobotPoseX.Name = "textBoxBottomLeftDobotPoseX";
            this.textBoxBottomLeftDobotPoseX.Size = new System.Drawing.Size(165, 19);
            this.textBoxBottomLeftDobotPoseX.TabIndex = 17;
            // 
            // textBoxBottomLeftArPoseX
            // 
            this.textBoxBottomLeftArPoseX.Location = new System.Drawing.Point(126, 217);
            this.textBoxBottomLeftArPoseX.Name = "textBoxBottomLeftArPoseX";
            this.textBoxBottomLeftArPoseX.Size = new System.Drawing.Size(133, 19);
            this.textBoxBottomLeftArPoseX.TabIndex = 16;
            // 
            // labelObjectHeight
            // 
            this.labelObjectHeight.AutoSize = true;
            this.labelObjectHeight.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelObjectHeight.Location = new System.Drawing.Point(188, 266);
            this.labelObjectHeight.Name = "labelObjectHeight";
            this.labelObjectHeight.Size = new System.Drawing.Size(146, 20);
            this.labelObjectHeight.TabIndex = 19;
            this.labelObjectHeight.Text = "オブジェクトの高さ";
            // 
            // textBoxObjectHeight
            // 
            this.textBoxObjectHeight.Location = new System.Drawing.Point(192, 298);
            this.textBoxObjectHeight.Name = "textBoxObjectHeight";
            this.textBoxObjectHeight.Size = new System.Drawing.Size(86, 19);
            this.textBoxObjectHeight.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(285, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "mm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBottomLeftDobotPoseY);
            this.groupBox1.Controls.Add(this.textBoxBottomRightDobotPoseY);
            this.groupBox1.Controls.Add(this.textBoxTopRightDobotPoseY);
            this.groupBox1.Controls.Add(this.textBoxBottomLeftArPoseY);
            this.groupBox1.Controls.Add(this.textBoxBottomRightArPoseY);
            this.groupBox1.Controls.Add(this.textBoxTopRightArPoseY);
            this.groupBox1.Controls.Add(this.textBoxTopLeftArPoseY);
            this.groupBox1.Controls.Add(this.textBoxTopLeftDobotPoseX);
            this.groupBox1.Controls.Add(this.labelBottomLeft);
            this.groupBox1.Controls.Add(this.labelBottomRight);
            this.groupBox1.Controls.Add(this.labelTopRight);
            this.groupBox1.Controls.Add(this.labelTopLeft);
            this.groupBox1.Controls.Add(this.textBoxTopLeftDobotPoseY);
            this.groupBox1.Controls.Add(this.labelDobotPose);
            this.groupBox1.Controls.Add(this.textBoxTopRightDobotPoseX);
            this.groupBox1.Controls.Add(this.textBoxBottomRightDobotPoseX);
            this.groupBox1.Controls.Add(this.textBoxBottomLeftDobotPoseX);
            this.groupBox1.Location = new System.Drawing.Point(5, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 209);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "座標変換";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMax);
            this.groupBox2.Controls.Add(this.labelMin);
            this.groupBox2.Controls.Add(this.textBoxValueMax);
            this.groupBox2.Controls.Add(this.textBoxValueMin);
            this.groupBox2.Controls.Add(this.textBoxSaturationMax);
            this.groupBox2.Controls.Add(this.textBoxSaturationMin);
            this.groupBox2.Controls.Add(this.textBoxHueMax);
            this.groupBox2.Controls.Add(this.textBoxHueMin);
            this.groupBox2.Controls.Add(this.labelValue);
            this.groupBox2.Controls.Add(this.labelSaturation);
            this.groupBox2.Controls.Add(this.labelHue);
            this.groupBox2.Location = new System.Drawing.Point(5, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 188);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "色の設定";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMax.Location = new System.Drawing.Point(374, 24);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(49, 20);
            this.labelMax.TabIndex = 36;
            this.labelMax.Text = "上限";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMin.Location = new System.Drawing.Point(217, 24);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(49, 20);
            this.labelMin.TabIndex = 35;
            this.labelMin.Text = "下限";
            // 
            // textBoxValueMax
            // 
            this.textBoxValueMax.Location = new System.Drawing.Point(346, 150);
            this.textBoxValueMax.Name = "textBoxValueMax";
            this.textBoxValueMax.Size = new System.Drawing.Size(107, 19);
            this.textBoxValueMax.TabIndex = 34;
            // 
            // textBoxValueMin
            // 
            this.textBoxValueMin.Location = new System.Drawing.Point(187, 151);
            this.textBoxValueMin.Name = "textBoxValueMin";
            this.textBoxValueMin.Size = new System.Drawing.Size(107, 19);
            this.textBoxValueMin.TabIndex = 33;
            // 
            // textBoxSaturationMax
            // 
            this.textBoxSaturationMax.Location = new System.Drawing.Point(346, 106);
            this.textBoxSaturationMax.Name = "textBoxSaturationMax";
            this.textBoxSaturationMax.Size = new System.Drawing.Size(107, 19);
            this.textBoxSaturationMax.TabIndex = 32;
            // 
            // textBoxSaturationMin
            // 
            this.textBoxSaturationMin.Location = new System.Drawing.Point(187, 105);
            this.textBoxSaturationMin.Name = "textBoxSaturationMin";
            this.textBoxSaturationMin.Size = new System.Drawing.Size(107, 19);
            this.textBoxSaturationMin.TabIndex = 31;
            // 
            // textBoxHueMax
            // 
            this.textBoxHueMax.Location = new System.Drawing.Point(346, 57);
            this.textBoxHueMax.Name = "textBoxHueMax";
            this.textBoxHueMax.Size = new System.Drawing.Size(107, 19);
            this.textBoxHueMax.TabIndex = 30;
            // 
            // textBoxHueMin
            // 
            this.textBoxHueMin.Location = new System.Drawing.Point(187, 56);
            this.textBoxHueMin.Name = "textBoxHueMin";
            this.textBoxHueMin.Size = new System.Drawing.Size(107, 19);
            this.textBoxHueMin.TabIndex = 29;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelValue.Location = new System.Drawing.Point(25, 150);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(56, 20);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "Value";
            // 
            // labelSaturation
            // 
            this.labelSaturation.AutoSize = true;
            this.labelSaturation.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSaturation.Location = new System.Drawing.Point(24, 105);
            this.labelSaturation.Name = "labelSaturation";
            this.labelSaturation.Size = new System.Drawing.Size(96, 20);
            this.labelSaturation.TabIndex = 1;
            this.labelSaturation.Text = "Saturation";
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHue.Location = new System.Drawing.Point(25, 56);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(42, 20);
            this.labelHue.TabIndex = 0;
            this.labelHue.Text = "Hue";
            // 
            // labelPedestalBottom
            // 
            this.labelPedestalBottom.AutoSize = true;
            this.labelPedestalBottom.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPedestalBottom.Location = new System.Drawing.Point(9, 266);
            this.labelPedestalBottom.Name = "labelPedestalBottom";
            this.labelPedestalBottom.Size = new System.Drawing.Size(116, 20);
            this.labelPedestalBottom.TabIndex = 26;
            this.labelPedestalBottom.Text = "台座のZ位置";
            // 
            // textBoxPedestalZ
            // 
            this.textBoxPedestalZ.Location = new System.Drawing.Point(13, 298);
            this.textBoxPedestalZ.Name = "textBoxPedestalZ";
            this.textBoxPedestalZ.Size = new System.Drawing.Size(107, 19);
            this.textBoxPedestalZ.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(126, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "mm";
            // 
            // labelTopLeft
            // 
            this.labelTopLeft.AutoSize = true;
            this.labelTopLeft.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTopLeft.Location = new System.Drawing.Point(32, 45);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(49, 20);
            this.labelTopLeft.TabIndex = 37;
            this.labelTopLeft.Text = "左上";
            // 
            // labelTopRight
            // 
            this.labelTopRight.AutoSize = true;
            this.labelTopRight.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTopRight.Location = new System.Drawing.Point(32, 88);
            this.labelTopRight.Name = "labelTopRight";
            this.labelTopRight.Size = new System.Drawing.Size(49, 20);
            this.labelTopRight.TabIndex = 38;
            this.labelTopRight.Text = "右上";
            // 
            // labelBottomRight
            // 
            this.labelBottomRight.AutoSize = true;
            this.labelBottomRight.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBottomRight.Location = new System.Drawing.Point(32, 134);
            this.labelBottomRight.Name = "labelBottomRight";
            this.labelBottomRight.Size = new System.Drawing.Size(49, 20);
            this.labelBottomRight.TabIndex = 39;
            this.labelBottomRight.Text = "右下";
            // 
            // labelBottomLeft
            // 
            this.labelBottomLeft.AutoSize = true;
            this.labelBottomLeft.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBottomLeft.Location = new System.Drawing.Point(32, 173);
            this.labelBottomLeft.Name = "labelBottomLeft";
            this.labelBottomLeft.Size = new System.Drawing.Size(49, 20);
            this.labelBottomLeft.TabIndex = 40;
            this.labelBottomLeft.Text = "左下";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(5, 529);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 34);
            this.buttonSave.TabIndex = 29;
            this.buttonSave.Text = "値保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRoadPreviousValue
            // 
            this.buttonRoadPreviousValue.Location = new System.Drawing.Point(178, 529);
            this.buttonRoadPreviousValue.Name = "buttonRoadPreviousValue";
            this.buttonRoadPreviousValue.Size = new System.Drawing.Size(121, 34);
            this.buttonRoadPreviousValue.TabIndex = 30;
            this.buttonRoadPreviousValue.Text = "前回保存値取得";
            this.buttonRoadPreviousValue.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlacePose
            // 
            this.groupBoxPlacePose.Controls.Add(this.label5);
            this.groupBoxPlacePose.Controls.Add(this.textBoxPlacePoseZCoordinate);
            this.groupBoxPlacePose.Controls.Add(this.label4);
            this.groupBoxPlacePose.Controls.Add(this.label3);
            this.groupBoxPlacePose.Controls.Add(this.textBoxPlacePoseYCoordinate);
            this.groupBoxPlacePose.Controls.Add(this.textBoxPlacePoseXCoordinate);
            this.groupBoxPlacePose.Location = new System.Drawing.Point(503, 323);
            this.groupBoxPlacePose.Name = "groupBoxPlacePose";
            this.groupBoxPlacePose.Size = new System.Drawing.Size(247, 188);
            this.groupBoxPlacePose.TabIndex = 31;
            this.groupBoxPlacePose.TabStop = false;
            this.groupBoxPlacePose.Text = "持っていく場所";
            // 
            // textBoxPlacePoseXCoordinate
            // 
            this.textBoxPlacePoseXCoordinate.Location = new System.Drawing.Point(73, 56);
            this.textBoxPlacePoseXCoordinate.Name = "textBoxPlacePoseXCoordinate";
            this.textBoxPlacePoseXCoordinate.Size = new System.Drawing.Size(168, 19);
            this.textBoxPlacePoseXCoordinate.TabIndex = 37;
            // 
            // textBoxPlacePoseYCoordinate
            // 
            this.textBoxPlacePoseYCoordinate.Location = new System.Drawing.Point(73, 105);
            this.textBoxPlacePoseYCoordinate.Name = "textBoxPlacePoseYCoordinate";
            this.textBoxPlacePoseYCoordinate.Size = new System.Drawing.Size(168, 19);
            this.textBoxPlacePoseYCoordinate.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "X座標";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Y座標";
            // 
            // textBoxTopLeftDobotPoseX
            // 
            this.textBoxTopLeftDobotPoseX.Location = new System.Drawing.Point(425, 49);
            this.textBoxTopLeftDobotPoseX.Name = "textBoxTopLeftDobotPoseX";
            this.textBoxTopLeftDobotPoseX.Size = new System.Drawing.Size(165, 19);
            this.textBoxTopLeftDobotPoseX.TabIndex = 41;
            // 
            // textBoxTopLeftArPoseY
            // 
            this.textBoxTopLeftArPoseY.Location = new System.Drawing.Point(260, 49);
            this.textBoxTopLeftArPoseY.Name = "textBoxTopLeftArPoseY";
            this.textBoxTopLeftArPoseY.Size = new System.Drawing.Size(152, 19);
            this.textBoxTopLeftArPoseY.TabIndex = 32;
            // 
            // textBoxTopRightArPoseY
            // 
            this.textBoxTopRightArPoseY.Location = new System.Drawing.Point(260, 91);
            this.textBoxTopRightArPoseY.Name = "textBoxTopRightArPoseY";
            this.textBoxTopRightArPoseY.Size = new System.Drawing.Size(152, 19);
            this.textBoxTopRightArPoseY.TabIndex = 32;
            // 
            // textBoxBottomRightArPoseY
            // 
            this.textBoxBottomRightArPoseY.Location = new System.Drawing.Point(260, 135);
            this.textBoxBottomRightArPoseY.Name = "textBoxBottomRightArPoseY";
            this.textBoxBottomRightArPoseY.Size = new System.Drawing.Size(152, 19);
            this.textBoxBottomRightArPoseY.TabIndex = 32;
            // 
            // textBoxBottomLeftArPoseY
            // 
            this.textBoxBottomLeftArPoseY.Location = new System.Drawing.Point(260, 174);
            this.textBoxBottomLeftArPoseY.Name = "textBoxBottomLeftArPoseY";
            this.textBoxBottomLeftArPoseY.Size = new System.Drawing.Size(152, 19);
            this.textBoxBottomLeftArPoseY.TabIndex = 32;
            // 
            // textBoxTopRightDobotPoseY
            // 
            this.textBoxTopRightDobotPoseY.Location = new System.Drawing.Point(596, 92);
            this.textBoxTopRightDobotPoseY.Name = "textBoxTopRightDobotPoseY";
            this.textBoxTopRightDobotPoseY.Size = new System.Drawing.Size(143, 19);
            this.textBoxTopRightDobotPoseY.TabIndex = 42;
            // 
            // textBoxBottomRightDobotPoseY
            // 
            this.textBoxBottomRightDobotPoseY.Location = new System.Drawing.Point(596, 135);
            this.textBoxBottomRightDobotPoseY.Name = "textBoxBottomRightDobotPoseY";
            this.textBoxBottomRightDobotPoseY.Size = new System.Drawing.Size(143, 19);
            this.textBoxBottomRightDobotPoseY.TabIndex = 43;
            // 
            // textBoxBottomLeftDobotPoseY
            // 
            this.textBoxBottomLeftDobotPoseY.Location = new System.Drawing.Point(596, 177);
            this.textBoxBottomLeftDobotPoseY.Name = "textBoxBottomLeftDobotPoseY";
            this.textBoxBottomLeftDobotPoseY.Size = new System.Drawing.Size(143, 19);
            this.textBoxBottomLeftDobotPoseY.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Z座標";
            // 
            // textBoxPlacePoseZCoordinate
            // 
            this.textBoxPlacePoseZCoordinate.Location = new System.Drawing.Point(73, 147);
            this.textBoxPlacePoseZCoordinate.Name = "textBoxPlacePoseZCoordinate";
            this.textBoxPlacePoseZCoordinate.Size = new System.Drawing.Size(168, 19);
            this.textBoxPlacePoseZCoordinate.TabIndex = 40;
            // 
            // DobotSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPlacePose);
            this.Controls.Add(this.buttonRoadPreviousValue);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPedestalZ);
            this.Controls.Add(this.labelPedestalBottom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxObjectHeight);
            this.Controls.Add(this.labelObjectHeight);
            this.Controls.Add(this.textBoxBottomLeftArPoseX);
            this.Controls.Add(this.textBoxBottomRightArPoseX);
            this.Controls.Add(this.textBoxTopRightArPoseX);
            this.Controls.Add(this.textBoxTopLeftArPoseX);
            this.Controls.Add(this.labelArMarker);
            this.Controls.Add(this.buttonNavExecute);
            this.Controls.Add(this.labelCalibration);
            this.Controls.Add(this.textBoxCalibFilePath);
            this.Controls.Add(this.buttonOpenCalibFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "DobotSettings";
            this.Size = new System.Drawing.Size(780, 580);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPlacePose.ResumeLayout(false);
            this.groupBoxPlacePose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenCalibFile;
        private System.Windows.Forms.TextBox textBoxCalibFilePath;
        private System.Windows.Forms.Label labelCalibration;
        private System.Windows.Forms.Button buttonNavExecute;
        private System.Windows.Forms.Label labelArMarker;
        private System.Windows.Forms.Label labelDobotPose;
        private System.Windows.Forms.TextBox textBoxTopLeftArPoseX;
        private System.Windows.Forms.TextBox textBoxTopLeftDobotPoseY;
        private System.Windows.Forms.TextBox textBoxTopRightDobotPoseX;
        private System.Windows.Forms.TextBox textBoxTopRightArPoseX;
        private System.Windows.Forms.TextBox textBoxBottomRightDobotPoseX;
        private System.Windows.Forms.TextBox textBoxBottomRightArPoseX;
        private System.Windows.Forms.TextBox textBoxBottomLeftDobotPoseX;
        private System.Windows.Forms.TextBox textBoxBottomLeftArPoseX;
        private System.Windows.Forms.Label labelObjectHeight;
        private System.Windows.Forms.TextBox textBoxObjectHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxValueMax;
        private System.Windows.Forms.TextBox textBoxValueMin;
        private System.Windows.Forms.TextBox textBoxSaturationMax;
        private System.Windows.Forms.TextBox textBoxSaturationMin;
        private System.Windows.Forms.TextBox textBoxHueMax;
        private System.Windows.Forms.TextBox textBoxHueMin;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelSaturation;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Label labelPedestalBottom;
        private System.Windows.Forms.TextBox textBoxPedestalZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBottomLeft;
        private System.Windows.Forms.Label labelBottomRight;
        private System.Windows.Forms.Label labelTopRight;
        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRoadPreviousValue;
        private System.Windows.Forms.GroupBox groupBoxPlacePose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPlacePoseYCoordinate;
        private System.Windows.Forms.TextBox textBoxPlacePoseXCoordinate;
        private System.Windows.Forms.TextBox textBoxTopLeftArPoseY;
        private System.Windows.Forms.TextBox textBoxTopLeftDobotPoseX;
        private System.Windows.Forms.TextBox textBoxTopRightArPoseY;
        private System.Windows.Forms.TextBox textBoxBottomRightArPoseY;
        private System.Windows.Forms.TextBox textBoxTopRightDobotPoseY;
        private System.Windows.Forms.TextBox textBoxBottomLeftArPoseY;
        private System.Windows.Forms.TextBox textBoxBottomRightDobotPoseY;
        private System.Windows.Forms.TextBox textBoxBottomLeftDobotPoseY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlacePoseZCoordinate;
    }
}
