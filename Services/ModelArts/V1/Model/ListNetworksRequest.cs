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
    /// Request Object
    /// </summary>
    public class ListNetworksRequest 
    {

        /// <summary>
        /// **参数解释**：标签筛选。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("labelSelector", IsQuery = true)]
        [JsonProperty("labelSelector", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelSelector { get; set; }

        /// <summary>
        /// **参数解释**：分页单次查询返回的资源数量。 **约束限制**：不涉及。 **取值范围**：0 - 500。 **默认取值**：500。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：分页查询的偏移标志。取值来自用户上一次分页查询响应结果中metadata.continue中的值，值为空默认无偏移。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("continue", IsQuery = true)]
        [JsonProperty("continue", NullValueHandling = NullValueHandling.Ignore)]
        public string Continue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNetworksRequest {\n");
            sb.Append("  labelSelector: ").Append(LabelSelector).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  Continue: ").Append(Continue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNetworksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNetworksRequest input)
        {
            if (input == null) return false;
            if (this.LabelSelector != input.LabelSelector || (this.LabelSelector != null && !this.LabelSelector.Equals(input.LabelSelector))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Continue != input.Continue || (this.Continue != null && !this.Continue.Equals(input.Continue))) return false;

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
                if (this.LabelSelector != null) hashCode = hashCode * 59 + this.LabelSelector.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Continue != null) hashCode = hashCode * 59 + this.Continue.GetHashCode();
                return hashCode;
            }
        }
    }
}
