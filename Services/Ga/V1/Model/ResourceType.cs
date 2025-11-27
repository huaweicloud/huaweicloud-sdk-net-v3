using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 资源类型，取值范围： - ga-accelerators：加速实例 - ga-listeners：监听器
    /// </summary>
    /// <value>资源类型，取值范围： - ga-accelerators：加速实例 - ga-listeners：监听器</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ResourceType
    {
        /// <summary>
        /// Enum GA_ACCELERATORS for value: ga-accelerators
        /// </summary>
        [EnumMember(Value = "ga-accelerators")]
        GA_ACCELERATORS = 1,

        /// <summary>
        /// Enum GA_LISTENERS for value: ga-listeners
        /// </summary>
        [EnumMember(Value = "ga-listeners")]
        GA_LISTENERS = 2

    }

}
