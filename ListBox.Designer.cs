﻿namespace MonitorSys
{
    partial class ListBox
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
            uiListBox1 = new Sunny.UI.UIListBox();
            SuspendLayout();
            // 
            // uiListBox1
            // 
            uiListBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiListBox1.HoverColor = Color.FromArgb(155, 200, 255);
            uiListBox1.ItemSelectForeColor = Color.White;
            uiListBox1.Location = new Point(112, 36);
            uiListBox1.Margin = new Padding(4, 5, 4, 5);
            uiListBox1.MinimumSize = new Size(1, 1);
            uiListBox1.Name = "uiListBox1";
            uiListBox1.Padding = new Padding(2);
            uiListBox1.ShowText = false;
            uiListBox1.Size = new Size(857, 579);
            uiListBox1.TabIndex = 0;
            uiListBox1.Text = "uiListBox1";
            // 
            // ListBox
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 682);
            Controls.Add(uiListBox1);
            Name = "ListBox";
            Text = "ListBox";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIListBox uiListBox1;
    }
}