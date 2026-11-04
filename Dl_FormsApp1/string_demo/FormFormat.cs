using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {
    public partial class FormFormat : Form {
        public FormFormat()
        {
            InitializeComponent();
        }


        // 定义double数组
        double[] data = { 1.25, 2.38, 3.45, 4.12, 5.56 };
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "原始数据" + "\r\n" ;
            // 格式化输出至label
            // 4.12|5.67 join
            textBox1.Text += String.Join("|", data) + "\r\n";
            // 打印元素个数，“元素个数”加粗和加黑
            textBox1.Text += $"元素个数：{data.Length}" + "\r\n";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 清空textBox1
            textBox1.Text = "";
        }

        private void FormFormat_Load(object sender, EventArgs e)
        {

        }
    }
}
