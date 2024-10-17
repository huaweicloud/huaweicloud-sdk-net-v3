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
    public class UpdateNatGatewayDnatRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dnat_rule", NullValueHandling = NullValueHandling.Ignore)]
        public NatGatewayDnatRuleResponseBody DnatRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNatGatewayDnatRuleResponse {\n");
            sb.Append("  dnatRule: ").Append(DnatRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNatGatewayDnatRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNatGatewayDnatRuleResponse input)
        {
            if (input == null) return false;
            if (this.DnatRule != input.DnatRule || (this.DnatRule != null && !this.DnatRule.Equals(input.DnatRule))) return false;

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
                if (this.DnatRule != null) hashCode = hashCode * 59 + this.DnatRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
