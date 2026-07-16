using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业资源规格信息。flavor_id和pool_id+[flavor_id]方式二选一。 - 选择公共资源池时，仅上送flavor_id，选择训练作业需要的卡数、内存等资源规格，当公共资源池空闲资源满足选择的规格需求时，作业可被调度； - 选择专属资源池时，需上送pool_id与flavor_id，选择专属资源池下可选的实际规格，即满足训练作业条件的最小卡数，以便节省专属资源，提高利用率。
    /// </summary>
    public class SpecResource 
    {

        /// <summary>
        /// **参数解释**：训练作业资源规格id。 **约束限制**：不涉及。 **取值范围**：CPU规格专属资源池不支持指定flavor_id。GPU/Ascend规格专属资源池可选取值如下： - modelarts.pool.visual.xlarge（1卡） - modelarts.pool.visual.2xlarge（2卡） - modelarts.pool.visual.4xlarge（4卡） - modelarts.pool.visual.8xlarge（8卡） - modelarts.pool.visual.16xlarge（16卡，当前仅限Snt9b23超节点资源池）  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：资源池创建训练作业使用节点数。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：默认单节点。
        /// </summary>
        [JsonProperty("node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// **参数解释**：专属资源池id。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释**：资源池联邦id。 **约束限制**：当kind为federated_pool_job时，该字段必填。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("pool_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("main_container_customized_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public MainContainerCustomizedFlavor MainContainerCustomizedFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecResource {\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  nodeCount: ").Append(NodeCount).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  poolGroupId: ").Append(PoolGroupId).Append("\n");
            sb.Append("  mainContainerCustomizedFlavor: ").Append(MainContainerCustomizedFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecResource input)
        {
            if (input == null) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.NodeCount != input.NodeCount || (this.NodeCount != null && !this.NodeCount.Equals(input.NodeCount))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.PoolGroupId != input.PoolGroupId || (this.PoolGroupId != null && !this.PoolGroupId.Equals(input.PoolGroupId))) return false;
            if (this.MainContainerCustomizedFlavor != input.MainContainerCustomizedFlavor || (this.MainContainerCustomizedFlavor != null && !this.MainContainerCustomizedFlavor.Equals(input.MainContainerCustomizedFlavor))) return false;

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
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.NodeCount != null) hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.PoolGroupId != null) hashCode = hashCode * 59 + this.PoolGroupId.GetHashCode();
                if (this.MainContainerCustomizedFlavor != null) hashCode = hashCode * 59 + this.MainContainerCustomizedFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
