using Dl_FormsApp1.common;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1.string_demo {
    public partial class FormStringCommTest : UIForm {
        public FormStringCommTest()
        {
            InitializeComponent();
        }

        // 定义校验方式变量
        private string checkType;



        // run button
        private void btn_run_Click(object sender, EventArgs e)
        {
            /**
             * 
             *  连 PLC：拆开 IP 和端口
             *  三色灯：把点位洗干净
             *  变频器：解析一行指令
             *  步进轴：条码末两位是位置
             *  定位日志：别用 += 拼字符串
             * 
             */
            // 检查下拉选项是否选择
            if (comboxCheckType.SelectedIndex == -1)
            {
                lblOut.Text = "请选择检查方式";
                return;
            }

            // 根据选择的值进行不同的处理
            switch (checkType)
            {
                case "连 PLC：拆开 IP 和端口":
                    CheckIp();
                    break;
                case "三色灯：把点位洗干净":
                    lightCheck();
                    break;
                case "变频器：解析一行指令":
                    freqCheck();
                    break;
                case "步进轴：条码末两位是位置":
                    stepCheck();
                    break;
                case "定位日志：别用 += 拼字符串":
                    logCheck();
                    break;
                default:
                    lblOut.Text = "请选择检查方式";
                    break;

            }

        }

        private int _count = 0;
        private StringBuilder _log = new StringBuilder();
        private void logCheck()
        {
            _count++;
            float pos = 20.00f;
            _log.Append("第 " + _count + " 次　定位 " + pos.ToString("0.00") + " mm");
            txtOut.AppendText("第 " + _count + " 次　定位 " + pos.ToString("0.00") + " mm\r\n");

            // 测试文件方式写日志
            LogHepler.AddLog(_log.ToString());
            _log.Clear();
        }

        private void stepCheck()
        {
            /**
             * 
             用到：Length　Substring　float.TryParse
             先判长度 >= 2，再截取
             取末两位：Substring(code.Length - 2)
             转数字用 float.TryParse，失败给提示
             *  PKG-2026-A020
             */

            string code = txtInput.Text.Trim();
            if (code.Length < 11) { lblOut.Text = "条码太短"; return; }

            // 末两位
            string tail = code.Substring(code.LastIndexOf("-"));

            float target;
            if (!float.TryParse(tail, out target))
            {
                lblOut.Text = "末两位不是数字";
                return;
            }

            lblOut.Text = "目标 " + target.ToString("0.00") + " mm";

        }

        private void freqCheck()
        {
            // 先去除空格
            string input = txtInput.Text.Trim();
            // 在切割
            string[] p = input.Split('|');
            // 判断长度是否正确
            if (p.Length != 3)
            {
                lblOut.Text = "格式不对，应为 SET|地址|值";
                return;
            }
            //
            string cmd = p[0].Trim().ToUpper();
            string addr = p[1].Trim().ToUpper();
            string val = p[2].Trim();

            lblOut.Text = "写入 " + addr + " = " + val;
            // 写入日志

        }

        // 三色灯：把点位洗干净
        private void lightCheck()
        {
            // 校验输入信息不能为空
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                lblOut.Text = "请输入正确点位 示例:Q0.4";
                return;
            }
            // 获取输入的点位 去除空格后转大写
            string plcAddress = txtInput.Text.Trim().ToUpper();
            //判断开头是否
            if (!plcAddress.StartsWith("Q"))
            {
                lblOut.Text = "灯的点位必须以 Q 开头";
                return;
            }
            lblOut.Text = $"合法: {plcAddress}";
        }

        //检查IP
        private void CheckIp()
        {
            // 检查输入框中是否有内容
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                lblOut.Text = "请输入地址";
                return;
            }
            // 去除前后空格
            string address = txtInput.Text.Trim();
            // 找冒号
            int colonIndex = address.IndexOf(':');
            // 判断是否找到
            if (colonIndex == -1)
            {
                MessageBox.Show("缺少端口");
                return;
            }
            // 获取冒号前的部分和冒号后的部分
            string ip = address.Substring(0, colonIndex);
            string port = address.Substring(colonIndex + 1);

            //校验端口不能为空
            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("缺少端口");
                return;
            }
            // 结果输出页面
            lblOut.Text = "IP=" + ip + "　端口=" + port;
        }

        // 下拉框选择
        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获取选择的值
            checkType = comboxCheckType.SelectedItem.ToString();
            lblOut.Text = "等待输入…";
        }
    }
}
