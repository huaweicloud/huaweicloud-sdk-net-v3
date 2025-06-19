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
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class TaskAssignCaseVo 
    {

        /// <summary>
        /// 排序顺序
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort { get; set; }

        /// <summary>
        /// 用例uri
        /// </summary>
        [JsonProperty("case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseUri { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAvailable { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("test_case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("test_case_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskAssignCaseVo {\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  caseUri: ").Append(CaseUri).Append("\n");
            sb.Append("  isAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  testCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  testCaseNumber: ").Append(TestCaseNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskAssignCaseVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskAssignCaseVo input)
        {
            if (input == null) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.CaseUri != input.CaseUri || (this.CaseUri != null && !this.CaseUri.Equals(input.CaseUri))) return false;
            if (this.IsAvailable != input.IsAvailable || (this.IsAvailable != null && !this.IsAvailable.Equals(input.IsAvailable))) return false;
            if (this.TestCaseName != input.TestCaseName || (this.TestCaseName != null && !this.TestCaseName.Equals(input.TestCaseName))) return false;
            if (this.TestCaseNumber != input.TestCaseNumber || (this.TestCaseNumber != null && !this.TestCaseNumber.Equals(input.TestCaseNumber))) return false;

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
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.CaseUri != null) hashCode = hashCode * 59 + this.CaseUri.GetHashCode();
                if (this.IsAvailable != null) hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.TestCaseName != null) hashCode = hashCode * 59 + this.TestCaseName.GetHashCode();
                if (this.TestCaseNumber != null) hashCode = hashCode * 59 + this.TestCaseNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
