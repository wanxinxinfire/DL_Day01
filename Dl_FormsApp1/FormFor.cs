using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dl_FormsApp1 {
    public partial class FormFor : Form {
        public FormFor()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            textBox1.Text += $"{i.ToString()},";
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                // 当打印为奇数字体颜色为绿色
                // 偶数是为红色
                if (i % 2 == 1)
                {
                    textBox1.ForeColor = Color.Green;
                    button2.BackColor = Color.Green;

                    // 写之前先定这段文字的颜色：奇数绿、偶数红
                    richTextBox1.SelectionColor = (i % 2 == 1) ? Color.Green : Color.Red;
                    button2.BackColor = richTextBox1.SelectionColor;
                }
                else
                {
                    textBox1.ForeColor = Color.Red;
                    button2.BackColor = Color.Red;

                    // 写之前先定这段文字的颜色：奇数绿、偶数红
                    richTextBox1.SelectionColor = (i % 2 == 1) ? Color.Green : Color.Red;
                    button2.BackColor = richTextBox1.SelectionColor;
                }

                if (i + 1 == 10)
                {
                    textBox1.Text += $"{i.ToString()};" + "\r\n";
                    richTextBox1.AppendText($"{i};\r\n");
                }
                else
                {

                    textBox1.Text += $"{i.ToString()},";
                    richTextBox1.AppendText($"{i},");
                }
                //控制展示速度和强制刷新
                await Task.Delay(300);
            }
        }

        // whlie 循环控件
        Boolean flag;
        int whlieValue = 0;
        bool isRunning = false;   // 新增：是否已经在跑
        private async void button3_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                textBox1.Text += $"{whlieValue.ToString()},";
            }
            if (isRunning) return;   // 正在跑就直接退出，不再开新循环
            isRunning = true;
            button3.Enabled = false;  // 顺手禁用按钮，物理上也点不了
            flag = true;
            while (flag)
            {
                // 打印
                whlieValue++;
                textBox1.Text += $"{whlieValue.ToString()},";
                await Task.Delay(100);
            }

            // 循环被 button4 停掉后，恢复状态
            isRunning = false;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                // 清空
                textBox1.Clear();
                whlieValue = 0;
            }
            flag = false;

        }

        private void FormFor_Load(object sender, EventArgs e)
        {

        }
    }
}
