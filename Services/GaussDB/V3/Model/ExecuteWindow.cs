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
    /// **参数解释**：  事件执行窗口。  **约束限制**：  不涉及。
    /// </summary>
    public class ExecuteWindow 
    {

        /// <summary>
        /// **参数解释**：  计划执行日期，格式为：“yyyy-MM-dd”。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("planned_execution_day", NullValueHandling = NullValueHandling.Ignore)]
        public string PlannedExecutionDay { get; set; }

        /// <summary>
        /// **参数解释**：  事件执行窗口开始时间，格式为 \&quot;hh:mm\&quot;。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：  事件执行窗口结束时间，格式为 \&quot;hh:mm\&quot;。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteWindow {\n");
            sb.Append("  plannedExecutionDay: ").Append(PlannedExecutionDay).Append("\n");
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
            return this.Equals(input as ExecuteWindow);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteWindow input)
        {
            if (input == null) return false;
            if (this.PlannedExecutionDay != input.PlannedExecutionDay || (this.PlannedExecutionDay != null && !this.PlannedExecutionDay.Equals(input.PlannedExecutionDay))) return false;
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
                if (this.PlannedExecutionDay != null) hashCode = hashCode * 59 + this.PlannedExecutionDay.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
