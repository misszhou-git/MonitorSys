using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MonitorSys.Models;
using MonitorSys.utils;
using QQDESK.Models;
using QQDESK.service;
using QQDESK.ServiceImpl;
using QQDESK.utils;
using Sunny.UI;

namespace QQDESK
{
    public partial class FrmRegister : UIForm
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        private IUserService UserServiceImpl {  get; set; }

        private void doRegister_Click(object sender, EventArgs e)
        {
            this.tips.Visible = true;
            string name = this.nameRegisterText.Text.Trim();
            if (Check.CheckUserInput(name) || !Check.CheckLengh(name, 5))
            {
                this.tips.Text = "用户名长度应>5位";
                return;
            }
            string pass = this.passRegisterText.Text.Trim();
            if (Check.CheckUserInput(pass) || !Check.CheckLengh(pass, 6))
            {
                this.tips.Text = "密码长度应>6位";
                return;
            }
            string email = this.emailRegisterText.Text.Trim();
            if (!Check.IsEmail(email))
            {
                this.tips.Text = "邮箱格式有误";
                return;
            }
            string phone = this.phoneRegisterText.Text.Trim();
            if (!Check.IsPhone(phone))
            {
                this.tips.Text = "手机格式有误";
                return;
            }
            this.tips.Visible = false;
            //构建当前注册用户对象
            User user = new User();
            user.UserName = name;
            user.Password = pass;
            user.UserEmail = email;
            user.Phone = phone;
           
            if (UserServiceImpl.Register(user))
            {
                
                //生成随机帐号信息
                //注册成功
                MessageBox.Show("注册成功,当前帐号为："+ UserUtil.CreateUserAccount()+"，跳转登录页...");
                Thread.Sleep(2000);
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                MessageBox.Show("注册失败");
            }
           
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.tips.Visible = false;

            UserServiceImpl = new UserServiceImpl();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

     
    }
}
