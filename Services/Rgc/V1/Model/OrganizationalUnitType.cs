using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 组织单元类型。 * CORE - 基础组织单元 * CUSTOM - 组织单元 * ROOT - ROOT
    /// </summary>
    /// <value>组织单元类型。 * CORE - 基础组织单元 * CUSTOM - 组织单元 * ROOT - ROOT</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrganizationalUnitType
    {
        /// <summary>
        /// Enum CORE for value: CORE
        /// </summary>
        [EnumMember(Value = "CORE")]
        CORE = 1,

        /// <summary>
        /// Enum CUSTOM for value: CUSTOM
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM = 2,

        /// <summary>
        /// Enum ROOT for value: ROOT
        /// </summary>
        [EnumMember(Value = "ROOT")]
        ROOT = 3

    }

}
