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
    /// 停机类型： * &#x60;SOFT&#x60; - 普通 * &#x60;HARD&#x60; - 强制
    /// </summary>
    /// <value>停机类型： * &#x60;SOFT&#x60; - 普通 * &#x60;HARD&#x60; - 强制</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ServerHaltType
    {
        /// <summary>
        /// Enum SOFT for value: SOFT
        /// </summary>
        [EnumMember(Value = "SOFT")]
        SOFT = 1,

        /// <summary>
        /// Enum HARD for value: HARD
        /// </summary>
        [EnumMember(Value = "HARD")]
        HARD = 2

    }

}
