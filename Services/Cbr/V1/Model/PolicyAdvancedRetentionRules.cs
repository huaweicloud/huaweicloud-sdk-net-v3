using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 按照时间的高级保留策略
    /// </summary>
    public class PolicyAdvancedRetentionRules 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("weekly_retention_rules", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyWeeklyRetentionRules WeeklyRetentionRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("monthly_retention_rules", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyMonthlyRetentionRules MonthlyRetentionRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("yearly_retention_rules", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyYearlyRetentionRules YearlyRetentionRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyAdvancedRetentionRules {\n");
            sb.Append("  weeklyRetentionRules: ").Append(WeeklyRetentionRules).Append("\n");
            sb.Append("  monthlyRetentionRules: ").Append(MonthlyRetentionRules).Append("\n");
            sb.Append("  yearlyRetentionRules: ").Append(YearlyRetentionRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyAdvancedRetentionRules);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyAdvancedRetentionRules input)
        {
            if (input == null) return false;
            if (this.WeeklyRetentionRules != input.WeeklyRetentionRules || (this.WeeklyRetentionRules != null && !this.WeeklyRetentionRules.Equals(input.WeeklyRetentionRules))) return false;
            if (this.MonthlyRetentionRules != input.MonthlyRetentionRules || (this.MonthlyRetentionRules != null && !this.MonthlyRetentionRules.Equals(input.MonthlyRetentionRules))) return false;
            if (this.YearlyRetentionRules != input.YearlyRetentionRules || (this.YearlyRetentionRules != null && !this.YearlyRetentionRules.Equals(input.YearlyRetentionRules))) return false;

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
                if (this.WeeklyRetentionRules != null) hashCode = hashCode * 59 + this.WeeklyRetentionRules.GetHashCode();
                if (this.MonthlyRetentionRules != null) hashCode = hashCode * 59 + this.MonthlyRetentionRules.GetHashCode();
                if (this.YearlyRetentionRules != null) hashCode = hashCode * 59 + this.YearlyRetentionRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
