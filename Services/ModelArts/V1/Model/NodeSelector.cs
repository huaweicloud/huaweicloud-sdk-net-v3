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
    public class NodeSelector 
    {

        /// <summary>
        /// **参数解释**：必填项。节点选择器项的列表。这些项是“或”的关系。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("nodeSelectorTerms", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeSelectorTerm> NodeSelectorTerms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSelector {\n");
            sb.Append("  nodeSelectorTerms: ").Append(NodeSelectorTerms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSelector);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSelector input)
        {
            if (input == null) return false;
            if (this.NodeSelectorTerms != input.NodeSelectorTerms || (this.NodeSelectorTerms != null && input.NodeSelectorTerms != null && !this.NodeSelectorTerms.SequenceEqual(input.NodeSelectorTerms))) return false;

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
                if (this.NodeSelectorTerms != null) hashCode = hashCode * 59 + this.NodeSelectorTerms.GetHashCode();
                return hashCode;
            }
        }
    }
}
