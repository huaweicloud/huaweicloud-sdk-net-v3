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
    /// 授权类型，基于应用(组)授权，默认为APP_GROUP授权。 * &#x60;APP&#x60; - 按照应用授权（***尚未支持***）。 * &#x60;APP_GROUP&#x60; - 按照应用组授权。
    /// </summary>
    /// <value>授权类型，基于应用(组)授权，默认为APP_GROUP授权。 * &#x60;APP&#x60; - 按照应用授权（***尚未支持***）。 * &#x60;APP_GROUP&#x60; - 按照应用组授权。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AuthorizationTypeEnum
    {
        /// <summary>
        /// Enum APP for value: APP
        /// </summary>
        [EnumMember(Value = "APP")]
        APP = 1,

        /// <summary>
        /// Enum APP_GROUP for value: APP_GROUP
        /// </summary>
        [EnumMember(Value = "APP_GROUP")]
        APP_GROUP = 2

    }

}
