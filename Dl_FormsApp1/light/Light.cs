using HslCommunication.Profinet.Siemens;
using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1.light {
    internal class Light {

        // 灯名称
        public string LightName;
        // 灯地址
        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                // 校验地址合法性
                if (string.IsNullOrEmpty(value) || !value.StartsWith("Q", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("地址不合法");
                }
                address = value;
            }
        }


        public void LightOn(SiemensS7Net plc)
        {
            // 
            plc.Write(address, true);
        }

        public void LightOFF(SiemensS7Net plc)
        {
            plc.Write(address, false);
        }

        public void LightOFF(int a)
        {
        }

        public void LightOFF(int a,string b)
        {
        }

        public void LightOFF(string b, int a)
        {
        }
    }
}
