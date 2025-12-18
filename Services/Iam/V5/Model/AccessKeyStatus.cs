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
    /// 访问密钥状态，可以为“启用”（active）或“停用”（inactive）。
    /// </summary>
    /// <value>访问密钥状态，可以为“启用”（active）或“停用”（inactive）。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccessKeyStatus
    {
        /// <summary>
        /// Enum ACTIVE for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        ACTIVE = 1,

        /// <summary>
        /// Enum INACTIVE for value: inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        INACTIVE = 2

    }

}
