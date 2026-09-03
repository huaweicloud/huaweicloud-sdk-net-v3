using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数解释**：  执行时间窗。  **约束限制**：  当operation_type为reservation时，该字段必传。
    /// </summary>
    public class EventScheduleWindow 
    {

        /// <summary>
        /// **参数解释**：  执行日期。  **约束限制**：  格式为“yyyy-mm-dd”。  **取值范围**：  大于或等于当前日期。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("planned_day", NullValueHandling = NullValueHandling.Ignore)]
        public string PlannedDay { get; set; }

        /// <summary>
        /// **参数解释**：  事件执行窗口开始时间。  **约束限制**：  格式为 “hh:mm”。当end_time有值时，该字段必传。  **取值范围**：  不涉及。  **默认取值**：  “01:00”。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件执行窗口结束时间。  **约束限制**：  格式为 \&quot;hh:mm\&quot;。当start_time有值时，该字段必传。  **取值范围**：  不涉及。  **默认取值**：  “03:00”。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventScheduleWindow {\n");
            sb.Append("  plannedDay: ").Append(PlannedDay).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventScheduleWindow);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventScheduleWindow input)
        {
            if (input == null) return false;
            if (this.PlannedDay != input.PlannedDay || (this.PlannedDay != null && !this.PlannedDay.Equals(input.PlannedDay))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.PlannedDay != null) hashCode = hashCode * 59 + this.PlannedDay.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
