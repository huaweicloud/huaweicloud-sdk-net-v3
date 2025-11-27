using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RuleInfo 
    {

        /// <summary>
        /// 权限策略id
        /// </summary>
        [JsonProperty("ruleID", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleID { get; set; }

        /// <summary>
        /// 权限策略名字
        /// </summary>
        [JsonProperty("ruleName", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleInfo {\n");
            sb.Append("  ruleID: ").Append(RuleID).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleInfo input)
        {
            if (input == null) return false;
            if (this.RuleID != input.RuleID || (this.RuleID != null && !this.RuleID.Equals(input.RuleID))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;

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
                if (this.RuleID != null) hashCode = hashCode * 59 + this.RuleID.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
