using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dl_FormsApp1.common;

namespace Dl_FormsApp1.page {
    public partial class FormTreeView : UIForm {
        public FormTreeView()
        {
            InitializeComponent();
        }
        // 页面加载事件
        private void FormTreeView_Load(object sender, EventArgs e)
        {
            // 隐藏 树子节点
            //panel2.Visible = false;
            //panel3.Visible = false;
        }
        #region 菜单按钮展示下级菜单
        //  基础菜单
        private void button1_Click(object sender, EventArgs e)
        {
            // 显示 树子节点
            //panel2.Visible = !panel2.Visible;
        }
        #endregion

        #region 菜单跳转公共事件

        private void page_show_panel(object sender, EventArgs e)
        {

        }



        #endregion

        // 点击实现菜单跳转
        private void uiTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UITreeView treeView = sender as UITreeView;
            // 获取当前选中的节点
            TreeNode node = treeView.SelectedNode;
            if (node.Tag != null && node.Tag.ToString() != "")
            {
                // 获取当前节点的Tag
                string formName = node.Tag.ToString();
                // 跳转页面
                try
                {
                    PageType pageType = PageUtils.GetPageType(formName);
                    Form form = PageUtils.getFormPage(pageType);
                    // 添加页面
                    PageUtils.panellAdd(form, panel1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
    }
}
