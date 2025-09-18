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
    /// 客户端亲和性，取值： - SOURCE_IP：按源IP保持会话。 - NONE：关闭。
    /// </summary>
    /// <value>客户端亲和性，取值： - SOURCE_IP：按源IP保持会话。 - NONE：关闭。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ClientAffinity
    {
        /// <summary>
        /// Enum SOURCE_IP for value: SOURCE_IP
        /// </summary>
        [EnumMember(Value = "SOURCE_IP")]
        SOURCE_IP = 1,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 2

    }

}
