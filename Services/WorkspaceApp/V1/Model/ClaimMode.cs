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
    /// 存储声明的类型： * &#x60;USER&#x60; -  用户目录 * &#x60;SHARE&#x60; - 共享目录
    /// </summary>
    /// <value>存储声明的类型： * &#x60;USER&#x60; -  用户目录 * &#x60;SHARE&#x60; - 共享目录</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ClaimMode
    {
        /// <summary>
        /// Enum USER for value: USER
        /// </summary>
        [EnumMember(Value = "USER")]
        USER = 1,

        /// <summary>
        /// Enum SHARE for value: SHARE
        /// </summary>
        [EnumMember(Value = "SHARE")]
        SHARE = 2

    }

}
