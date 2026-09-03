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
    /// 可见性范围枚举。
    /// </summary>
    /// <value>可见性范围枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VisibilityScopeEnum
    {
        /// <summary>
        /// Enum OWNER_ONLY for value: OWNER_ONLY
        /// </summary>
        [EnumMember(Value = "OWNER_ONLY")]
        OWNER_ONLY = 1,

        /// <summary>
        /// Enum ALL_TENANTS for value: ALL_TENANTS
        /// </summary>
        [EnumMember(Value = "ALL_TENANTS")]
        ALL_TENANTS = 2,

        /// <summary>
        /// Enum SPECIFIC_TENANTS for value: SPECIFIC_TENANTS
        /// </summary>
        [EnumMember(Value = "SPECIFIC_TENANTS")]
        SPECIFIC_TENANTS = 3

    }

}
