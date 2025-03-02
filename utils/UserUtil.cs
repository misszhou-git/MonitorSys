using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorSys.Models;

namespace MonitorSys.utils
{
    public static  class UserUtil
    {
        public static string CreateAccount(int length)
        {
            createAccount:
            Random rnd = new Random();
            StringBuilder newAccount = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                newAccount.Append(rnd.Next(9));
            }
            //检查帐号是否重复
            if (CheckUserCount(newAccount))
            {
                return newAccount.ToString();
            }
            else
            {
                goto createAccount;
            }
        }
        /// <summary>
        /// 检查帐号是否重复
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>

        private static bool CheckUserCount(StringBuilder newAccount)
        {

            UserDB userDB = UserDB.GetUserDb();
            foreach (var item in userDB.users) {
                if (item.Account == newAccount.ToString()) {
                    return false;
                }
            }
            return true;
        }
    }
}
