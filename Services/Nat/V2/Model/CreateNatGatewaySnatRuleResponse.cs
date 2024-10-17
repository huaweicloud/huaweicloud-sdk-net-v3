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
    public class CreateNatGatewaySnatRuleResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snat_rule", NullValueHandling = NullValueHandling.Ignore)]
        public CreateNatGatewaySnatRuleResponseBody SnatRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNatGatewaySnatRuleResponse {\n");
            sb.Append("  snatRule: ").Append(SnatRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNatGatewaySnatRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNatGatewaySnatRuleResponse input)
        {
            if (input == null) return false;
            if (this.SnatRule != input.SnatRule || (this.SnatRule != null && !this.SnatRule.Equals(input.SnatRule))) return false;

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
                if (this.SnatRule != null) hashCode = hashCode * 59 + this.SnatRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
