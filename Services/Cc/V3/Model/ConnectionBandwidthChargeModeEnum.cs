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
    /// - bwd (按需按带宽计费) - trf (按流量计费) - 95 (传统95计费) - 95avr (日95计费)
    /// </summary>
    /// <value>- bwd (按需按带宽计费) - trf (按流量计费) - 95 (传统95计费) - 95avr (日95计费)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConnectionBandwidthChargeModeEnum
    {
        /// <summary>
        /// Enum BWD for value: bwd
        /// </summary>
        [EnumMember(Value = "bwd")]
        BWD = 1,

        /// <summary>
        /// Enum TRF for value: trf
        /// </summary>
        [EnumMember(Value = "trf")]
        TRF = 2,

        /// <summary>
        /// Enum _95 for value: 95
        /// </summary>
        [EnumMember(Value = "95")]
        _95 = 3,

        /// <summary>
        /// Enum _95AVR for value: 95avr
        /// </summary>
        [EnumMember(Value = "95avr")]
        _95AVR = 4

    }

}
