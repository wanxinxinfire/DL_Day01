using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dl_FormsApp1.common {
    public static class TransducerPools {

        // <summary>
        /// 通讯命令
        /// </summary>
        public const string SendRequet = "M7.0";
        public const string SendHZ = "VW2500";
        public const string SendStatus = "VW2502";


        #region Register Address
        /// <summary>
        /// Communication command setting register address 0x2001
        /// </summary>
        public const ushort CommandRegAddr_0x2001 = 0x2001;

        /// <summary>
        /// Communication command setting register address 0x3001
        /// </summary>
        public const ushort CommandRegAddr_0x3001 = 0x3001;
        #endregion

        #region Command Value
        /// <summary>
        /// No operation command
        /// </summary>
        public const ushort Cmd_None = 0x0000;

        /// <summary>
        /// Forward run command
        /// </summary>
        public const ushort Cmd_ForwardRun = 0x0001;

        /// <summary>
        /// Reverse run command
        /// </summary>
        public const ushort Cmd_ReverseRun = 0x0002;

        /// <summary>
        /// Forward jog command
        /// </summary>
        public const ushort Cmd_ForwardJog = 0x0003;

        /// <summary>
        /// Reverse jog command
        /// </summary>
        public const ushort Cmd_ReverseJog = 0x0004;

        /// <summary>
        /// Decelerate to stop
        /// </summary>
        public const ushort Cmd_StopDec = 0x0005;

        /// <summary>
        /// Coast to stop
        /// </summary>
        public const ushort Cmd_StopFree = 0x0006;

        /// <summary>
        /// Fault reset command
        /// </summary>
        public const ushort Cmd_FaultReset = 0x0007;

        /// <summary>
        /// Disable run permission
        /// </summary>
        public const ushort Cmd_RunDisable = 0x0008;

        /// <summary>
        /// Enable run permission
        /// </summary>
        public const ushort Cmd_RunEnable = 0x0009;
        #endregion

        // 中文-值映射字典（和表格严格对应）
        private static readonly Dictionary<string, ushort> _cmdDic = new Dictionary<string, ushort>()
    {
        {"无命令", Cmd_None},
        {"正转运行", Cmd_ForwardRun},
        {"反转运行", Cmd_ReverseRun},
        {"正转点动", Cmd_ForwardJog},
        {"反转点动", Cmd_ReverseJog},
        {"减速停机", Cmd_StopDec},
        {"自由停机", Cmd_StopFree},
        {"故障复位", Cmd_FaultReset},
        {"运行禁止命令", Cmd_RunDisable},
        {"运行允许命令", Cmd_RunEnable}
    };

        /// <summary>
        /// 根据中文名称获取命令值
        /// </summary>
        /// <param name="cnName">中文命令名称</param>
        /// <returns>成功返回ushort，不存在返回null</returns>
        public static short? GetCmdValueByCnName(string cnName)
        {
            if (string.IsNullOrWhiteSpace(cnName))
                return null;

            if (_cmdDic.TryGetValue(cnName, out var val))
            {
                return (short)val;
            }
            return null;
        }

        /// <summary>
        /// 获取全部中文命令列表（用于下拉绑定）
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllCnNameList()
        {
            return _cmdDic.Keys.ToList();
        }
    }
}
