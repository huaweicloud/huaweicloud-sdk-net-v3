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
    public class UpgradeInstanceResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 实例升级任务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**： 实例升级调度任务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("schedule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInstanceResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  scheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInstanceResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ScheduleId != input.ScheduleId || (this.ScheduleId != null && !this.ScheduleId.Equals(input.ScheduleId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ScheduleId != null) hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
