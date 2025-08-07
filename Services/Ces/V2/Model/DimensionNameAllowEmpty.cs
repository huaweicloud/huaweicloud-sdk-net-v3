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
    /// **参数解释**： 资源维度。 **约束限制**： 当template_type为0或者不选时，DimensionName必填。当template_type为2时，DimensionName为空。 **取值范围**： 必须以字母开头，多维度用\&quot;,\&quot;分割，只能包含0-9/a-z/A-Z/_/-，每个维度的最大长度为32。字符串最大长度为131。 **默认取值**： 不涉及。 
    /// </summary>
    public class DimensionNameAllowEmpty 
    {



    }
}
