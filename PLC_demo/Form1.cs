using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace PLC_demo {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }


        // 硬件  绿色按钮 I1.1 红色按钮 I1.2  


        // 创建PLC连接对接
        Plc plc = new Plc(CpuType.S7200Smart, "192.168.0.2", 0, 0);
        private void button1_Click(object sender, EventArgs e)
        {
            plc.Open();
            // 判断硬件是否连接成功
            if (plc.IsConnected)
            {
                MessageBox.Show("PLC连接成功");
            }
            else
            {
                MessageBox.Show("PLC连接失败");
            }
        }
    }
}
