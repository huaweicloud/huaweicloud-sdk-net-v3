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
    /// 
    /// </summary>
    public class PartitionReassignRequest 
    {

        /// <summary>
        /// 重平衡分配方案。
        /// </summary>
        [JsonProperty("reassignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<PartitionReassignEntity> Reassignments { get; set; }

        /// <summary>
        /// 重平衡门限值。
        /// </summary>
        [JsonProperty("throttle", NullValueHandling = NullValueHandling.Ignore)]
        public int? Throttle { get; set; }

        /// <summary>
        /// 是否作为定时任务执行。若非定时执行，则is_schedule 和execute_at字段可为空；若为定时执行，is_schedule为true，execute_at字段非空。
        /// </summary>
        [JsonProperty("is_schedule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSchedule { get; set; }

        /// <summary>
        /// 定时时间，格式为Unix时间戳，单位为毫秒
        /// </summary>
        [JsonProperty("execute_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteAt { get; set; }

        /// <summary>
        /// 设为true表示执行时间预估任务，false为执行重平衡任务。
        /// </summary>
        [JsonProperty("time_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TimeEstimate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartitionReassignRequest {\n");
            sb.Append("  reassignments: ").Append(Reassignments).Append("\n");
            sb.Append("  throttle: ").Append(Throttle).Append("\n");
            sb.Append("  isSchedule: ").Append(IsSchedule).Append("\n");
            sb.Append("  executeAt: ").Append(ExecuteAt).Append("\n");
            sb.Append("  timeEstimate: ").Append(TimeEstimate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartitionReassignRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PartitionReassignRequest input)
        {
            if (input == null) return false;
            if (this.Reassignments != input.Reassignments || (this.Reassignments != null && input.Reassignments != null && !this.Reassignments.SequenceEqual(input.Reassignments))) return false;
            if (this.Throttle != input.Throttle || (this.Throttle != null && !this.Throttle.Equals(input.Throttle))) return false;
            if (this.IsSchedule != input.IsSchedule || (this.IsSchedule != null && !this.IsSchedule.Equals(input.IsSchedule))) return false;
            if (this.ExecuteAt != input.ExecuteAt || (this.ExecuteAt != null && !this.ExecuteAt.Equals(input.ExecuteAt))) return false;
            if (this.TimeEstimate != input.TimeEstimate || (this.TimeEstimate != null && !this.TimeEstimate.Equals(input.TimeEstimate))) return false;

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
                if (this.Reassignments != null) hashCode = hashCode * 59 + this.Reassignments.GetHashCode();
                if (this.Throttle != null) hashCode = hashCode * 59 + this.Throttle.GetHashCode();
                if (this.IsSchedule != null) hashCode = hashCode * 59 + this.IsSchedule.GetHashCode();
                if (this.ExecuteAt != null) hashCode = hashCode * 59 + this.ExecuteAt.GetHashCode();
                if (this.TimeEstimate != null) hashCode = hashCode * 59 + this.TimeEstimate.GetHashCode();
                return hashCode;
            }
        }
    }
}
