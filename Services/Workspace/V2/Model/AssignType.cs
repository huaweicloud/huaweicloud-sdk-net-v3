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
    /// * &#x60;ALL_USER&#x60; - 全部用户 * &#x60;ASSIGN_USER&#x60; - 授权指定用户
    /// </summary>
    /// <value>* &#x60;ALL_USER&#x60; - 全部用户 * &#x60;ASSIGN_USER&#x60; - 授权指定用户</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AssignType
    {
        /// <summary>
        /// Enum ALL_USER for value: ALL_USER
        /// </summary>
        [EnumMember(Value = "ALL_USER")]
        ALL_USER = 1,

        /// <summary>
        /// Enum ASSIGN_USER for value: ASSIGN_USER
        /// </summary>
        [EnumMember(Value = "ASSIGN_USER")]
        ASSIGN_USER = 2

    }

}
