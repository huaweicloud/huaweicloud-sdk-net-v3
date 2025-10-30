using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// 站点状态： - initial：待部署 - deploying：部署中 - available：可用 - unavailable：不可用
    /// </summary>
    /// <value>站点状态： - initial：待部署 - deploying：部署中 - available：可用 - unavailable：不可用</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteStatus
    {
        /// <summary>
        /// Enum INITIAL for value: initial
        /// </summary>
        [EnumMember(Value = "initial")]
        INITIAL = 1,

        /// <summary>
        /// Enum DEPLOYING for value: deploying
        /// </summary>
        [EnumMember(Value = "deploying")]
        DEPLOYING = 2,

        /// <summary>
        /// Enum AVAILABLE for value: available
        /// </summary>
        [EnumMember(Value = "available")]
        AVAILABLE = 3,

        /// <summary>
        /// Enum UNAVAILABLE for value: unavailable
        /// </summary>
        [EnumMember(Value = "unavailable")]
        UNAVAILABLE = 4

    }

}
