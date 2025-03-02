using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Service;
using QQDESK.Models;

namespace MonitorSys.ServiceImpl
{
    public class UserServiceDBImpl: IUserServiceDB
    {
        // 文件路径
        static string path = @"Users\users.txt";

        /// <summary>
        /// 获取本地所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            string localUser = null;
            using (StreamReader s = new StreamReader(path))
            {
                while (!s.EndOfStream)
                {
                    localUser = s.ReadLine();
                    users.Add(ParseUser(localUser));
                }
            }
            return users;
        }
        //解析当前用户字符串信息
        private User ParseUser(string? localUser)
        {
            User user = new User();
            string[] str = localUser.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                user.Id = Convert.ToInt32(str[0]);
                user.Account = str[1];
                user.UserName = str[2];
                user.Password = str[3];
                user.Email = str[4];
                user.Phone = str[5];
            }
            catch { }
            return user;
        }

        /// <summary>
        /// 保存用户信息
        /// </summary>
        /// <param name="user">User</param>
    
        public void SaveUser(User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{user.Id} {user.Account} {user.UserName}  {user.Password} {user.Email} {user.Phone}");

            using (StreamWriter s = new StreamWriter(path, true))
            {
                s.WriteLine(sb.ToString());
            }
        }
    }
}
