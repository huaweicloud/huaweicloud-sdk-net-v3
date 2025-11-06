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
    /// **参数解释**： 屏蔽告警通知的实现方式。 **约束限制**： 不涉及。 **取值范围**： - ALARM_RULE：通过告警规则屏蔽告警通知(不支持通过该接口修改，请通过接口“[批量设置告警通知屏蔽规则](BatchUpdateNotificationMasks.xml)”设置)。 - RESOURCE：通过资源屏蔽告警通知。 - RESOURCE_POLICY_NOTIFICATION：通过告警策略屏蔽告警通知。 - EVENT.SYS: 通过事件来蔽告警通知。 - RESOURCE_POLICY_ALARM：（已废弃）通过屏蔽告警计算来屏蔽告警通知。 **默认取值**： 不涉及。 
    /// </summary>
    /// <value>**参数解释**： 屏蔽告警通知的实现方式。 **约束限制**： 不涉及。 **取值范围**： - ALARM_RULE：通过告警规则屏蔽告警通知(不支持通过该接口修改，请通过接口“[批量设置告警通知屏蔽规则](BatchUpdateNotificationMasks.xml)”设置)。 - RESOURCE：通过资源屏蔽告警通知。 - RESOURCE_POLICY_NOTIFICATION：通过告警策略屏蔽告警通知。 - EVENT.SYS: 通过事件来蔽告警通知。 - RESOURCE_POLICY_ALARM：（已废弃）通过屏蔽告警计算来屏蔽告警通知。 **默认取值**： 不涉及。 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RelationType
    {
        /// <summary>
        /// Enum ALARM_RULE for value: ALARM_RULE
        /// </summary>
        [EnumMember(Value = "ALARM_RULE")]
        ALARM_RULE = 1,

        /// <summary>
        /// Enum RESOURCE for value: RESOURCE
        /// </summary>
        [EnumMember(Value = "RESOURCE")]
        RESOURCE = 2,

        /// <summary>
        /// Enum RESOURCE_POLICY_NOTIFICATION for value: RESOURCE_POLICY_NOTIFICATION
        /// </summary>
        [EnumMember(Value = "RESOURCE_POLICY_NOTIFICATION")]
        RESOURCE_POLICY_NOTIFICATION = 3,

        /// <summary>
        /// Enum RESOURCE_POLICY_ALARM for value: RESOURCE_POLICY_ALARM
        /// </summary>
        [EnumMember(Value = "RESOURCE_POLICY_ALARM")]
        RESOURCE_POLICY_ALARM = 4,

        /// <summary>
        /// Enum EVENT_SYS for value: EVENT.SYS
        /// </summary>
        [EnumMember(Value = "EVENT.SYS")]
        EVENT_SYS = 5

    }

}
