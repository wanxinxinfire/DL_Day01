using Dl_FormsApp1.light;
using Dl_FormsApp1.page;
using Dl_FormsApp1.string_demo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dl_FormsApp1 {
    internal static class Program {

        //全局公共对象
        

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTreeView());
        }
    }
}
