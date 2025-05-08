using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkflowTask 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo Input { get; set; }

        /// <summary>
        /// 工作流任务结果列表
        /// </summary>
        [JsonProperty("task_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectTaskResult> TaskResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTask {\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  taskResult: ").Append(TaskResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowTask input)
        {
            if (input == null) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.TaskResult != input.TaskResult || (this.TaskResult != null && input.TaskResult != null && !this.TaskResult.SequenceEqual(input.TaskResult))) return false;

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
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.TaskResult != null) hashCode = hashCode * 59 + this.TaskResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
