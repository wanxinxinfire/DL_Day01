namespace PLC_demo {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btl_open = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btl_open
            // 
            this.btl_open.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btl_open.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btl_open.Location = new System.Drawing.Point(117, 61);
            this.btl_open.Name = "btl_open";
            this.btl_open.Size = new System.Drawing.Size(131, 70);
            this.btl_open.TabIndex = 0;
            this.btl_open.Text = "PLC连接";
            this.btl_open.UseVisualStyleBackColor = false;
            this.btl_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "PLC关闭";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 726);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btl_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btl_open;
        private System.Windows.Forms.Button button2;
    }
}

