using MonitorSys;

namespace QQDESK
{
    internal  class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //设置登录页为默认打开页面
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            //接收到登录页的返回值OK才会继续运行主窗体
            if (frmLogin.DialogResult == DialogResult.OK )
            {
                Application.Run(new FMain());
                
            }
        }
    }
}