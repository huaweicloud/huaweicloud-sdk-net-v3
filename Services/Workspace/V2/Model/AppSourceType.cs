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
    /// 应用来源： * &#x60;CUSTOM&#x60; - 用户上传 * &#x60;SYSTEM&#x60; - 内置应用 * &#x60;MARKET&#x60; - 市场应用
    /// </summary>
    /// <value>应用来源： * &#x60;CUSTOM&#x60; - 用户上传 * &#x60;SYSTEM&#x60; - 内置应用 * &#x60;MARKET&#x60; - 市场应用</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppSourceType
    {
        /// <summary>
        /// Enum CUSTOM for value: CUSTOM
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 1,

        /// <summary>
        /// Enum SYSTEM for value: SYSTEM
        /// </summary>
        [EnumMember(Value = "SYSTEM")]
        SYSTEM = 2,

        /// <summary>
        /// Enum MARKET for value: MARKET
        /// </summary>
        [EnumMember(Value = "MARKET")]
        MARKET = 3

    }

}
