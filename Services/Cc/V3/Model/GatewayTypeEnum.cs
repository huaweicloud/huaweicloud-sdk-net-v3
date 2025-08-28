using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 网关的类型。GDGW：全球接入网关。
    /// </summary>
    /// <value>网关的类型。GDGW：全球接入网关。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GatewayTypeEnum
    {
        /// <summary>
        /// Enum GDGW for value: GDGW
        /// </summary>
        [EnumMember(Value = "GDGW")]
        GDGW = 1

    }

}
