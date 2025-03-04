using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;
using MonitorSys.Service;
using MonitorSys.utils;
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
                user.Id = str[0];
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
            //生成guid
            user.Id = Guid.NewGuid().ToString();

            sb.Append($"{user.Id} {user.Account} {user.UserName}  {user.Password} {user.Email} {user.Phone}");

            using (StreamWriter s = new StreamWriter(path, true))
            {
                s.WriteLine(sb.ToString());
            }
        }

        /// <summary>
        /// 根据id查找当前用户对象信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>用户对象</returns>
        public User GetUserById(string id)
        {
            User currentUser = new User();
            //获取所有用户信息
            List<User> users = GetUser();
            //匹配当前用户信息
            foreach (var item in users)
            {
                if (item.Id == id)
                {
                    currentUser.Id = item.Id;
                    currentUser.Account = item.Account;
                    currentUser.UserName = item.UserName;
                    currentUser.Password = item.Password;
                    currentUser.Email = item.Email;
                    currentUser.Phone = item.Phone;
                }
            }
            return currentUser;
        }

        /// <summary>
        /// 根据id修改当前用户对象信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>用户对象</returns>
        public void UpdateUserById(User user)
        {
            //获取所有用户信息
            List<User> users = GetUser();
            //删除本地用户数据txt文件
            DeleteUserById();
            FileStream fs = File.Create(path);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            //构建新用户对象信息
            for(var i=0;i< users.Count; i++)
            {
                if (users[i].Id == user.Id)
                {
                    users[i].Id = user.Id;
                    users[i].Account = user.Account;
                    users[i].UserName = user.UserName;
                    users[i].Password = user.Password;
                    users[i].Email = user.Email;
                    users[i].Phone = user.Phone;
                }
                //将新信息存入本地文件
                SaveUser(users[i]);
            }

        }

        public void DeleteUserById()
        {
            File.Delete(path);
        }

      
    }
}
