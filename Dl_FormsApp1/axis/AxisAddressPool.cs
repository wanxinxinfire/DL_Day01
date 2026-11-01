using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dl_FormsApp1 {
    internal class AxisAddressPool {

        // 映射：轴号 → 对应的轴地址实例，一次性注册
        private static readonly Dictionary<int, AxisLocation> _axisDict = new Dictionary<int, AxisLocation>
    {
        { 1, AxisOneLocationStr.Instance },
        { 2, AxisTwoLocationStr.Instance }
    };

        /// <summary>
        /// 根据轴号获取轴地址对象
        /// </summary>
        /// <param name="axisNo">选中的轴编号</param>
        /// <returns>AxisLocation地址对象</returns>
        /// <exception cref="KeyNotFoundException">轴不存在抛出</exception>
        public static AxisLocation Get(int axisNo)
        {
            if (_axisDict.TryGetValue(axisNo, out var loc))
            {
                return loc;
            }
            throw new KeyNotFoundException($"不存在轴号：{axisNo}");
        }

    }
}
