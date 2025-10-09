using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数解释**：  设置serverless算力配置策略请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class UpdateServerlessComputeAbilityPolicy 
    {

        /// <summary>
        /// **参数解释**：  单节点VCPUs伸缩下限。  **约束限制**：  不涉及。  **取值范围**：  取值范围可根据[查询数据库规格](https://support.huaweicloud.com/api-taurusdb/ShowGaussMySqlFlavors.html)接口获取。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("min_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  单节点VCPUs伸缩上限。  **约束限制**：  不涉及。  **取值范围**：  ≥4。取值范围可根据[查询数据库规格](https://support.huaweicloud.com/api-taurusdb/ShowGaussMySqlFlavors.html)接口获取。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("max_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  节点算力同步，修改算力范围的同时，是否将小于最小算力的节点的当前算力同步至最小算力。  **约束限制**：  不涉及。  **取值范围**： - true: 节点算力同步。 - false: 节点算力不同步。  **默认取值**： false。
        /// </summary>
        [JsonProperty("need_update_nodes_compute_ability", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedUpdateNodesComputeAbility { get; set; }

        /// <summary>
        /// **参数解释**：  是否增删只读节点。  **约束限制**：  - 存在数据库代理时，才可以使用增删只读节点功能。  - 使用增删节点功能时，避免使用读内网地址连接应用。  - 打开增删只读节点后，数据库代理的路由模式会变为负载均衡模式。  **取值范围**： - true: 开启增删只读节点。 - false: 不开启增删只读节点。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("scale_out_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScaleOutSwitch { get; set; }

        /// <summary>
        /// **参数解释**：  只读节点数量上限。  **约束限制**：  开启增删只读节点时才会生效, 且开启增删只读节点时该参数必选。  **取值范围**：  2-7。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("max_readonly_node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReadonlyNodeCount { get; set; }

        /// <summary>
        /// **参数解释**：  只读节点数量上限。  **约束限制**：  开启增删只读节点时才会生效, 且开启增删只读节点时该参数必选。  **取值范围**：  1-6。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("min_readonly_node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReadonlyNodeCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerlessComputeAbilityPolicy {\n");
            sb.Append("  minVcpus: ").Append(MinVcpus).Append("\n");
            sb.Append("  maxVcpus: ").Append(MaxVcpus).Append("\n");
            sb.Append("  needUpdateNodesComputeAbility: ").Append(NeedUpdateNodesComputeAbility).Append("\n");
            sb.Append("  scaleOutSwitch: ").Append(ScaleOutSwitch).Append("\n");
            sb.Append("  maxReadonlyNodeCount: ").Append(MaxReadonlyNodeCount).Append("\n");
            sb.Append("  minReadonlyNodeCount: ").Append(MinReadonlyNodeCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerlessComputeAbilityPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerlessComputeAbilityPolicy input)
        {
            if (input == null) return false;
            if (this.MinVcpus != input.MinVcpus || (this.MinVcpus != null && !this.MinVcpus.Equals(input.MinVcpus))) return false;
            if (this.MaxVcpus != input.MaxVcpus || (this.MaxVcpus != null && !this.MaxVcpus.Equals(input.MaxVcpus))) return false;
            if (this.NeedUpdateNodesComputeAbility != input.NeedUpdateNodesComputeAbility || (this.NeedUpdateNodesComputeAbility != null && !this.NeedUpdateNodesComputeAbility.Equals(input.NeedUpdateNodesComputeAbility))) return false;
            if (this.ScaleOutSwitch != input.ScaleOutSwitch || (this.ScaleOutSwitch != null && !this.ScaleOutSwitch.Equals(input.ScaleOutSwitch))) return false;
            if (this.MaxReadonlyNodeCount != input.MaxReadonlyNodeCount || (this.MaxReadonlyNodeCount != null && !this.MaxReadonlyNodeCount.Equals(input.MaxReadonlyNodeCount))) return false;
            if (this.MinReadonlyNodeCount != input.MinReadonlyNodeCount || (this.MinReadonlyNodeCount != null && !this.MinReadonlyNodeCount.Equals(input.MinReadonlyNodeCount))) return false;

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
                if (this.MinVcpus != null) hashCode = hashCode * 59 + this.MinVcpus.GetHashCode();
                if (this.MaxVcpus != null) hashCode = hashCode * 59 + this.MaxVcpus.GetHashCode();
                if (this.NeedUpdateNodesComputeAbility != null) hashCode = hashCode * 59 + this.NeedUpdateNodesComputeAbility.GetHashCode();
                if (this.ScaleOutSwitch != null) hashCode = hashCode * 59 + this.ScaleOutSwitch.GetHashCode();
                if (this.MaxReadonlyNodeCount != null) hashCode = hashCode * 59 + this.MaxReadonlyNodeCount.GetHashCode();
                if (this.MinReadonlyNodeCount != null) hashCode = hashCode * 59 + this.MinReadonlyNodeCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
