using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListGroupScheduledTasksResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// 计划任务列表
        /// </summary>
        [JsonProperty("scheduled_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduledTaskDetail> ScheduledTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGroupScheduledTasksResponse {\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  scheduledTasks: ").Append(ScheduledTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGroupScheduledTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGroupScheduledTasksResponse input)
        {
            if (input == null) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.ScheduledTasks != input.ScheduledTasks || (this.ScheduledTasks != null && input.ScheduledTasks != null && !this.ScheduledTasks.SequenceEqual(input.ScheduledTasks))) return false;

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
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.ScheduledTasks != null) hashCode = hashCode * 59 + this.ScheduledTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
