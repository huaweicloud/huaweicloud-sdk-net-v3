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
    /// 技能来源枚举。
    /// </summary>
    /// <value>技能来源枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SkillSourceEnum
    {
        /// <summary>
        /// Enum CUSTOM for value: CUSTOM
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 1,

        /// <summary>
        /// Enum OFFICIAL for value: OFFICIAL
        /// </summary>
        [EnumMember(Value = "OFFICIAL")]
        OFFICIAL = 2,

        /// <summary>
        /// Enum MARKETPLACE for value: MARKETPLACE
        /// </summary>
        [EnumMember(Value = "MARKETPLACE")]
        MARKETPLACE = 3

    }

}
