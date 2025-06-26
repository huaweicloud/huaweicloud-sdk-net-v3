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
    /// 系统类型，当前仅支持Windows。 * &#x60;Linux&#x60; - * &#x60;Windows&#x60; - * &#x60;Other&#x60; -
    /// </summary>
    /// <value>系统类型，当前仅支持Windows。 * &#x60;Linux&#x60; - * &#x60;Windows&#x60; - * &#x60;Other&#x60; -</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OsTypeEnum
    {
        /// <summary>
        /// Enum LINUX for value: Linux
        /// </summary>
        [EnumMember(Value = "Linux")]
        LINUX = 1,

        /// <summary>
        /// Enum WINDOWS for value: Windows
        /// </summary>
        [EnumMember(Value = "Windows")]
        WINDOWS = 2,

        /// <summary>
        /// Enum OTHER for value: Other
        /// </summary>
        [EnumMember(Value = "Other")]
        OTHER = 3

    }

}
