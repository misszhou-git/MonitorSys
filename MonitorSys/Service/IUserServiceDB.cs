using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQDESK.Models;

namespace MonitorSys.Service
{
    public interface IUserServiceDB
    {
        /// <summary>
        /// 获取所有本地用户信息
        /// </summary>
        /// <returns></returns>
        List<User> GetUser();

        /// <summary>
        /// 保存用户信息
        /// </summary>
        /// <param name="user"></param>
        void SaveUser(User user);
    }
}
