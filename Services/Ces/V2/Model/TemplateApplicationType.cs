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
    /// 模板应用类型。ALL_DIMENSION：所有维度, ONE_DIMENSION：同一维度。
    /// </summary>
    /// <value>模板应用类型。ALL_DIMENSION：所有维度, ONE_DIMENSION：同一维度。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TemplateApplicationType
    {
        /// <summary>
        /// Enum ALL_DIMENSION for value: ALL_DIMENSION
        /// </summary>
        [EnumMember(Value = "ALL_DIMENSION")]
        ALL_DIMENSION = 1,

        /// <summary>
        /// Enum ONE_DIMENSION for value: ONE_DIMENSION
        /// </summary>
        [EnumMember(Value = "ONE_DIMENSION")]
        ONE_DIMENSION = 2

    }

}
