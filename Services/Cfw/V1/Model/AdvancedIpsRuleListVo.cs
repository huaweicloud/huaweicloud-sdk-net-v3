using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdvancedIpsRuleListVo 
    {

        /// <summary>
        /// 频率ips规则列表
        /// </summary>
        [JsonProperty("advanced_ips_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<AdvancedIpsRuleVo> AdvancedIpsRules { get; set; }

        /// <summary>
        /// 频率ips规则总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedIpsRuleListVo {\n");
            sb.Append("  advancedIpsRules: ").Append(AdvancedIpsRules).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdvancedIpsRuleListVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdvancedIpsRuleListVo input)
        {
            if (input == null) return false;
            if (this.AdvancedIpsRules != input.AdvancedIpsRules || (this.AdvancedIpsRules != null && input.AdvancedIpsRules != null && !this.AdvancedIpsRules.SequenceEqual(input.AdvancedIpsRules))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.AdvancedIpsRules != null) hashCode = hashCode * 59 + this.AdvancedIpsRules.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
