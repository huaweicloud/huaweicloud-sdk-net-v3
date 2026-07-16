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
    /// 节点的metadata信息。
    /// </summary>
    public class NodeListMetadata 
    {

        /// <summary>
        /// **参数解释**：分页查询的偏移标志。 **取值范围**：取值来自用户上一次分页查询响应结果中metadata.continue中的值，值为空默认无偏移。
        /// </summary>
        [JsonProperty("continue", NullValueHandling = NullValueHandling.Ignore)]
        public string Continue { get; set; }

        /// <summary>
        /// **参数解释**：分页查询中剩余资源的数量。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("remainingItemCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? RemainingItemCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeListMetadata {\n");
            sb.Append("  Continue: ").Append(Continue).Append("\n");
            sb.Append("  remainingItemCount: ").Append(RemainingItemCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeListMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeListMetadata input)
        {
            if (input == null) return false;
            if (this.Continue != input.Continue || (this.Continue != null && !this.Continue.Equals(input.Continue))) return false;
            if (this.RemainingItemCount != input.RemainingItemCount || (this.RemainingItemCount != null && !this.RemainingItemCount.Equals(input.RemainingItemCount))) return false;

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
                if (this.Continue != null) hashCode = hashCode * 59 + this.Continue.GetHashCode();
                if (this.RemainingItemCount != null) hashCode = hashCode * 59 + this.RemainingItemCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
