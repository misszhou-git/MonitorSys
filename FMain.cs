using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitorSys.Forms.Pages;
using MonitorSys.Models;
using MonitorSys.Pages;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using QQDESK;
using QQDESK.Models;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MonitorSys
{
    public partial class FMain : UIHeaderMainFooterFrame
    {

        public FMain()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Fmain_FormClosing);

            //设置关联
            Header.TabControl = MainTabControl;
            UserPage UserPage = new UserPage();
            //连接数据库
            DatabaseHelper.GetConnection();

            //增加页面到Main
            AddPage(new Home(), 1001);
            AddPage(new Logger(), 1002);
            AddPage(new Setter(), 1003);
            AddPage(new UserPage(), 1004);

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

            //查询当前登录用户信息
            IUserServiceDB UserServiceDB = new UserServiceDBImpl();
            User user = new User();
            user = UserServiceDB.GetUserById(CurrentUserDB.Id);
            //当前登录用户信息
            this.uiLabel1.Text = "你好," + user.UserName + ",欢迎回来";

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Fmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true; // 取消关闭操作
                }
            }
        }


    }

}
