using System.Drawing;
using System.Windows.Forms;
using HslCommunication.Profinet.Siemens;

namespace Dl_FormsApp1.light {
    partial class FormLight {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnAllOff;
        private System.Windows.Forms.Label lblState;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConn = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnAllOff = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "三色灯控制";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(14, 62);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(157, 28);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "192.168.0.2";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(180, 62);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(99, 31);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // lblConn
            // 
            this.lblConn.Location = new System.Drawing.Point(290, 67);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(135, 24);
            this.lblConn.TabIndex = 3;
            this.lblConn.Text = "未连接";
            this.lblConn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(14, 132);
            this.btnRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(124, 48);
            this.btnRed.TabIndex = 4;
            this.btnRed.Tag = "Q0.4";
            this.btnRed.Text = "红灯";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(151, 132);
            this.btnGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(124, 48);
            this.btnGreen.TabIndex = 5;
            this.btnGreen.Tag = "Q0.5";
            this.btnGreen.Text = "绿灯";
            this.btnGreen.UseVisualStyleBackColor = true;
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(288, 132);
            this.btnYellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(124, 48);
            this.btnYellow.TabIndex = 6;
            this.btnYellow.Tag = "Q1.1";
            this.btnYellow.Text = "黄灯";
            this.btnYellow.UseVisualStyleBackColor = true;
            // 
            // btnAllOff
            // 
            this.btnAllOff.Location = new System.Drawing.Point(14, 194);
            this.btnAllOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllOff.Name = "btnAllOff";
            this.btnAllOff.Size = new System.Drawing.Size(124, 48);
            this.btnAllOff.TabIndex = 7;
            this.btnAllOff.Text = "全部熄灭";
            this.btnAllOff.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(151, 206);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(270, 24);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "状态：全灭";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "灯亮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "灯灭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "设置灯地址";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Q0.4",
            "Q0.5",
            "Q1.1"});
            this.comboBox1.Location = new System.Drawing.Point(640, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 12;
            // 
            // FormLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(810, 288);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnAllOff);
            this.Controls.Add(this.lblState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三色灯控制";
            this.Load += new System.EventHandler(this.FormLight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
    }

}