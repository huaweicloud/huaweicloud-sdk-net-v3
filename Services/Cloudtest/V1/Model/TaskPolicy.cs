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
    public class TaskPolicy 
    {

        /// <summary>
        /// 任务连续失败N次告警
        /// </summary>
        [JsonProperty("failed_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedTimes { get; set; }

        /// <summary>
        /// 小网拨测：同一个ip失败的用例大于多少个告警
        /// </summary>
        [JsonProperty("sameIpFailedTestCaseCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SameIpFailedTestCaseCount { get; set; }

        /// <summary>
        /// 小网拨测:同一用例在N个IP中失败，并且失败的用例个数达到M个
        /// </summary>
        [JsonProperty("sameTestCaseFailedIpCount", NullValueHandling = NullValueHandling.Ignore)]
        public string SameTestCaseFailedIpCount { get; set; }

        /// <summary>
        /// 任务中多少个用例失败告警
        /// </summary>
        [JsonProperty("testCaseFailedCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseFailedCount { get; set; }

        /// <summary>
        /// 任务中多少百分比的用例失败告警
        /// </summary>
        [JsonProperty("testCaseFailedRatio", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseFailedRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskPolicy {\n");
            sb.Append("  failedTimes: ").Append(FailedTimes).Append("\n");
            sb.Append("  sameIpFailedTestCaseCount: ").Append(SameIpFailedTestCaseCount).Append("\n");
            sb.Append("  sameTestCaseFailedIpCount: ").Append(SameTestCaseFailedIpCount).Append("\n");
            sb.Append("  testCaseFailedCount: ").Append(TestCaseFailedCount).Append("\n");
            sb.Append("  testCaseFailedRatio: ").Append(TestCaseFailedRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskPolicy input)
        {
            if (input == null) return false;
            if (this.FailedTimes != input.FailedTimes || (this.FailedTimes != null && !this.FailedTimes.Equals(input.FailedTimes))) return false;
            if (this.SameIpFailedTestCaseCount != input.SameIpFailedTestCaseCount || (this.SameIpFailedTestCaseCount != null && !this.SameIpFailedTestCaseCount.Equals(input.SameIpFailedTestCaseCount))) return false;
            if (this.SameTestCaseFailedIpCount != input.SameTestCaseFailedIpCount || (this.SameTestCaseFailedIpCount != null && !this.SameTestCaseFailedIpCount.Equals(input.SameTestCaseFailedIpCount))) return false;
            if (this.TestCaseFailedCount != input.TestCaseFailedCount || (this.TestCaseFailedCount != null && !this.TestCaseFailedCount.Equals(input.TestCaseFailedCount))) return false;
            if (this.TestCaseFailedRatio != input.TestCaseFailedRatio || (this.TestCaseFailedRatio != null && !this.TestCaseFailedRatio.Equals(input.TestCaseFailedRatio))) return false;

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
                if (this.FailedTimes != null) hashCode = hashCode * 59 + this.FailedTimes.GetHashCode();
                if (this.SameIpFailedTestCaseCount != null) hashCode = hashCode * 59 + this.SameIpFailedTestCaseCount.GetHashCode();
                if (this.SameTestCaseFailedIpCount != null) hashCode = hashCode * 59 + this.SameTestCaseFailedIpCount.GetHashCode();
                if (this.TestCaseFailedCount != null) hashCode = hashCode * 59 + this.TestCaseFailedCount.GetHashCode();
                if (this.TestCaseFailedRatio != null) hashCode = hashCode * 59 + this.TestCaseFailedRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
