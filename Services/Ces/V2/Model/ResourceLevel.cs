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
    /// 产品层级跨纬规则创建时需要指明为产品层级规则，resource_level取值为product即为产品层级跨纬规则，不填或者取值为dimension则为旧的规则类型
    /// </summary>
    /// <value>产品层级跨纬规则创建时需要指明为产品层级规则，resource_level取值为product即为产品层级跨纬规则，不填或者取值为dimension则为旧的规则类型</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ResourceLevel
    {
        /// <summary>
        /// Enum PRODUCT for value: product
        /// </summary>
        [EnumMember(Value = "product")]
        PRODUCT = 1,

        /// <summary>
        /// Enum DIMENSION for value: dimension
        /// </summary>
        [EnumMember(Value = "dimension")]
        DIMENSION = 2

    }

}
