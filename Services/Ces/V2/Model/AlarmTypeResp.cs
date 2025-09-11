using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// **参数解释**： 告警规则类型 **取值范围**： 枚举值。 - ALL_INSTANCE：全部资源指标告警。 - RESOURCE_GROUP：资源分组指标告警。 - MULTI_INSTANCE：指定资源指标告警。 - EVENT.SYS：系统事件告警。 - EVENT.CUSTOM：自定义事件告警。 - DNSHealthCheck：健康检查告警。 
    /// </summary>
    /// <value>**参数解释**： 告警规则类型 **取值范围**： 枚举值。 - ALL_INSTANCE：全部资源指标告警。 - RESOURCE_GROUP：资源分组指标告警。 - MULTI_INSTANCE：指定资源指标告警。 - EVENT.SYS：系统事件告警。 - EVENT.CUSTOM：自定义事件告警。 - DNSHealthCheck：健康检查告警。 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AlarmTypeResp
    {
        /// <summary>
        /// Enum EVENT_SYS for value: EVENT.SYS
        /// </summary>
        [EnumMember(Value = "EVENT.SYS")]
        EVENT_SYS = 1,

        /// <summary>
        /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
        /// </summary>
        [EnumMember(Value = "EVENT.CUSTOM")]
        EVENT_CUSTOM = 2,

        /// <summary>
        /// Enum DNSHEALTHCHECK for value: DNSHealthCheck
        /// </summary>
        [EnumMember(Value = "DNSHealthCheck")]
        DNSHEALTHCHECK = 3,

        /// <summary>
        /// Enum RESOURCE_GROUP for value: RESOURCE_GROUP
        /// </summary>
        [EnumMember(Value = "RESOURCE_GROUP")]
        RESOURCE_GROUP = 4,

        /// <summary>
        /// Enum MULTI_INSTANCE for value: MULTI_INSTANCE
        /// </summary>
        [EnumMember(Value = "MULTI_INSTANCE")]
        MULTI_INSTANCE = 5,

        /// <summary>
        /// Enum ALL_INSTANCE for value: ALL_INSTANCE
        /// </summary>
        [EnumMember(Value = "ALL_INSTANCE")]
        ALL_INSTANCE = 6

    }

}
