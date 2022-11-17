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
    public class BatchCreateNatGatewayDnatRulesResponse : SdkResponse
    {

        /// <summary>
        /// DNAT规则批量创建对象的响应体。
        /// </summary>
        [JsonProperty("dnat_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<NatGatewayDnatRuleResponseBody> DnatRules { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateNatGatewayDnatRulesResponse {\n");
            sb.Append("  dnatRules: ").Append(DnatRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateNatGatewayDnatRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateNatGatewayDnatRulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnatRules == input.DnatRules ||
                    this.DnatRules != null &&
                    input.DnatRules != null &&
                    this.DnatRules.SequenceEqual(input.DnatRules)
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
                if (this.DnatRules != null)
                    hashCode = hashCode * 59 + this.DnatRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
