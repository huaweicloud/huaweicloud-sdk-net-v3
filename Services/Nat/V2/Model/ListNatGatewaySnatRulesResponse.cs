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
    public class ListNatGatewaySnatRulesResponse : SdkResponse
    {

        /// <summary>
        /// 查询SNAT规则列表的响应体。
        /// </summary>
        [JsonProperty("snat_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<NatGatewaySnatRuleResponseBody> SnatRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNatGatewaySnatRulesResponse {\n");
            sb.Append("  snatRules: ").Append(SnatRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNatGatewaySnatRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNatGatewaySnatRulesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SnatRules == input.SnatRules ||
                    this.SnatRules != null &&
                    input.SnatRules != null &&
                    this.SnatRules.SequenceEqual(input.SnatRules)
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
                if (this.SnatRules != null)
                    hashCode = hashCode * 59 + this.SnatRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
