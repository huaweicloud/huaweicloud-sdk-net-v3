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
    /// 中心网络连接点类型定义： - ER (EnterpriseRouter) - GDGW (Global DC Gateway) - ER_ROUTE_TABLE (Route Table)
    /// </summary>
    /// <value>中心网络连接点类型定义： - ER (EnterpriseRouter) - GDGW (Global DC Gateway) - ER_ROUTE_TABLE (Route Table)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConnectionPointTypeEnum
    {
        /// <summary>
        /// Enum ER for value: ER
        /// </summary>
        [EnumMember(Value = "ER")]
        ER = 1,

        /// <summary>
        /// Enum GDGW for value: GDGW
        /// </summary>
        [EnumMember(Value = "GDGW")]
        GDGW = 2,

        /// <summary>
        /// Enum ER_ROUTE_TABLE for value: ER_ROUTE_TABLE
        /// </summary>
        [EnumMember(Value = "ER_ROUTE_TABLE")]
        ER_ROUTE_TABLE = 3

    }

}
