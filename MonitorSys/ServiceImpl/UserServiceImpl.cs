using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using QQDESK.Models;
using QQDESK.service;

namespace QQDESK.ServiceImpl
{
    public class UserServiceImpl : IUserService
    {
        public IUserServiceDB UserServiceDB { get; set; }
        public List<User> Users { get; set; }

        public UserServiceImpl() {
            UserServiceDB = new UserServiceDBImpl();
        }
       
        public bool Login(User user)
        {
            if (user.UserName == "admin" && user.Password == "123456") {
                return true;
            }
            return false;
        }

        public bool Register(User user)
        {
            
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Phone))
            {
                return false;
            }
            Users = new UserDB().users;
            //检验手机号唯一性
            foreach (var item in Users)
            {
                if(item.Phone == user.Phone)
                {
                    return false;
                }
            }
            //保存注册用户信息
            UserServiceDB.SaveUser(user);

            return true;
        }


    }
}
