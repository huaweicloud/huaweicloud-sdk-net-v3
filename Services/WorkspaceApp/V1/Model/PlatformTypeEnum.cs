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
    /// 平台类型： * &#x60;AD&#x60; - AD域 * &#x60;LOCAL&#x60; - LiteAs * &#x60;SYSTEM&#x60; - 系统内置
    /// </summary>
    /// <value>平台类型： * &#x60;AD&#x60; - AD域 * &#x60;LOCAL&#x60; - LiteAs * &#x60;SYSTEM&#x60; - 系统内置</value>
    
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
        LOCAL = 2,

        /// <summary>
        /// Enum SYSTEM for value: SYSTEM
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        SYSTEM = 3

    }

}
