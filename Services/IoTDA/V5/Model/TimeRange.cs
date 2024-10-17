using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 规则有效时间段
    /// </summary>
    public class TimeRange 
    {

        /// <summary>
        /// **参数说明**：规则条件触发的开始时间，格式：HH:mm。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数说明**：规则条件触发的结束时间，格式：HH:mm。若结束时间与开始时间一致，则时间为全天。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数说明**：星期列表，以逗号分隔。1代表周日，2代表周一，依次类推，默认为每天。星期列表中的日期为开始时间的日期。
        /// </summary>
        [JsonProperty("days_of_week", NullValueHandling = NullValueHandling.Ignore)]
        public string DaysOfWeek { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRange {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  daysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimeRange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TimeRange input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.DaysOfWeek != input.DaysOfWeek || (this.DaysOfWeek != null && !this.DaysOfWeek.Equals(input.DaysOfWeek))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.DaysOfWeek != null) hashCode = hashCode * 59 + this.DaysOfWeek.GetHashCode();
                return hashCode;
            }
        }
    }
}
