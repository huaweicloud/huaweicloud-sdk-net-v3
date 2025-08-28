using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 跨地域类型。 - intra-region （同地域） - inter-region （跨地域）
    /// </summary>
    /// <value>跨地域类型。 - intra-region （同地域） - inter-region （跨地域）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CrossRegionTypeEnum
    {
        /// <summary>
        /// Enum INTRA_REGION for value: intra-region
        /// </summary>
        [EnumMember(Value = "intra-region")]
        INTRA_REGION = 1,

        /// <summary>
        /// Enum INTER_REGION for value: inter-region
        /// </summary>
        [EnumMember(Value = "inter-region")]
        INTER_REGION = 2

    }

}
