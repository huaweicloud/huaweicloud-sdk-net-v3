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
    /// 更新用户类型。 * &#x60;ADD&#x60; - 添加。 * &#x60;DELETE&#x60; - 按照应用组授权。
    /// </summary>
    /// <value>更新用户类型。 * &#x60;ADD&#x60; - 添加。 * &#x60;DELETE&#x60; - 按照应用组授权。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UpdateUserEnum
    {
        /// <summary>
        /// Enum ADD for value: ADD
        /// </summary>
        [EnumMember(Value = "ADD")]
        ADD = 1,

        /// <summary>
        /// Enum DELETE for value: DELETE
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE = 2

    }

}
