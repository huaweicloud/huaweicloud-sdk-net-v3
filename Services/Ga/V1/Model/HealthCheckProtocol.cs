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
    /// 健康检查的协议。
    /// </summary>
    /// <value>健康检查的协议。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum HealthCheckProtocol
    {
        /// <summary>
        /// Enum TCP for value: TCP
        /// </summary>
        [EnumMember(Value = "TCP")]
        TCP = 1

    }

}
