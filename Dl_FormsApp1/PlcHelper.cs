using HslCommunication;
using HslCommunication.Profinet.Siemens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {

    // PLC操作类

    internal class PlcHelper {


        // 创建PLC连接对接
        //Plc plc = new Plc(CpuType.S7200Smart, "192.168.0.2", 0, 0);
        public SiemensS7Net plc;

        // PLC 启动标志 初始值未启动 true连接 false断开
        public bool isStartFlag = false;

       
        // 启动PLC
        public void startUpPlc()
        {
            // 由于PLC是盗版的，第一次连接可能会失败，所以需要重试
            // 打开PLC连接
            try
            {
                plc = new SiemensS7Net(HslCommunication.Profinet.Siemens.SiemensPLCS.S200Smart);
                plc.CommunicationPipe = new HslCommunication.Core.Pipe.PipeTcpNet("192.168.0.2", 102)
                {
                    ConnectTimeOut = 1000,    // 连接超时时间，单位毫秒
                    ReceiveTimeOut = 1000,    // 接收设备数据反馈的超时时间
                    SleepTime = 0,
                    SocketKeepAliveTime = -1,
                    IsPersistentConnection = true,
                };
            }
            catch (Exception)
            {
                //// 由于盗版PLC，第一次连接可能会失败，所以需要重试
                //plc = new SiemensS7Net(HslCommunication.Profinet.Siemens.SiemensPLCS.S200Smart);
                //plc.CommunicationPipe = new HslCommunication.Core.Pipe.PipeTcpNet("192.168.0.2", 102)
                //{
                //    ConnectTimeOut = 5000,    // 连接超时时间，单位毫秒
                //    ReceiveTimeOut = 10000,    // 接收设备数据反馈的超时时间
                //    SleepTime = 0,
                //    SocketKeepAliveTime = -1,
                //    IsPersistentConnection = true,
                //};
            }
            finally
            {
                // 判断硬件是否连接成功
                if (isPlcConnect())
                {
                    isStartFlag = true;
                    MessageBox.Show("PLC连接成功");
                }
                else
                {
                    isStartFlag = false;
                    MessageBox.Show("PLC连接失败");
                }
                Console.WriteLine($"启动标志:{isStartFlag}");
            }


        }

        // 停止PLC
        public void stopPlc()
        {
            plc.ConnectClose();
            isStartFlag = false;
            MessageBox.Show("PLC已断开");
        }

        // 判断PlC是否连接成功
        public Boolean isPlcConnect()
        {
            // 连接对象
            if (plc == null)
            {
                MessageBox.Show("请先操作PLC连接");
                return false;
            }
            OperateResult content = plc.ConnectServer();
            if (!content.IsSuccess)
            {
                MessageBox.Show("连接失败,失败原因 :" + content.Message);
                return false;
            }
            // 连接成功
            return true;

        }

    }

   
}
