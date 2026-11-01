using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dl_FormsApp1 {


    /// <summary>
    /// 单根轴PLC地址模型，存放一根轴所有原生绝对地址字符串
    /// </summary>
    public class AxisLocation {


        /// <summary>回零启动｜W｜脉冲信号</summary>
        public string HomeStart { get; set; }
        /// <summary>回零完成｜R</summary>
        public string HomeDone { get; set; }
        /// <summary>回零错误码｜R</summary>
        public string HomeError { get; set; }

        /// <summary>绝对定位启动｜W｜脉冲信号</summary>
        public string MoveStart { get; set; }
        /// <summary>目标位置｜R/W REAL</summary>
        public string TargetPos { get; set; }
        /// <summary>目标速度｜R/W REAL</summary>
        public string TargetSpeed { get; set; }
        /// <summary>定位完成｜R</summary>
        public string MoveDone { get; set; }
        /// <summary>定位错误码｜R</summary>
        public string MoveError { get; set; }

        /// <summary>手动点动速度｜R/W REAL</summary>
        public string JogSpeed { get; set; }
        /// <summary>手动正向｜W</summary>
        public string JogPlus { get; set; }
        /// <summary>手动负向｜W</summary>
        public string JogMinus { get; set; }

        /// <summary>当前实际位置｜R REAL</summary>
        public string CurrentPos { get; set; }
        /// <summary>当前实际速度｜R REAL</summary>
        public string CurrentSpeed { get; set; }
        /// <summary>轴控制块完成｜R</summary>
        public string CtrlDone { get; set; }
        /// <summary>轴控制块错误码｜R</summary>
        public string CtrlError { get; set; }


        /// <summary>左限位｜R</summary>
        public String negLimitStatus { get; set; }

        /// <summary>右限位｜R</summary>
        public String posLimitStatus { get; set; }

        /// <summary>原点位置｜R</summary>
        public String originPos { get; set; }
    }


    /// <summary>轴1 全部PLC点位静态定义</summary>
    public static class AxisOneLocationStr {
        /// <summary>轴1地址实例对象</summary>
        public static readonly AxisLocation Instance = new AxisLocation
        {
            HomeStart = "M0.0",
            HomeDone = "M10.0",
            HomeError = "VB13",

            MoveStart = "M1.0",
            TargetPos = "VD3000",
            TargetSpeed = "VD3004",
            MoveDone = "V0.2",
            MoveError = "VB12",

            // 手动相关操作
            // 速度
            JogSpeed = "VD2108",
            // 整箱左移动
            JogPlus = "M3.0",
            // 反向右移动
            JogMinus = "M3.1",


            CurrentPos = "VD100",
            CurrentSpeed = "VD104",
            CtrlDone = "V0.0",
            CtrlError = "VB10",

            // 限位
            // 左边
            negLimitStatus = "I0.2",
            // 原点位置
            originPos = "I0.3",
            // 右边
            posLimitStatus = "I0.4"
        };
    }

    /// <summary>轴2 全部PLC点位静态定义</summary>
    public static class AxisTwoLocationStr {
        /// <summary>轴2地址实例对象</summary>
        public static readonly AxisLocation Instance = new AxisLocation
        {
            HomeStart = "M0.1",
            HomeDone = "M10.1",
            HomeError = "VB17",

            MoveStart = "M1.1",
            TargetPos = "VD3008",
            TargetSpeed = "VD3012",
            MoveDone = "V0.6",
            MoveError = "VB16",

            JogSpeed = "VD2112",
            JogPlus = "M3.4",
            JogMinus = "M3.5",

            CurrentPos = "VD108",
            CurrentSpeed = "VD112",
            CtrlDone = "V0.4",
            CtrlError = "VB14",


            // 限位
            // 左边
            negLimitStatus = "I0.5",
            // 原点位置
            originPos = "I0.6",
            // 右边
            posLimitStatus = "I0.7",
            
        };
    }
}
