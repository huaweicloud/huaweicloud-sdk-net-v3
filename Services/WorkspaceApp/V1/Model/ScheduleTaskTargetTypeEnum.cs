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
    /// 定时任务对象类型： * &#x60;SERVER&#x60; - 服务器 * &#x60;SERVER_GROUP&#x60; - 服务器组
    /// </summary>
    /// <value>定时任务对象类型： * &#x60;SERVER&#x60; - 服务器 * &#x60;SERVER_GROUP&#x60; - 服务器组</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScheduleTaskTargetTypeEnum
    {
        /// <summary>
        /// Enum SERVER for value: SERVER
        /// </summary>
        [EnumMember(Value = "SERVER")]
        SERVER = 1,

        /// <summary>
        /// Enum SERVER_GROUP for value: SERVER_GROUP
        /// </summary>
        [EnumMember(Value = "SERVER_GROUP")]
        SERVER_GROUP = 2

    }

}
