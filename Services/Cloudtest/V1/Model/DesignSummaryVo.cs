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
    /// 设计阶段信息汇总
    /// </summary>
    public class DesignSummaryVo 
    {

        /// <summary>
        /// 需求总数
        /// </summary>
        [JsonProperty("issue_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueNum { get; set; }

        /// <summary>
        /// 已覆盖需求数
        /// </summary>
        [JsonProperty("issue_cover_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueCoverNum { get; set; }

        /// <summary>
        /// 用例数
        /// </summary>
        [JsonProperty("case_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignSummaryVo {\n");
            sb.Append("  issueNum: ").Append(IssueNum).Append("\n");
            sb.Append("  issueCoverNum: ").Append(IssueCoverNum).Append("\n");
            sb.Append("  caseNum: ").Append(CaseNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesignSummaryVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesignSummaryVo input)
        {
            if (input == null) return false;
            if (this.IssueNum != input.IssueNum || (this.IssueNum != null && !this.IssueNum.Equals(input.IssueNum))) return false;
            if (this.IssueCoverNum != input.IssueCoverNum || (this.IssueCoverNum != null && !this.IssueCoverNum.Equals(input.IssueCoverNum))) return false;
            if (this.CaseNum != input.CaseNum || (this.CaseNum != null && !this.CaseNum.Equals(input.CaseNum))) return false;

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
                if (this.IssueNum != null) hashCode = hashCode * 59 + this.IssueNum.GetHashCode();
                if (this.IssueCoverNum != null) hashCode = hashCode * 59 + this.IssueCoverNum.GetHashCode();
                if (this.CaseNum != null) hashCode = hashCode * 59 + this.CaseNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
