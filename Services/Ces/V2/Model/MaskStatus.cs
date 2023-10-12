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
    /// 屏蔽状态。UN_MASKED：未屏蔽，MASK_EFFECTIVE：已生效，MASK_INEFFECTIVE：未生效。
    /// </summary>
    /// <value>屏蔽状态。UN_MASKED：未屏蔽，MASK_EFFECTIVE：已生效，MASK_INEFFECTIVE：未生效。</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MaskStatus
    {
        /// <summary>
        /// Enum UN_MASKED for value: UN_MASKED
        /// </summary>
        [EnumMember(Value = "UN_MASKED")]
        UN_MASKED = 1,

        /// <summary>
        /// Enum MASK_EFFECTIVE for value: MASK_EFFECTIVE
        /// </summary>
        [EnumMember(Value = "MASK_EFFECTIVE")]
        MASK_EFFECTIVE = 2,

        /// <summary>
        /// Enum MASK_INEFFECTIVE for value: MASK_INEFFECTIVE
        /// </summary>
        [EnumMember(Value = "MASK_INEFFECTIVE")]
        MASK_INEFFECTIVE = 3

    }

}
