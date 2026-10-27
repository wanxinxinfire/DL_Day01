using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_Day01 {

    #region
    internal class Program {

        static void Main(string[] args)
        {
            //InOut();
            //Console.WriteLine(Student.GetInfo());


            // 计算代码
            Console.WriteLine(Calculator.Add(10, 20));
            Console.WriteLine(Calculator.Sub(10, 20));
            Console.WriteLine(Calculator.Mul(10, 20));
            Console.WriteLine(Calculator.Div(10, 20));

        }

        // 封装输入输出方法
        private static void InOut()
        {
            // 设置窗口背景颜色为黄色
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("请输入名称");
            string name = Console.ReadLine();
            Console.WriteLine("您的名称为:{0}", name);


            Console.WriteLine("请输入您的年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("您的年龄为:{0}", age);

            Console.WriteLine("请输入您的身高");
            string height = Console.ReadLine();
            Console.WriteLine("您的身高为:{0}", height);
        }
    }
    #endregion

}
