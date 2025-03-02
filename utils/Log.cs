using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;

namespace QQDESK
{
    public static class Log<T> where T : class
    {
        private static ILogger<T> logs;
        public static  LogLevel _LogLevel = LogLevel.Information;
        
        /// <summary>
        /// 日志初始化
        /// </summary>
        /// <returns></returns>
        private static ILogger<T> InitLogger(LogLevel logLevel)
        {
            var loggerFactory = LoggerFactory.Create(b =>
            {
                b.AddConsole();

                if (logLevel != LogLevel.Information)
                {
                    b.SetMinimumLevel(logLevel);
                }
                else
                {
                    b.SetMinimumLevel(LogLevel.Information);
                }
            });
            return loggerFactory.CreateLogger<T>();
        }
        /// <summary>
        /// 日志信息
        /// </summary>
        /// <param name="loggerMsg">日志内容</param>
        public static void LogInfomation(string loggerMsg)
        {
            logs = InitLogger(LogLevel.Information);
            logs.LogError(loggerMsg);// 写入控制台
            LogFile("Information", loggerMsg);// 写入文件
        }
        public static void LogWarning(string loggerMsg)
        {
            logs = InitLogger(LogLevel.Warning);
            logs.LogError(loggerMsg);// 写入控制台
            LogFile("Warning", loggerMsg);// 写入文件
        }
        /// <summary>
        /// 日志错误信息
        /// </summary>
        /// <param name="loggerMsg">日志内容</param>
        public static void LogError(string loggerMsg)
        {
            logs = InitLogger(LogLevel.Error);
            logs.LogError(loggerMsg);// 写入控制台
            LogFile("Error", loggerMsg);// 写入文件
        }
        /// <summary>
        /// 创建日志文件
        /// </summary>
        /// <param name="level">日志级别</param>
        /// <param name="msg">日志内容</param>
        private static void LogFile(string level,string msg)
        {
            logs = InitLogger(_LogLevel);
 
            if (!Directory.Exists("LOGGER"))
            {
                Directory.CreateDirectory("LOGGER"); 
            }
           

            string FilePath = $"{DateTime.Now.Year}年{DateTime.Now.Month}月{DateTime.Now.Day}日.txt";
            //判断文件释放存在
            if (!File.Exists("LOGGER/" + FilePath))
            {
                var f = File.CreateText(FilePath); 
                f.Flush();
                f.DisposeAsync();
                f.Close ();
                logs.LogDebug("创建日志文件成功");

            }

            //获取类名
            msg = $"{level} {DateTime.Now} {typeof(T).Name} {msg}\r\n";

            //消息转换成字节数组
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            using (FileStream fs = new FileStream("LOGGER/" + FilePath, FileMode.Append, FileAccess.Write))
            {
                fs.Write(buffer, 0, buffer.Length);
                logs.LogDebug("写入成功");
            }
            //删除过期文件
            string directoryPath = Environment.CurrentDirectory + "/LOGGER";
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            FileInfo[] filePaths = directoryInfo.GetFiles();
            foreach (FileInfo filePath in filePaths)
            {
                DeleteFile(filePath);
            }
        }

        private static void DeleteFile(FileInfo fileInfo)
        {
            var fileName = fileInfo.Name;
            string[] str = fileName.Split(new char[] { '年', '月', '日', '.','t','x','t' }, StringSplitOptions.RemoveEmptyEntries);
            DateTime dateTime = new DateTime((int)Convert.ToInt64(str[0]), (int)Convert.ToInt64(str[1]), (int)Convert.ToInt64(str[2]));
            
        
            if (dateTime.AddDays(7) <= DateTime.Now)
            {
                File.Delete(fileInfo.FullName);
            }

        }
        
    }

}

   