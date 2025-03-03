﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitorSys.Models;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using QQDESK.Models;
using Sunny.UI;

namespace MonitorSys.Forms.Pages
{
    public partial class UserPage : UIPage
    {
        public User user { get; set; }
        public IUserServiceDB UserServiceDB { get; set; }
  
    
        public UserPage()
        {
            InitializeComponent();
            user = new User();
            UserServiceDB = new UserServiceDBImpl();
        }

        private void UserPage_Initialize(object sender, EventArgs e)
        {
            //查询当前登录用户信息
            user = UserServiceDB.GetUserById(CurrentUserDB.Id);
            //当前登录用户信息
            this.uiTextBox1.Text = user.UserName;
            this.uiTextBox2.Text = user.Account;
            this.uiTextBox3.Text = user.Password;
            this.uiTextBox4.Text = user.Email;
            this.uiTextBox5.Text = user.Phone;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            user.Id = CurrentUserDB.Id;
       
            user.UserName = this.uiTextBox1.Text.Trim();
            user.Account = this.uiTextBox2.Text.Trim();
            user.Password = this.uiTextBox3.Text.Trim();
            user.Email = this.uiTextBox4.Text.Trim();
            user.Phone = this.uiTextBox5.Text.Trim();

            UserServiceDB.UpdateUserById(user);
          

            MessageBox.Show("用户信息更新成功");
        }
    }
}
