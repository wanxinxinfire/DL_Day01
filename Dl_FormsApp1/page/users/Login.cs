using Dl_FormsApp1.page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {
    public partial class Login : Form {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // 定义接受 用户账号和密码
        string account = "admin";
        String password = "admin123";
        private void button1_Click(object sender, EventArgs e)
        {
            // 校验账号密码不为空并且用户账号和密码相同
            if (string.IsNullOrEmpty(txt_account.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("账户或密码不能为空", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            
            // 校验账号密码是否一致
            if (!string.Equals(txt_account.Text, account) || !string.Equals(txt_password.Text, password))
            {
                MessageBox.Show("账户或密码错误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("登录成","提示", MessageBoxButtons.OK);
            // 弹窗home
            LightOn home = new LightOn();
            this.Hide();
            home.Show();
            
        }



        // 去注册
        private void btn_go_register_Click(object sender, EventArgs e)
        {
            // 去注册页面
            Registr registr = new Registr();
            registr.Show();
            this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
