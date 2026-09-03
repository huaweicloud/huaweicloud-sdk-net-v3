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
    /// 技能包状态枚举。
    /// </summary>
    /// <value>技能包状态枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PackageStatusEnum
    {
        /// <summary>
        /// Enum UPLOAD for value: UPLOAD
        /// </summary>
        [EnumMember(Value = "UPLOAD")]
        UPLOAD = 1,

        /// <summary>
        /// Enum PUBLISHED for value: PUBLISHED
        /// </summary>
        [EnumMember(Value = "PUBLISHED")]
        PUBLISHED = 2,

        /// <summary>
        /// Enum DISABLED for value: DISABLED
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED = 3

    }

}
