namespace Dl_FormsApp1.page {
    partial class FormTransducer {
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownHz = new System.Windows.Forms.NumericUpDown();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHz)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "设置频率";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // numericUpDownHz
            // 
            this.numericUpDownHz.Location = new System.Drawing.Point(191, 257);
            this.numericUpDownHz.Name = "numericUpDownHz";
            this.numericUpDownHz.Size = new System.Drawing.Size(257, 35);
            this.numericUpDownHz.TabIndex = 2;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(191, 207);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(163, 23);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "0^50Hz * 100";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Items.AddRange(new object[] {
            "无命令",
            "正转运行",
            "反转运行",
            "正转点动",
            "反转点动",
            "减速停机",
            "自由停机",
            "故障复位",
            "运行禁止命令",
            "运行允许命令"});
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(191, 390);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(257, 29);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 4;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "启动";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(187, 350);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(163, 23);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "请选择通讯命令";
            // 
            // FormTransducer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1009, 648);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.numericUpDownHz);
            this.Controls.Add(this.button1);
            this.Name = "FormTransducer";
            this.Text = "FormTransducer";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 1009, 648);
            this.Load += new System.EventHandler(this.FormTransducer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownHz;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private System.Windows.Forms.Button button2;
        private Sunny.UI.UILabel uiLabel2;
    }
}