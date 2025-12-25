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
    /// **参数解释**： 屏蔽资源类型。 **约束限制**： 不涉及。 **取值范围**: - ALL_INSTANCE：全部资源 - MULTI_INSTANCE：多实例资源 **默认取值**： 不涉及。 
    /// </summary>
    /// <value>**参数解释**： 屏蔽资源类型。 **约束限制**： 不涉及。 **取值范围**: - ALL_INSTANCE：全部资源 - MULTI_INSTANCE：多实例资源 **默认取值**： 不涉及。 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MaskResourceType
    {
        /// <summary>
        /// Enum ALL_INSTANCE for value: ALL_INSTANCE
        /// </summary>
        [EnumMember(Value = "ALL_INSTANCE")]
        ALL_INSTANCE = 1,

        /// <summary>
        /// Enum MULTI_INSTANCE for value: MULTI_INSTANCE
        /// </summary>
        [EnumMember(Value = "MULTI_INSTANCE")]
        MULTI_INSTANCE = 2

    }

}
