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
    /// 屏蔽资源类型。ALL_INSTANCE：全部资源，MULTI_INSTANCE：多实例资源
    /// </summary>
    /// <value>屏蔽资源类型。ALL_INSTANCE：全部资源，MULTI_INSTANCE：多实例资源</value>
    
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
