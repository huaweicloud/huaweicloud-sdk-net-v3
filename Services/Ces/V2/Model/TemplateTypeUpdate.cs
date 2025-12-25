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
    /// **参数解释**： 自定义告警模板类型 **约束限制**： 不涉及。 **取值范围**： 0：指标；2： 事件。 **默认取值**： 0 
    /// </summary>
    /// <value>**参数解释**： 自定义告警模板类型 **约束限制**： 不涉及。 **取值范围**： 0：指标；2： 事件。 **默认取值**： 0 </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TemplateTypeUpdate
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 2

    }

}
