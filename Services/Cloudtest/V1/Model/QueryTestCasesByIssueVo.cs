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
    /// 
    /// </summary>
    public class QueryTestCasesByIssueVo 
    {

        /// <summary>
        /// 用例状态
        /// </summary>
        [JsonProperty("case_status_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> CaseStatusMap { get; set; }

        /// <summary>
        /// 新建态
        /// </summary>
        [JsonProperty("new_create", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCreate { get; set; }

        /// <summary>
        /// 设计态
        /// </summary>
        [JsonProperty("designing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Designing { get; set; }

        /// <summary>
        /// 完成态
        /// </summary>
        [JsonProperty("finished", NullValueHandling = NullValueHandling.Ignore)]
        public int? Finished { get; set; }

        /// <summary>
        /// 测试态
        /// </summary>
        [JsonProperty("testing", NullValueHandling = NullValueHandling.Ignore)]
        public int? Testing { get; set; }

        /// <summary>
        /// 需求关联的用例数量
        /// </summary>
        [JsonProperty("test_case_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseNum { get; set; }

        /// <summary>
        /// 用例详情
        /// </summary>
        [JsonProperty("testcases", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestCaseVo> Testcases { get; set; }

        /// <summary>
        /// 用例总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryTestCasesByIssueVo {\n");
            sb.Append("  caseStatusMap: ").Append(CaseStatusMap).Append("\n");
            sb.Append("  newCreate: ").Append(NewCreate).Append("\n");
            sb.Append("  designing: ").Append(Designing).Append("\n");
            sb.Append("  finished: ").Append(Finished).Append("\n");
            sb.Append("  testing: ").Append(Testing).Append("\n");
            sb.Append("  testCaseNum: ").Append(TestCaseNum).Append("\n");
            sb.Append("  testcases: ").Append(Testcases).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryTestCasesByIssueVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryTestCasesByIssueVo input)
        {
            if (input == null) return false;
            if (this.CaseStatusMap != input.CaseStatusMap || (this.CaseStatusMap != null && input.CaseStatusMap != null && !this.CaseStatusMap.SequenceEqual(input.CaseStatusMap))) return false;
            if (this.NewCreate != input.NewCreate || (this.NewCreate != null && !this.NewCreate.Equals(input.NewCreate))) return false;
            if (this.Designing != input.Designing || (this.Designing != null && !this.Designing.Equals(input.Designing))) return false;
            if (this.Finished != input.Finished || (this.Finished != null && !this.Finished.Equals(input.Finished))) return false;
            if (this.Testing != input.Testing || (this.Testing != null && !this.Testing.Equals(input.Testing))) return false;
            if (this.TestCaseNum != input.TestCaseNum || (this.TestCaseNum != null && !this.TestCaseNum.Equals(input.TestCaseNum))) return false;
            if (this.Testcases != input.Testcases || (this.Testcases != null && input.Testcases != null && !this.Testcases.SequenceEqual(input.Testcases))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.CaseStatusMap != null) hashCode = hashCode * 59 + this.CaseStatusMap.GetHashCode();
                if (this.NewCreate != null) hashCode = hashCode * 59 + this.NewCreate.GetHashCode();
                if (this.Designing != null) hashCode = hashCode * 59 + this.Designing.GetHashCode();
                if (this.Finished != null) hashCode = hashCode * 59 + this.Finished.GetHashCode();
                if (this.Testing != null) hashCode = hashCode * 59 + this.Testing.GetHashCode();
                if (this.TestCaseNum != null) hashCode = hashCode * 59 + this.TestCaseNum.GetHashCode();
                if (this.Testcases != null) hashCode = hashCode * 59 + this.Testcases.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
