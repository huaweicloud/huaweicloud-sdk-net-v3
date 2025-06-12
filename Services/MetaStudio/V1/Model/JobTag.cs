using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 任务标签。 * ECOMMERCE: 电商 * NEWS: 新闻 * MARKETING: 营销
    /// </summary>
    /// <value>任务标签。 * ECOMMERCE: 电商 * NEWS: 新闻 * MARKETING: 营销</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobTag
    {
        /// <summary>
        /// Enum ECOMMERCE for value: ECOMMERCE
        /// </summary>
        [EnumMember(Value = "ECOMMERCE")]
        ECOMMERCE = 1,

        /// <summary>
        /// Enum NEWS for value: NEWS
        /// </summary>
        [EnumMember(Value = "NEWS")]
        NEWS = 2,

        /// <summary>
        /// Enum MARKETING for value: MARKETING
        /// </summary>
        [EnumMember(Value = "MARKETING")]
        MARKETING = 3

    }

}
