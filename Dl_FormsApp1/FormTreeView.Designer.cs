using System.Windows.Forms;

namespace Dl_FormsApp1.page {
    partial class FormTreeView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        #endregion
        private Panel panel1;
        private Panel tree_view_manu;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("三色灯");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("For");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("步进器");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("登录");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("注册");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("变频器");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("基础功能", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("压力数据格式化输出");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("IP格式化");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("数组练习");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Day1102", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("字符串运用");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("通用窗体Test");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Day1103", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("课后练习", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode14});
            this.tree_view_manu = new System.Windows.Forms.Panel();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_plc = new Sunny.UI.UIButton();
            this.plc_open_time = new Sunny.UI.UILabel();
            this.plc_status_lab = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tree_view_manu.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree_view_manu
            // 
            this.tree_view_manu.AutoScroll = true;
            this.tree_view_manu.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.tree_view_manu.AutoScrollMinSize = new System.Drawing.Size(240, 1200);
            this.tree_view_manu.AutoSize = true;
            this.tree_view_manu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree_view_manu.Controls.Add(this.uiTreeView1);
            this.tree_view_manu.Location = new System.Drawing.Point(3, 135);
            this.tree_view_manu.Name = "tree_view_manu";
            this.tree_view_manu.Size = new System.Drawing.Size(182, 759);
            this.tree_view_manu.TabIndex = 0;
            // 
            // uiTreeView1
            // 
            this.uiTreeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTreeView1.FillColor = System.Drawing.Color.White;
            this.uiTreeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeView1.Location = new System.Drawing.Point(0, 0);
            this.uiTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeView1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeView1.Name = "uiTreeView1";
            treeNode1.Name = "节点1";
            treeNode1.Tag = "LightOn";
            treeNode1.Text = "三色灯";
            treeNode2.Name = "节点2";
            treeNode2.Tag = "FormFor";
            treeNode2.Text = "For";
            treeNode3.Checked = true;
            treeNode3.Name = "节点4";
            treeNode3.Tag = "FormAxis";
            treeNode3.Text = "步进器";
            treeNode4.Name = "节点0";
            treeNode4.Tag = "Login";
            treeNode4.Text = "登录";
            treeNode5.Name = "节点1";
            treeNode5.Tag = "Registr";
            treeNode5.Text = "注册";
            treeNode6.Name = "节点0";
            treeNode6.Tag = "FormTransducer";
            treeNode6.Text = "变频器";
            treeNode7.Name = "节点0";
            treeNode7.Text = "基础功能";
            treeNode8.Name = "节点1";
            treeNode8.Tag = "FormFormat";
            treeNode8.Text = "压力数据格式化输出";
            treeNode9.Name = "节点0";
            treeNode9.Tag = "FormIPFormat";
            treeNode9.Text = "IP格式化";
            treeNode10.Name = "节点1";
            treeNode10.Tag = "FormArray";
            treeNode10.Text = "数组练习";
            treeNode11.Name = "节点0";
            treeNode11.Text = "Day1102";
            treeNode12.Name = "节点2";
            treeNode12.Tag = "FormString";
            treeNode12.Text = "字符串运用";
            treeNode13.Name = "节点0";
            treeNode13.Tag = "FormStringCommTest";
            treeNode13.Text = "通用窗体Test";
            treeNode14.Name = "节点1";
            treeNode14.Text = "Day1103";
            treeNode15.Name = "节点0";
            treeNode15.Text = "课后练习";
            this.uiTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode15});
            this.uiTreeView1.ScrollBarStyleInherited = false;
            this.uiTreeView1.ShowText = false;
            this.uiTreeView1.Size = new System.Drawing.Size(250, 753);
            this.uiTreeView1.TabIndex = 1;
            this.uiTreeView1.Text = "uiTreeView1";
            this.uiTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uiTreeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(184, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 759);
            this.panel1.TabIndex = 1;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btn_plc);
            this.uiPanel1.Controls.Add(this.plc_open_time);
            this.uiPanel1.Controls.Add(this.plc_status_lab);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiPanel1.FillColorGradient = true;
            this.uiPanel1.FillColorGradientDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(3, 40);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1187, 95);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_plc
            // 
            this.btn_plc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plc.FillColor = System.Drawing.Color.Silver;
            this.btn_plc.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_plc.Location = new System.Drawing.Point(649, 49);
            this.btn_plc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_plc.Name = "btn_plc";
            this.btn_plc.Size = new System.Drawing.Size(100, 35);
            this.btn_plc.TabIndex = 3;
            this.btn_plc.Text = "连接";
            this.btn_plc.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_plc.Click += new System.EventHandler(this.btn_plc_Click);
            // 
            // plc_open_time
            // 
            this.plc_open_time.BackColor = System.Drawing.Color.Transparent;
            this.plc_open_time.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plc_open_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.plc_open_time.Location = new System.Drawing.Point(976, 60);
            this.plc_open_time.Name = "plc_open_time";
            this.plc_open_time.Size = new System.Drawing.Size(116, 24);
            this.plc_open_time.TabIndex = 2;
            this.plc_open_time.Text = "连接时长:";
            // 
            // plc_status_lab
            // 
            this.plc_status_lab.BackColor = System.Drawing.Color.Transparent;
            this.plc_status_lab.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plc_status_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.plc_status_lab.Location = new System.Drawing.Point(804, 60);
            this.plc_status_lab.Name = "plc_status_lab";
            this.plc_status_lab.Size = new System.Drawing.Size(116, 24);
            this.plc_status_lab.TabIndex = 1;
            this.plc_status_lab.Text = "PLC状态：";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(15, 23);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(200, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "上位机系统";
            // 
            // FormTreeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1193, 897);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tree_view_manu);
            this.Name = "FormTreeView";
            this.Text = "FormTreeView";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1196, 711);
            this.Load += new System.EventHandler(this.FormTreeView_Load);
            this.tree_view_manu.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel plc_status_lab;
        private Sunny.UI.UITreeView uiTreeView1;
        private Sunny.UI.UILabel plc_open_time;
        private Sunny.UI.UIButton btn_plc;
    }

}