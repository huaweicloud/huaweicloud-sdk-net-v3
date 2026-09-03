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
    public class ErrorAlert 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alert_template", NullValueHandling = NullValueHandling.Ignore)]
        public AlertTemplate AlertTemplate { get; set; }

        /// <summary>
        /// 异常告警是否开启：0关闭，1开启，默认关闭
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taskErrorPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public TaskErrorPolicy TaskErrorPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorAlert {\n");
            sb.Append("  alertTemplate: ").Append(AlertTemplate).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  taskErrorPolicy: ").Append(TaskErrorPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorAlert);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorAlert input)
        {
            if (input == null) return false;
            if (this.AlertTemplate != input.AlertTemplate || (this.AlertTemplate != null && !this.AlertTemplate.Equals(input.AlertTemplate))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.TaskErrorPolicy != input.TaskErrorPolicy || (this.TaskErrorPolicy != null && !this.TaskErrorPolicy.Equals(input.TaskErrorPolicy))) return false;

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
                if (this.TaskErrorPolicy != null) hashCode = hashCode * 59 + this.TaskErrorPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
