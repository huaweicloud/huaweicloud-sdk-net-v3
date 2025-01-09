using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 规则范围： * &#x60;PRODUCT&#x60; - 产品 * &#x60;PATH&#x60; - 路径
    /// </summary>
    /// <value>规则范围： * &#x60;PRODUCT&#x60; - 产品 * &#x60;PATH&#x60; - 路径</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RuleScope
    {
        /// <summary>
        /// Enum PRODUCT for value: PRODUCT
        /// </summary>
        [EnumMember(Value = "PRODUCT")]
        PRODUCT = 1,

        /// <summary>
        /// Enum PATH for value: PATH
        /// </summary>
        [EnumMember(Value = "PATH")]
        PATH = 2

    }

}
