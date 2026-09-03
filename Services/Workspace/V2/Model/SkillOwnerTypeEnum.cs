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
    /// 技能所有者类型枚举。
    /// </summary>
    /// <value>技能所有者类型枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SkillOwnerTypeEnum
    {
        /// <summary>
        /// Enum COMMON for value: COMMON
        /// </summary>
        [EnumMember(Value = "COMMON")]
        COMMON = 1,

        /// <summary>
        /// Enum TENANT for value: TENANT
        /// </summary>
        [EnumMember(Value = "TENANT")]
        TENANT = 2

    }

}
