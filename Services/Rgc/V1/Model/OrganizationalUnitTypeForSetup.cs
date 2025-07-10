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
    /// 可设置的注册OU类型。包括核心注册OU和自定义注册OU。
    /// </summary>
    /// <value>可设置的注册OU类型。包括核心注册OU和自定义注册OU。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrganizationalUnitTypeForSetup
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
        CUSTOM = 2

    }

}
