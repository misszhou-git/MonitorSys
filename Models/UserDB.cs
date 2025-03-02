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
        private  UserDB userDb {  get; set; }
        private IUserServiceDB UserServiceDB { get; set; }


        public UserDB()
        {
            InitUser();
        }

        private void InitUser()
        {
            users = new List<User>();
            UserServiceDB = new UserServiceDBImpl();
            users = UserServiceDB.GetUser();
        }
        public UserDB GetUserDb()
        {
            if (userDb == null)
            {
                userDb = new UserDB();
            }
            return userDb;
        }

    }
}
