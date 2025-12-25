using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// **参数解释** 资源分组健康状态 **取值范围** - health: 表示健康 - unhealth: 表示不健康 - no_alarm_rule: 表示未配置告警规则 
    /// </summary>
    /// <value>**参数解释** 资源分组健康状态 **取值范围** - health: 表示健康 - unhealth: 表示不健康 - no_alarm_rule: 表示未配置告警规则 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StatusSchemaResp
    {
        /// <summary>
        /// Enum HEALTH for value: health
        /// </summary>
        [EnumMember(Value = "health")]
        HEALTH = 1,

        /// <summary>
        /// Enum UNHEALTH for value: unhealth
        /// </summary>
        [EnumMember(Value = "unhealth")]
        UNHEALTH = 2,

        /// <summary>
        /// Enum NO_ALARM_RULE for value: no_alarm_rule
        /// </summary>
        [EnumMember(Value = "no_alarm_rule")]
        NO_ALARM_RULE = 3

    }

}
