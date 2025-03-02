using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using QQDESK.Models;

namespace MonitorSys.Models
{
    public class UserDB
    {
        public List<User> users;
        private static UserDB userDb {  get; set; }
        private IUserServiceDB UserServiceDB { get; set; }

        //单例模式，全局只有一个用户对象list
        private UserDB()
        {
            InitUser();
        }

        private void InitUser()
        {
            users = new List<User>();
            //UserServiceDB = new UserServiceDBImpl();
            //users = UserServiceDB.GetUser();
        }
        public static UserDB GetUserDb()
        {
            if (userDb == null)
            {
                userDb = new UserDB();
            }
            return userDb;
        }

    }
}
