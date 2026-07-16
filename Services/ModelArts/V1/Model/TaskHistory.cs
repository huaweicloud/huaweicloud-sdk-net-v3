using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：训练作业的某次调度的某个实例信息，包含实例IP、实例所在的节点IP、该实例归属于第几次调度等。
    /// </summary>
    public class TaskHistory 
    {

        /// <summary>
        /// **参数解释**：实例名。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public string Task { get; set; }

        /// <summary>
        /// **参数解释**：实例IP。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// **参数解释**：实例所在的节点IP。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("host_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIp { get; set; }

        /// <summary>
        /// **参数解释**：该实例归属于第几次调度。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("schedule_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScheduleCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskHistory {\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  hostIp: ").Append(HostIp).Append("\n");
            sb.Append("  scheduleCount: ").Append(ScheduleCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskHistory);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskHistory input)
        {
            if (input == null) return false;
            if (this.Task != input.Task || (this.Task != null && !this.Task.Equals(input.Task))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.HostIp != input.HostIp || (this.HostIp != null && !this.HostIp.Equals(input.HostIp))) return false;
            if (this.ScheduleCount != input.ScheduleCount || (this.ScheduleCount != null && !this.ScheduleCount.Equals(input.ScheduleCount))) return false;

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
                if (this.Task != null) hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.HostIp != null) hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                if (this.ScheduleCount != null) hashCode = hashCode * 59 + this.ScheduleCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
