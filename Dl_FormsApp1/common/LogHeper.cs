using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Dl_FormsApp1 {
    public static class LogHeper {

        public static string logpath = Application.StartupPath + "\\log";

        static LogHeper()
        {

            if (!Directory.Exists(logpath))
            {
                Directory.CreateDirectory(logpath);

            }

        }


        //  当前时间      日志信息    日志等级 
        public static void WriteLog(string logmsg, LogType logType)
        {


            //按日期生成日志文件（每一个日志文件，方便归档排查）
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log1111111.txt";
            string logFullPath = Path.Combine(logpath, logFileName);

            //  定义的日志
            string log = $"【{DateTime.Now}】【线程编号{Thread.CurrentThread.ManagedThreadId}】  【{logType}】   【{logmsg}】  " + "\r\n";
            File.AppendAllText(logFullPath, log, System.Text.Encoding.UTF8);



        }

        public enum LogType {
            操作,
            警告,
            错误,
            严重报警
        }

    }

}