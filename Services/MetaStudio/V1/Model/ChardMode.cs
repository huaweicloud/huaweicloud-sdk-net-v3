using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 资源计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性计费 &gt; * 一次性计费包括：租户订购的一次性资源，SP管理员分配给租户的一次性资源。
    /// </summary>
    /// <value>资源计费类型。 * PERIODIC: 包周期 * ONE_TIME：一次性计费 &gt; * 一次性计费包括：租户订购的一次性资源，SP管理员分配给租户的一次性资源。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChardMode
    {
        /// <summary>
        /// Enum PERIODIC for value: PERIODIC
        /// </summary>
        [EnumMember(Value = "PERIODIC")]
        PERIODIC = 1,

        /// <summary>
        /// Enum ONE_TIME for value: ONE_TIME
        /// </summary>
        [EnumMember(Value = "ONE_TIME")]
        ONE_TIME = 2

    }

}
