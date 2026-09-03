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
    public class TaskTimeoutPolicy 
    {

        /// <summary>
        /// 小网拨测：同一个ip超时的用例大于多少个告警
        /// </summary>
        [JsonProperty("sameIpTimeoutTestCaseCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? SameIpTimeoutTestCaseCount { get; set; }

        /// <summary>
        /// 小网拨测:同一用例在N个IP中超时，并且超时的用例个数达到M个告警
        /// </summary>
        [JsonProperty("sameTestCaseTimeoutIpCount", NullValueHandling = NullValueHandling.Ignore)]
        public string SameTestCaseTimeoutIpCount { get; set; }

        /// <summary>
        /// 任务中多少个用例超时告警
        /// </summary>
        [JsonProperty("testCaseTimeoutCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseTimeoutCount { get; set; }

        /// <summary>
        /// 任务中多少百分比的用例超时告警
        /// </summary>
        [JsonProperty("testCaseTimeoutRatio", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestCaseTimeoutRatio { get; set; }

        /// <summary>
        /// 任务连续超时告警
        /// </summary>
        [JsonProperty("timeoutTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeoutTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskTimeoutPolicy {\n");
            sb.Append("  sameIpTimeoutTestCaseCount: ").Append(SameIpTimeoutTestCaseCount).Append("\n");
            sb.Append("  sameTestCaseTimeoutIpCount: ").Append(SameTestCaseTimeoutIpCount).Append("\n");
            sb.Append("  testCaseTimeoutCount: ").Append(TestCaseTimeoutCount).Append("\n");
            sb.Append("  testCaseTimeoutRatio: ").Append(TestCaseTimeoutRatio).Append("\n");
            sb.Append("  timeoutTimes: ").Append(TimeoutTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskTimeoutPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskTimeoutPolicy input)
        {
            if (input == null) return false;
            if (this.SameIpTimeoutTestCaseCount != input.SameIpTimeoutTestCaseCount || (this.SameIpTimeoutTestCaseCount != null && !this.SameIpTimeoutTestCaseCount.Equals(input.SameIpTimeoutTestCaseCount))) return false;
            if (this.SameTestCaseTimeoutIpCount != input.SameTestCaseTimeoutIpCount || (this.SameTestCaseTimeoutIpCount != null && !this.SameTestCaseTimeoutIpCount.Equals(input.SameTestCaseTimeoutIpCount))) return false;
            if (this.TestCaseTimeoutCount != input.TestCaseTimeoutCount || (this.TestCaseTimeoutCount != null && !this.TestCaseTimeoutCount.Equals(input.TestCaseTimeoutCount))) return false;
            if (this.TestCaseTimeoutRatio != input.TestCaseTimeoutRatio || (this.TestCaseTimeoutRatio != null && !this.TestCaseTimeoutRatio.Equals(input.TestCaseTimeoutRatio))) return false;
            if (this.TimeoutTimes != input.TimeoutTimes || (this.TimeoutTimes != null && !this.TimeoutTimes.Equals(input.TimeoutTimes))) return false;

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
                if (this.SameIpTimeoutTestCaseCount != null) hashCode = hashCode * 59 + this.SameIpTimeoutTestCaseCount.GetHashCode();
                if (this.SameTestCaseTimeoutIpCount != null) hashCode = hashCode * 59 + this.SameTestCaseTimeoutIpCount.GetHashCode();
                if (this.TestCaseTimeoutCount != null) hashCode = hashCode * 59 + this.TestCaseTimeoutCount.GetHashCode();
                if (this.TestCaseTimeoutRatio != null) hashCode = hashCode * 59 + this.TestCaseTimeoutRatio.GetHashCode();
                if (this.TimeoutTimes != null) hashCode = hashCode * 59 + this.TimeoutTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
