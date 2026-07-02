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
    /// **参数解释**：  设置动态Serverless算力策略请求体。  **约束限制**：  不涉及。
    /// </summary>
    public class UpdateDynamicServerlessPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**：   最小动态Serverless算力。  **取值范围**：  取值范围可根据[查询动态Serverless算力策略](https://support.huaweicloud.com/api-taurusdb/ShowDynamicServerlessPolicy.html)接口获取，并且小于等于max_vcpus。
        /// </summary>
        [JsonProperty("min_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVcpus { get; set; }

        /// <summary>
        /// **参数解释**：   最大动态Serverless算力。  **取值范围**：  取值范围可根据[查询动态Serverless算力策略](https://support.huaweicloud.com/api-taurusdb/ShowDynamicServerlessPolicy.html)接口获取，并且大于等于min_vcpus。
        /// </summary>
        [JsonProperty("max_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  节点算力同步，修改算力范围的同时，是否将小于最小算力的节点的当前算力同步至最小算力。  **约束限制**：  不涉及。  **取值范围**： - true: 节点算力同步。 - false: 节点算力不同步。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("need_update_nodes_compute_ability", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedUpdateNodesComputeAbility { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDynamicServerlessPolicyRequestBody {\n");
            sb.Append("  minVcpus: ").Append(MinVcpus).Append("\n");
            sb.Append("  maxVcpus: ").Append(MaxVcpus).Append("\n");
            sb.Append("  needUpdateNodesComputeAbility: ").Append(NeedUpdateNodesComputeAbility).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDynamicServerlessPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDynamicServerlessPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.MinVcpus != input.MinVcpus || (this.MinVcpus != null && !this.MinVcpus.Equals(input.MinVcpus))) return false;
            if (this.MaxVcpus != input.MaxVcpus || (this.MaxVcpus != null && !this.MaxVcpus.Equals(input.MaxVcpus))) return false;
            if (this.NeedUpdateNodesComputeAbility != input.NeedUpdateNodesComputeAbility || (this.NeedUpdateNodesComputeAbility != null && !this.NeedUpdateNodesComputeAbility.Equals(input.NeedUpdateNodesComputeAbility))) return false;

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
                return hashCode;
            }
        }
    }
}
