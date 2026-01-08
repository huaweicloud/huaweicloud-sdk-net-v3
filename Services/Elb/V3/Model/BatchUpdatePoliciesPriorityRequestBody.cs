using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class BatchUpdatePoliciesPriorityRequestBody 
    {

        /// <summary>
        /// **参数解释**：批量更新转发策略优先级的请求参数。  **约束限制**：不涉及
        /// </summary>
        [JsonProperty("l7policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchUpdatePriorityRequestBody> L7policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdatePoliciesPriorityRequestBody {\n");
            sb.Append("  l7policies: ").Append(L7policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdatePoliciesPriorityRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdatePoliciesPriorityRequestBody input)
        {
            if (input == null) return false;
            if (this.L7policies != input.L7policies || (this.L7policies != null && input.L7policies != null && !this.L7policies.SequenceEqual(input.L7policies))) return false;

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
                if (this.L7policies != null) hashCode = hashCode * 59 + this.L7policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
