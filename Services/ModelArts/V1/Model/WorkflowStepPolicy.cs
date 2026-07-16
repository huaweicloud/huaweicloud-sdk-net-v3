using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 节点执行策略。
    /// </summary>
    public class WorkflowStepPolicy 
    {

        /// <summary>
        /// 节点执行间隔。
        /// </summary>
        [JsonProperty("poll_interval_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public string PollIntervalSeconds { get; set; }

        /// <summary>
        /// 最大执行时间。
        /// </summary>
        [JsonProperty("max_execution_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxExecutionMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowStepPolicy {\n");
            sb.Append("  pollIntervalSeconds: ").Append(PollIntervalSeconds).Append("\n");
            sb.Append("  maxExecutionMinutes: ").Append(MaxExecutionMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowStepPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowStepPolicy input)
        {
            if (input == null) return false;
            if (this.PollIntervalSeconds != input.PollIntervalSeconds || (this.PollIntervalSeconds != null && !this.PollIntervalSeconds.Equals(input.PollIntervalSeconds))) return false;
            if (this.MaxExecutionMinutes != input.MaxExecutionMinutes || (this.MaxExecutionMinutes != null && !this.MaxExecutionMinutes.Equals(input.MaxExecutionMinutes))) return false;

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
                if (this.PollIntervalSeconds != null) hashCode = hashCode * 59 + this.PollIntervalSeconds.GetHashCode();
                if (this.MaxExecutionMinutes != null) hashCode = hashCode * 59 + this.MaxExecutionMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
