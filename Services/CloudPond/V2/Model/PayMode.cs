using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 包周期付款类型 - FULL: 全预付 - HALF：半预付 - PAID_BY_YEAR：按年付费 - ZERO_PAID_BY_YEAR：零预付-按年
    /// </summary>
    /// <value>包周期付款类型 - FULL: 全预付 - HALF：半预付 - PAID_BY_YEAR：按年付费 - ZERO_PAID_BY_YEAR：零预付-按年</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayMode
    {
        /// <summary>
        /// Enum FULL for value: FULL
        /// </summary>
        [EnumMember(Value = "FULL")]
        FULL = 1,

        /// <summary>
        /// Enum HALF for value: HALF
        /// </summary>
        [EnumMember(Value = "HALF")]
        HALF = 2,

        /// <summary>
        /// Enum PAID_BY_YEAR for value: PAID_BY_YEAR
        /// </summary>
        [EnumMember(Value = "PAID_BY_YEAR")]
        PAID_BY_YEAR = 3,

        /// <summary>
        /// Enum ZERO_PAID_BY_YEAR for value: ZERO_PAID_BY_YEAR
        /// </summary>
        [EnumMember(Value = "ZERO_PAID_BY_YEAR")]
        ZERO_PAID_BY_YEAR = 4

    }

}
