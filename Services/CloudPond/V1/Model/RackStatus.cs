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
    /// 机柜状态。 - CREATING：创建中 - AVAILABLE：可用 - EXPANDING：扩容中 - PENDING_PAYMENT: 待支付
    /// </summary>
    /// <value>机柜状态。 - CREATING：创建中 - AVAILABLE：可用 - EXPANDING：扩容中 - PENDING_PAYMENT: 待支付</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RackStatus
    {
        /// <summary>
        /// Enum CREATING for value: CREATING
        /// </summary>
        [EnumMember(Value = "CREATING")]
        CREATING = 1,

        /// <summary>
        /// Enum AVAILABLE for value: AVAILABLE
        /// </summary>
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE = 2,

        /// <summary>
        /// Enum EXPANDING for value: EXPANDING
        /// </summary>
        [EnumMember(Value = "EXPANDING")]
        EXPANDING = 3,

        /// <summary>
        /// Enum PENDING_PAYMENT for value: PENDING_PAYMENT
        /// </summary>
        [EnumMember(Value = "PENDING_PAYMENT")]
        PENDING_PAYMENT = 4

    }

}
