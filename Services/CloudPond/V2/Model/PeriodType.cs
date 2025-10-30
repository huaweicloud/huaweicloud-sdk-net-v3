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
    /// 包周期类型 - year：包年
    /// </summary>
    /// <value>包周期类型 - year：包年</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PeriodType
    {
        /// <summary>
        /// Enum YEAR for value: year
        /// </summary>
        [EnumMember(Value = "year")]
        YEAR = 1

    }

}
