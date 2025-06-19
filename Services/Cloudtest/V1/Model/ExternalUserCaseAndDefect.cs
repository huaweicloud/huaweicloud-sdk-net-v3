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
    /// 用户创建用例以及关联缺陷信息
    /// </summary>
    public class ExternalUserCaseAndDefect 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Creator { get; set; }

        /// <summary>
        /// 缺陷数
        /// </summary>
        [JsonProperty("defect_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectCount { get; set; }

        /// <summary>
        /// 缺陷ID列表
        /// </summary>
        [JsonProperty("defect_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DefectIds { get; set; }

        /// <summary>
        /// 用例ID
        /// </summary>
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }

        /// <summary>
        /// 分支ID
        /// </summary>
        [JsonProperty("branch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalUserCaseAndDefect {\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  defectCount: ").Append(DefectCount).Append("\n");
            sb.Append("  defectIds: ").Append(DefectIds).Append("\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("  branchId: ").Append(BranchId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalUserCaseAndDefect);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalUserCaseAndDefect input)
        {
            if (input == null) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.DefectCount != input.DefectCount || (this.DefectCount != null && !this.DefectCount.Equals(input.DefectCount))) return false;
            if (this.DefectIds != input.DefectIds || (this.DefectIds != null && input.DefectIds != null && !this.DefectIds.SequenceEqual(input.DefectIds))) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;
            if (this.BranchId != input.BranchId || (this.BranchId != null && !this.BranchId.Equals(input.BranchId))) return false;

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
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.DefectCount != null) hashCode = hashCode * 59 + this.DefectCount.GetHashCode();
                if (this.DefectIds != null) hashCode = hashCode * 59 + this.DefectIds.GetHashCode();
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                if (this.BranchId != null) hashCode = hashCode * 59 + this.BranchId.GetHashCode();
                return hashCode;
            }
        }
    }
}
