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
    public class TestCaseTimeoutPolicy 
    {

        /// <summary>
        /// 用例超时多少次告警
        /// </summary>
        [JsonProperty("timeoutTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeoutTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseTimeoutPolicy {\n");
            sb.Append("  timeoutTimes: ").Append(TimeoutTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseTimeoutPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseTimeoutPolicy input)
        {
            if (input == null) return false;
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
                if (this.TimeoutTimes != null) hashCode = hashCode * 59 + this.TimeoutTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
