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
    /// 终端节点类型。
    /// </summary>
    /// <value>终端节点类型。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EndpointType
    {
        /// <summary>
        /// Enum EIP for value: EIP
        /// </summary>
        [EnumMember(Value = "EIP")]
        EIP = 1

    }

}
