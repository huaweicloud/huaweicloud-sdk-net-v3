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
    public class ListScheduleEventsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  事件总数。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**：  待授权的事件数。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("inquiring_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? InquiringCount { get; set; }

        /// <summary>
        /// **参数解释**：  待执行的事件数。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("schedule_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScheduleCount { get; set; }

        /// <summary>
        /// **参数解释**：  正在执行的事件数。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("executing_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutingCount { get; set; }

        /// <summary>
        /// **参数解释**：  执行失败的事件数。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("failed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedCount { get; set; }

        /// <summary>
        /// **参数解释**：  事件详情列表。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleEventInfo> Events { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScheduleEventsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  inquiringCount: ").Append(InquiringCount).Append("\n");
            sb.Append("  scheduleCount: ").Append(ScheduleCount).Append("\n");
            sb.Append("  executingCount: ").Append(ExecutingCount).Append("\n");
            sb.Append("  failedCount: ").Append(FailedCount).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduleEventsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduleEventsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.InquiringCount != input.InquiringCount || (this.InquiringCount != null && !this.InquiringCount.Equals(input.InquiringCount))) return false;
            if (this.ScheduleCount != input.ScheduleCount || (this.ScheduleCount != null && !this.ScheduleCount.Equals(input.ScheduleCount))) return false;
            if (this.ExecutingCount != input.ExecutingCount || (this.ExecutingCount != null && !this.ExecutingCount.Equals(input.ExecutingCount))) return false;
            if (this.FailedCount != input.FailedCount || (this.FailedCount != null && !this.FailedCount.Equals(input.FailedCount))) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.InquiringCount != null) hashCode = hashCode * 59 + this.InquiringCount.GetHashCode();
                if (this.ScheduleCount != null) hashCode = hashCode * 59 + this.ScheduleCount.GetHashCode();
                if (this.ExecutingCount != null) hashCode = hashCode * 59 + this.ExecutingCount.GetHashCode();
                if (this.FailedCount != null) hashCode = hashCode * 59 + this.FailedCount.GetHashCode();
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                return hashCode;
            }
        }
    }
}
