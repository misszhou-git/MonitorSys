using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MonitorSys.utils;
using QQDESK.service;
using QQDESK.ServiceImpl;
using QQDESK.utils;
using Sunny.UI;
using QQDESK.Models;

namespace QQDESK
{
    public partial class FrmRegister : UIForm
    {
        public IUserService userService;
        public Models.User User {  get; set; }
        public FrmRegister()
        {
            InitializeComponent();
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            this.tips.Visible = false;
            userService = new UserServiceImpl();
           
        }


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

            Models.User user = new Models.User();
            user.UserName = name;
            user.Password = pass;
            user.Email = email;
            user.Phone = phone; 

            if (userService.Register(user))
            {
                string newAccount = UserUtil.CreateAccount();
                MessageBox.Show("注册成功，帐号为：" + newAccount + "正在跳转登录页...");
                Thread.Sleep(2000);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("注册失败，手机号已存在");
            }
        }

       
        private void exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

     
    }
}
