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
    /// This is an auto create Body Object
    /// </summary>
    public class BatchCreateNatGatewayDnatRulesRequestBody 
    {

        /// <summary>
        /// DNAT规则批量创建对象的请求体。
        /// </summary>
        [JsonProperty("dnat_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateNatGatewayDnatOption> DnatRules { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateNatGatewayDnatRulesRequestBody {\n");
            sb.Append("  dnatRules: ").Append(DnatRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateNatGatewayDnatRulesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateNatGatewayDnatRulesRequestBody input)
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
