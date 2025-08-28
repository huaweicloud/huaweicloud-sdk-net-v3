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
    /// 拓扑结构。 - p2p（点对点拓扑） - mesh （网状拓扑） - star （星形拓扑） - hybrid （混合拓扑）
    /// </summary>
    /// <value>拓扑结构。 - p2p（点对点拓扑） - mesh （网状拓扑） - star （星形拓扑） - hybrid （混合拓扑）</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteNetworkTopologyEnum
    {
        /// <summary>
        /// Enum P2P for value: p2p
        /// </summary>
        [EnumMember(Value = "p2p")]
        P2P = 1,

        /// <summary>
        /// Enum MESH for value: mesh
        /// </summary>
        [EnumMember(Value = "mesh")]
        MESH = 2,

        /// <summary>
        /// Enum STAR for value: star
        /// </summary>
        [EnumMember(Value = "star")]
        STAR = 3,

        /// <summary>
        /// Enum HYBRID for value: hybrid
        /// </summary>
        [EnumMember(Value = "hybrid")]
        HYBRID = 4

    }

}
