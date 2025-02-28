using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;
using MonitorSys.Pages;
using QQDESK.Models;
using QQDESK.service;
using QQDESK.utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QQDESK.ServiceImpl
{
    internal class UserServiceImpl : IUserService
    {
        private readonly UserDB userDb;
    
        public UserServiceImpl() {
            userDb = new UserDB();
        }

        public bool CheckUserInput(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length < 5) {
                return true;
            }
            return false;
                
        }


        public bool Login(User user)
        {
            if (string.IsNullOrEmpty(user.UserName)||string.IsNullOrEmpty(user.Password) ){
                return false;
            }
            foreach (User item in userDb.users)
            {
                if (item.UserName == user.UserName && item.Password == user.Password) {
                    return true;
                }
            }
            return false;
        }

        public bool Register(User user)
        {
            if (string.IsNullOrEmpty(user.UserName) && string.IsNullOrEmpty(user.Password)) {
                return false;
            }
            foreach (User item in userDb.users)
            {
                if(item.Phone == user.Phone)
                {
                    return false;
                }
            }
            userDb.users.Add(user);
            //存到本地文件中
          
            return true;
        }
    }
}
