using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// **参数解释**： 数据聚合的方式。 **取值范围**： 支持 average、variance、min、max、sum。 - average： 平均值 - variance：方差 - min：最小值 - max：最大值 - sum：求和 
    /// </summary>
    /// <value>**参数解释**： 数据聚合的方式。 **取值范围**： 支持 average、variance、min、max、sum。 - average： 平均值 - variance：方差 - min：最小值 - max：最大值 - sum：求和 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FilterResp
    {
        /// <summary>
        /// Enum AVERAGE for value: average
        /// </summary>
        [EnumMember(Value = "average")]
        AVERAGE = 1,

        /// <summary>
        /// Enum VARIANCE for value: variance
        /// </summary>
        [EnumMember(Value = "variance")]
        VARIANCE = 2,

        /// <summary>
        /// Enum MIN for value: min
        /// </summary>
        [EnumMember(Value = "min")]
        MIN = 3,

        /// <summary>
        /// Enum MAX for value: max
        /// </summary>
        [EnumMember(Value = "max")]
        MAX = 4,

        /// <summary>
        /// Enum SUM for value: sum
        /// </summary>
        [EnumMember(Value = "sum")]
        SUM = 5

    }

}
