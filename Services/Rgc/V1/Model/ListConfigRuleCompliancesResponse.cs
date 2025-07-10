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
    /// Response Object
    /// </summary>
    public class ListConfigRuleCompliancesResponse : SdkResponse
    {

        /// <summary>
        /// 纳管账号ID
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// Config规则合规性信息
        /// </summary>
        [JsonProperty("config_rule_compliances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigRuleCompliance> ConfigRuleCompliances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigRuleCompliancesResponse {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  configRuleCompliances: ").Append(ConfigRuleCompliances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigRuleCompliancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigRuleCompliancesResponse input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.ConfigRuleCompliances != input.ConfigRuleCompliances || (this.ConfigRuleCompliances != null && input.ConfigRuleCompliances != null && !this.ConfigRuleCompliances.SequenceEqual(input.ConfigRuleCompliances))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.ConfigRuleCompliances != null) hashCode = hashCode * 59 + this.ConfigRuleCompliances.GetHashCode();
                return hashCode;
            }
        }
    }
}
