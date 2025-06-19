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
    public class ShowApiTestcaseHistoriesResponse : SdkResponse
    {

        /// <summary>
        /// 测试用例总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 测试服务id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 测试用例id
        /// </summary>
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }

        /// <summary>
        /// 测试用例名称
        /// </summary>
        [JsonProperty("testcase_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseName { get; set; }

        /// <summary>
        /// 测试用例结果集
        /// </summary>
        [JsonProperty("testcase_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestcaseResult> TestcaseResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowApiTestcaseHistoriesResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("  testcaseName: ").Append(TestcaseName).Append("\n");
            sb.Append("  testcaseResults: ").Append(TestcaseResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowApiTestcaseHistoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowApiTestcaseHistoriesResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;
            if (this.TestcaseName != input.TestcaseName || (this.TestcaseName != null && !this.TestcaseName.Equals(input.TestcaseName))) return false;
            if (this.TestcaseResults != input.TestcaseResults || (this.TestcaseResults != null && input.TestcaseResults != null && !this.TestcaseResults.SequenceEqual(input.TestcaseResults))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                if (this.TestcaseName != null) hashCode = hashCode * 59 + this.TestcaseName.GetHashCode();
                if (this.TestcaseResults != null) hashCode = hashCode * 59 + this.TestcaseResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
