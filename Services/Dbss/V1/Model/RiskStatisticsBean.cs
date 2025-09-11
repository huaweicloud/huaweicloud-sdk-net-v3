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
    public class RiskStatisticsBean 
    {

        /// <summary>
        /// 高风险数量
        /// </summary>
        [JsonProperty("high_risk_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? HighRiskNum { get; set; }

        /// <summary>
        /// 低风险数量
        /// </summary>
        [JsonProperty("low_risk_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? LowRiskNum { get; set; }

        /// <summary>
        /// 中风险数量
        /// </summary>
        [JsonProperty("middle_risk_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? MiddleRiskNum { get; set; }

        /// <summary>
        /// 无风险数量
        /// </summary>
        [JsonProperty("no_risk_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? NoRiskNum { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskStatisticsBean {\n");
            sb.Append("  highRiskNum: ").Append(HighRiskNum).Append("\n");
            sb.Append("  lowRiskNum: ").Append(LowRiskNum).Append("\n");
            sb.Append("  middleRiskNum: ").Append(MiddleRiskNum).Append("\n");
            sb.Append("  noRiskNum: ").Append(NoRiskNum).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RiskStatisticsBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RiskStatisticsBean input)
        {
            if (input == null) return false;
            if (this.HighRiskNum != input.HighRiskNum || (this.HighRiskNum != null && !this.HighRiskNum.Equals(input.HighRiskNum))) return false;
            if (this.LowRiskNum != input.LowRiskNum || (this.LowRiskNum != null && !this.LowRiskNum.Equals(input.LowRiskNum))) return false;
            if (this.MiddleRiskNum != input.MiddleRiskNum || (this.MiddleRiskNum != null && !this.MiddleRiskNum.Equals(input.MiddleRiskNum))) return false;
            if (this.NoRiskNum != input.NoRiskNum || (this.NoRiskNum != null && !this.NoRiskNum.Equals(input.NoRiskNum))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;

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
                if (this.HighRiskNum != null) hashCode = hashCode * 59 + this.HighRiskNum.GetHashCode();
                if (this.LowRiskNum != null) hashCode = hashCode * 59 + this.LowRiskNum.GetHashCode();
                if (this.MiddleRiskNum != null) hashCode = hashCode * 59 + this.MiddleRiskNum.GetHashCode();
                if (this.NoRiskNum != null) hashCode = hashCode * 59 + this.NoRiskNum.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
