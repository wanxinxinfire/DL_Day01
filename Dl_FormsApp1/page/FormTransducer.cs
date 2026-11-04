using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1.page {
    public partial class FormTransducer : UIForm {

        private readonly PlcHelper plcHelper;
        public FormTransducer()
        {

            InitializeComponent();
            //plcHelper = plc;
        }

        // 按下设置频率
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // 获取频率输入框的值
            // 判断输入框的值是否为数字
            decimal hz = decimal.Multiply(numericUpDownHz.Value, 100);
            short shortHz = Convert.ToInt16(hz);
            plcHelper.plc.Write("vw2500", shortHz);
            plcHelper.plc.Write("M7.0", true);

            //double frequency = Convert.ToDouble(textBox1.Text);
        }

        // 抬起设置M7.0的值
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            plcHelper.plc.Write("M7.0", false);
        }
    }
}
