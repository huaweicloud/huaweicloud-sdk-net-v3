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
    /// **参数解释**：空节点选择器或空节点选择器项不匹配任何对象。 **约束限制**：要求是按“与”（AND）逻辑进行组合。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeSelectorTerm 
    {

        /// <summary>
        /// **参数解释**：按节点标签列出的节点选择器要求。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("matchExpressions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeSelectorRequirement> MatchExpressions { get; set; }

        /// <summary>
        /// **参数解释**：按节点字段列出的节点选择器要求。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("matchFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeSelectorRequirement> MatchFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSelectorTerm {\n");
            sb.Append("  matchExpressions: ").Append(MatchExpressions).Append("\n");
            sb.Append("  matchFields: ").Append(MatchFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSelectorTerm);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSelectorTerm input)
        {
            if (input == null) return false;
            if (this.MatchExpressions != input.MatchExpressions || (this.MatchExpressions != null && input.MatchExpressions != null && !this.MatchExpressions.SequenceEqual(input.MatchExpressions))) return false;
            if (this.MatchFields != input.MatchFields || (this.MatchFields != null && input.MatchFields != null && !this.MatchFields.SequenceEqual(input.MatchFields))) return false;

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
                if (this.MatchExpressions != null) hashCode = hashCode * 59 + this.MatchExpressions.GetHashCode();
                if (this.MatchFields != null) hashCode = hashCode * 59 + this.MatchFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
