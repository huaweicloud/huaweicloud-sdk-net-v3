using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 报告阶段信息汇总
    /// </summary>
    public class ReportSummaryVo 
    {

        /// <summary>
        /// 用例通过率
        /// </summary>
        [JsonProperty("case_success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseSuccessRate { get; set; }

        /// <summary>
        /// 用例完成率
        /// </summary>
        [JsonProperty("case_complete_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseCompleteRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportSummaryVo {\n");
            sb.Append("  caseSuccessRate: ").Append(CaseSuccessRate).Append("\n");
            sb.Append("  caseCompleteRate: ").Append(CaseCompleteRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportSummaryVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportSummaryVo input)
        {
            if (input == null) return false;
            if (this.CaseSuccessRate != input.CaseSuccessRate || (this.CaseSuccessRate != null && !this.CaseSuccessRate.Equals(input.CaseSuccessRate))) return false;
            if (this.CaseCompleteRate != input.CaseCompleteRate || (this.CaseCompleteRate != null && !this.CaseCompleteRate.Equals(input.CaseCompleteRate))) return false;

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
                if (this.CaseSuccessRate != null) hashCode = hashCode * 59 + this.CaseSuccessRate.GetHashCode();
                if (this.CaseCompleteRate != null) hashCode = hashCode * 59 + this.CaseCompleteRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
