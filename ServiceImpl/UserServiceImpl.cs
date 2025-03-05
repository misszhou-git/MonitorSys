using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;
using MonitorSys.Service;
using MonitorSys.ServiceImpl;
using MonitorSys.utils;
using QQDESK.Models;
using QQDESK.service;

namespace QQDESK.ServiceImpl
{
    public class UserServiceImpl : IUserService
    {
        const int ACCOUNT_LENGTH = 7;
        public IUserServiceDB UserServiceDB { get; set; }
        public List<User> Users { get; set; }

        public UserServiceImpl() {
            UserServiceDB = new UserServiceDBImpl();
            Users = UserServiceDB.GetUser();
        }
       
        public bool Login(User user)
        {
            foreach (var item in Users) {
                if (item.UserName.Trim() == user.UserName && item.Password.Trim() == user.Password) {
                    //保存当前登录用户id
                    CurrentUserDB.Id = item.Id;
                    return true;
                }
            }
            return false;
        }

        public bool Register(User user)
        {
            
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Phone))
            {
                return false;
            }
            
            //检验手机号和用户名唯一性
            foreach (var item in Users)
            {
                if(item.Phone == user.Phone || item.UserName == user.UserName)
                {
                    return false;
                }
            }

            //随机生成帐号
            user.Account = UserUtil.CreateAccount(ACCOUNT_LENGTH);
            //密码加密
            user.Password = MD5Helper.GetMd5(user.Password);

            //保存注册用户信息
         
           //UserServiceDB.SaveUser(user);
            DatabaseHelper.AddUser(user);

            return true;
        }


    }
}
