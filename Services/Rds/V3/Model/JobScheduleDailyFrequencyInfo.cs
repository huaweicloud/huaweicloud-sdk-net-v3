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
    /// 策略每日频率。
    /// </summary>
    public class JobScheduleDailyFrequencyInfo 
    {

        /// <summary>
        /// 每日频率类型 once:每日一次, multiple:每日多次。
        /// </summary>
        [JsonProperty("freq_subday_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FreqSubdayType { get; set; }

        /// <summary>
        /// 每日第一次执行时间。每日频率类型为每日一次时，则只执行这一次。 HH:mm:ss
        /// </summary>
        [JsonProperty("active_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveStartTime { get; set; }

        /// <summary>
        /// 最后一次执行时间。每日执行多次时该参数必传，每日执行一次时不生效。 HH:mm:ss
        /// </summary>
        [JsonProperty("active_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// 执行间隔。每日执行多次时该参数必传，每日执行一次时不生效。取值范围1至99
        /// </summary>
        [JsonProperty("freq_subday_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreqSubdayInterval { get; set; }

        /// <summary>
        /// 执行间隔的单位。每日执行多次时该参数必传，每日执行一次时不生效。 second:秒, minute:分, hour:时
        /// </summary>
        [JsonProperty("freq_interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string FreqIntervalUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobScheduleDailyFrequencyInfo {\n");
            sb.Append("  freqSubdayType: ").Append(FreqSubdayType).Append("\n");
            sb.Append("  activeStartTime: ").Append(ActiveStartTime).Append("\n");
            sb.Append("  activeEndTime: ").Append(ActiveEndTime).Append("\n");
            sb.Append("  freqSubdayInterval: ").Append(FreqSubdayInterval).Append("\n");
            sb.Append("  freqIntervalUnit: ").Append(FreqIntervalUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobScheduleDailyFrequencyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobScheduleDailyFrequencyInfo input)
        {
            if (input == null) return false;
            if (this.FreqSubdayType != input.FreqSubdayType || (this.FreqSubdayType != null && !this.FreqSubdayType.Equals(input.FreqSubdayType))) return false;
            if (this.ActiveStartTime != input.ActiveStartTime || (this.ActiveStartTime != null && !this.ActiveStartTime.Equals(input.ActiveStartTime))) return false;
            if (this.ActiveEndTime != input.ActiveEndTime || (this.ActiveEndTime != null && !this.ActiveEndTime.Equals(input.ActiveEndTime))) return false;
            if (this.FreqSubdayInterval != input.FreqSubdayInterval || (this.FreqSubdayInterval != null && !this.FreqSubdayInterval.Equals(input.FreqSubdayInterval))) return false;
            if (this.FreqIntervalUnit != input.FreqIntervalUnit || (this.FreqIntervalUnit != null && !this.FreqIntervalUnit.Equals(input.FreqIntervalUnit))) return false;

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
                if (this.FreqSubdayType != null) hashCode = hashCode * 59 + this.FreqSubdayType.GetHashCode();
                if (this.ActiveStartTime != null) hashCode = hashCode * 59 + this.ActiveStartTime.GetHashCode();
                if (this.ActiveEndTime != null) hashCode = hashCode * 59 + this.ActiveEndTime.GetHashCode();
                if (this.FreqSubdayInterval != null) hashCode = hashCode * 59 + this.FreqSubdayInterval.GetHashCode();
                if (this.FreqIntervalUnit != null) hashCode = hashCode * 59 + this.FreqIntervalUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
