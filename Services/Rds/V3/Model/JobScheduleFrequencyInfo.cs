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
    /// 策略间隔周期。
    /// </summary>
    public class JobScheduleFrequencyInfo 
    {

        /// <summary>
        /// 策略频率类型 daily:按天, weekly:按周, monthly_day:按月、每月按天, monthly_week:按月、每月按周。
        /// </summary>
        [JsonProperty("freq_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FreqType { get; set; }

        /// <summary>
        /// 执行间隔。取值范围1至99。
        /// </summary>
        [JsonProperty("freq_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreqInterval { get; set; }

        /// <summary>
        /// 频率类型为按周时该参数必传，不为按周时不生效。 每周执行哪几天。参数值：Monday，Tuesday … Sunday
        /// </summary>
        [JsonProperty("freq_interval_weekly", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FreqIntervalWeekly { get; set; }

        /// <summary>
        /// 频率类型为按月、每月按天时该参数必传，不为按月、每月按天时时不生效。 每月执行的日期。取值范围1-31。
        /// </summary>
        [JsonProperty("freq_interval_day_monthly", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreqIntervalDayMonthly { get; set; }

        /// <summary>
        /// 频率类型为按月、每月按周时该参数必传，不为按月、每月按周时时不生效。 每周执行哪几天。 Sunday, Monday,Tuesday ... Saturday, day, weekday, weekend
        /// </summary>
        [JsonProperty("freq_interval_monthly", NullValueHandling = NullValueHandling.Ignore)]
        public string FreqIntervalMonthly { get; set; }

        /// <summary>
        /// 频率类型为按月、每月按周时该参数必传，不为按月、每月按周时时不生效。 每月在哪周执行。 first, second, third, fourth, last
        /// </summary>
        [JsonProperty("freq_relative_interval_monthly", NullValueHandling = NullValueHandling.Ignore)]
        public string FreqRelativeIntervalMonthly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobScheduleFrequencyInfo {\n");
            sb.Append("  freqType: ").Append(FreqType).Append("\n");
            sb.Append("  freqInterval: ").Append(FreqInterval).Append("\n");
            sb.Append("  freqIntervalWeekly: ").Append(FreqIntervalWeekly).Append("\n");
            sb.Append("  freqIntervalDayMonthly: ").Append(FreqIntervalDayMonthly).Append("\n");
            sb.Append("  freqIntervalMonthly: ").Append(FreqIntervalMonthly).Append("\n");
            sb.Append("  freqRelativeIntervalMonthly: ").Append(FreqRelativeIntervalMonthly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobScheduleFrequencyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobScheduleFrequencyInfo input)
        {
            if (input == null) return false;
            if (this.FreqType != input.FreqType || (this.FreqType != null && !this.FreqType.Equals(input.FreqType))) return false;
            if (this.FreqInterval != input.FreqInterval || (this.FreqInterval != null && !this.FreqInterval.Equals(input.FreqInterval))) return false;
            if (this.FreqIntervalWeekly != input.FreqIntervalWeekly || (this.FreqIntervalWeekly != null && input.FreqIntervalWeekly != null && !this.FreqIntervalWeekly.SequenceEqual(input.FreqIntervalWeekly))) return false;
            if (this.FreqIntervalDayMonthly != input.FreqIntervalDayMonthly || (this.FreqIntervalDayMonthly != null && !this.FreqIntervalDayMonthly.Equals(input.FreqIntervalDayMonthly))) return false;
            if (this.FreqIntervalMonthly != input.FreqIntervalMonthly || (this.FreqIntervalMonthly != null && !this.FreqIntervalMonthly.Equals(input.FreqIntervalMonthly))) return false;
            if (this.FreqRelativeIntervalMonthly != input.FreqRelativeIntervalMonthly || (this.FreqRelativeIntervalMonthly != null && !this.FreqRelativeIntervalMonthly.Equals(input.FreqRelativeIntervalMonthly))) return false;

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
                if (this.FreqType != null) hashCode = hashCode * 59 + this.FreqType.GetHashCode();
                if (this.FreqInterval != null) hashCode = hashCode * 59 + this.FreqInterval.GetHashCode();
                if (this.FreqIntervalWeekly != null) hashCode = hashCode * 59 + this.FreqIntervalWeekly.GetHashCode();
                if (this.FreqIntervalDayMonthly != null) hashCode = hashCode * 59 + this.FreqIntervalDayMonthly.GetHashCode();
                if (this.FreqIntervalMonthly != null) hashCode = hashCode * 59 + this.FreqIntervalMonthly.GetHashCode();
                if (this.FreqRelativeIntervalMonthly != null) hashCode = hashCode * 59 + this.FreqRelativeIntervalMonthly.GetHashCode();
                return hashCode;
            }
        }
    }
}
