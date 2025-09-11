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
    /// **参数解释**： 屏蔽告警通知或者屏蔽告警计算的实现方式。 **约束限制**： 不涉及。 **取值范围**： 枚举值，只能为ALARM_RULE、RESOURCE、RESOURCE_POLICY_NOTIFICATION、RESOURCE_POLICY_ALARM，长度为[1,32]个字符。 - ALARM_RULE：通过告警规则屏蔽告警通知。 - RESOURCE：通过资源屏蔽告警通知。 - RESOURCE_POLICY_NOTIFICATION：通过告警策略和告警资源屏蔽告警通知。 - RESOURCE_POLICY_ALARM：通过告警策略和告警资源屏蔽计算告警。           **默认取值**： 不涉及。 
    /// </summary>
    /// <value>**参数解释**： 屏蔽告警通知或者屏蔽告警计算的实现方式。 **约束限制**： 不涉及。 **取值范围**： 枚举值，只能为ALARM_RULE、RESOURCE、RESOURCE_POLICY_NOTIFICATION、RESOURCE_POLICY_ALARM，长度为[1,32]个字符。 - ALARM_RULE：通过告警规则屏蔽告警通知。 - RESOURCE：通过资源屏蔽告警通知。 - RESOURCE_POLICY_NOTIFICATION：通过告警策略和告警资源屏蔽告警通知。 - RESOURCE_POLICY_ALARM：通过告警策略和告警资源屏蔽计算告警。           **默认取值**： 不涉及。 </value>
    
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
        RESOURCE_POLICY_ALARM = 4

    }

}
