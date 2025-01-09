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
    /// 账户类型： * &#39;SIMPLE&#39; - 普通用户 * &#39;USER_GROUP&#39; - 用户组
    /// </summary>
    /// <value>账户类型： * &#39;SIMPLE&#39; - 普通用户 * &#39;USER_GROUP&#39; - 用户组</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountTypeEnum
    {
        /// <summary>
        /// Enum SIMPLE for value: SIMPLE
        /// </summary>
        [EnumMember(Value = "SIMPLE")]
        SIMPLE = 1,

        /// <summary>
        /// Enum USER_GROUP for value: USER_GROUP
        /// </summary>
        [EnumMember(Value = "USER_GROUP")]
        USER_GROUP = 2

    }

}
