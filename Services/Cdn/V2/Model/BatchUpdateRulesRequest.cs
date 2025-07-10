using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 批量更新规则状态和优先级 **约束限制：** 不涉及
    /// </summary>
    public class BatchUpdateRulesRequest 
    {

        /// <summary>
        /// **参数解释：** 规则列表 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateRuleStatusRequest> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateRulesRequest {\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateRulesRequest input)
        {
            if (input == null) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
