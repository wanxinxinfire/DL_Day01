using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Dl_FormsApp1.light {
    public partial class FormLight : Form {
        public FormLight()
        {
            InitializeComponent();
        }

        // 定义PLC对象
        PlcHelper plcHelper;
        // 定义light对象
        Light light;

        private void FormLight_Load(object sender, EventArgs e)
        {
            // 创建plc对象
            plcHelper = new PlcHelper();
            plcHelper.startUpPlc("192.168.0.2");
            // 判断是否连接成功
            if (!plcHelper.isPlcConnect())
            {
                MessageBox.Show("PLC连接失败");
                return;
            }
            light = new Light();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            light.Address = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            light.LightOn(plcHelper.plc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            light.LightOFF(plcHelper.plc);
        }

        bool isStart = false;
        private void btnRed_Click(object sender, EventArgs e)
        {
            // 点一次亮 点一次灭
            //light.address = btnRed.Text.Split(' ')[1];
            Light light1 = new Light();
            light1.Address = btnRed.Tag.ToString();
            isStart = !isStart;
            if (isStart) {
                light1.LightOn(plcHelper.plc);
            }
            else
            {
                light1.LightOFF(plcHelper.plc);
            }

            
        }
    }
}
