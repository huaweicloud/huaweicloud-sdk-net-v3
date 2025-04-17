using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 聚合规则，last:最新值,max:最大值,min:最小值,average:平均值,sum:求和值
    /// </summary>
    /// <value>聚合规则，last:最新值,max:最大值,min:最小值,average:平均值,sum:求和值</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RollupFilter
    {
        /// <summary>
        /// Enum LAST for value: last
        /// </summary>
        [EnumMember(Value = "last")]
        LAST = 1,

        /// <summary>
        /// Enum MAX for value: max
        /// </summary>
        [EnumMember(Value = "max")]
        MAX = 2,

        /// <summary>
        /// Enum MIN for value: min
        /// </summary>
        [EnumMember(Value = "min")]
        MIN = 3,

        /// <summary>
        /// Enum AVERAGE for value: average
        /// </summary>
        [EnumMember(Value = "average")]
        AVERAGE = 4,

        /// <summary>
        /// Enum SUM for value: sum
        /// </summary>
        [EnumMember(Value = "sum")]
        SUM = 5

    }

}
