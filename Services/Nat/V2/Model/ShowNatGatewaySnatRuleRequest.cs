using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowNatGatewaySnatRuleRequest 
    {

        /// <summary>
        /// SNAT规则的ID。
        /// </summary>
        [SDKProperty("snat_rule_id", IsPath = true)]
        [JsonProperty("snat_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnatRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNatGatewaySnatRuleRequest {\n");
            sb.Append("  snatRuleId: ").Append(SnatRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNatGatewaySnatRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNatGatewaySnatRuleRequest input)
        {
            if (input == null) return false;
            if (this.SnatRuleId != input.SnatRuleId || (this.SnatRuleId != null && !this.SnatRuleId.Equals(input.SnatRuleId))) return false;

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
                if (this.SnatRuleId != null) hashCode = hashCode * 59 + this.SnatRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
