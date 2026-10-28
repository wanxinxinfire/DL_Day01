using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL_Day01 {
    static public class EnumExtension {

        /// <summary>
        /// 获取枚举上Description字符串
        /// </summary>
        public static string GetPlcAddress(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attrs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (attrs != null && attrs.Length > 0)
            {
                return attrs[0].Description;
            }
            return "";
        }
    }
}
