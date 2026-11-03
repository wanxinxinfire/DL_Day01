using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1.page {
    public partial class Registr : Form {
        public Registr()
        {
            InitializeComponent();
        }

        // 跳转登录页面
        private void button2_Click(object sender, EventArgs e)
        {
            // 创建登录窗体
            Login home = new Login();
            // 添加窗体
            home.Show();
        }


        // 注册用户事件 提交注册信息
        private void button1_Click(object sender, EventArgs e)
        {
            // 
        }
    }
}
