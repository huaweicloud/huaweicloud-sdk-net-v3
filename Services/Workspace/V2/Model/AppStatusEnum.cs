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
    /// 应用状态(正常、禁用) * &#39;NORMAL&#39; - 正常 * &#39;FORBIDDEN&#39; - 禁用状态
    /// </summary>
    /// <value>应用状态(正常、禁用) * &#39;NORMAL&#39; - 正常 * &#39;FORBIDDEN&#39; - 禁用状态</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppStatusEnum
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
