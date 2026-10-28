using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_Day01 {
    public static class BasicGrammar {

        

        // 设置一个可空的变量int类型
        public static void Nullable()
        {
            int? a = null;
            //这里的 int? 是 Nullable<int> 的语法糖（简写形式），两者完全等价：
            Nullable<int> i = new Nullable<int>();
            Console.WriteLine(a);
            Console.WriteLine(i);

            int result = i ?? 1;
            Console.WriteLine(result);


            int? b = 0;
            Console.WriteLine(b);
            // 打印当前的注释
            Console.WriteLine("显式构造，默认为 null");
            // 显式构造，（）内为空默认为 null
            bool? isActive = new bool?(true);
            Console.WriteLine(isActive);
            Console.WriteLine("打印时间");
            DateTime? birthday = null;
            birthday = new DateTime?();
            Console.WriteLine(birthday);

            Console.WriteLine("---测试---");
            int? c = null;
            Console.WriteLine(c.GetValueOrDefault(10));

            // 使用 ?. 运算符安全访问可能为 null 的对象
            // 定义String类型的 user address city name;
            string user = null;
            string address = null;

            // 打印当前时间
            Console.WriteLine(DateTime.Now);

        }

    }
}
