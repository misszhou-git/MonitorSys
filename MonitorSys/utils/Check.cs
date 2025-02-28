using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QQDESK.utils
{
    internal class Check
    {
        /// <summary>
        /// 校验输入框内容是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns>true/false</returns>
        public static bool CheckUserInput(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 输入长度校验
        /// </summary>
        /// <param name="str">输入内容</param>
        /// <param name="length">校验长度</param>
        /// <returns>bool</returns>
        public static bool CheckLengh(string str, int length)
        {
            if (str.Length < length)
            {
                return false;
            }
            return true;
        }

        public static bool IsEmail(string email)
        {
            //  使用正则表达式检查邮箱格式
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool IsPhone(string? userPhone)
        {
            //1 3-9 9
            // 使用正则表达式检查手机格式
            string pattern = @"^1[3-9]\d{9}$"; ;
            return Regex.IsMatch(userPhone, pattern);
        }

      
    }
}
