using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 状态(允许、禁用)： * &#x60;Allow&#x60; - 允许 * &#x60;Deny&#x60; - 禁用
    /// </summary>
    /// <value>状态(允许、禁用)： * &#x60;Allow&#x60; - 允许 * &#x60;Deny&#x60; - 禁用</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PolicyEffectEnum
    {
        /// <summary>
        /// Enum ALLOW for value: Allow
        /// </summary>
        [EnumMember(Value = "Allow")]
        ALLOW = 1,

        /// <summary>
        /// Enum DENY for value: Deny
        /// </summary>
        [EnumMember(Value = "Deny")]
        DENY = 2

    }

}
