using DL_Day01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            // 创建登录窗体
            Login login = new Login();
            panellAdd(login);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 创建登录窗体
            LightOn home = new LightOn();
            panellAdd(home);
        }

        private void panellAdd(Form form)
        {
            // 清空容器
            panel1.Controls.Clear();

            // 设置窗体的填充属性 取消窗体等级 允许被添加到panell容器中
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            // 设置窗体的边框属性
            form.FormBorderStyle = FormBorderStyle.None;

            //设置窗体位置
            form.Location = new Point((panel1.ClientSize.Width - form.Width) / 2, (panel1.ClientSize.Height - form.Height) / 2);

            // 设置窗体展示
            form.Show();
            // 添加到容器中
            panel1.Controls.Add(form);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 创建窗体
            FormFor formFor = new FormFor();
            panellAdd(formFor);
        }
    }
}
