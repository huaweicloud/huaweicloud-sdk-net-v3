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
    /// 服务器组应用类型： * &#x60;SESSION_DESKTOP_APP&#x60; - 会话桌面app * &#x60;COMMON_APP&#x60; - 普通app
    /// </summary>
    /// <value>服务器组应用类型： * &#x60;SESSION_DESKTOP_APP&#x60; - 会话桌面app * &#x60;COMMON_APP&#x60; - 普通app</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AppTypeEnum
    {
        /// <summary>
        /// Enum SESSION_DESKTOP_APP for value: SESSION_DESKTOP_APP
        /// </summary>
        [EnumMember(Value = "SESSION_DESKTOP_APP")]
        SESSION_DESKTOP_APP = 1,

        /// <summary>
        /// Enum COMMON_APP for value: COMMON_APP
        /// </summary>
        [EnumMember(Value = "COMMON_APP")]
        COMMON_APP = 2

    }

}
