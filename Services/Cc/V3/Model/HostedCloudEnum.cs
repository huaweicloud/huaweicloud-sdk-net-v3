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
    /// - HWCloud (华为云) - Ireland (爱尔兰)
    /// </summary>
    /// <value>- HWCloud (华为云) - Ireland (爱尔兰)</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum HostedCloudEnum
    {
        /// <summary>
        /// Enum HWCLOUD for value: HWCloud
        /// </summary>
        [EnumMember(Value = "HWCloud")]
        HWCLOUD = 1,

        /// <summary>
        /// Enum IRELAND for value: Ireland
        /// </summary>
        [EnumMember(Value = "Ireland")]
        IRELAND = 2

    }

}
