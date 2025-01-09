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
    public class ListScheduledTasksResponse : SdkResponse
    {

        /// <summary>
        /// 定时任务列表。
        /// </summary>
        [JsonProperty("scheduled_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduledTask> ScheduledTasks { get; set; }

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
            sb.Append("class ListScheduledTasksResponse {\n");
            sb.Append("  scheduledTasks: ").Append(ScheduledTasks).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduledTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduledTasksResponse input)
        {
            if (input == null) return false;
            if (this.ScheduledTasks != input.ScheduledTasks || (this.ScheduledTasks != null && input.ScheduledTasks != null && !this.ScheduledTasks.SequenceEqual(input.ScheduledTasks))) return false;
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
                if (this.ScheduledTasks != null) hashCode = hashCode * 59 + this.ScheduledTasks.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
