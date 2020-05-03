namespace MyDobotVisionForm.Views
{
    partial class DobotExecute
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
            this.buttonNavSettings = new System.Windows.Forms.Button();
            this.textBoxExecuteHistory = new System.Windows.Forms.TextBox();
            this.labelExecuteHistory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonEvacuation = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNavSettings
            // 
            this.buttonNavSettings.Location = new System.Drawing.Point(644, 532);
            this.buttonNavSettings.Name = "buttonNavSettings";
            this.buttonNavSettings.Size = new System.Drawing.Size(121, 34);
            this.buttonNavSettings.TabIndex = 4;
            this.buttonNavSettings.Text = "設定画面へ行くお";
            this.buttonNavSettings.UseVisualStyleBackColor = true;
            // 
            // textBoxExecuteHistory
            // 
            this.textBoxExecuteHistory.Location = new System.Drawing.Point(580, 30);
            this.textBoxExecuteHistory.Multiline = true;
            this.textBoxExecuteHistory.Name = "textBoxExecuteHistory";
            this.textBoxExecuteHistory.Size = new System.Drawing.Size(185, 485);
            this.textBoxExecuteHistory.TabIndex = 5;
            // 
            // labelExecuteHistory
            // 
            this.labelExecuteHistory.AutoSize = true;
            this.labelExecuteHistory.Location = new System.Drawing.Point(580, 12);
            this.labelExecuteHistory.Name = "labelExecuteHistory";
            this.labelExecuteHistory.Size = new System.Drawing.Size(53, 12);
            this.labelExecuteHistory.TabIndex = 6;
            this.labelExecuteHistory.Text = "実行履歴";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "カメラ映像";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(5, 532);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(121, 34);
            this.buttonExecute.TabIndex = 9;
            this.buttonExecute.Text = "実行するで";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 485);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(562, 485);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // buttonEvacuation
            // 
            this.buttonEvacuation.Location = new System.Drawing.Point(453, 532);
            this.buttonEvacuation.Name = "buttonEvacuation";
            this.buttonEvacuation.Size = new System.Drawing.Size(121, 34);
            this.buttonEvacuation.TabIndex = 11;
            this.buttonEvacuation.Text = "逃げる";
            this.buttonEvacuation.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(326, 532);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(121, 34);
            this.buttonHome.TabIndex = 12;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // DobotExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonEvacuation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExecuteHistory);
            this.Controls.Add(this.textBoxExecuteHistory);
            this.Controls.Add(this.buttonNavSettings);
            this.Name = "DobotExecute";
            this.Size = new System.Drawing.Size(780, 580);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNavSettings;
        private System.Windows.Forms.TextBox textBoxExecuteHistory;
        private System.Windows.Forms.Label labelExecuteHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonEvacuation;
        private System.Windows.Forms.Button buttonHome;
    }
}
