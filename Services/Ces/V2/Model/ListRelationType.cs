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
    /// **参数解释**： 屏蔽告警通知的实现方式。 **约束限制**： 不涉及。 **取值范围**： 枚举值，长度为[1,32]个字符，取值为: - ALARM_RULE：通过告警规则屏蔽告警通知。 - RESOURCE：通过资源屏蔽告警通知。使用方式：《告警屏蔽》页面点击《创建告警屏蔽》按钮，选择资源屏蔽。 - RESOURCE_POLICY_NOTIFICATION：通过告警策略屏蔽告警通知。使用方式：《告警屏蔽》页面点击《创建告警屏蔽》按钮，选择策略屏蔽。 - EVENT.SYS：屏蔽事件类告警通知。使用方式：《告警屏蔽》页面点击《创建告警屏蔽》按钮，选择事件屏蔽。 - RESOURCE_POLICY_ALARM：（已废弃，不推荐使用）通过屏蔽告警计算来屏蔽告警通知。 - DEFAULT：（已废弃，不推荐使用）默认包含RESOURCE、RESOURCE_POLICY_NOTIFICATION、EVENT.SYS **默认取值**： 不涉及。 
    /// </summary>
    /// <value>**参数解释**： 屏蔽告警通知的实现方式。 **约束限制**： 不涉及。 **取值范围**： 枚举值，长度为[1,32]个字符，取值为: - ALARM_RULE：通过告警规则屏蔽告警通知。 - RESOURCE：通过资源屏蔽告警通知。使用方式：《告警屏蔽》页面点击《创建告警屏蔽》按钮，选择资源屏蔽。 - RESOURCE_POLICY_NOTIFICATION：通过告警策略屏蔽告警通知。使用方式：《告警屏蔽》页面点击《创建告警屏蔽》按钮，选择策略屏蔽。 - EVENT.SYS：屏蔽事件类告警通知。使用方式：《告警屏蔽》页面点击《创建告警屏蔽》按钮，选择事件屏蔽。 - RESOURCE_POLICY_ALARM：（已废弃，不推荐使用）通过屏蔽告警计算来屏蔽告警通知。 - DEFAULT：（已废弃，不推荐使用）默认包含RESOURCE、RESOURCE_POLICY_NOTIFICATION、EVENT.SYS **默认取值**： 不涉及。 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListRelationType
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
        /// Enum DEFAULT for value: DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT = 5

    }

}
