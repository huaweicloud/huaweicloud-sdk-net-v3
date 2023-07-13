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
    /// 条件中每日定时类型的信息，自定义结构。
    /// </summary>
    public class DailyTimerType 
    {

        /// <summary>
        /// **参数说明**：规则触发的时间，格式：HH:MM。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// **参数说明**：星期列表，以逗号分隔。1代表周日，2代表周一，依次类推，默认为每天。
        /// </summary>
        [JsonProperty("days_of_week", NullValueHandling = NullValueHandling.Ignore)]
        public string DaysOfWeek { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyTimerType {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  daysOfWeek: ").Append(DaysOfWeek).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DailyTimerType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DailyTimerType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.DaysOfWeek == input.DaysOfWeek ||
                    (this.DaysOfWeek != null &&
                    this.DaysOfWeek.Equals(input.DaysOfWeek))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.DaysOfWeek != null)
                    hashCode = hashCode * 59 + this.DaysOfWeek.GetHashCode();
                return hashCode;
            }
        }
    }
}
