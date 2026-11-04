using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {
    public partial class FormIPFormat : Form {
        public FormIPFormat()
        {
            InitializeComponent();
        }

        // 提取IP
        /**
            * 串口提取打印格式 赋值到richTextBox1
            * 以下是格式示例：
            * 
            * 输入: ParseDeviceAddress ("192.168.1.100:502")
            * 输出:
            * ----------------------------
            * 设备类型:以太网设备
            * IP地址:192.168.1.100
            * 端口号:502
            */
        private void button1_Click(object sender, EventArgs e)
        {
            // 获取文本框内容

            // 方式一
            //string text = textBox1.Text;
            //string[] ip = text.Split(':');
            //richTextBox1.Text += "----------------------------\r\n";
            //richTextBox1.Text += "设备类型:以太网设备" +
            //    "\r\nIP地址:" + ip[0]
            //    + "\r\n端口号:" + ip[1];
            //richTextBox1.Text += "\r\n----------------------------";
            //textBox1.Focus();

            // 方法二 indexof和substring
            //string text = textBox1.Text;
            //int index = text.IndexOf(':');
            //richTextBox1.Text += "----------------------------\r\n";
            //richTextBox1.Text += "设备类型:串口设备" +
            //    "\r\n串口地址:" + text.Substring(0, index)
            //    + "\r\n波特率:" + text.Substring(index + 1);
            //richTextBox1.Text += "\r\n----------------------------";
            //textBox1.Focus();

            ParseDeviceAddress(textBox1.Text);
        }

        // 提取串口

        private void button2_Click(object sender, EventArgs e)
        {
            ParseDeviceAddress(textBox2.Text);

        }


        /// <summary>
        /// 解析设备地址字符串。
        /// 支持两种格式：
        ///   1. IP地址:端口号，如 "192.168.1.100:502"
        ///   2. 串口:波特率,校验位,数据位,停止位，如 "COM3:9600,N,8,1"
        /// 全部使用 IndexOf + Substring 实现分割。
        /// </summary>
        public void ParseDeviceAddress(string address)
        {
            // 1) 找到第一个冒号的位置
            int colonIndex = address.IndexOf(':');

            // 2) 冒号之前的部分：IP地址 或 串口号
            string head = address.Substring(0, colonIndex);

            // 3) 冒号之后的部分：端口号 或 波特率,校验位,数据位,停止位
            string tail = address.Substring(colonIndex + 1);
            richTextBox1.Clear();
            richTextBox1.Text += "------------------------";

            // 4) 根据前半部分判断设备类型（以 COM 开头视为串口设备）
            if (head.StartsWith("COM", StringComparison.OrdinalIgnoreCase))
            {
                // —— 串口设备 ——
                richTextBox1.Text += "\r\n设备类型: 串口设备";
                richTextBox1.Text += "\r\n串口号: " + head;

                // 用 IndexOf + Substring 逐个切分逗号分隔的参数
                string[] parts = new string[4];
                int start = 0;
                for (int i = 0; i < 3; i++)
                {
                    int commaIndex = tail.IndexOf(',', start);
                    parts[i] = tail.Substring(start, commaIndex - start);
                    start = commaIndex + 1;
                }
                parts[3] = tail.Substring(start); // 最后一段到末尾

                richTextBox1.Text += "\r\n波特率: " + parts[0];
                richTextBox1.Text += "\r\n校验位: " + parts[1];
                richTextBox1.Text += "\r\n数据位: " + parts[2];
                richTextBox1.Text += "\r\n停止位: " + parts[3];
            }
            else {
                // —— 以太网设备 ——
                richTextBox1.Text += "\r\n设备类型: 以太网设备";
                richTextBox1.Text += "\r\nIP地址: " + head;
                richTextBox1.Text += "\r\n端口号: " + tail;
            }
            richTextBox1.Text += "\r\n------------------------";
        }

        private void FormIPFormat_Load(object sender, EventArgs e)
        {

        }
    }
}
