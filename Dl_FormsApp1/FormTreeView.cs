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
using Dl_FormsApp1.common;

namespace Dl_FormsApp1.page {
    public partial class FormTreeView : UIForm {

        // 设置PLC 连接对象
        private PlcHelper plcHelper { get; set; }

        // 连接起始时间，null=未连接
        public static DateTime? ConnectStartTime { get; set; }

        // PLC 状态
        public static bool plc_status { get; set; } = false;

        public FormTreeView()
        {
            InitializeComponent();
            plcHelper = new PlcHelper();
        }
        // 页面加载事件
        private void FormTreeView_Load(object sender, EventArgs e)
        {
            // 查询PLC 状态 和连接时长
            if (plc_status)
            {
                // 若是连接成功设置
                ConnectStartTime = DateTime.Now;
                plc_status_lab.Text = "PLC 状态：已连接";
                // 设置连接时长格式为 HH:mm:ss，需要计算当前时间减去连接时间
                plc_open_time.Text = DateTime.Now.Subtract(ConnectStartTime.Value).ToString("HH:mm:ss");
            }
            else
            {
                plc_status_lab.Text = "PLC 状态：未连接";
                // 为连接状态下设置为 00:00:00
                plc_open_time.Text = "连接时长: 00:00:00";
            }
        }
        #region 菜单按钮展示下级菜单
        //  基础菜单
        private void button1_Click(object sender, EventArgs e)
        {
            // 显示 树子节点
            //panel2.Visible = !panel2.Visible;
        }
        #endregion

        #region 菜单跳转公共事件

        private void page_show_panel(object sender, EventArgs e)
        {

        }



        #endregion

        // 点击实现菜单跳转
        private void uiTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UITreeView treeView = sender as UITreeView;
            // 获取当前选中的节点
            TreeNode node = treeView.SelectedNode;
            if (node.Tag != null && node.Tag.ToString() != "")
            {
                // 获取当前节点的Tag
                string formName = node.Tag.ToString();
                // 跳转页面
                try
                {
                    PageType pageType = PageUtils.GetPageType(formName);
                    Form form = PageUtils.getFormPage(pageType);
                    // 添加页面
                    PageUtils.panellAdd(form, panel1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        // 连接PLC
        private void btn_plc_Click(object sender, EventArgs e)
        {

            if (btn_plc.Text == "断开")
            {
                // 写PLC 断开连接操作 断开成功按钮 改为连接
                plcHelper.stopPlc();
                plc_status_lab.Text = "PLC 状态：未连接";
                plc_open_time.Text = "连接时长: 00:00:00";
                ConnectStartTime = null;
                btn_plc.Text = "连接";
                // 定时任务停止
                timer1.Stop();
            }
            else
            {
                plcHelper.startUpPlc();
                if (plcHelper.isPlcConnect())
                {
                    btn_plc.Text = "断开";
                    plc_status_lab.Text = "PLC 状态：已连接";
                    ConnectStartTime = DateTime.Now;
                    plc_open_time.Text = ("连接时长: " + DateTime.Now.Subtract(ConnectStartTime.Value).ToString(@"hh\:mm\:ss"));
                    timer1.Start();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            plc_open_time.Text = "连接时长: " + DateTime.Now.Subtract(ConnectStartTime.Value).ToString(@"hh\:mm\:ss");
        }
    }
}
