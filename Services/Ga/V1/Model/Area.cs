using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 地区，取值： - OUTOFCM：中国大陆以外 - CM：中国大陆
    /// </summary>
    /// <value>地区，取值： - OUTOFCM：中国大陆以外 - CM：中国大陆</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Area
    {
        /// <summary>
        /// Enum OUTOFCM for value: OUTOFCM
        /// </summary>
        [EnumMember(Value = "OUTOFCM")]
        OUTOFCM = 1,

        /// <summary>
        /// Enum CM for value: CM
        /// </summary>
        [EnumMember(Value = "CM")]
        CM = 2

    }

}
