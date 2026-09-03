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
    public class TimeoutAlert 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alert_template", NullValueHandling = NullValueHandling.Ignore)]
        public AlertTemplate AlertTemplate { get; set; }

        /// <summary>
        /// 超时告警开启 0关闭 1开启
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_timeout_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTimeoutPolicy TaskTimeoutPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("testCaseTimeoutPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public TestCaseTimeoutPolicy TestCaseTimeoutPolicy { get; set; }

        /// <summary>
        /// 超时重试次数
        /// </summary>
        [JsonProperty("timeoutRetryTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeoutRetryTimes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeoutAlert {\n");
            sb.Append("  alertTemplate: ").Append(AlertTemplate).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  taskTimeoutPolicy: ").Append(TaskTimeoutPolicy).Append("\n");
            sb.Append("  testCaseTimeoutPolicy: ").Append(TestCaseTimeoutPolicy).Append("\n");
            sb.Append("  timeoutRetryTimes: ").Append(TimeoutRetryTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeoutAlert);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TimeoutAlert input)
        {
            if (input == null) return false;
            if (this.AlertTemplate != input.AlertTemplate || (this.AlertTemplate != null && !this.AlertTemplate.Equals(input.AlertTemplate))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.TaskTimeoutPolicy != input.TaskTimeoutPolicy || (this.TaskTimeoutPolicy != null && !this.TaskTimeoutPolicy.Equals(input.TaskTimeoutPolicy))) return false;
            if (this.TestCaseTimeoutPolicy != input.TestCaseTimeoutPolicy || (this.TestCaseTimeoutPolicy != null && !this.TestCaseTimeoutPolicy.Equals(input.TestCaseTimeoutPolicy))) return false;
            if (this.TimeoutRetryTimes != input.TimeoutRetryTimes || (this.TimeoutRetryTimes != null && !this.TimeoutRetryTimes.Equals(input.TimeoutRetryTimes))) return false;

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
                if (this.AlertTemplate != null) hashCode = hashCode * 59 + this.AlertTemplate.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.TaskTimeoutPolicy != null) hashCode = hashCode * 59 + this.TaskTimeoutPolicy.GetHashCode();
                if (this.TestCaseTimeoutPolicy != null) hashCode = hashCode * 59 + this.TestCaseTimeoutPolicy.GetHashCode();
                if (this.TimeoutRetryTimes != null) hashCode = hashCode * 59 + this.TimeoutRetryTimes.GetHashCode();
                return hashCode;
            }
        }
    }
}
