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
    /// 工作流执行简要信息。
    /// </summary>
    public class ExecutionBrief 
    {

        /// <summary>
        /// 工作流执行ID。
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 工作流执行的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 工作流状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 运行的节点。
        /// </summary>
        [JsonProperty("running_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RunningSteps { get; set; }

        /// <summary>
        /// 当前节点。
        /// </summary>
        [JsonProperty("current_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CurrentSteps { get; set; }

        /// <summary>
        /// 运行时长。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionBrief {\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  runningSteps: ").Append(RunningSteps).Append("\n");
            sb.Append("  currentSteps: ").Append(CurrentSteps).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionBrief);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionBrief input)
        {
            if (input == null) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RunningSteps != input.RunningSteps || (this.RunningSteps != null && input.RunningSteps != null && !this.RunningSteps.SequenceEqual(input.RunningSteps))) return false;
            if (this.CurrentSteps != input.CurrentSteps || (this.CurrentSteps != null && input.CurrentSteps != null && !this.CurrentSteps.SequenceEqual(input.CurrentSteps))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RunningSteps != null) hashCode = hashCode * 59 + this.RunningSteps.GetHashCode();
                if (this.CurrentSteps != null) hashCode = hashCode * 59 + this.CurrentSteps.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
