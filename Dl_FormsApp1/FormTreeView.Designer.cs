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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("三色灯");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("For");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("步进器");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("登录");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("注册");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("变频器");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("基础功能", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("压力数据格式化输出");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("IP格式化");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("数组练习");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Day1102", new System.Windows.Forms.TreeNode[] {
            treeNode83,
            treeNode84,
            treeNode85});
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("字符串运用");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("通用窗体Test");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Day1103", new System.Windows.Forms.TreeNode[] {
            treeNode87,
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("课后练习", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode89});
            this.tree_view_manu = new System.Windows.Forms.Panel();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btn_plc = new Sunny.UI.UIButton();
            this.plc_open_time = new Sunny.UI.UILabel();
            this.plc_status_lab = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            treeNode76.Name = "节点1";
            treeNode76.Tag = "LightOn";
            treeNode76.Text = "三色灯";
            treeNode77.Name = "节点2";
            treeNode77.Tag = "FormFor";
            treeNode77.Text = "For";
            treeNode78.Checked = true;
            treeNode78.Name = "节点4";
            treeNode78.Tag = "FormAxis";
            treeNode78.Text = "步进器";
            treeNode79.Name = "节点0";
            treeNode79.Tag = "Login";
            treeNode79.Text = "登录";
            treeNode80.Name = "节点1";
            treeNode80.Tag = "Registr";
            treeNode80.Text = "注册";
            treeNode81.Name = "节点0";
            treeNode81.Tag = "FormTransducer";
            treeNode81.Text = "变频器";
            treeNode82.Name = "节点0";
            treeNode82.Text = "基础功能";
            treeNode83.Name = "节点1";
            treeNode83.Tag = "FormFormat";
            treeNode83.Text = "压力数据格式化输出";
            treeNode84.Name = "节点0";
            treeNode84.Tag = "FormIPFormat";
            treeNode84.Text = "IP格式化";
            treeNode85.Name = "节点1";
            treeNode85.Tag = "FormArray";
            treeNode85.Text = "数组练习";
            treeNode86.Name = "节点0";
            treeNode86.Text = "Day1102";
            treeNode87.Name = "节点2";
            treeNode87.Tag = "FormString";
            treeNode87.Text = "字符串运用";
            treeNode88.Name = "节点0";
            treeNode88.Tag = "FormStringCommTest";
            treeNode88.Text = "通用窗体Test";
            treeNode89.Name = "节点1";
            treeNode89.Text = "Day1103";
            treeNode90.Name = "节点0";
            treeNode90.Text = "课后练习";
            this.uiTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode90});
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
            this.plc_open_time.Location = new System.Drawing.Point(947, 60);
            this.plc_open_time.Name = "plc_open_time";
            this.plc_open_time.Size = new System.Drawing.Size(237, 24);
            this.plc_open_time.TabIndex = 2;
            this.plc_open_time.Text = "连接时长:";
            // 
            // plc_status_lab
            // 
            this.plc_status_lab.BackColor = System.Drawing.Color.Transparent;
            this.plc_status_lab.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plc_status_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.plc_status_lab.Location = new System.Drawing.Point(776, 60);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private Timer timer1;
        private Timer timer2;
    }

}