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
    /// 中心网络连接类型定义： - ER-ER (ER-ER Connection) - ER-GDGW (ER-GDGW Attachment Connection) - ER-ER_ROUTE_TABLE (ER-ER_ROUTE_TABLE Attachment Connection)
    /// </summary>
    /// <value>中心网络连接类型定义： - ER-ER (ER-ER Connection) - ER-GDGW (ER-GDGW Attachment Connection) - ER-ER_ROUTE_TABLE (ER-ER_ROUTE_TABLE Attachment Connection)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConnectionTypeEnum
    {
        /// <summary>
        /// Enum ER_ER for value: ER-ER
        /// </summary>
        [EnumMember(Value = "ER-ER")]
        ER_ER = 1,

        /// <summary>
        /// Enum ER_GDGW for value: ER-GDGW
        /// </summary>
        [EnumMember(Value = "ER-GDGW")]
        ER_GDGW = 2,

        /// <summary>
        /// Enum ER_ER_ROUTE_TABLE for value: ER-ER_ROUTE_TABLE
        /// </summary>
        [EnumMember(Value = "ER-ER_ROUTE_TABLE")]
        ER_ER_ROUTE_TABLE = 3

    }

}
