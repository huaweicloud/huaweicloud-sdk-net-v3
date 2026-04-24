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
    /// 域类型 KERBEROS：对接AD OPEN_API：使用OPEN_API的方式对接统信域控
    /// </summary>
    /// <value>域类型 KERBEROS：对接AD OPEN_API：使用OPEN_API的方式对接统信域控</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DomainType
    {
        /// <summary>
        /// Enum KERBEROS for value: KERBEROS
        /// </summary>
        [EnumMember(Value = "KERBEROS")]
        KERBEROS = 1,

        /// <summary>
        /// Enum OPEN_API for value: OPEN_API
        /// </summary>
        [EnumMember(Value = "OPEN_API")]
        OPEN_API = 2

    }

}
