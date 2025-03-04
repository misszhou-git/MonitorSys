using System;
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
        private User selectUser { get; set; }


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
            EnableDelete(user);

            InitTable();

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



        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("UserName", typeof(string));
            table.Columns.Add("Account", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Phone", typeof(string));


            List<User> users = new List<User>();
            users = UserServiceDB.GetUser();
            for (var i = 0; i < users.Count; i++)
            {
                // 添加一些行数据
                table.Rows.Add(users[i].UserName, users[i].Account, users[i].Email, users[i].Phone);
            }
            uiDataGridView1.DataSource = table;

            //处理单元格点击事件
            uiDataGridView1.CellClick += (sender, e) =>
            {
                //MessageBox.Show($"Cell {e.ColumnIndex} {e.RowIndex} ");
                //更新左边用户视图
                selectUser = new User();
                selectUser = users[e.RowIndex];
                EnableDelete(selectUser);

                this.uiTextBox1.Text = selectUser.UserName;
                this.uiTextBox2.Text = selectUser.Account;
                this.uiTextBox3.Text = selectUser.Password;
                this.uiTextBox4.Text = selectUser.Email;
                this.uiTextBox5.Text = selectUser.Phone;
            };
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("删除");
           // EnableDelete();

        }
        private void EnableDelete(User user)
        {
            //管理员帐号禁止删除
            if(user.Account == "0083016")
            {
                this.delete.Enabled = false;
            }
            else
            {
                this.delete.Enabled = true;
            }
        }
    }
}
