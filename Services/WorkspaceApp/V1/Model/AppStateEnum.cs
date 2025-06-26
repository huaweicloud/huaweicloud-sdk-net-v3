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
    /// 应用状态： * &#x60;NORMAL&#x60; - 正常状态。 * &#x60;FORBIDDEN&#x60; - 禁用状态。
    /// </summary>
    /// <value>应用状态： * &#x60;NORMAL&#x60; - 正常状态。 * &#x60;FORBIDDEN&#x60; - 禁用状态。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppStateEnum
    {
        /// <summary>
        /// Enum NORMAL for value: NORMAL
        /// </summary>
        [EnumMember(Value = "NORMAL")]
        NORMAL = 1,

        /// <summary>
        /// Enum FORBIDDEN for value: FORBIDDEN
        /// </summary>
        [EnumMember(Value = "FORBIDDEN")]
        FORBIDDEN = 2

    }

}
