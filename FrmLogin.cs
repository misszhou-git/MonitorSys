using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MonitorSys;
using MonitorSys.Models;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using MonitorSys.utils;
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
        public UserDB UserDB { get; set; }
        public IUserServiceDB UserServiceDB {  get; set; }

        public const string PATH = @"Users\remberPass.txt";

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
        /// <summary>
        /// ��¼��ť���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Models.User user = new Models.User();
            user.UserName = usernameBox.Text.Trim();
            user.Password = MD5Helper.GetMd5(passwordBox.Text.Trim());

            IUserService userService = new UserServiceImpl();

            if (userService.Login(user))
            {
                //MessageBox.Show("��¼�ɹ���������ת����ϵͳ...");

                //Console.WriteLine("��¼��־��Ϣ");
                //Log<FrmLogin>.LogInfomation("LogInfomation");
                //Log<FrmLogin>.LogWarning("LogWarning");
                //Log<FrmLogin>.LogError("LogError");

                //��������
                this.DialogResult = DialogResult.OK;

                //���µ�ǰ��¼�û���Ϣ����ס���빦��
                File.WriteAllText(PATH, "");
                StringBuilder sb = new StringBuilder();
                sb.Append($"{user.UserName}  {this.passwordBox.Text.Trim()} {this.rememberCheck.Checked}");
                using (StreamWriter s = new StreamWriter(PATH, true))
                {
                    s.WriteLine(sb.ToString());
                }
            }
            else
            {
                this.tipsText.Visible = true;
                this.tipsText.Text = "�û������������";
            }

        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //��ȡ���ؼ�¼�û�
            Models.User user = new Models.User();
            string localUser = null;

            using (StreamReader s = new StreamReader(PATH))
            {
                while (!s.EndOfStream)
                {
                    localUser = s.ReadLine();
                    user = ParseUser(localUser);
                }
            }
            //��ȡ�Ƿ��ס����
            this.usernameBox.Text = user.UserName;
            if (user.Check.ToBoolean())
            {
                this.rememberCheck.Checked = user.Check.ToBoolean();
                this.passwordBox.Text = user.Password;
            }
                    
            //��ȡ�����û���Ϣ
            UserDB  =  UserDB.GetUserDb();
            UserServiceDB = new UserServiceDBImpl();
            UserDB.users = UserServiceDB.GetUser();

           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberCheck.Checked) {
                using(FileStream fs = File.Create(PATH))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("true");
                    fs.Write(info, 0, info.Length);
                }
            }
        }
        /// <summary>
        /// ���������û���ס������Ϣ
        /// </summary>
        /// <param name="localUser">��ǰ���ڵ�¼���û���Ϣ</param>
        /// <returns>User</returns>
        private Models.User ParseUser(string localUser)
        {
            Models.User user = new Models.User();
            string[] str = localUser.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                user.UserName = str[0];
                user.Password = str[1];
                user.Check = str[2];
            }
            catch { }
            return user;
        }
    }
}
