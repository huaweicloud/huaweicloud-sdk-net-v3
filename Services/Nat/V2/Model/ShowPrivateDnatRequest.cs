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
    public class ShowPrivateDnatRequest 
    {

        /// <summary>
        /// DNAT规则的ID。
        /// </summary>
        [SDKProperty("dnat_rule_id", IsPath = true)]
        [JsonProperty("dnat_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DnatRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPrivateDnatRequest {\n");
            sb.Append("  dnatRuleId: ").Append(DnatRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPrivateDnatRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPrivateDnatRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnatRuleId == input.DnatRuleId ||
                    (this.DnatRuleId != null &&
                    this.DnatRuleId.Equals(input.DnatRuleId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DnatRuleId != null)
                    hashCode = hashCode * 59 + this.DnatRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
