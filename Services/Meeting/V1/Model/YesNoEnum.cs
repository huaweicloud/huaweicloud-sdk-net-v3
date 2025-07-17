using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 是、否 通用枚举
    /// </summary>
    /// <value>是、否 通用枚举</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum YesNoEnum
    {
        /// <summary>
        /// Enum Y for value: Y
        /// </summary>
        [EnumMember(Value = "Y")]
        Y = 1,

        /// <summary>
        /// Enum N for value: N
        /// </summary>
        [EnumMember(Value = "N")]
        N = 2

    }

}
