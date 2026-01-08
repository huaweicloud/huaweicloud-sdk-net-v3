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
    /// **参数解释** 资源分组健康状态 **约束限制** 不涉及 **取值范围** - health: 表示无告警 - unhealth: 表示告警中 - no_alarm_rule: 表示未设置告警规则 **默认取值** 不涉及 
    /// </summary>
    /// <value>**参数解释** 资源分组健康状态 **约束限制** 不涉及 **取值范围** - health: 表示无告警 - unhealth: 表示告警中 - no_alarm_rule: 表示未设置告警规则 **默认取值** 不涉及 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StatusSchema
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
