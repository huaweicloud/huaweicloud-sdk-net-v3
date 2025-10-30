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
    /// 计费模式。 - prepaid：包周期
    /// </summary>
    /// <value>计费模式。 - prepaid：包周期</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChargeMode
    {
        /// <summary>
        /// Enum PREPAID for value: prepaid
        /// </summary>
        [EnumMember(Value = "prepaid")]
        PREPAID = 1

    }

}
