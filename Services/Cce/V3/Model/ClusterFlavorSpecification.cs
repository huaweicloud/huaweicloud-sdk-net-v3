using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释**： 集群可售卖规格详情
    /// </summary>
    public class ClusterFlavorSpecification 
    {

        /// <summary>
        /// **参数解释**： 规格名称 **取值范围**： - cce.s1.small: 小规模单控制节点CCE集群（最大50节点） - cce.s1.medium: 中等规模单控制节点CCE集群（最大200节点） - cce.s2.small: 小规模三控制节点CCE集群（最大50节点） - cce.s2.medium: 中等规模三控制节点CCE集群（最大200节点） - cce.s2.large: 大规模三控制节点CCE集群（最大1000节点） - cce.s2.xlarge: 超大规模三控制节点CCE集群（最大2000节点） [- cce.s3.small: 小规模五控制节点CCE集群（最大50节点）](tag:hcs,hcs_sm) [- cce.s3.medium: 中等规模五控制节点CCE集群（最大200节点）](tag:hcs,hcs_sm) [- cce.s3.large: 大规模五控制节点CCE集群（最大1000节点）](tag:hcs,hcs_sm) [- cce.s3.xlarge: 超大规模五控制节点CCE集群（最大2000节点）](tag:hcs,hcs_sm)  [专属云特殊规格如下：](tag:hws,hws_hk,hcs,hcs_sm) [- cce.dec.s1.small: 小规模单控制节点的专属云CCE集群（最大50节点）](tag:hws,hws_hk) [- cce.dec.s1.medium: 中等规模单控制节点的专属云CCE集群（最大200节点）](tag:hws,hws_hk) [- cce.dec.s1.large: 大规模单控制节点的专属云CCE集群（最大1000节点）](tag:hws,hws_hk) [- cce.dec.s1.xlarge: 超大规模单控制节点的专属云CCE集群（最大2000节点）](tag:hws,hws_hk) [- cce.dec.s2.small: 小规模三控制节点的专属云CCE集群（最大50节点）](tag:hws,hws_hk) [- cce.dec.s2.medium: 中等规模三控制节点的专属云CCE集群（最大200节点）](tag:hws,hws_hk) [- cce.dec.s2.large: 大规模三控制节点的专属云CCE集群（最大1000节点）](tag:hws,hws_hk) [- cce.dec.s2.xlarge: 超大规模三控制节点的专属云CCE集群（最大2000节点）](tag:hws,hws_hk) [- cce.dec.s3.small: 小规模五控制节点的专属云CCE集群（最大50节点）](tag:hcs,hcs_sm) [- cce.dec.s3.medium: 中等规模五控制节点的专属云CCE集群（最大200节点）](tag:hcs,hcs_sm) [- cce.dec.s3.large: 大规模五控制节点的专属云CCE集群（最大1000节点）](tag:hcs,hcs_sm) [- cce.dec.s3.xlarge: 超大规模五控制节点的专属云CCE集群（最大2000节点）](tag:hcs,hcs_sm)
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 集群节点规模 **取值范围**： - 50: 最大支持50节点 - 200: 最大支持200节点 - 100: 最大支持1000节点 - 2000: 最大支持2000节点
        /// </summary>
        [JsonProperty("nodeCapacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCapacity { get; set; }

        /// <summary>
        /// **参数解释**： 控制节点详情
        /// </summary>
        [JsonProperty("availableMasterFlavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<MasterFlavorSpec> AvailableMasterFlavors { get; set; }

        /// <summary>
        /// **参数解释**： 集群规格是否售罄 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("isSoldOut", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSoldOut { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持控制节点多可用区分布 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("isSupportMultiAZ", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportMultiAZ { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterFlavorSpecification {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nodeCapacity: ").Append(NodeCapacity).Append("\n");
            sb.Append("  availableMasterFlavors: ").Append(AvailableMasterFlavors).Append("\n");
            sb.Append("  isSoldOut: ").Append(IsSoldOut).Append("\n");
            sb.Append("  isSupportMultiAZ: ").Append(IsSupportMultiAZ).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterFlavorSpecification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterFlavorSpecification input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NodeCapacity != input.NodeCapacity || (this.NodeCapacity != null && !this.NodeCapacity.Equals(input.NodeCapacity))) return false;
            if (this.AvailableMasterFlavors != input.AvailableMasterFlavors || (this.AvailableMasterFlavors != null && input.AvailableMasterFlavors != null && !this.AvailableMasterFlavors.SequenceEqual(input.AvailableMasterFlavors))) return false;
            if (this.IsSoldOut != input.IsSoldOut || (this.IsSoldOut != null && !this.IsSoldOut.Equals(input.IsSoldOut))) return false;
            if (this.IsSupportMultiAZ != input.IsSupportMultiAZ || (this.IsSupportMultiAZ != null && !this.IsSupportMultiAZ.Equals(input.IsSupportMultiAZ))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeCapacity != null) hashCode = hashCode * 59 + this.NodeCapacity.GetHashCode();
                if (this.AvailableMasterFlavors != null) hashCode = hashCode * 59 + this.AvailableMasterFlavors.GetHashCode();
                if (this.IsSoldOut != null) hashCode = hashCode * 59 + this.IsSoldOut.GetHashCode();
                if (this.IsSupportMultiAZ != null) hashCode = hashCode * 59 + this.IsSupportMultiAZ.GetHashCode();
                return hashCode;
            }
        }
    }
}
