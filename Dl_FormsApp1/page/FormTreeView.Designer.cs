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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("三色灯");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("For");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("步进器");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("基础功能", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.tree_view_manu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTreeView1 = new Sunny.UI.UITreeView();
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
            this.tree_view_manu.Size = new System.Drawing.Size(240, 759);
            this.tree_view_manu.TabIndex = 0;
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
            this.uiPanel1.Controls.Add(this.uiLabel2);
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
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(543, 11);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(116, 24);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "PLC状态：";
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
            // uiTreeView1
            // 
            this.uiTreeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTreeView1.FillColor = System.Drawing.Color.White;
            this.uiTreeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTreeView1.Location = new System.Drawing.Point(0, 0);
            this.uiTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTreeView1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTreeView1.Name = "uiTreeView1";
            treeNode5.Name = "节点1";
            treeNode5.Tag = "LightOn";
            treeNode5.Text = "三色灯";
            treeNode6.Name = "节点2";
            treeNode6.Tag = "FormFor";
            treeNode6.Text = "For";
            treeNode7.Name = "节点4";
            treeNode7.Tag = "Axis";
            treeNode7.Text = "步进器";
            treeNode8.Name = "节点0";
            treeNode8.Text = "基础功能";
            this.uiTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.uiTreeView1.ScrollBarStyleInherited = false;
            this.uiTreeView1.ShowText = false;
            this.uiTreeView1.Size = new System.Drawing.Size(250, 731);
            this.uiTreeView1.TabIndex = 1;
            this.uiTreeView1.Text = "uiTreeView1";
            this.uiTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.uiTreeView1_AfterSelect);
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
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITreeView uiTreeView1;
    }

}