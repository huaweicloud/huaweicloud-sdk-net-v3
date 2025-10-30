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
    /// - PENDING_PAYMENT：待支付 - DELIVERING：交付中 - USING：使用中
    /// </summary>
    /// <value>- PENDING_PAYMENT：待支付 - DELIVERING：交付中 - USING：使用中</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum NetworkDeviceStatus
    {
        /// <summary>
        /// Enum PENDING_PAYMENT for value: PENDING_PAYMENT
        /// </summary>
        [EnumMember(Value = "PENDING_PAYMENT")]
        PENDING_PAYMENT = 1,

        /// <summary>
        /// Enum DELIVERING for value: DELIVERING
        /// </summary>
        [EnumMember(Value = "DELIVERING")]
        DELIVERING = 2,

        /// <summary>
        /// Enum USING for value: USING
        /// </summary>
        [EnumMember(Value = "USING")]
        USING = 3

    }

}
