using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListScheduleTasksResponse : SdkResponse
    {

        /// <summary>
        /// 定时任务列表。
        /// </summary>
        [JsonProperty("schedule_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleTaskInfo> ScheduleTasks { get; set; }

        /// <summary>
        /// 总任务数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScheduleTasksResponse {\n");
            sb.Append("  scheduleTasks: ").Append(ScheduleTasks).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduleTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduleTasksResponse input)
        {
            if (input == null) return false;
            if (this.ScheduleTasks != input.ScheduleTasks || (this.ScheduleTasks != null && input.ScheduleTasks != null && !this.ScheduleTasks.SequenceEqual(input.ScheduleTasks))) return false;
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
                if (this.ScheduleTasks != null) hashCode = hashCode * 59 + this.ScheduleTasks.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
