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
    /// **参数解释**：训练作业规格参数。 **约束限制**：不涉及。
    /// </summary>
    public class JobUpdateRequestBodySpec 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Notification Notification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("schedule_policy", NullValueHandling = NullValueHandling.Ignore)]
        public JobUpdateRequestBodySpecSchedulePolicy SchedulePolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobUpdateRequestBodySpec {\n");
            sb.Append("  notification: ").Append(Notification).Append("\n");
            sb.Append("  schedulePolicy: ").Append(SchedulePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobUpdateRequestBodySpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobUpdateRequestBodySpec input)
        {
            if (input == null) return false;
            if (this.Notification != input.Notification || (this.Notification != null && !this.Notification.Equals(input.Notification))) return false;
            if (this.SchedulePolicy != input.SchedulePolicy || (this.SchedulePolicy != null && !this.SchedulePolicy.Equals(input.SchedulePolicy))) return false;

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
                if (this.Notification != null) hashCode = hashCode * 59 + this.Notification.GetHashCode();
                if (this.SchedulePolicy != null) hashCode = hashCode * 59 + this.SchedulePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
