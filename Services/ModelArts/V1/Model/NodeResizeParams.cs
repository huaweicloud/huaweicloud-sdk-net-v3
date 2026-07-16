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
    /// 节点规格变更参数
    /// </summary>
    public class NodeResizeParams 
    {

        /// <summary>
        /// **参数解释**：节点池。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("nodePool", NullValueHandling = NullValueHandling.Ignore)]
        public string NodePool { get; set; }

        /// <summary>
        /// **参数解释**：规格。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：步长。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("creatingStep", NullValueHandling = NullValueHandling.Ignore)]
        public Object CreatingStep { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeResizeParams {\n");
            sb.Append("  nodePool: ").Append(NodePool).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  creatingStep: ").Append(CreatingStep).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeResizeParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeResizeParams input)
        {
            if (input == null) return false;
            if (this.NodePool != input.NodePool || (this.NodePool != null && !this.NodePool.Equals(input.NodePool))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.CreatingStep != input.CreatingStep || (this.CreatingStep != null && !this.CreatingStep.Equals(input.CreatingStep))) return false;

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
                if (this.NodePool != null) hashCode = hashCode * 59 + this.NodePool.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.CreatingStep != null) hashCode = hashCode * 59 + this.CreatingStep.GetHashCode();
                return hashCode;
            }
        }
    }
}
