using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;
using QQDESK.Models;

namespace MonitorSys.utils
{
    internal static class UserUtil
    {
        /// <summary>
        /// 系统自动生成新帐号
        /// </summary>
        /// <returns>生成的帐号字条串</returns>
        public static string CreateUserAccount()
        {
            StringBuilder sb = new StringBuilder();
            CreateAccout:
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                sb.Append(random.Next(9));
            }
            if (CheckAccount(sb.ToString())) {
                return sb.ToString();
            }
            else
            {
                goto CreateAccout;
            }
           
        }

        private static bool CheckAccount(string account)
        {
            UserDB userDB = new UserDB();
            foreach (var item in userDB.users)
            {
                if(item.Account == account)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
