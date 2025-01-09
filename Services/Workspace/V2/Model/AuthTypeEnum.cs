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
    /// 认证类型。 RADIUS_GATEWAY：短信辅助认证 OAUTH2:OAUTH2认证 CLIENT_TOKEN:本地token认证 USER_PASSWORD:密码认证类型
    /// </summary>
    /// <value>认证类型。 RADIUS_GATEWAY：短信辅助认证 OAUTH2:OAUTH2认证 CLIENT_TOKEN:本地token认证 USER_PASSWORD:密码认证类型</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AuthTypeEnum
    {
        /// <summary>
        /// Enum RADIUS_GATEWAY for value: RADIUS_GATEWAY
        /// </summary>
        [EnumMember(Value = "RADIUS_GATEWAY")]
        RADIUS_GATEWAY = 1,

        /// <summary>
        /// Enum OAUTH2 for value: OAUTH2
        /// </summary>
        [EnumMember(Value = "OAUTH2")]
        OAUTH2 = 2,

        /// <summary>
        /// Enum LDAP for value: LDAP
        /// </summary>
        [EnumMember(Value = "LDAP")]
        LDAP = 3,

        /// <summary>
        /// Enum CLIENT_TOKEN for value: CLIENT_TOKEN
        /// </summary>
        [EnumMember(Value = "CLIENT_TOKEN")]
        CLIENT_TOKEN = 4,

        /// <summary>
        /// Enum USER_PASSWORD for value: USER_PASSWORD
        /// </summary>
        [EnumMember(Value = "USER_PASSWORD")]
        USER_PASSWORD = 5,

        /// <summary>
        /// Enum FINGER for value: FINGER
        /// </summary>
        [EnumMember(Value = "FINGER")]
        FINGER = 6

    }

}
