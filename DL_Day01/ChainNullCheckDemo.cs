using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 链式空条件运算符 ?. 演示类
/// 演示：user?.Address?.City?.Name
/// </summary>
namespace DL_Day01 {
     class ChainNullCheckDemo {

        public static void Main(string[] args) {
            Console.WriteLine("===== 链式空值检查 ?. 测试 =====");

            // 情况1：user 为 null
            User user = null;
            string cityName = user?.Address?.City?.Name;
            Console.WriteLine($"case1 user=null：结果={cityName ?? "null"}");

            // 情况2：user 有值，Address=null
            user = new User();
            user.Address = null;
            cityName = user?.Address?.City?.Name;
            Console.WriteLine($"case2 Address=null：结果={cityName ?? "null"}");

            // 情况3：Address有值，City=null
            user.Address = new Address();
            user.Address.City = null;
            cityName = user?.Address?.City?.Name;
            Console.WriteLine($"case3 City=null：结果={cityName ?? "null"}");

            // 情况4：整条链路对象都不为空
            user.Address.City = new City { Name = "苏州市" };
            cityName = user?.Address?.City?.Name;
            Console.WriteLine($"case4 全部不为空：结果={cityName ?? "null"}");
        }

    }

    class User {
        public Address Address { get; set; }
    }

    class Address {
        public City City { get; set; }
    }

    class City {
        public string Name { get; set; }
    }
}
