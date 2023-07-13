using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Defines VideoFormatVar
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VideoFormatVar
    {
        /// <summary>
        /// Enum FLV for value: FLV
        /// </summary>
        [EnumMember(Value = "FLV")]
        FLV = 1,

        /// <summary>
        /// Enum HLS for value: HLS
        /// </summary>
        [EnumMember(Value = "HLS")]
        HLS = 2,

        /// <summary>
        /// Enum MP4 for value: MP4
        /// </summary>
        [EnumMember(Value = "MP4")]
        MP4 = 3

    }

}
