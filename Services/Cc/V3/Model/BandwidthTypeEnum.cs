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
    /// 带宽类型包括： - BandwidthPackage (按带宽计费，需要绑定全域互联带宽，并指定分配带宽大小) - TestBandwidth (不收费的测试带宽，仅保留最小带宽，用于测试跨地域连通性）
    /// </summary>
    /// <value>带宽类型包括： - BandwidthPackage (按带宽计费，需要绑定全域互联带宽，并指定分配带宽大小) - TestBandwidth (不收费的测试带宽，仅保留最小带宽，用于测试跨地域连通性）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum BandwidthTypeEnum
    {
        /// <summary>
        /// Enum BANDWIDTHPACKAGE for value: BandwidthPackage
        /// </summary>
        [EnumMember(Value = "BandwidthPackage")]
        BANDWIDTHPACKAGE = 1,

        /// <summary>
        /// Enum TESTBANDWIDTH for value: TestBandwidth
        /// </summary>
        [EnumMember(Value = "TestBandwidth")]
        TESTBANDWIDTH = 2

    }

}
