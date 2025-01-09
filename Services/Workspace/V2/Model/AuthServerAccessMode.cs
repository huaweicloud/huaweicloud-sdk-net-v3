using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 辅助认证服务接入模式 INTERNET：互联网接入 DEDICATED：专线接入 SYSTEM_DEFAULT：系统默认
    /// </summary>
    /// <value>辅助认证服务接入模式 INTERNET：互联网接入 DEDICATED：专线接入 SYSTEM_DEFAULT：系统默认</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AuthServerAccessMode
    {
        /// <summary>
        /// Enum INTERNET for value: INTERNET
        /// </summary>
        [EnumMember(Value = "INTERNET")]
        INTERNET = 1,

        /// <summary>
        /// Enum DEDICATED for value: DEDICATED
        /// </summary>
        [EnumMember(Value = "DEDICATED")]
        DEDICATED = 2,

        /// <summary>
        /// Enum SYSTEM_DEFAULT for value: SYSTEM_DEFAULT
        /// </summary>
        [EnumMember(Value = "SYSTEM_DEFAULT")]
        SYSTEM_DEFAULT = 3

    }

}
