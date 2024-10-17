using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SqlRuleRequest 
    {

        /// <summary>
        /// 风险级别 - HIGH - MEDIUM - LOW - NO_RISK
        /// </summary>
        [JsonProperty("risk_levels", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskLevels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlRuleRequest {\n");
            sb.Append("  riskLevels: ").Append(RiskLevels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlRuleRequest input)
        {
            if (input == null) return false;
            if (this.RiskLevels != input.RiskLevels || (this.RiskLevels != null && !this.RiskLevels.Equals(input.RiskLevels))) return false;

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
                if (this.RiskLevels != null) hashCode = hashCode * 59 + this.RiskLevels.GetHashCode();
                return hashCode;
            }
        }
    }
}
