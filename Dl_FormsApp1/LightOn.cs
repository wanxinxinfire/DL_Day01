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
using S7.Net;

namespace Dl_FormsApp1 {
    public partial class LightOn : Form {
        public LightOn()
        {
            InitializeComponent();
        }

        // 创建PLC连接对接
        Plc plc = new Plc(CpuType.S7200Smart, "192.168.0.2", 0, 0);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // 控制红灯灭
        private void button6_Click(object sender, EventArgs e)
        {
            //btn_red.BackColor = Color.Silver;
            // 设置PLC的红灯亮
            plc.Write("Q0.4", false);
            //btn_red.BackColor = Color.Red;
            AddLog("红灯灭");
        }

        // 控制红灯亮
        private void button1_Click(object sender, EventArgs e)
        {

            // 校验不通过直接return，终止后续代码
            if (!checkPlcOpen())
            {
                return;
            }
            // 设置PLC的红灯亮
            plc.Write("Q0.4", true);
            //btn_red.BackColor = Color.Red;
            AddLog("红灯亮");

        }

        #region 辅助日志方法
        private void AddLog(string logStr)
        {
            textBox1.Text += $"【{DateTime.Now}】" + logStr + "\r\n";
            // 获取或设置文本框中选定的文本起始点
            textBox1.SelectionStart = textBox1.Text.Length;
            // 将控件内容滚动到当前插入符号位置
            textBox1.ScrollToCaret();
        }
        #endregion


        // 检查PLC是否连接，返回true=已连接；false=未连接
        private bool checkPlcOpen()
        {
            if (!plc.IsConnected) // 这里用你PLC对象自带的连接属性！
            {
                MessageBox.Show("请先连接PLC");
                return false;
            }
            return true;
        }

        // 按钮单击控制开关
        bool greenLightFlag = false;
        private void button2_Click(object sender, EventArgs e)
        {
            // 检查PLC连接
            checkPlcOpen();
            btn_green.BackColor = Color.Red;
            if (!greenLightFlag)
            {
                plc.Write("Q0.5", true);
                AddLog("绿灯亮");
            }
            else
            {
                plc.Write("Q0.5", false);
                AddLog("绿灯亮");
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn_green.BackColor = Color.Silver;
            plc.Write("Q0.5", false);
            AddLog("绿灯灭");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //btn_yellow.BackColor = Color.Red;
            plc.Write("Q1.1", false);
            AddLog("黄灯亮");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_yellow.BackColor = Color.Silver;
            AddLog("黄灯灭");
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
                // texBox_add_R.Text值判断奇数，偶数，小数返回NumberEunm值
                NumberEunm numberEunm = GetNumberType(Convert.ToDouble(texBox_add_R.Text));
                // switch判断 奇数、偶数、小数 进行PLC灯亮
                switch (numberEunm)
                {
                    case NumberEunm.odd_:
                        plc.Write("Q1.1", true);
                        plc.Write("Q0.4", false);
                        plc.Write("Q0.5", false);
                        break;
                    case NumberEunm.decimal_:
                        // 黄灯亮
                        plc.Write("Q1.1", true);
                        plc.Write("Q0.4", false);
                        plc.Write("Q0.5", false);
                        break;
                    case NumberEunm.even_:
                        plc.Write("Q0.5", true);
                        plc.Write("Q1.1", false);
                        plc.Write("Q0.4", false);
                        break;
                }


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

        // 监控器扫描三色灯状态
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 读取PLC中的三色灯状态
            // Q0.5 绿灯
            bool greenLightFlag = Convert.ToBoolean(plc.Read("Q0.5"));
            // Q0.4	红灯
            bool redLightFlag = Convert.ToBoolean(plc.Read("Q0.4"));
            // Q1.1 黄灯
            bool yellowLightFlag = Convert.ToBoolean(plc.Read("Q1.1"));

            // 根据PLC中的三色灯状态，设置界面中的三色灯状态
            if (redLightFlag)
            {
                redLightOn();
            }
            if (greenLightFlag)
            {
                greenLightOn();
            }

            if (yellowLightFlag)
            {
                yellowLightOn();
            }





        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 由于PLC是盗版的，第一次连接可能会失败，所以需要重试
            // 打开PLC连接
            try
            {
                plc.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("PLC第一次连接失败");
            }
            finally
            {
                // 判断硬件是否连接成功
                if (plc.IsConnected)
                {
                    // 设置按钮为红色 按钮提示词是运行中 并且不可以再次点击
                    button13.BackColor = Color.Green;
                    button13.Text = "PLC连接中";
                    // 设置按钮不能点击
                    button13.Enabled = false;
                    MessageBox.Show("PLC连接成功");
                }
                else
                {
                    MessageBox.Show("PLC连接失败");
                }
            }


        }



        // 关闭PLC连接
        private void button14_Click(object sender, EventArgs e)
        {
            // 关闭PLC连接
            plc.Close();
            // 弹窗提示
            if (!plc.IsConnected)
            {
                MessageBox.Show("PLC已关闭");
            }
            // 恢复按钮状态
            button13.BackColor = Color.DimGray;
            button13.Text = "PLC连接";
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {

        }

        // 控制黄色灯按下亮
        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            // 若是不在连接操作前 需要判断是否成功连接PLC 
            if (!plc.IsConnected)
            {
                MessageBox.Show("请先连接PLC");
                return;
            }
            plc.Write("Q1.1", true);
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            plc.Write("Q1.1", false);
        }

        private void button12_Click(object sender, EventArgs e)
        {

            //检查plc是否连接
            if (!plc.IsConnected)
            {
                MessageBox.Show("请先连接PLC");
                return;
            }

            // 监控定时器
            timer1.Enabled = !timer1.Enabled;
            // 设置监控中
            button12.Text = timer1.Enabled ? "停止监控" : "开始监控";
            // 开始监控灰色 停止监控绿
            button12.ForeColor = timer1.Enabled ? Color.BlanchedAlmond : Color.Gray;
            // 设置背景颜色
            button12.BackColor = timer1.Enabled ? Color.Green : Color.Silver;


        }

        private void button15_Click(object sender, EventArgs e)
        {
            yellowLightFlag = false;
            // 设置PLC黄灯关闭
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Yellow), false);
        }

        private NumberEunm GetNumberType(double number)
        {
            // 判断是不是小数：小数部分不为0
            if (number % 1 != 0)
            {
                return NumberEunm.decimal_;
            }

            long integerVal = (long)number;
            if (integerVal % 2 != 0)
            {
                return NumberEunm.odd_;
            }
            else
            {
                return NumberEunm.even_;
            }
        }

        // 定义黄灯闪烁按钮状态成员变量
        private bool yellowLightFlag = false;

        // 1. 点击开始按钮  黄灯200ms 闪烁     点击停止按钮  闪烁停止 
        private async void button16_Click(object sender, EventArgs e)
        {
            // 判断PLC是否
            if (!checkPlcOpen())
            {
                return;
            }
            // 设置闪烁
            while (!yellowLightFlag)
            {
                plc.Write("Q1.1", true);
                await Task.Delay(200);
            }
        }

        // 设置黄灯闪烁变量值
        bool yellowLightFlashingFlag = false;


        //写一个红绿灯按钮 红灯亮3秒
        //然后绿灯亮三秒 然后黄灯闪烁
        //然后一直循环 直到点击停止按钮。所有灯全部熄灭
        private async void button18_Click(object sender, EventArgs e)
        {
            //写一个红绿灯按钮 红灯亮3秒
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Red), true);
            await Task.Delay(3000);
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Red), false);
            //然后绿灯亮三秒 然后黄灯闪烁
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Green), true);
            await Task.Delay(3000);
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Green), false);
            while (!yellowLightFlashingFlag)
            {
                plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Yellow), true);
                await Task.Delay(1000);
            }
            //然后一直循环 直到点击停止按钮。所有灯全部熄灭

        }


        /// <summary>
        /// 获取枚举上Description字符串
        /// </summary>
        public static string GetPlcAddress(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (attrs != null && attrs.Length > 0)
            {
                return attrs[0].Description;
            }
            return "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Red), false);
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Yellow), false);
            plc.Write(EnumExtension.GetPlcAddress(PlcLightEnum.Green), false);
        }
    }



    // 灯亮枚举
    enum LightOnEunm {
        yellow_light_on,
        red_light_on,
        green_light_on
    }

    /// <summary>
    /// PLC三色灯枚举，Description存放PLC点位地址
    /// </summary>
    public enum PlcLightEnum {
        [Description("Q0.4")]
        Red,

        [Description("Q0.5")]
        Green,

        [Description("Q1.1")]
        Yellow
    }

    // 添加奇数 偶数 小数枚举类
    enum NumberEunm {
        odd_,
        even_,
        decimal_
    }
}
