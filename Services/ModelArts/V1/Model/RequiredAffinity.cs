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
    /// 训练作业亲和要求
    /// </summary>
    public class RequiredAffinity 
    {

        /// <summary>
        /// **参数解释**：亲和调度策略。 **约束限制**：不涉及。 **取值范围**： - cabinet：强整柜调度 - hyperinstance：超节点亲和调度 - networkTopology: 网络拓扑亲和调度  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("affinity_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AffinityType { get; set; }

        /// <summary>
        /// **参数解释**：作业整体的网络拓扑约束。 **约束限制**：affinity_type为networkTopology时有效，系统会将作业的所有task调度至不高于job_level层的节点组中。 用户向超节点资源池投递训练作业，如果未设置作业整体的网络拓扑约束，系统会默认赋值为cluster。 **取值范围**： - cluster：资源池级 - hyperinstanceGroup: 超节点级  **默认取值**：默认值cluster。
        /// </summary>
        [JsonProperty("job_level", NullValueHandling = NullValueHandling.Ignore)]
        public string JobLevel { get; set; }

        /// <summary>
        /// **参数解释**：亲和组大小。 **约束限制**：affinity_type为hyperinstance或networkTopology时必填，系统会将affinity_group_size个task调度到一个超节点内组成亲和组。affinity_group_size的大小不能超过超节点的步长。 用户向超节点资源池投递训练作业，如果未设置亲和组大小，系统会默认赋值为1。 **取值范围**：不涉及。 **默认取值**：默认值1。
        /// </summary>
        [JsonProperty("affinity_group_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffinityGroupSize { get; set; }

        /// <summary>
        /// **参数解释**：亲和组的网络拓扑约束。 **约束限制**：affinity_type为networkTopology时有效，系统会将affinity_group_size个task组成的亲和组调度至不高于affinity_group_level层的节点组中。 用户向超节点资源池投递训练作业，如果未设置亲和组的网络拓扑约束，系统会默认赋值为hyperinstanceGroup。 **取值范围**： - hyperinstance：超节点级 - slice: 柜级  **默认取值**：默认值hyperinstanceGroup。
        /// </summary>
        [JsonProperty("affinity_group_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AffinityGroupLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSelector NodeAffinity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequiredAffinity {\n");
            sb.Append("  affinityType: ").Append(AffinityType).Append("\n");
            sb.Append("  jobLevel: ").Append(JobLevel).Append("\n");
            sb.Append("  affinityGroupSize: ").Append(AffinityGroupSize).Append("\n");
            sb.Append("  affinityGroupLevel: ").Append(AffinityGroupLevel).Append("\n");
            sb.Append("  nodeAffinity: ").Append(NodeAffinity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RequiredAffinity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RequiredAffinity input)
        {
            if (input == null) return false;
            if (this.AffinityType != input.AffinityType || (this.AffinityType != null && !this.AffinityType.Equals(input.AffinityType))) return false;
            if (this.JobLevel != input.JobLevel || (this.JobLevel != null && !this.JobLevel.Equals(input.JobLevel))) return false;
            if (this.AffinityGroupSize != input.AffinityGroupSize || (this.AffinityGroupSize != null && !this.AffinityGroupSize.Equals(input.AffinityGroupSize))) return false;
            if (this.AffinityGroupLevel != input.AffinityGroupLevel || (this.AffinityGroupLevel != null && !this.AffinityGroupLevel.Equals(input.AffinityGroupLevel))) return false;
            if (this.NodeAffinity != input.NodeAffinity || (this.NodeAffinity != null && !this.NodeAffinity.Equals(input.NodeAffinity))) return false;

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
                if (this.AffinityType != null) hashCode = hashCode * 59 + this.AffinityType.GetHashCode();
                if (this.JobLevel != null) hashCode = hashCode * 59 + this.JobLevel.GetHashCode();
                if (this.AffinityGroupSize != null) hashCode = hashCode * 59 + this.AffinityGroupSize.GetHashCode();
                if (this.AffinityGroupLevel != null) hashCode = hashCode * 59 + this.AffinityGroupLevel.GetHashCode();
                if (this.NodeAffinity != null) hashCode = hashCode * 59 + this.NodeAffinity.GetHashCode();
                return hashCode;
            }
        }
    }
}
