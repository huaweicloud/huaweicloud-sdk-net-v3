using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 文档模板版本。 - 2022.08.30 (2022.08.30)
    /// </summary>
    /// <value>文档模板版本。 - 2022.08.30 (2022.08.30)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum DocumentTemplateVersionEnum
    {
        /// <summary>
        /// Enum _2022_08_30 for value: 2022.08.30
        /// </summary>
        [EnumMember(Value = "2022.08.30")]
        _2022_08_30 = 1

    }

}
