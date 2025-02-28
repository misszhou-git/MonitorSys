namespace QQDESK
{
    partial class FrmRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nameRegisterText = new TextBox();
            passRegisterText = new TextBox();
            emailRegisterText = new TextBox();
            phoneRegisterText = new TextBox();
            doRegister = new Button();
            tips = new Label();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(84, 61);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "用户名";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(84, 124);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "密    码";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(84, 195);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "邮    箱";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(84, 257);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "手机号";
            // 
            // nameRegisterText
            // 
            nameRegisterText.Location = new Point(222, 58);
            nameRegisterText.Name = "nameRegisterText";
            nameRegisterText.Size = new Size(229, 30);
            nameRegisterText.TabIndex = 4;
            nameRegisterText.Text = "admin";
            // 
            // passRegisterText
            // 
            passRegisterText.Location = new Point(222, 121);
            passRegisterText.Name = "passRegisterText";
            passRegisterText.Size = new Size(229, 30);
            passRegisterText.TabIndex = 5;
            passRegisterText.Text = "123456";
            // 
            // emailRegisterText
            // 
            emailRegisterText.Location = new Point(222, 192);
            emailRegisterText.Name = "emailRegisterText";
            emailRegisterText.Size = new Size(229, 30);
            emailRegisterText.TabIndex = 6;
            emailRegisterText.Text = "959946790@qq.com";
            // 
            // phoneRegisterText
            // 
            phoneRegisterText.Location = new Point(222, 254);
            phoneRegisterText.Name = "phoneRegisterText";
            phoneRegisterText.Size = new Size(229, 30);
            phoneRegisterText.TabIndex = 7;
            phoneRegisterText.Text = "18120076680";
            // 
            // doRegister
            // 
            doRegister.BackColor = SystemColors.MenuHighlight;
            doRegister.Location = new Point(84, 337);
            doRegister.Name = "doRegister";
            doRegister.Size = new Size(367, 34);
            doRegister.TabIndex = 8;
            doRegister.Text = "注册";
            doRegister.UseVisualStyleBackColor = false;
            doRegister.Click += doRegister_Click;
            // 
            // tips
            // 
            tips.AutoSize = true;
            tips.BackColor = Color.Transparent;
            tips.ForeColor = Color.Red;
            tips.Location = new Point(322, 301);
            tips.Name = "tips";
            tips.Size = new Size(129, 20);
            tips.TabIndex = 9;
            tips.Text = "输入格式有误";
            tips.UseWaitCursor = true;
            tips.Visible = false;
            // 
            // exit
            // 
            exit.BackColor = SystemColors.Menu;
            exit.Location = new Point(84, 377);
            exit.Name = "exit";
            exit.Size = new Size(367, 34);
            exit.TabIndex = 10;
            exit.Text = "退出";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // FrmRegister
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = MonitorSys.Resource.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(582, 453);
            Controls.Add(exit);
            Controls.Add(tips);
            Controls.Add(doRegister);
            Controls.Add(phoneRegisterText);
            Controls.Add(emailRegisterText);
            Controls.Add(passRegisterText);
            Controls.Add(nameRegisterText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "用户注册";
            ZoomScaleRect = new Rectangle(19, 19, 582, 453);
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nameRegisterText;
        private TextBox passRegisterText;
        private TextBox emailRegisterText;
        private TextBox phoneRegisterText;
        private Button doRegister;
        private Label tips;
        private Button exit;
    }
}