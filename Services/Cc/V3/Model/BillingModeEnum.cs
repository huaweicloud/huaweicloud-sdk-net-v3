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
    /// 带宽包实例在大陆站或国际站的计费方式。 1：大陆站包周期。 2：国际站包周期。 3：大陆站按需计费。 4：国际站按需计费。 5：大陆站按95方式计费。 6：国际站按95方式计费。
    /// </summary>
    /// <value>带宽包实例在大陆站或国际站的计费方式。 1：大陆站包周期。 2：国际站包周期。 3：大陆站按需计费。 4：国际站按需计费。 5：大陆站按95方式计费。 6：国际站按95方式计费。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BillingModeEnum
    {
        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 2,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        NUMBER_3 = 3,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        [EnumMember(Value = "4")]
        NUMBER_4 = 4,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        [EnumMember(Value = "5")]
        NUMBER_5 = 5,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        [EnumMember(Value = "6")]
        NUMBER_6 = 6

    }

}
