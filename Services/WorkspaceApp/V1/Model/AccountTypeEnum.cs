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
    /// 用户类型： * &#x60;USER&#x60; - 用户 * &#x60;USER_GROUP&#x60; - 用户组
    /// </summary>
    /// <value>用户类型： * &#x60;USER&#x60; - 用户 * &#x60;USER_GROUP&#x60; - 用户组</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountTypeEnum
    {
        /// <summary>
        /// Enum USER for value: USER
        /// </summary>
        [EnumMember(Value = "USER")]
        USER = 1,

        /// <summary>
        /// Enum USER_GROUP for value: USER_GROUP
        /// </summary>
        [EnumMember(Value = "USER_GROUP")]
        USER_GROUP = 2

    }

}
