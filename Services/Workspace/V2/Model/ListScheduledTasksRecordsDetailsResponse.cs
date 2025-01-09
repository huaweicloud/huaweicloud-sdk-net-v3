using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListScheduledTasksRecordsDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 定时任务执行记录详情列表。
        /// </summary>
        [JsonProperty("tasks_records_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduledTasksRecordsDetails> TasksRecordsDetails { get; set; }

        /// <summary>
        /// 总个数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScheduledTasksRecordsDetailsResponse {\n");
            sb.Append("  tasksRecordsDetails: ").Append(TasksRecordsDetails).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduledTasksRecordsDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduledTasksRecordsDetailsResponse input)
        {
            if (input == null) return false;
            if (this.TasksRecordsDetails != input.TasksRecordsDetails || (this.TasksRecordsDetails != null && input.TasksRecordsDetails != null && !this.TasksRecordsDetails.SequenceEqual(input.TasksRecordsDetails))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.TasksRecordsDetails != null) hashCode = hashCode * 59 + this.TasksRecordsDetails.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
