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
    /// 接入网络实例类型，GDGW (专线)和ER_ROUTE_TABLE (路由表)。
    /// </summary>
    /// <value>接入网络实例类型，GDGW (专线)和ER_ROUTE_TABLE (路由表)。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AttachmentInstanceTypeEnum
    {
        /// <summary>
        /// Enum GDGW for value: GDGW
        /// </summary>
        [EnumMember(Value = "GDGW")]
        GDGW = 1,

        /// <summary>
        /// Enum ER_ROUTE_TABLE for value: ER_ROUTE_TABLE
        /// </summary>
        [EnumMember(Value = "ER_ROUTE_TABLE")]
        ER_ROUTE_TABLE = 2

    }

}
