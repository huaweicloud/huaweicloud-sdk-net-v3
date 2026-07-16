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
    /// Response Object
    /// </summary>
    public class BatchRebootPoolNodesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：节点名称集合。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("nodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NodeNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRebootPoolNodesResponse {\n");
            sb.Append("  nodeNames: ").Append(NodeNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRebootPoolNodesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRebootPoolNodesResponse input)
        {
            if (input == null) return false;
            if (this.NodeNames != input.NodeNames || (this.NodeNames != null && input.NodeNames != null && !this.NodeNames.SequenceEqual(input.NodeNames))) return false;

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
                return hashCode;
            }
        }
    }
}
