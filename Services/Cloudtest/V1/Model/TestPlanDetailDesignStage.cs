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
    /// 测试计划设计阶段信息
    /// </summary>
    public class TestPlanDetailDesignStage 
    {

        /// <summary>
        /// 用例个数
        /// </summary>
        [JsonProperty("case_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseCount { get; set; }

        /// <summary>
        /// 需求个数
        /// </summary>
        [JsonProperty("issue_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueCount { get; set; }

        /// <summary>
        /// 已被用例关联的需求个数
        /// </summary>
        [JsonProperty("issue_covered_count", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCoveredCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestPlanDetailDesignStage {\n");
            sb.Append("  caseCount: ").Append(CaseCount).Append("\n");
            sb.Append("  issueCount: ").Append(IssueCount).Append("\n");
            sb.Append("  issueCoveredCount: ").Append(IssueCoveredCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestPlanDetailDesignStage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestPlanDetailDesignStage input)
        {
            if (input == null) return false;
            if (this.CaseCount != input.CaseCount || (this.CaseCount != null && !this.CaseCount.Equals(input.CaseCount))) return false;
            if (this.IssueCount != input.IssueCount || (this.IssueCount != null && !this.IssueCount.Equals(input.IssueCount))) return false;
            if (this.IssueCoveredCount != input.IssueCoveredCount || (this.IssueCoveredCount != null && !this.IssueCoveredCount.Equals(input.IssueCoveredCount))) return false;

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
                if (this.CaseCount != null) hashCode = hashCode * 59 + this.CaseCount.GetHashCode();
                if (this.IssueCount != null) hashCode = hashCode * 59 + this.IssueCount.GetHashCode();
                if (this.IssueCoveredCount != null) hashCode = hashCode * 59 + this.IssueCoveredCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
