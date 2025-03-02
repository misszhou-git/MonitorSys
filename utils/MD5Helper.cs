using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MonitorSys.utils
{
    public class MD5Helper
    {

        /// <summary>
        /// md5工具类生产加密字符串
        /// </summary>
        /// <returns></returns>
        public static string GetMd5(string str)
        {
            //1.创建md5对象
            MD5 md5 = MD5.Create();

            //2.我们需要把我们的字符串通过md5对象进行加密 先转换字节数组
            byte[] buffer = Encoding.UTF8.GetBytes(str);

            //3.针对字节数组进行加密
            byte[] newBuffer = md5.ComputeHash(buffer);

            //4.把加密后的字节数组转换成16进制的字符串  每个字符串2位
            //把newBuffer每一个字节都需要转换

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < newBuffer.Length; i++)
            {
                sb.Append(newBuffer[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
