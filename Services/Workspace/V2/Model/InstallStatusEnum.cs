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
    /// 安装状态枚举。
    /// </summary>
    /// <value>安装状态枚举。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum InstallStatusEnum
    {
        /// <summary>
        /// Enum INSTALLING for value: INSTALLING
        /// </summary>
        [EnumMember(Value = "INSTALLING")]
        INSTALLING = 1,

        /// <summary>
        /// Enum INSTALLED for value: INSTALLED
        /// </summary>
        [EnumMember(Value = "INSTALLED")]
        INSTALLED = 2,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 3,

        /// <summary>
        /// Enum UNINSTALLING for value: UNINSTALLING
        /// </summary>
        [EnumMember(Value = "UNINSTALLING")]
        UNINSTALLING = 4,

        /// <summary>
        /// Enum UNINSTALLED for value: UNINSTALLED
        /// </summary>
        [EnumMember(Value = "UNINSTALLED")]
        UNINSTALLED = 5

    }

}
