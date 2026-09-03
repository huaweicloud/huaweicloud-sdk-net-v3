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
    /// 技能状态枚举。
    /// </summary>
    /// <value>技能状态枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SkillStatusEnum
    {
        /// <summary>
        /// Enum ACTIVE for value: ACTIVE
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,

        /// <summary>
        /// Enum DISABLED for value: DISABLED
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED = 2

    }

}
