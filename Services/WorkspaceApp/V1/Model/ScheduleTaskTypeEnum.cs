using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 定时任务类型： * &#x60;RESTART_SERVER&#x60; - 定时重启服务器 * &#x60;START_SERVER&#x60; - 定时开机 * &#x60;STOP_SERVER&#x60; - 定时关机 * &#x60;REINSTALL_OS&#x60; - 定时重装操作系统
    /// </summary>
    /// <value>定时任务类型： * &#x60;RESTART_SERVER&#x60; - 定时重启服务器 * &#x60;START_SERVER&#x60; - 定时开机 * &#x60;STOP_SERVER&#x60; - 定时关机 * &#x60;REINSTALL_OS&#x60; - 定时重装操作系统</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScheduleTaskTypeEnum
    {
        /// <summary>
        /// Enum RESTART_SERVER for value: RESTART_SERVER
        /// </summary>
        [EnumMember(Value = "RESTART_SERVER")]
        RESTART_SERVER = 1,

        /// <summary>
        /// Enum START_SERVER for value: START_SERVER
        /// </summary>
        [EnumMember(Value = "START_SERVER")]
        START_SERVER = 2,

        /// <summary>
        /// Enum STOP_SERVER for value: STOP_SERVER
        /// </summary>
        [EnumMember(Value = "STOP_SERVER")]
        STOP_SERVER = 3,

        /// <summary>
        /// Enum REINSTALL_OS for value: REINSTALL_OS
        /// </summary>
        [EnumMember(Value = "REINSTALL_OS")]
        REINSTALL_OS = 4

    }

}
