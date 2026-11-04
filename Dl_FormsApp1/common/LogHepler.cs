using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Dl_FormsApp1.common {
    internal class LogHepler {

        // 文件日志添加
        public static void AddLog(string log)
        {
            // 设置路径
            String path = Path.Combine(Application.StartupPath, "log.txt");
            // 日志格式排版
            String logText = $"【{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}】 {log}\r\n";
            // 写入日志
            File.AppendAllText(path, logText);
        }

        // 页面box 添加日志
        private void AddBoxLog(string logStr, TextBox textBox)
        {
            textBox.Text += $"【{DateTime.Now}】" + logStr + "\r\n";
            // 获取或设置文本框中选定的文本起始点
            textBox.SelectionStart = textBox.Text.Length;
            // 将控件内容滚动到当前插入符号位置
            textBox.ScrollToCaret();
        }
    }
}
