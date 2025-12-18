using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 功能状态。
    /// </summary>
    /// <value>功能状态。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FeatureStatus
    {
        /// <summary>
        /// Enum ON for value: on
        /// </summary>
        [EnumMember(Value = "on")]
        ON = 1,

        /// <summary>
        /// Enum OFF for value: off
        /// </summary>
        [EnumMember(Value = "off")]
        OFF = 2,

        /// <summary>
        /// Enum PENDING for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        PENDING = 3

    }

}
