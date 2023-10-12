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
    /// 告警条件判断周期，单位为秒，支持的值为1，300，1200，3600，14400，86400。说明：当period设置为1时，表示以原始的指标数据判断告警。当alarm_type为（EVENT.SYS| EVENT.CUSTOM）时允许为0。
    /// </summary>
    /// <value>告警条件判断周期，单位为秒，支持的值为1，300，1200，3600，14400，86400。说明：当period设置为1时，表示以原始的指标数据判断告警。当alarm_type为（EVENT.SYS| EVENT.CUSTOM）时允许为0。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Period
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,

        /// <summary>
        /// Enum NUMBER_300 for value: 300
        /// </summary>
        [EnumMember(Value = "300")]
        NUMBER_300 = 3,

        /// <summary>
        /// Enum NUMBER_1200 for value: 1200
        /// </summary>
        [EnumMember(Value = "1200")]
        NUMBER_1200 = 4,

        /// <summary>
        /// Enum NUMBER_3600 for value: 3600
        /// </summary>
        [EnumMember(Value = "3600")]
        NUMBER_3600 = 5,

        /// <summary>
        /// Enum NUMBER_14400 for value: 14400
        /// </summary>
        [EnumMember(Value = "14400")]
        NUMBER_14400 = 6,

        /// <summary>
        /// Enum NUMBER_86400 for value: 86400
        /// </summary>
        [EnumMember(Value = "86400")]
        NUMBER_86400 = 7

    }

}
