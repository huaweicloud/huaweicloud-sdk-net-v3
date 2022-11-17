using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBackgroundTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务个数
        /// </summary>
        [JsonProperty("task_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskCount { get; set; }

        /// <summary>
        /// 任务详情数组
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleBackgroundTask> Tasks { get; set; }

        /// <summary>
        /// 任务结束时间，格式为2020-06-17T07:38:42.503Z
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 任务启动时间，格式为2020-06-17T07:38:42.503Z
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackgroundTaskResponse {\n");
            sb.Append("  taskCount: ").Append(TaskCount).Append("\n");
            sb.Append("  tasks: ").Append(Tasks).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackgroundTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackgroundTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskCount == input.TaskCount ||
                    (this.TaskCount != null &&
                    this.TaskCount.Equals(input.TaskCount))
                ) && 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TaskCount != null)
                    hashCode = hashCode * 59 + this.TaskCount.GetHashCode();
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
