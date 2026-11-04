namespace Dl_FormsApp1.string_demo {
    partial class FormStringCommTest {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboxCheckType = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(37, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "字符串测试";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(41, 114);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(544, 35);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "在这里输入";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(831, 111);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(148, 37);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "执行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(125, 210);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(142, 24);
            this.lblOut.TabIndex = 3;
            this.lblOut.Text = "等待输入...";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(831, 197);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(148, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(41, 237);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(743, 451);
            this.txtOut.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "结果：";
            // 
            // comboxCheckType
            // 
            this.comboxCheckType.DataSource = null;
            this.comboxCheckType.FillColor = System.Drawing.Color.White;
            this.comboxCheckType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboxCheckType.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboxCheckType.Items.AddRange(new object[] {
            "连 PLC：拆开 IP 和端口",
            "三色灯：把点位洗干净",
            "变频器：解析一行指令",
            "步进轴：条码末两位是位置",
            "定位日志：别用 += 拼字符串"});
            this.comboxCheckType.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboxCheckType.Location = new System.Drawing.Point(593, 112);
            this.comboxCheckType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboxCheckType.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboxCheckType.Name = "comboxCheckType";
            this.comboxCheckType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboxCheckType.Size = new System.Drawing.Size(206, 38);
            this.comboxCheckType.SymbolSize = 24;
            this.comboxCheckType.TabIndex = 7;
            this.comboxCheckType.Text = "请选择检查方式";
            this.comboxCheckType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboxCheckType.Watermark = "";
            this.comboxCheckType.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // FormStringCommTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 746);
            this.Controls.Add(this.comboxCheckType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormStringCommTest";
            this.Text = "FormStringCommTest";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1142, 746);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIComboBox comboxCheckType;
    }
}