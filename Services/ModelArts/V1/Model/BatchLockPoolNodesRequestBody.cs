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
    public class BatchLockPoolNodesRequestBody 
    {

        /// <summary>
        /// **参数解释**：需要变更锁状态的节点名称列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("nodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// **参数解释**：变更的功能类型。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Actions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchLockPoolNodesRequestBody {\n");
            sb.Append("  nodeNames: ").Append(NodeNames).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchLockPoolNodesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchLockPoolNodesRequestBody input)
        {
            if (input == null) return false;
            if (this.NodeNames != input.NodeNames || (this.NodeNames != null && input.NodeNames != null && !this.NodeNames.SequenceEqual(input.NodeNames))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;

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
                if (this.NodeNames != null) hashCode = hashCode * 59 + this.NodeNames.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
