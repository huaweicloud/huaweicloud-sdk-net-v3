using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 包周期付款类型 - FULL: 全预付 - HALF：半预付
    /// </summary>
    /// <value>包周期付款类型 - FULL: 全预付 - HALF：半预付</value>
    
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
        HALF = 2

    }

}
