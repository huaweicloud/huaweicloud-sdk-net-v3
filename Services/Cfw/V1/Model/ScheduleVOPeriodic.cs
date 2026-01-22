using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ScheduleVOPeriodic 
    {

        /// <summary>
        /// **参数解释**： 周期计划类型 **取值范围**： 0：每天 1：每周的某几天 2：每周的一段时间
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// **参数解释**： 周期计划开始时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 周期计划结束时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 每周的某几天 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("week_mask", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> WeekMask { get; set; }

        /// <summary>
        /// **参数解释**： 每周周期计划开始日 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("start_week", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartWeek { get; set; }

        /// <summary>
        /// **参数解释**： 每周周期计划结束日 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("end_week", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndWeek { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleVOPeriodic {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  weekMask: ").Append(WeekMask).Append("\n");
            sb.Append("  startWeek: ").Append(StartWeek).Append("\n");
            sb.Append("  endWeek: ").Append(EndWeek).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleVOPeriodic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleVOPeriodic input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.WeekMask != input.WeekMask || (this.WeekMask != null && input.WeekMask != null && !this.WeekMask.SequenceEqual(input.WeekMask))) return false;
            if (this.StartWeek != input.StartWeek || (this.StartWeek != null && !this.StartWeek.Equals(input.StartWeek))) return false;
            if (this.EndWeek != input.EndWeek || (this.EndWeek != null && !this.EndWeek.Equals(input.EndWeek))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.WeekMask != null) hashCode = hashCode * 59 + this.WeekMask.GetHashCode();
                if (this.StartWeek != null) hashCode = hashCode * 59 + this.StartWeek.GetHashCode();
                if (this.EndWeek != null) hashCode = hashCode * 59 + this.EndWeek.GetHashCode();
                return hashCode;
            }
        }
    }
}
