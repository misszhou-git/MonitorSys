using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQDESK.Models;

namespace QQDESK.service
{
    internal interface IUserService
    {
        //检查用户输入
        bool CheckUserInput(string str);
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>bool</returns>
        bool Login(User user);

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns>bool</returns>
        bool Register(User user);
        
    }
}
