using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_Day01 {

    // 计算工具类
    public class Calculator {


        // 两数相加
        public static double Add(double a, double b) {

            Console.WriteLine($"{a} * {b}");
               return a + b;
        }

        // 两数相减

        public static double Sub(double a, double b)
        {
            return a - b;
        }
        // 两数相乘

        public static double Mul(double a, double b)
        {
            return a * b;
        }
        // 两数相除
        public static double Div(double a, double b)
        {
            return a / b;
        }
    }
}
