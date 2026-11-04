using DL_Day03_Stepper_Axis;
using Dl_FormsApp1.page;
using Dl_FormsApp1.string_demo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1.common {

    /// <summary>
    ///    页面工具类
    /// </summary>
    ///
    public static class PageUtils {

        // plc
        //public static PlcHelper plcHelper = new PlcHelper();

        // 定义页面
        public static readonly Dictionary<PageType, Form> PageTypeMap = new Dictionary<PageType, Form>()
        {
            // 步进机
            { PageType.FormAxis, new FormAxis() },
            // for循环
            { PageType.FormFor, new FormFor() },
            // 三色灯
            { PageType.LightOn, new LightOn() },
            // 登录
            { PageType.Login, new Login() },
            // 注册
            { PageType.Registr, new Registr() },


            // 课后练习作业
            { PageType.FormFormat, new FormFormat() },
            { PageType.FormArray, new FormArray() },
            { PageType.FormIPFormat, new FormIPFormat() },
            { PageType.FormString, new FormString() },
            { PageType.FormStringCommTest, new FormStringCommTest() },
            { PageType.FormTransducer, new FormTransducer() },
        };



        public static Form getFormPage(PageType pageType)
        {
            // 根据pageType来获取PageTypeMap的value
            // 判断pageType
            if (PageTypeMap.TryGetValue(pageType, out var lo))
            {
                return lo;
            }
            else
            {
                throw new Exception("页面不存在");
            }

        }

        /** panel中添加展示的页面
         * 
         * @param form  需要展示的页面
         * @param panel 存放页面的容器
         */
        public static void panellAdd(Form form, Panel panel)
        {
            //targetForm
            // 清空容器
            panel.Controls.Clear();

            // 设置窗体的填充属性 取消窗体等级 允许被添加到panell容器中
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            // 设置窗体的边框属性
            form.FormBorderStyle = FormBorderStyle.None;

            //设置窗体位置
            form.Location = new Point((panel.ClientSize.Width - form.Width) / 2, (panel.ClientSize.Height - form.Height) / 2);

            // 设置窗体展示
            form.Show();
            // 添加到容器中
            panel.Controls.Add(form);
        }

        // 根据字符串获取枚举
        public static PageType GetPageType(string pageName)
        {
            // 获取枚举 若是根据字符串获取枚举找不到对应的枚举 则返回null
            if (!Enum.IsDefined(typeof(PageType), pageName))
            {
                throw new Exception("页面不存在,请先创建");
            }
            // 获取枚举
            return (PageType)Enum.Parse(typeof(PageType), pageName);
        }
    }



}

// 页面类型枚举
public enum PageType {
    /// <summary> for循环 </summary>
    FormAxis,
    /// <summary> 步进机 </summary>
    FormFor,
    /// <summary> 三色灯 </summary>
    LightOn,
    // 登录
    Login,
    // 注册
    Registr,
    // 变频器
    FormTransducer,


    // 课后练习作业
    FormArray,
    FormFormat,
    FormIPFormat,
    FormString,
    // 通用测试窗体
    FormStringCommTest,
}