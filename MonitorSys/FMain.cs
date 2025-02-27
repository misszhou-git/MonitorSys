﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitorSys.Forms.Pages;
using MonitorSys.Pages;
using QQDESK;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MonitorSys
{
    public partial class FMain : UIHeaderMainFooterFrame
    {
        public FMain()
        {
            InitializeComponent();
            //连接数据库
            //DatabaseHelper.GetConnection();
            //设置关联
            Header.TabControl = MainTabControl;


            //增加页面到Main
            AddPage(new Home(), 1001);
            AddPage(new Logger(), 1002);
            AddPage(new Setter(), 1003);
            AddPage(new Media(), 1004);

            //设置Header节点索引
            Header.CreateNode("主页", 1001);
            Header.CreateNode("数据报表", 1002);
            Header.CreateNode("参数设置", 1003);
            Header.CreateNode("个人信息", 1004);

            //显示默认界面
            Header.SelectedIndex = 0;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            Footer.Text = "备案号@2875245qerq ";
            //窗体最大化
            this.WindowState = FormWindowState.Maximized;

            this.Hide();

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();


        }

    }

}
