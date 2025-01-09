using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 平台类型： * &#x60;AD&#x60; - AD域 * &#x60;LOCAL&#x60; - LiteAs
    /// </summary>
    /// <value>平台类型： * &#x60;AD&#x60; - AD域 * &#x60;LOCAL&#x60; - LiteAs</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PlatformTypeEnum
    {
        /// <summary>
        /// Enum AD for value: AD
        /// </summary>
        [EnumMember(Value = "AD")]
        AD = 1,

        /// <summary>
        /// Enum LOCAL for value: LOCAL
        /// </summary>
        [EnumMember(Value = "LOCAL")]
        LOCAL = 2

    }

}
