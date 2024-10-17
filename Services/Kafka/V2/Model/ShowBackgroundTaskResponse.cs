using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBackgroundTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务数量。
        /// </summary>
        [JsonProperty("task_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskCount { get; set; }

        /// <summary>
        /// 任务列表。
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListBackgroundTasksRespTasks> Tasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBackgroundTaskResponse {\n");
            sb.Append("  taskCount: ").Append(TaskCount).Append("\n");
            sb.Append("  tasks: ").Append(Tasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBackgroundTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBackgroundTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskCount != input.TaskCount || (this.TaskCount != null && !this.TaskCount.Equals(input.TaskCount))) return false;
            if (this.Tasks != input.Tasks || (this.Tasks != null && input.Tasks != null && !this.Tasks.SequenceEqual(input.Tasks))) return false;

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
                if (this.TaskCount != null) hashCode = hashCode * 59 + this.TaskCount.GetHashCode();
                if (this.Tasks != null) hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
