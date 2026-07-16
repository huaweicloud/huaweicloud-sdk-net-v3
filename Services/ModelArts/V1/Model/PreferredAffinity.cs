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
    /// 
    /// </summary>
    public class PreferredAffinity 
    {

        /// <summary>
        /// **参数解释**：调度器会优先将Pod调度到满足该字段指定的亲和性表达式的节点上，但它也可能选择违反一个或多个表达式的节点。最优先选择的节点是权重总和最大的节点，即对于每个满足所有调度要求（资源请求、调度期间必需的亲和性表达式等）的节点，通过遍历该字段的元素并计算总和，如果节点匹配相应的匹配表达式，则将“权重”加到总和中；权重总和最高的节点即为最优先选择的节点。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("node_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreferredSchedulingTerm> NodeAffinity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreferredAffinity {\n");
            sb.Append("  nodeAffinity: ").Append(NodeAffinity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreferredAffinity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreferredAffinity input)
        {
            if (input == null) return false;
            if (this.NodeAffinity != input.NodeAffinity || (this.NodeAffinity != null && input.NodeAffinity != null && !this.NodeAffinity.SequenceEqual(input.NodeAffinity))) return false;

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
                if (this.NodeAffinity != null) hashCode = hashCode * 59 + this.NodeAffinity.GetHashCode();
                return hashCode;
            }
        }
    }
}
