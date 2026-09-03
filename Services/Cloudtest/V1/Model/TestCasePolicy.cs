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
    public class TestCasePolicy 
    {

        /// <summary>
        /// 单用例失败多少次告警
        /// </summary>
        [JsonProperty("failed_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedTimes { get; set; }

        /// <summary>
        /// 单用例重试多少次后告警
        /// </summary>
        [JsonProperty("retryTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCasePolicy {\n");
            sb.Append("  failedTimes: ").Append(FailedTimes).Append("\n");
            sb.Append("  retryTimes: ").Append(RetryTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCasePolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCasePolicy input)
        {
            if (input == null) return false;
            if (this.FailedTimes != input.FailedTimes || (this.FailedTimes != null && !this.FailedTimes.Equals(input.FailedTimes))) return false;
            if (this.RetryTimes != input.RetryTimes || (this.RetryTimes != null && !this.RetryTimes.Equals(input.RetryTimes))) return false;

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
                if (this.RetryTimes != null) hashCode = hashCode * 59 + this.RetryTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
