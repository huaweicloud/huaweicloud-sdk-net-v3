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
    /// Response Object
    /// </summary>
    public class ShowNatGatewaySnatRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snat_rule", NullValueHandling = NullValueHandling.Ignore)]
        public NatGatewaySnatRuleResponseBody SnatRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNatGatewaySnatRuleResponse {\n");
            sb.Append("  snatRule: ").Append(SnatRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNatGatewaySnatRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNatGatewaySnatRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SnatRule == input.SnatRule ||
                    (this.SnatRule != null &&
                    this.SnatRule.Equals(input.SnatRule))
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
                if (this.SnatRule != null)
                    hashCode = hashCode * 59 + this.SnatRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
