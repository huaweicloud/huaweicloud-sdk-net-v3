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
    public class OperationStatisticsBean 
    {

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 风险操作数量
        /// </summary>
        [JsonProperty("risk_operation_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? RiskOperationNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationStatisticsBean {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  riskOperationNum: ").Append(RiskOperationNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperationStatisticsBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperationStatisticsBean input)
        {
            if (input == null) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.RiskOperationNum != input.RiskOperationNum || (this.RiskOperationNum != null && !this.RiskOperationNum.Equals(input.RiskOperationNum))) return false;

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
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.RiskOperationNum != null) hashCode = hashCode * 59 + this.RiskOperationNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
