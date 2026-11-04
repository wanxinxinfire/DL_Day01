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
    public partial class FormArray : Form {
        public FormArray()
        {
            InitializeComponent();
        }

        // 定义int类型数据 求平均值
        int[] avg = { 10, 9, 8 };







        // 数组测试
        private void button1_Click(object sender, EventArgs e)
        {
            // 获取数组
            if (avg == null || avg.Length == 0) {
                MessageBox.Show("数组为空");
                return;
            }
            // 下表文本不能输入负数和小数以及不能为空
            if (textBox1.Text == "" || Convert.ToInt32(textBox1.Text) < 0 || Convert.ToInt32(textBox1.Text) >= avg.Length) {
                MessageBox.Show("请输入正确的下标");
                return;
            }
            textBox3.Text = avg[Convert.ToInt32(textBox1.Text)].ToString();
            
        }

        // 求数组平均值
        private void button2_Click(object sender, EventArgs e)
        {
            // for循环求数组平均值 要求每个元素在循环时打印在textBox2中并且需要换行 循环结束后打印平均值
            if (avg == null || avg.Length == 0) {
                MessageBox.Show("数组为空");
                return;
            }
            double sum = 0;
            for (int i = 0; i < avg.Length; i++) {
                textBox2.Text += avg[i].ToString() + "\r\n";
                sum += avg[i];
            }

            textBox2.Text += $"平均值为：{sum / avg.Length}";
        }

        private void FormArray_Load(object sender, EventArgs e)
        {

        }
    }
}
