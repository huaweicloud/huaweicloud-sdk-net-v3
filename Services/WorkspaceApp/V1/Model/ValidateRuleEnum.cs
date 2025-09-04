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
    /// 校验类型： * &#x60;naming&#x60; - 命名规范 * &#x60;duplicate&#x60; - 重复
    /// </summary>
    /// <value>校验类型： * &#x60;naming&#x60; - 命名规范 * &#x60;duplicate&#x60; - 重复</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ValidateRuleEnum
    {
        /// <summary>
        /// Enum NAMING for value: naming
        /// </summary>
        [EnumMember(Value = "naming")]
        NAMING = 1,

        /// <summary>
        /// Enum DUPLICATE for value: duplicate
        /// </summary>
        [EnumMember(Value = "duplicate")]
        DUPLICATE = 2

    }

}
