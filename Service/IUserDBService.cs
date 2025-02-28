using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQDESK.Models;
using QQDESK.ServiceImpl;

namespace MonitorSys.Service
{
    public interface IUserDBService
    {
        //获取所有的用户信息
        List<User> GetUsers();

        

    }
}
