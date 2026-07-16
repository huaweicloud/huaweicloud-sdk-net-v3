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
    /// 批量删除节点请求体。
    /// </summary>
    public class NodesDeletionRequest 
    {

        /// <summary>
        /// **参数解释**：待删除的节点名称列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("deleteNodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeleteNodeNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodesDeletionRequest {\n");
            sb.Append("  deleteNodeNames: ").Append(DeleteNodeNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodesDeletionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodesDeletionRequest input)
        {
            if (input == null) return false;
            if (this.DeleteNodeNames != input.DeleteNodeNames || (this.DeleteNodeNames != null && input.DeleteNodeNames != null && !this.DeleteNodeNames.SequenceEqual(input.DeleteNodeNames))) return false;

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
                if (this.DeleteNodeNames != null) hashCode = hashCode * 59 + this.DeleteNodeNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
