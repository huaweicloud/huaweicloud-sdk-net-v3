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
    public class BatchUpdatePoolNodesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：更新成功的节点名称列表。
        /// </summary>
        [JsonProperty("successNodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessNodeNames { get; set; }

        /// <summary>
        /// **参数解释**：更新失败的节点名称列表。
        /// </summary>
        [JsonProperty("failNodeNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FailNodeNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdatePoolNodesResponse {\n");
            sb.Append("  successNodeNames: ").Append(SuccessNodeNames).Append("\n");
            sb.Append("  failNodeNames: ").Append(FailNodeNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdatePoolNodesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdatePoolNodesResponse input)
        {
            if (input == null) return false;
            if (this.SuccessNodeNames != input.SuccessNodeNames || (this.SuccessNodeNames != null && input.SuccessNodeNames != null && !this.SuccessNodeNames.SequenceEqual(input.SuccessNodeNames))) return false;
            if (this.FailNodeNames != input.FailNodeNames || (this.FailNodeNames != null && input.FailNodeNames != null && !this.FailNodeNames.SequenceEqual(input.FailNodeNames))) return false;

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
                if (this.SuccessNodeNames != null) hashCode = hashCode * 59 + this.SuccessNodeNames.GetHashCode();
                if (this.FailNodeNames != null) hashCode = hashCode * 59 + this.FailNodeNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
