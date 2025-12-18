using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 身份策略类型，可以为“自定义”（custom）或“系统预置”（system）。
    /// </summary>
    /// <value>身份策略类型，可以为“自定义”（custom）或“系统预置”（system）。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PolicyType
    {
        /// <summary>
        /// Enum CUSTOM for value: custom
        /// </summary>
        [EnumMember(Value = "custom")]
        CUSTOM = 1,

        /// <summary>
        /// Enum SYSTEM for value: system
        /// </summary>
        [EnumMember(Value = "system")]
        SYSTEM = 2

    }

}
