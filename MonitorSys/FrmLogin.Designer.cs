using MonitorSys;

namespace QQDESK
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            username = new Label();
            password = new Label();
            btnRegister = new Label();
            btnLogout = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            tipsText = new Label();
            uiLabel1 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            rememberCheck = new CheckBox();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Transparent;
            username.ForeColor = Color.Black;
            username.Location = new Point(135, 206);
            username.Name = "username";
            username.Size = new Size(89, 20);
            username.TabIndex = 0;
            username.Text = "帐    号";
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.Transparent;
            password.ForeColor = Color.Black;
            password.Location = new Point(135, 256);
            password.Name = "password";
            password.Size = new Size(89, 20);
            password.TabIndex = 1;
            password.Text = "密    码";
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = true;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(93, 495);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(49, 20);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "注册";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Location = new Point(621, 495);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(49, 20);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "退出";
            btnLogout.Click += logout_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(244, 203);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(282, 30);
            usernameBox.TabIndex = 5;
            usernameBox.Text = "admin";
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(244, 253);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(282, 30);
            passwordBox.TabIndex = 6;
            passwordBox.Text = "123456";
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // tipsText
            // 
            tipsText.AutoSize = true;
            tipsText.BackColor = Color.Transparent;
            tipsText.Font = new Font("宋体", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tipsText.ForeColor = Color.OrangeRed;
            tipsText.Location = new Point(415, 295);
            tipsText.Name = "tipsText";
            tipsText.Size = new Size(111, 13);
            tipsText.TabIndex = 7;
            tipsText.Text = "用户名或密码错误";
            tipsText.TextAlign = ContentAlignment.MiddleRight;
            tipsText.Visible = false;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("宋体", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(203, 60);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(373, 60);
            uiLabel1.TabIndex = 8;
            uiLabel1.Text = "水泵智慧监测项目";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(244, 374);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(270, 42);
            uiButton1.TabIndex = 9;
            uiButton1.Text = "登录";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // rememberCheck
            // 
            rememberCheck.AutoSize = true;
            rememberCheck.BackColor = Color.Transparent;
            rememberCheck.ForeColor = Color.Black;
            rememberCheck.Location = new Point(415, 323);
            rememberCheck.Name = "rememberCheck";
            rememberCheck.Size = new Size(111, 24);
            rememberCheck.TabIndex = 10;
            rememberCheck.Text = "记住密码";
            rememberCheck.UseVisualStyleBackColor = false;
            rememberCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmLogin
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Resource.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(833, 568);
            Controls.Add(rememberCheck);
            Controls.Add(uiButton1);
            Controls.Add(uiLabel1);
            Controls.Add(tipsText);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(btnLogout);
            Controls.Add(btnRegister);
            Controls.Add(password);
            Controls.Add(username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "系统登录";
            ZoomScaleRect = new Rectangle(19, 19, 615, 362);
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password;
        private Label btnRegister;
        private Label btnLogout;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label tipsText;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private CheckBox rememberCheck;
    }
}
