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

            //���õ�¼ҳΪĬ�ϴ�ҳ��
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            //���յ���¼ҳ�ķ���ֵOK�Ż��������������
            if (frmLogin.DialogResult == DialogResult.OK )
            {
                Application.Run(new FMain());
                
            }
        }
    }
}