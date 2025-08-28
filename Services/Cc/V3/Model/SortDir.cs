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
    /// desc(降序), asc(升序).
    /// </summary>
    /// <value>desc(降序), asc(升序).</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SortDir
    {
        /// <summary>
        /// Enum DESC for value: desc
        /// </summary>
        [EnumMember(Value = "desc")]
        DESC = 1,

        /// <summary>
        /// Enum ASC for value: asc
        /// </summary>
        [EnumMember(Value = "asc")]
        ASC = 2

    }

}
