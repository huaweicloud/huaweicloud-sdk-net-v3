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
    public class ResizeNodeInfo 
    {

        /// <summary>
        /// **参数解释**：节点批次ID，批次变更时需要，可以从节点的os.modelarts.node/batch.uid标签中获取。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("batchUID", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchUID { get; set; }

        /// <summary>
        /// **参数解释**：批次缩容场景，指定要缩容的节点名称列表。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("deleteNodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeleteNodeNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeNodeInfo {\n");
            sb.Append("  batchUID: ").Append(BatchUID).Append("\n");
            sb.Append("  deleteNodeNames: ").Append(DeleteNodeNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeNodeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeNodeInfo input)
        {
            if (input == null) return false;
            if (this.BatchUID != input.BatchUID || (this.BatchUID != null && !this.BatchUID.Equals(input.BatchUID))) return false;
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
                if (this.BatchUID != null) hashCode = hashCode * 59 + this.BatchUID.GetHashCode();
                if (this.DeleteNodeNames != null) hashCode = hashCode * 59 + this.DeleteNodeNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
