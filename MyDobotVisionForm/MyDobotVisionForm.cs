using MyDobotVisionForm.Models;
using MyDobotVisionForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDobotVisionForm
{
    public partial class MyDobotVisionForm : Form
    {
        public MyDobotVisionForm()
        {
            InitializeComponent();
            this.Load += MyDobotVisionForm_Load;
        }

        /// <summary>
        /// フォーム読み込み処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyDobotVisionForm_Load(object sender, EventArgs e)
        {
            // 初期は設定画面を表示
            Navigate(typeof(DobotSettings), null);
        }

        /// <summary>
        /// 画面遷移
        /// </summary>
        /// <param name="t"></param>
        public void Navigate(Type t, SettingsObj obj)
        {
            // Typeがnullなら終了
            if (t == null)
            {
                Close(); 
                return;
            }

            this.Controls.Clear();
            var uc = obj != null ? 
                Activator.CreateInstance(t, new Object[] { obj }) as UserControl 
              : Activator.CreateInstance(t) as UserControl;
            this.Controls.Add(uc);
        }
    }
}
