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
    public class TaskErrorPolicy 
    {

        /// <summary>
        /// 小网拨测：同一个ip异常的用例大于多少个告警
        /// </summary>
        [JsonProperty("sameIpErrorTestCaseCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SameIpErrorTestCaseCount { get; set; }

        /// <summary>
        /// 小网拨测:同一用例在N个IP中异常，并且异常的用例个数达到M个告警
        /// </summary>
        [JsonProperty("sameTestCaseErrorIpCount", NullValueHandling = NullValueHandling.Ignore)]
        public string SameTestCaseErrorIpCount { get; set; }

        /// <summary>
        /// 任务中多少个用例异常告警
        /// </summary>
        [JsonProperty("testCaseErrorCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseErrorCount { get; set; }

        /// <summary>
        /// 任务中多少百分比的用例异常告警
        /// </summary>
        [JsonProperty("testCaseErrorRatio", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseErrorRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskErrorPolicy {\n");
            sb.Append("  sameIpErrorTestCaseCount: ").Append(SameIpErrorTestCaseCount).Append("\n");
            sb.Append("  sameTestCaseErrorIpCount: ").Append(SameTestCaseErrorIpCount).Append("\n");
            sb.Append("  testCaseErrorCount: ").Append(TestCaseErrorCount).Append("\n");
            sb.Append("  testCaseErrorRatio: ").Append(TestCaseErrorRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskErrorPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskErrorPolicy input)
        {
            if (input == null) return false;
            if (this.SameIpErrorTestCaseCount != input.SameIpErrorTestCaseCount || (this.SameIpErrorTestCaseCount != null && !this.SameIpErrorTestCaseCount.Equals(input.SameIpErrorTestCaseCount))) return false;
            if (this.SameTestCaseErrorIpCount != input.SameTestCaseErrorIpCount || (this.SameTestCaseErrorIpCount != null && !this.SameTestCaseErrorIpCount.Equals(input.SameTestCaseErrorIpCount))) return false;
            if (this.TestCaseErrorCount != input.TestCaseErrorCount || (this.TestCaseErrorCount != null && !this.TestCaseErrorCount.Equals(input.TestCaseErrorCount))) return false;
            if (this.TestCaseErrorRatio != input.TestCaseErrorRatio || (this.TestCaseErrorRatio != null && !this.TestCaseErrorRatio.Equals(input.TestCaseErrorRatio))) return false;

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
                if (this.SameIpErrorTestCaseCount != null) hashCode = hashCode * 59 + this.SameIpErrorTestCaseCount.GetHashCode();
                if (this.SameTestCaseErrorIpCount != null) hashCode = hashCode * 59 + this.SameTestCaseErrorIpCount.GetHashCode();
                if (this.TestCaseErrorCount != null) hashCode = hashCode * 59 + this.TestCaseErrorCount.GetHashCode();
                if (this.TestCaseErrorRatio != null) hashCode = hashCode * 59 + this.TestCaseErrorRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
