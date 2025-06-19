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
    public class TestcasePlanVo 
    {

        /// <summary>
        /// 测试用例URI
        /// </summary>
        [JsonProperty("testcase_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseUri { get; set; }

        /// <summary>
        /// 测试用例用例编号
        /// </summary>
        [JsonProperty("testcase_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseNumber { get; set; }

        /// <summary>
        /// 测试计划信息
        /// </summary>
        [JsonProperty("plans", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestPlanVo> Plans { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestcasePlanVo {\n");
            sb.Append("  testcaseUri: ").Append(TestcaseUri).Append("\n");
            sb.Append("  testcaseNumber: ").Append(TestcaseNumber).Append("\n");
            sb.Append("  plans: ").Append(Plans).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestcasePlanVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestcasePlanVo input)
        {
            if (input == null) return false;
            if (this.TestcaseUri != input.TestcaseUri || (this.TestcaseUri != null && !this.TestcaseUri.Equals(input.TestcaseUri))) return false;
            if (this.TestcaseNumber != input.TestcaseNumber || (this.TestcaseNumber != null && !this.TestcaseNumber.Equals(input.TestcaseNumber))) return false;
            if (this.Plans != input.Plans || (this.Plans != null && input.Plans != null && !this.Plans.SequenceEqual(input.Plans))) return false;

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
                if (this.TestcaseUri != null) hashCode = hashCode * 59 + this.TestcaseUri.GetHashCode();
                if (this.TestcaseNumber != null) hashCode = hashCode * 59 + this.TestcaseNumber.GetHashCode();
                if (this.Plans != null) hashCode = hashCode * 59 + this.Plans.GetHashCode();
                return hashCode;
            }
        }
    }
}
