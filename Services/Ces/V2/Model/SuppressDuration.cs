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
    /// 告警抑制周期，值可为0, 300, 600, 900, 1800, 3600, 10800, 21600, 43200, 86400；单位为秒，0表示只告警一次
    /// </summary>
    /// <value>告警抑制周期，值可为0, 300, 600, 900, 1800, 3600, 10800, 21600, 43200, 86400；单位为秒，0表示只告警一次</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SuppressDuration
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_300 for value: 300
        /// </summary>
        [EnumMember(Value = "300")]
        NUMBER_300 = 2,

        /// <summary>
        /// Enum NUMBER_600 for value: 600
        /// </summary>
        [EnumMember(Value = "600")]
        NUMBER_600 = 3,

        /// <summary>
        /// Enum NUMBER_900 for value: 900
        /// </summary>
        [EnumMember(Value = "900")]
        NUMBER_900 = 4,

        /// <summary>
        /// Enum NUMBER_1800 for value: 1800
        /// </summary>
        [EnumMember(Value = "1800")]
        NUMBER_1800 = 5,

        /// <summary>
        /// Enum NUMBER_3600 for value: 3600
        /// </summary>
        [EnumMember(Value = "3600")]
        NUMBER_3600 = 6,

        /// <summary>
        /// Enum NUMBER_10800 for value: 10800
        /// </summary>
        [EnumMember(Value = "10800")]
        NUMBER_10800 = 7,

        /// <summary>
        /// Enum NUMBER_21600 for value: 21600
        /// </summary>
        [EnumMember(Value = "21600")]
        NUMBER_21600 = 8,

        /// <summary>
        /// Enum NUMBER_43200 for value: 43200
        /// </summary>
        [EnumMember(Value = "43200")]
        NUMBER_43200 = 9,

        /// <summary>
        /// Enum NUMBER_86400 for value: 86400
        /// </summary>
        [EnumMember(Value = "86400")]
        NUMBER_86400 = 10

    }

}
