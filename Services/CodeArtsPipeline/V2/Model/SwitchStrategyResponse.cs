using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SwitchStrategyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 更新状态是否成功。 **取值范围**： - true：状态更新成功。 - false：状态更新失败。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status { get; set; }

        /// <summary>
        /// **参数解释**： 更新的策略ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("rule_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchStrategyResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ruleSetId: ").Append(RuleSetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchStrategyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchStrategyResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RuleSetId != input.RuleSetId || (this.RuleSetId != null && !this.RuleSetId.Equals(input.RuleSetId))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RuleSetId != null) hashCode = hashCode * 59 + this.RuleSetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
