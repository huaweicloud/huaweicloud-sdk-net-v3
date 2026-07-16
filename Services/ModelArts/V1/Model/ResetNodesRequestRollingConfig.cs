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
    /// **参数解释**：节点重置是滚动配置。 **约束限制**：不涉及。
    /// </summary>
    public class ResetNodesRequestRollingConfig 
    {

        /// <summary>
        /// **参数解释**：滚动策略。 **约束限制**：不涉及。 **取值范围**：可选值如下： - RollingByNumber：表示按节点数量设置最大同时重置节点数量，例如10，表示单次最多重置10个节点 - RollingByPercent：表示按百分比设置最大同时重置节点数量。例如10，表示单次最多重置10%的节点 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }

        /// <summary>
        /// **参数解释**：滚动重置的节点数量或者节点比例, 当strategy为RollingByNumber时,表示允许同时重置的节点数量, 当strategy为RollingByPercent时,表示允许同时重置的最大节点比例。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("maxUnavailable", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxUnavailable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetNodesRequestRollingConfig {\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  maxUnavailable: ").Append(MaxUnavailable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetNodesRequestRollingConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetNodesRequestRollingConfig input)
        {
            if (input == null) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;
            if (this.MaxUnavailable != input.MaxUnavailable || (this.MaxUnavailable != null && !this.MaxUnavailable.Equals(input.MaxUnavailable))) return false;

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
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.MaxUnavailable != null) hashCode = hashCode * 59 + this.MaxUnavailable.GetHashCode();
                return hashCode;
            }
        }
    }
}
