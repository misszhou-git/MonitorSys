using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;
using MonitorSys.Service;
using QQDESK.Models;

namespace MonitorSys.ServiceImpl
{
    internal class UserDBServiceImpl : IUserDBService
    {
        const string path = @"Users\users.txt";
        private string localUser = null; //null不会开辟内存
       
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (StreamReader sr = new StreamReader(path)){
                if(!sr.EndOfStream)
                {
                    localUser = sr.ReadLine();
                    users.Add(ParseUser(localUser));
                }
            }

            return users;
        }

   

        //构建用户信息
        private User ParseUser(string localUser)
        {
            User user = new User();
            string[] users = localUser.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            user.Id = users[0];
            user.Account = users[1];
            user.UserName = users[2];
            user.Password = users[3];
            user.UserEmail = users[4];
            user.Phone = users[5];
            return user;
        }
    }
}
