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
    /// **参数解释**： 屏蔽类型。          **约束限制**： 不涉及。 **取值范围**： 只能为START_END_TIME、FOREVER_TIME、CYCLE_TIME - START_END_TIME：按起止时间屏蔽。 - FOREVER_TIME：永久时间屏蔽。 - CYCLE_TIME：按周期时间屏蔽。           **默认取值**： 不涉及。 
    /// </summary>
    /// <value>**参数解释**： 屏蔽类型。          **约束限制**： 不涉及。 **取值范围**： 只能为START_END_TIME、FOREVER_TIME、CYCLE_TIME - START_END_TIME：按起止时间屏蔽。 - FOREVER_TIME：永久时间屏蔽。 - CYCLE_TIME：按周期时间屏蔽。           **默认取值**： 不涉及。 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MaskType
    {
        /// <summary>
        /// Enum START_END_TIME for value: START_END_TIME
        /// </summary>
        [EnumMember(Value = "START_END_TIME")]
        START_END_TIME = 1,

        /// <summary>
        /// Enum FOREVER_TIME for value: FOREVER_TIME
        /// </summary>
        [EnumMember(Value = "FOREVER_TIME")]
        FOREVER_TIME = 2,

        /// <summary>
        /// Enum CYCLE_TIME for value: CYCLE_TIME
        /// </summary>
        [EnumMember(Value = "CYCLE_TIME")]
        CYCLE_TIME = 3

    }

}
