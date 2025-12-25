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
    /// **参数解释**： 告警抑制时间，单位为秒，对应页面上创建告警规则时告警策略最后一个字段，该字段主要为解决告警频繁的问题。 **约束限制**： 不涉及。 **取值范围**： 枚举值，只能为0、300、600、900、1800、3600、10800、21600、43200、86400。 - 0：对于指标类告警，0代表告警一次。对于事件类告警，在立即触发场景中，0代表不抑制；在累计触发场景，0代表只告警一次。 - 300代表满足告警触发条件后每5分钟告警一次。 - 600代表满足告警触发条件后每10分钟告警一次。 - 900代表满足告警触发条件后每15分钟告警一次。 - 1800代表满足告警触发条件后每30分钟告警一次。 - 3600代表满足告警触发条件后每60分钟告警一次。 - 10800代表满足告警触发条件后每3小时告警一次。 - 21600代表满足告警触发条件后每6小时告警一次。 - 43200代表满足告警触发条件后每12小时告警一次。 - 86400代表满足告警触发条件后每一天告警一次。 **默认取值**： 不涉及。 
    /// </summary>
    /// <value>**参数解释**： 告警抑制时间，单位为秒，对应页面上创建告警规则时告警策略最后一个字段，该字段主要为解决告警频繁的问题。 **约束限制**： 不涉及。 **取值范围**： 枚举值，只能为0、300、600、900、1800、3600、10800、21600、43200、86400。 - 0：对于指标类告警，0代表告警一次。对于事件类告警，在立即触发场景中，0代表不抑制；在累计触发场景，0代表只告警一次。 - 300代表满足告警触发条件后每5分钟告警一次。 - 600代表满足告警触发条件后每10分钟告警一次。 - 900代表满足告警触发条件后每15分钟告警一次。 - 1800代表满足告警触发条件后每30分钟告警一次。 - 3600代表满足告警触发条件后每60分钟告警一次。 - 10800代表满足告警触发条件后每3小时告警一次。 - 21600代表满足告警触发条件后每6小时告警一次。 - 43200代表满足告警触发条件后每12小时告警一次。 - 86400代表满足告警触发条件后每一天告警一次。 **默认取值**： 不涉及。 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SuppressDuration
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_300 for value: 300
        /// </summary>
        [EnumMember(Value = "300")]
        NUMBER_300 = 2,

        /// <summary>
        /// Enum NUMBER_600 for value: 600
        /// </summary>
        [EnumMember(Value = "600")]
        NUMBER_600 = 3,

        /// <summary>
        /// Enum NUMBER_900 for value: 900
        /// </summary>
        [EnumMember(Value = "900")]
        NUMBER_900 = 4,

        /// <summary>
        /// Enum NUMBER_1800 for value: 1800
        /// </summary>
        [EnumMember(Value = "1800")]
        NUMBER_1800 = 5,

        /// <summary>
        /// Enum NUMBER_3600 for value: 3600
        /// </summary>
        [EnumMember(Value = "3600")]
        NUMBER_3600 = 6,

        /// <summary>
        /// Enum NUMBER_10800 for value: 10800
        /// </summary>
        [EnumMember(Value = "10800")]
        NUMBER_10800 = 7,

        /// <summary>
        /// Enum NUMBER_21600 for value: 21600
        /// </summary>
        [EnumMember(Value = "21600")]
        NUMBER_21600 = 8,

        /// <summary>
        /// Enum NUMBER_43200 for value: 43200
        /// </summary>
        [EnumMember(Value = "43200")]
        NUMBER_43200 = 9,

        /// <summary>
        /// Enum NUMBER_86400 for value: 86400
        /// </summary>
        [EnumMember(Value = "86400")]
        NUMBER_86400 = 10

    }

}
