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
    public class FailedAlert 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cloudAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public CloudAlarmDto CloudAlarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taskPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public TaskPolicy TaskPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("testCasePolicy", NullValueHandling = NullValueHandling.Ignore)]
        public TestCasePolicy TestCasePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wiseEye", NullValueHandling = NullValueHandling.Ignore)]
        public WiseEye WiseEye { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FailedAlert {\n");
            sb.Append("  cloudAlarm: ").Append(CloudAlarm).Append("\n");
            sb.Append("  taskPolicy: ").Append(TaskPolicy).Append("\n");
            sb.Append("  testCasePolicy: ").Append(TestCasePolicy).Append("\n");
            sb.Append("  wiseEye: ").Append(WiseEye).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FailedAlert);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FailedAlert input)
        {
            if (input == null) return false;
            if (this.CloudAlarm != input.CloudAlarm || (this.CloudAlarm != null && !this.CloudAlarm.Equals(input.CloudAlarm))) return false;
            if (this.TaskPolicy != input.TaskPolicy || (this.TaskPolicy != null && !this.TaskPolicy.Equals(input.TaskPolicy))) return false;
            if (this.TestCasePolicy != input.TestCasePolicy || (this.TestCasePolicy != null && !this.TestCasePolicy.Equals(input.TestCasePolicy))) return false;
            if (this.WiseEye != input.WiseEye || (this.WiseEye != null && !this.WiseEye.Equals(input.WiseEye))) return false;

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
                if (this.CloudAlarm != null) hashCode = hashCode * 59 + this.CloudAlarm.GetHashCode();
                if (this.TaskPolicy != null) hashCode = hashCode * 59 + this.TaskPolicy.GetHashCode();
                if (this.TestCasePolicy != null) hashCode = hashCode * 59 + this.TestCasePolicy.GetHashCode();
                if (this.WiseEye != null) hashCode = hashCode * 59 + this.WiseEye.GetHashCode();
                return hashCode;
            }
        }
    }
}
