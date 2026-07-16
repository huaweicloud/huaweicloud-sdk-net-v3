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
    public class BatchBindPoolNodesReq 
    {

        /// <summary>
        /// **参数解释**：需要进行换绑的节点列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<BindNodeItem> Nodes { get; set; }

        /// <summary>
        /// **参数解释**：是否对换绑的节点进行排水。 **约束限制**：不涉及。 **取值范围**： - true：排水 - false：不排水 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("drain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Drain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchBindPoolNodesReq {\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  drain: ").Append(Drain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchBindPoolNodesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchBindPoolNodesReq input)
        {
            if (input == null) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.Drain != input.Drain || (this.Drain != null && !this.Drain.Equals(input.Drain))) return false;

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
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Drain != null) hashCode = hashCode * 59 + this.Drain.GetHashCode();
                return hashCode;
            }
        }
    }
}
