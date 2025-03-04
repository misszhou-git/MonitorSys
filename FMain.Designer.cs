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
            uiButton1 = new Sunny.UI.UIButton();
            uiLabel1 = new Sunny.UI.UILabel();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Location = new Point(0, 693);
            Footer.Size = new Size(1365, 56);
            // 
            // Header
            // 
            Header.Controls.Add(uiLabel1);
            Header.Controls.Add(uiButton1);
            Header.Size = new Size(1365, 73);
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(1256, 21);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(71, 29);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "退出";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(990, 21);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(245, 29);
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "你好,{},欢迎登录";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1365, 749);
            Name = "FMain";
            Text = "智慧监测系统";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FMain_Load;
            Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel1;
    }
}