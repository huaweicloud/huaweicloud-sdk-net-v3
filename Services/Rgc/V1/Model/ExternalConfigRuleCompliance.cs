using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExternalConfigRuleCompliance 
    {

        /// <summary>
        /// 合规规则。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 合规状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 控制策略ID。
        /// </summary>
        [JsonProperty("control_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalConfigRuleCompliance {\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  controlId: ").Append(ControlId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalConfigRuleCompliance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalConfigRuleCompliance input)
        {
            if (input == null) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ControlId != input.ControlId || (this.ControlId != null && !this.ControlId.Equals(input.ControlId))) return false;

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
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ControlId != null) hashCode = hashCode * 59 + this.ControlId.GetHashCode();
                return hashCode;
            }
        }
    }
}
