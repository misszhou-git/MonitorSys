namespace MonitorSys
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiLabel1 = new Sunny.UI.UILabel();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Controls.Add(uiLabel1);
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(498, 29);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(263, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "你好，{username}欢迎回来";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Name = "FMain";
            Text = "智慧监测系统";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FMain_Load;
            Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
    }
}