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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            pictureBox1 = new PictureBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiSwitch1 = new Sunny.UI.UISwitch();
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiLedBulb1 = new Sunny.UI.UILedBulb();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Controls.Add(uiLedBulb1);
            Header.Controls.Add(uiButton1);
            Header.Controls.Add(uiLabel2);
            Header.Controls.Add(uiSwitch1);
            Header.Controls.Add(uiLabel1);
            Header.Controls.Add(pictureBox1);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource.logo;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.Black;
            uiLabel1.Location = new Point(92, 31);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(351, 29);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "喷涂工艺温湿度控制系统";
            // 
            // uiSwitch1
            // 
            uiSwitch1.BackColor = Color.White;
            uiSwitch1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSwitch1.Location = new Point(471, 30);
            uiSwitch1.MinimumSize = new Size(1, 1);
            uiSwitch1.Name = "uiSwitch1";
            uiSwitch1.Size = new Size(70, 30);
            uiSwitch1.TabIndex = 2;
            uiSwitch1.Text = "uiSwitch1";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(547, 31);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(79, 29);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "未连接";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(691, 30);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(106, 30);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "配置";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedBulb1
            // 
            uiLedBulb1.Color = Color.FromArgb(255, 128, 0);
            uiLedBulb1.Location = new Point(632, 20);
            uiLedBulb1.Name = "uiLedBulb1";
            uiLedBulb1.Size = new Size(40, 40);
            uiLedBulb1.TabIndex = 5;
            uiLedBulb1.Text = "uiLedBulb1";
            // 
            // FMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IconImage = Resource.logo;
            Name = "FMain";
            Text = "控制系统";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FMain_Load;
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISwitch uiSwitch1;
        private Sunny.UI.UILedBulb uiLedBulb1;
    }
}