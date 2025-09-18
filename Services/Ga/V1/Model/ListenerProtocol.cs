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
    /// 监听的网络传输协议类型。
    /// </summary>
    /// <value>监听的网络传输协议类型。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListenerProtocol
    {
        /// <summary>
        /// Enum TCP for value: TCP
        /// </summary>
        [EnumMember(Value = "TCP")]
        TCP = 1,

        /// <summary>
        /// Enum UDP for value: UDP
        /// </summary>
        [EnumMember(Value = "UDP")]
        UDP = 2

    }

}
