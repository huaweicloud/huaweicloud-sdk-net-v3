using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DdmGroupInfo 
    {

        /// <summary>
        /// **参数解释**：  组ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  名称。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  角色。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// **参数解释**：  组ip。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// **参数解释**：  ipv6。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("ipv6_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6Endpoint { get; set; }

        /// <summary>
        /// **参数解释**：  节点数量。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// **参数解释**：  负载均衡。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("load_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadBalance { get; set; }

        /// <summary>
        /// **参数解释**：  是否默认组。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("is_default_group", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultGroup { get; set; }

        /// <summary>
        /// **参数解释**：  其他信息。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("extend_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtendMap { get; set; }

        /// <summary>
        /// **参数解释**：  节点信息。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DdmNodeInfo> Nodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DdmGroupInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  ipv6Endpoint: ").Append(Ipv6Endpoint).Append("\n");
            sb.Append("  nodeCount: ").Append(NodeCount).Append("\n");
            sb.Append("  loadBalance: ").Append(LoadBalance).Append("\n");
            sb.Append("  isDefaultGroup: ").Append(IsDefaultGroup).Append("\n");
            sb.Append("  extendMap: ").Append(ExtendMap).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DdmGroupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DdmGroupInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.Ipv6Endpoint != input.Ipv6Endpoint || (this.Ipv6Endpoint != null && !this.Ipv6Endpoint.Equals(input.Ipv6Endpoint))) return false;
            if (this.NodeCount != input.NodeCount || (this.NodeCount != null && !this.NodeCount.Equals(input.NodeCount))) return false;
            if (this.LoadBalance != input.LoadBalance || (this.LoadBalance != null && !this.LoadBalance.Equals(input.LoadBalance))) return false;
            if (this.IsDefaultGroup != input.IsDefaultGroup || (this.IsDefaultGroup != null && !this.IsDefaultGroup.Equals(input.IsDefaultGroup))) return false;
            if (this.ExtendMap != input.ExtendMap || (this.ExtendMap != null && input.ExtendMap != null && !this.ExtendMap.SequenceEqual(input.ExtendMap))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.Ipv6Endpoint != null) hashCode = hashCode * 59 + this.Ipv6Endpoint.GetHashCode();
                if (this.NodeCount != null) hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.LoadBalance != null) hashCode = hashCode * 59 + this.LoadBalance.GetHashCode();
                if (this.IsDefaultGroup != null) hashCode = hashCode * 59 + this.IsDefaultGroup.GetHashCode();
                if (this.ExtendMap != null) hashCode = hashCode * 59 + this.ExtendMap.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
