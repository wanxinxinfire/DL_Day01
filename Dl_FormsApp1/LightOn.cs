using DL_Day01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {
    public partial class LightOn : Form {
        public LightOn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_red.BackColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_red.BackColor = Color.Red;
            AddLog();

        }

        #region 辅助日志方法
        private void AddLog()
        {
            textBox1.Text += DateTime.Now + "红灯亮" + "\r\n";
            // 获取或设置文本框中选定的文本起始点
            textBox1.SelectionStart = textBox1.Text.Length;
            // 将控件内容滚动到当前插入符号位置
            textBox1.ScrollToCaret();
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            btn_green.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn_green.BackColor = Color.Silver;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn_yellow.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_yellow.BackColor = Color.Silver;

        }


        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("我是弹窗");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            texBox_mul_R.Text = Calculator.Mul(Convert.ToDouble(texBox_mul_A.Text), Convert.ToDouble(texBox_mul_B.Text)).ToString();
            // 日志输出
            String logStr = $"{texBox_mul_A.Text} x {texBox_mul_B.Text} = {texBox_mul_R.Text}";
            CalcAddLog(logStr);
        }

        // 运算LOG
        private void CalcAddLog(String calculationProcesstext)
        {
            textBox1.Text += $"【{DateTime.Now}】" + $"  {calculationProcesstext}" + "\r\n";
            // 获取或设置文本框中选定的文本起始点
            textBox1.SelectionStart = textBox1.Text.Length;
            // 将控件内容滚动到当前插入符号位置
            textBox1.ScrollToCaret();
        }

        private bool checkBoxNotEmpty(String dataA, String dataB)
        {
            if (string.IsNullOrEmpty(dataA) || string.IsNullOrEmpty(dataB))
            {
                return false;
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 校验输入信息是否为空
            bool isBoxEmpty = checkBoxNotEmpty(texBox_add_A.Text, texBox_add_B.Text);
            if (!isBoxEmpty)
            {
                // 弹窗
                MessageBox.Show("参数不能为空");
                return;
            }
            String logStr;
            try
            {
                texBox_add_R.Text = Calculator.Add(Convert.ToDouble(texBox_add_A.Text), Convert.ToDouble(texBox_add_B.Text)).ToString();
                // 日志输出
                logStr = $"{texBox_add_A.Text} + {texBox_add_B.Text} = {texBox_add_R.Text}";
                CalcAddLog(logStr);
            }
            catch (Exception)
            {
                logStr = "请输入正确的数字";
                // 弹框提醒
                MessageBox.Show(logStr);
                CalcAddLog(logStr);

                //throw new Exception("异常");
            }

        }


        // 取余运算
        private void texBox_add_R_TextChanged(object sender, EventArgs e)
        {
            Double num3 = Convert.ToDouble(texBox_add_R.Text);
            // 取余 偶数 
            if (num3 % 2 == 0)
            {
                // 红灯亮
                redLightOn();
            }
            // 取余 奇数 绿灯亮
            else if (num3 % 2 == 1)
            {
                greenLightOn();
            }
            // 小数
            else
            {

                yellowLightOn();
            }
        }

        #region 灯亮逻辑
        // 红灯亮
        private void redLightOn()
        {
            btn_red.BackColor = Color.Red;
            btn_green.BackColor = Color.Silver;
            btn_yellow.BackColor = Color.Silver;
        }
        // 黄灯亮
        private void yellowLightOn()
        {
            btn_yellow.BackColor = Color.Red;
            btn_green.BackColor = Color.Silver;
            btn_red.BackColor = Color.Silver;
        }

        // 绿灯亮
        private void greenLightOn()
        {
            btn_green.BackColor = Color.Red;
            btn_red.BackColor = Color.Silver;
            btn_yellow.BackColor = Color.Silver;
        }
        #endregion


        private void button5_Click(object sender, EventArgs e)
        {
            texBox_sub_R.Text = Calculator.Sub(Convert.ToDouble(texBox_sub_A.Text), Convert.ToDouble(texBox_sub_B.Text)).ToString();
            // 日志输出
            String logStr = $"{texBox_sub_A.Text} - {texBox_sub_B.Text} = {texBox_sub_R.Text}";
            CalcAddLog(logStr);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            texBox_div_R.Text = Calculator.Div(Convert.ToDouble(texBox_div_A.Text), Convert.ToDouble(texBox_div_B.Text)).ToString();
            // 日志输出
            String logStr = $"{texBox_div_A.Text} x {texBox_div_B.Text} = {texBox_div_R.Text}";

            CalcAddLog(logStr);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        Button button;
        private void button11_Click(object sender, EventArgs e)
        {
            button = new Button();
            button.BackColor = Color.Green;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("宋体", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            button.ForeColor = Color.White;
            button.Location = new Point(248, 321);
            button.Name = "btn";
            button.Size = new Size(119, 59);
            button.Text = "自己创建的控件";
            button.UseVisualStyleBackColor = false;
            this.Controls.Add(button);
        }

        private void texBox_mul_R_TextChanged(object sender, EventArgs e)
        {
            // 获计算取结果值
            double res = Convert.ToDouble(texBox_mul_R.Text);
            LightOnEunm lightOnEunm;
            // 
            if (res % 2 == 0)
            {
                // 红灯亮
                lightOnEunm = LightOnEunm.red_light_on;
            }
            // 取余 奇数 绿灯亮
            else if (res % 2 == 1)
            {
                lightOnEunm = LightOnEunm.green_light_on;
            }
            // 小数
            else
            {
                lightOnEunm = LightOnEunm.yellow_light_on;
            }
            // switch控制开关等
            switch (lightOnEunm)
            {
                case LightOnEunm.yellow_light_on:
                    yellowLightOn();
                    break;
                case LightOnEunm.red_light_on:
                    redLightOn();
                    break;
                case LightOnEunm.green_light_on:
                    greenLightOn();
                    break;
                default:
                    break;  
            }
        }
    }

    // 灯亮枚举
    enum LightOnEunm {
        yellow_light_on,
        red_light_on,
        green_light_on
    }
}
