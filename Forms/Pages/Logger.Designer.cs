namespace MonitorSys.Pages
{
    partial class Logger
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            startTime = new Sunny.UI.UIDatetimePicker();
            uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            设备名称 = new DataGridViewTextBoxColumn();
            状态 = new DataGridViewTextBoxColumn();
            温度 = new DataGridViewTextBoxColumn();
            湿度 = new DataGridViewTextBoxColumn();
            安装日期 = new DataGridViewTextBoxColumn();
            厂商 = new DataGridViewTextBoxColumn();
            uiPagination1 = new Sunny.UI.UIPagination();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // startTime
            // 
            startTime.FillColor = Color.White;
            startTime.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            startTime.Location = new Point(511, 12);
            startTime.Margin = new Padding(4, 5, 4, 5);
            startTime.MaxLength = 19;
            startTime.MinimumSize = new Size(63, 0);
            startTime.Name = "startTime";
            startTime.Padding = new Padding(0, 0, 30, 2);
            startTime.Size = new Size(135, 36);
            startTime.SymbolDropDown = 61555;
            startTime.SymbolNormal = 61555;
            startTime.SymbolSize = 24;
            startTime.TabIndex = 0;
            startTime.Text = "2025-02-20 20:54:10";
            startTime.TextAlignment = ContentAlignment.MiddleLeft;
            startTime.Value = new DateTime(2025, 2, 20, 20, 54, 10, 960);
            startTime.Watermark = "";
            // 
            // uiDatetimePicker1
            // 
            uiDatetimePicker1.FillColor = Color.White;
            uiDatetimePicker1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDatetimePicker1.Location = new Point(654, 12);
            uiDatetimePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatetimePicker1.MaxLength = 19;
            uiDatetimePicker1.MinimumSize = new Size(63, 0);
            uiDatetimePicker1.Name = "uiDatetimePicker1";
            uiDatetimePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatetimePicker1.Size = new Size(135, 36);
            uiDatetimePicker1.SymbolDropDown = 61555;
            uiDatetimePicker1.SymbolNormal = 61555;
            uiDatetimePicker1.SymbolSize = 24;
            uiDatetimePicker1.TabIndex = 1;
            uiDatetimePicker1.Text = "2025-02-20 20:54:10";
            uiDatetimePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatetimePicker1.Value = new DateTime(2025, 2, 20, 20, 54, 10, 960);
            uiDatetimePicker1.Watermark = "";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(927, 12);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 36);
            uiButton1.TabIndex = 3;
            uiButton1.Text = "重置";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Location = new Point(796, 12);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(125, 36);
            uiButton2.TabIndex = 4;
            uiButton2.Text = "查询";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.ZoomScaleDisabled = true;
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { 设备名称, 状态, 温度, 湿度, 安装日期, 厂商 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(-3, 56);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            uiDataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(1067, 412);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 5;
            uiDataGridView1.ZoomScaleDisabled = true;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // 设备名称
            // 
            设备名称.HeaderText = "设备名称";
            设备名称.MinimumWidth = 6;
            设备名称.Name = "设备名称";
            // 
            // 状态
            // 
            状态.HeaderText = "状态";
            状态.MinimumWidth = 6;
            状态.Name = "状态";
            // 
            // 温度
            // 
            温度.HeaderText = "温度";
            温度.MinimumWidth = 6;
            温度.Name = "温度";
            // 
            // 湿度
            // 
            湿度.HeaderText = "湿度";
            湿度.MinimumWidth = 6;
            湿度.Name = "湿度";
            // 
            // 安装日期
            // 
            安装日期.HeaderText = "安装日期";
            安装日期.MinimumWidth = 6;
            安装日期.Name = "安装日期";
            // 
            // 厂商
            // 
            厂商.HeaderText = "厂商";
            厂商.MinimumWidth = 6;
            厂商.Name = "厂商";
            // 
            // uiPagination1
            // 
            uiPagination1.ButtonFillSelectedColor = Color.FromArgb(64, 128, 204);
            uiPagination1.ButtonStyleInherited = false;
            uiPagination1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPagination1.Location = new Point(396, 476);
            uiPagination1.Margin = new Padding(4, 5, 4, 5);
            uiPagination1.MinimumSize = new Size(1, 1);
            uiPagination1.Name = "uiPagination1";
            uiPagination1.RectSides = ToolStripStatusLabelBorderSides.None;
            uiPagination1.ShowText = false;
            uiPagination1.Size = new Size(1424, 44);
            uiPagination1.TabIndex = 6;
            uiPagination1.Text = "uiPagination1";
            uiPagination1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // Logger
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1064, 528);
            Controls.Add(uiPagination1);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Controls.Add(uiDatetimePicker1);
            Controls.Add(startTime);
            Name = "Logger";
            Text = "日志信息";
            Initialize += Logger_Initialize;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDatetimePicker startTime;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn 设备名称;
        private DataGridViewTextBoxColumn 状态;
        private DataGridViewTextBoxColumn 温度;
        private DataGridViewTextBoxColumn 湿度;
        private DataGridViewTextBoxColumn 安装日期;
        private DataGridViewTextBoxColumn 厂商;
        private Sunny.UI.UIPagination uiPagination1;
    }
}