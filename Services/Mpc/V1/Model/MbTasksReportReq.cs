using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MbTasksReportReq 
    {

        /// <summary>
        /// 任务ID。 如果返回值为200 OK，为接受任务后产生的任务ID。 
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务执行状态。 取值为RUNNING/FINISHED/FAILED。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务名称。 取值为RESET_TRACKS/MERGE_CHANNELS。 
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 失败任务是否重试。 
        /// </summary>
        [JsonProperty("retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Retry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parameter", NullValueHandling = NullValueHandling.Ignore)]
        public MbTaskParameter Parameter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MbTasksReportReq {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  retry: ").Append(Retry).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MbTasksReportReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MbTasksReportReq input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.Retry != input.Retry || (this.Retry != null && !this.Retry.Equals(input.Retry))) return false;
            if (this.Parameter != input.Parameter || (this.Parameter != null && !this.Parameter.Equals(input.Parameter))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.Retry != null) hashCode = hashCode * 59 + this.Retry.GetHashCode();
                if (this.Parameter != null) hashCode = hashCode * 59 + this.Parameter.GetHashCode();
                return hashCode;
            }
        }
    }
}
