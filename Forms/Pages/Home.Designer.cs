namespace MonitorSys.Pages
{
    partial class Home
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
            uiBarChart1 = new Sunny.UI.UIBarChart();
            uiLineChart1 = new Sunny.UI.UILineChart();
            uiPieChart1 = new Sunny.UI.UIPieChart();
            SuspendLayout();
            // 
            // uiBarChart1
            // 
            uiBarChart1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiBarChart1.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiBarChart1.Location = new Point(21, 24);
            uiBarChart1.MinimumSize = new Size(1, 1);
            uiBarChart1.Name = "uiBarChart1";
            uiBarChart1.Size = new Size(304, 226);
            uiBarChart1.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiBarChart1.TabIndex = 0;
            uiBarChart1.Text = "uiBarChart1";
            // 
            // uiLineChart1
            // 
            uiLineChart1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLineChart1.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLineChart1.Location = new Point(346, 24);
            uiLineChart1.MinimumSize = new Size(1, 1);
            uiLineChart1.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            uiLineChart1.Name = "uiLineChart1";
            uiLineChart1.Size = new Size(287, 226);
            uiLineChart1.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLineChart1.TabIndex = 1;
            uiLineChart1.Text = "uiLineChart1";
            // 
            // uiPieChart1
            // 
            uiPieChart1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPieChart1.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPieChart1.Location = new Point(21, 268);
            uiPieChart1.MinimumSize = new Size(1, 1);
            uiPieChart1.Name = "uiPieChart1";
            uiPieChart1.Size = new Size(304, 231);
            uiPieChart1.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPieChart1.TabIndex = 2;
            uiPieChart1.Text = "uiPieChart1";
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(1127, 603);
            Controls.Add(uiPieChart1);
            Controls.Add(uiLineChart1);
            Controls.Add(uiBarChart1);
            Name = "Home";
            Text = "主页";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIBarChart uiBarChart1;
        private Sunny.UI.UILineChart uiLineChart1;
        private Sunny.UI.UIPieChart uiPieChart1;
    }
}