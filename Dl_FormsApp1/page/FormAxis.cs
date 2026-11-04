using Dl_FormsApp1;
using HslCommunication;
using S7.Net;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DL_Day03_Stepper_Axis {
    public partial class FormAxis : Form {

        private PlcHelper plcHelper { get; set; }

        //// 构造函数
        //private FormAxis(PlcHelper plc)
        //{

        //}

        private FormAxis(PlcHelper plc)
        {
            InitializeComponent();
            if (DesignMode) return;
            plcHelper = plc;
        }

        public FormAxis()
        {
            InitializeComponent();
            if (DesignMode) return;
        }


        // 定义PLC操作对象


        // 定义选中的轴
        int selectAxis;

        #region 定义轴运动 
        // 目标位置
        public float CurrentTargetPos;
        // 运行速度
        public float CurrentRunSpeed;
        // 轴当前位置
        //public float CurrentAxisPos;
        // 负限位是否激活
        //public bool CurrentNegLimitStatus = false;
        // 正限位是否激活
        //public bool PosLimitStatus = false;
        // 原点
        //public bool CurrentOriginStatus = false;
        // 定位完成
        //public bool MoveDoneStatus = false;
        #endregion

        // 启动PLC
        private void Form2_Load(object sender, EventArgs e)
        {
            
            Console.WriteLine("启动PLC");
            // 设置默认选中按钮
            rdoAxis2.Checked = true;
            // 当前位置名称替换
            lblPositionAxisName.Text = "轴2当前位置:";
            selectAxis = 2;



            // 启动PLC
            //plcHelper.startUpPlc();

            // 检查PLC连接状态
            if (plcHelper.isStartFlag)
            {
                // 设置运行状态
                lblRunState.Text = "已连接";
                // 设置文本为绿色
                lblRunState.ForeColor = Color.Green;

                // 设置启动时的目标速度
                CurrentRunSpeed = (float)numSpeed.Value;
                Console.WriteLine("窗口启动时的默认轴移动速度:{0}", CurrentRunSpeed);

                // 监控状态
                //tmr_Refresh.Start();
            }
            else
            {
                // 设置运行状态
                lblRunState.Text = "未连接";
                // 设置文本为绿色
                lblRunState.ForeColor = Color.Silver;
            }
        }

        // 回原点
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                //Console.Write(AxisAddressPool.Get(selectAxis).HomeStart);

                // 启动回原点
                plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).HomeStart, true);
                // 等待回原点完成
                Thread.Sleep(300);
                plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).HomeStart, false);
            }
            catch (Exception ex)
            {
                // 弹窗提示异常信息
                MessageBox.Show(ex.Message);
            }



        }

        // 轴1 选择框
        private void rdoAxis1_CheckedChanged(object sender, EventArgs e)
        {
            // 若是选中 赋值1
            if (rdoAxis1.Checked)
            {
                selectAxis = 1;
                //rdoAxis1.BackColor = Color.Red;
                // 当前位置名称替换
                lblPositionAxisName.Text = "轴1当前位置:";
            }

        }

        // 轴2 选择框
        private void rdoAxis2_CheckedChanged(object sender, EventArgs e)
        {
            // 若是选中 赋值1
            if (rdoAxis2.Checked)
            {
                selectAxis = 2;
                //rdoAxis2.BackColor = Color.Red;
                // 当前位置名称替换
                lblPositionAxisName.Text = "轴2当前位置:";
            }
        }

        // 定位启动
        private void btnMove_Click(object sender, EventArgs e)
        {
            // 设置目标位置
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).TargetPos, float.Parse(Convert.ToString(numTarget.Value)));
            // 设置目标速度
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).TargetSpeed, float.Parse(Convert.ToString(numSpeed.Value)));

            // 定位启动
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).MoveStart, true);
            Thread.Sleep(300);
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).MoveStart, false);


        }



        // 停止
        private void btnStop_Click(object sender, EventArgs e)
        {
            // 将所有的轴停止
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).HomeStart, false);
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).MoveStart, false);
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogPlus, false);
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogMinus, false);

        }


        // 定时刷新状态栏方法（页面加载时调用）
        private void tmr_Refresh_Tick(object sender, EventArgs e)
        {
            // 检查PLC连接状态
            if (!plcHelper.isPlcConnect())
            {
                return;
            }
            // 设置左限位状态 
            //uiLight1.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).negLimitStatus).Content ? Color.Red : Color.Silver;
            lblNegative.Text = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).negLimitStatus).Content ? "负限位：未触发" : "负限位：已触发";
            uiLight1.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).negLimitStatus).Content ? Color.Red : Color.Green;

            // 设置正限位状态
            //uiLight3.OnColor = plcHelper.plc.ReadBool().Content ? Color.Red : Color.Silver;
            lblPositive.Text = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).posLimitStatus).Content ? "正限位：未触发" : "正限位：已触发";
            uiLight3.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).posLimitStatus).Content ? Color.Red : Color.Green;

            // 设置原点状态
            //uiLight2.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).originPos).Content ? Color.Red : Color.Silver;
            lblOrigin.Text = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).originPos).Content ? "原点：已触发" : "原点：未触发";
            uiLight2.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).originPos).Content ? Color.Green : Color.Red;

            // 设置定位完成状态
            //uiLight4.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).MoveDone).Content ? Color.Red : Color.Silver;
            lblDone.Text = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).MoveDone).Content ? "定位完成：已触发" : "定位完成：未触发";
            uiLight4.OnColor = plcHelper.plc.ReadBool(AxisAddressPool.Get(selectAxis).MoveDone).Content ? Color.Green : Color.Red;

            // 设置当前轴位置
            lblPosition.Text = plcHelper.plc.ReadFloat(AxisAddressPool.Get(selectAxis).CurrentPos).Content.ToString("0.00");

        }

        // 轴左边移动  按下时操作
        private void btnJogNegative_MouseDown(object sender, MouseEventArgs e)
        {
            // 设置轴手动移动速度 
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogSpeed, CurrentRunSpeed);
            // 设置想左边移动
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogPlus, true);
        }
        // 轴左边移动  抬起时操作
        private void btnJogNegative_MouseUp(object sender, MouseEventArgs e)
        {
            // 停止移动
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogPlus, false);
        }


        // 轴右边移动  按下时操作
        private void btnJogPositive_MouseDown(object sender, MouseEventArgs e)
        {
            // 设置轴手动移动速度 
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogSpeed, CurrentRunSpeed);
            // 设置想左边移动
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogMinus, true);
        }

        // 轴右边移动  抬起时操作
        private void btnJogPositive_MouseUp(object sender, MouseEventArgs e)
        {
            // 停止移动
            plcHelper.plc.Write(AxisAddressPool.Get(selectAxis).JogMinus, false);
        }

        // 设置轴移动速度
        private void numSpeed_ValueChanged(object sender, EventArgs e)
        {
            CurrentRunSpeed = (float)numSpeed.Value;
            // 控制台打印
            Console.WriteLine("轴移动速度:{0}", CurrentRunSpeed);
        }

        private void uiLight3_Click(object sender, EventArgs e)
        {

        }
    }
}
