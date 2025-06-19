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
    /// Response Object
    /// </summary>
    public class ShowProjectDataDashboardResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("defect", NullValueHandling = NullValueHandling.Ignore)]
        public DefectVo Defect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_pass_rate", NullValueHandling = NullValueHandling.Ignore)]
        public CasePassRateVo CasePassRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_completion_rate", NullValueHandling = NullValueHandling.Ignore)]
        public CaseCompletionRateVo CaseCompletionRate { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("issue_cover_rate", NullValueHandling = NullValueHandling.Ignore)]
        public IssueCoverRateVo IssueCoverRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectDataDashboardResponse {\n");
            sb.Append("  defect: ").Append(Defect).Append("\n");
            sb.Append("  casePassRate: ").Append(CasePassRate).Append("\n");
            sb.Append("  caseCompletionRate: ").Append(CaseCompletionRate).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  issueCoverRate: ").Append(IssueCoverRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectDataDashboardResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectDataDashboardResponse input)
        {
            if (input == null) return false;
            if (this.Defect != input.Defect || (this.Defect != null && !this.Defect.Equals(input.Defect))) return false;
            if (this.CasePassRate != input.CasePassRate || (this.CasePassRate != null && !this.CasePassRate.Equals(input.CasePassRate))) return false;
            if (this.CaseCompletionRate != input.CaseCompletionRate || (this.CaseCompletionRate != null && !this.CaseCompletionRate.Equals(input.CaseCompletionRate))) return false;
            if (this.ProjectType != input.ProjectType || (this.ProjectType != null && !this.ProjectType.Equals(input.ProjectType))) return false;
            if (this.IssueCoverRate != input.IssueCoverRate || (this.IssueCoverRate != null && !this.IssueCoverRate.Equals(input.IssueCoverRate))) return false;

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
                if (this.Defect != null) hashCode = hashCode * 59 + this.Defect.GetHashCode();
                if (this.CasePassRate != null) hashCode = hashCode * 59 + this.CasePassRate.GetHashCode();
                if (this.CaseCompletionRate != null) hashCode = hashCode * 59 + this.CaseCompletionRate.GetHashCode();
                if (this.ProjectType != null) hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.IssueCoverRate != null) hashCode = hashCode * 59 + this.IssueCoverRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
