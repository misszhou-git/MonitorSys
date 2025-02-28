using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MonitorSys;
using MonitorSys.Models;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using QQDESK.Models;
using QQDESK.service;
using QQDESK.ServiceImpl;
using QQDESK.utils;
using Sunny.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QQDESK
{
    public partial class FrmLogin : UIForm
    {
        //�����û���Ϣ
        public IUserDBService UserDBService { get; set; }
        public UserDB UserDB { get; set; }
        //public IUserService UserService { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            //Log<FrmLogin>._LogLevel = LogLevel.Debug;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            this.tipsText.Visible = false;
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            if (Check.CheckUserInput(username) || !Check.CheckLengh(username, 5) || Check.CheckUserInput(password) || !Check.CheckLengh(password, 6))
            {
                this.uiButton1.Enabled = false;
                return;
            }
            this.uiButton1.Enabled = true;
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            this.tipsText.Visible = false;
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();

            IUserService userService = new UserServiceImpl();
            if (Check.CheckUserInput(username) || !Check.CheckLengh(username, 5) || Check.CheckUserInput(password) || !Check.CheckLengh(password, 6))
            {
                this.uiButton1.Enabled = false;
                return;
            }
            this.uiButton1.Enabled = true;
        }
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Models.User user = new Models.User();
            user.UserName = usernameBox.Text.Trim();
            user.Password = passwordBox.Text.Trim();

            IUserService userService = new UserServiceImpl();

            if (userService.Login(user))
            {
                //MessageBox.Show("��¼�ɹ���������ת����ϵͳ...");

                //��������
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.tipsText.Visible = true;
                this.tipsText.Text = "�û������������";
            }

        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

            // this.Show();
            //��ȡ�Ƿ��ס����
            string filePath = @"D:\\1.Project\\MonitorSys\remembetPassword.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                try
                {
                    if (reader.ReadLine() == "true")
                    {
                        this.rememberCheck.Checked = true;
                    }
                    else
                    {
                        this.rememberCheck.Checked = false;
                    }
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }
            //���ر������е��û���Ϣ
            UserDBService = new UserDBServiceImpl();
            //UserDB.users = UserDBService.GetUsers();
           
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberCheck.Checked) {
                string path = @"D:\\1.Project\\MonitorSys\remembetPassword.txt";
                using(FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("true");
                    fs.Write(info, 0, info.Length);
                }
            }
        }
    }
}
