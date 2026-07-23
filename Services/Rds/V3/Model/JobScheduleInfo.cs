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
    /// 创建策略信息。
    /// </summary>
    public class JobScheduleInfo 
    {

        /// <summary>
        /// 策略id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否是用户自定义模板。false表示为系统默认模板。true表示为用户自定义模板。
        /// </summary>
        [JsonProperty("user_defined", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserDefined { get; set; }

        /// <summary>
        /// 策略类型，snapshot:快照策略, sync:同步策略。
        /// </summary>
        [JsonProperty("schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// 计划类型。  automatically：SQL Server代理启动时自动启动。 cpu_idle：CPU空闲时启动。 recurring：重复执行。 one_time：执行一次。
        /// </summary>
        [JsonProperty("job_schedule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobScheduleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("one_time_occurrence", NullValueHandling = NullValueHandling.Ignore)]
        public JobScheduleOneTimeOccurrenceInfo OneTimeOccurrence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public JobScheduleFrequencyInfo Frequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_frequency", NullValueHandling = NullValueHandling.Ignore)]
        public JobScheduleDailyFrequencyInfo DailyFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public JobScheduleDurationInfo Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobScheduleInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userDefined: ").Append(UserDefined).Append("\n");
            sb.Append("  scheduleType: ").Append(ScheduleType).Append("\n");
            sb.Append("  jobScheduleType: ").Append(JobScheduleType).Append("\n");
            sb.Append("  oneTimeOccurrence: ").Append(OneTimeOccurrence).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  dailyFrequency: ").Append(DailyFrequency).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobScheduleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobScheduleInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserDefined != input.UserDefined || (this.UserDefined != null && !this.UserDefined.Equals(input.UserDefined))) return false;
            if (this.ScheduleType != input.ScheduleType || (this.ScheduleType != null && !this.ScheduleType.Equals(input.ScheduleType))) return false;
            if (this.JobScheduleType != input.JobScheduleType || (this.JobScheduleType != null && !this.JobScheduleType.Equals(input.JobScheduleType))) return false;
            if (this.OneTimeOccurrence != input.OneTimeOccurrence || (this.OneTimeOccurrence != null && !this.OneTimeOccurrence.Equals(input.OneTimeOccurrence))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.DailyFrequency != input.DailyFrequency || (this.DailyFrequency != null && !this.DailyFrequency.Equals(input.DailyFrequency))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserDefined != null) hashCode = hashCode * 59 + this.UserDefined.GetHashCode();
                if (this.ScheduleType != null) hashCode = hashCode * 59 + this.ScheduleType.GetHashCode();
                if (this.JobScheduleType != null) hashCode = hashCode * 59 + this.JobScheduleType.GetHashCode();
                if (this.OneTimeOccurrence != null) hashCode = hashCode * 59 + this.OneTimeOccurrence.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.DailyFrequency != null) hashCode = hashCode * 59 + this.DailyFrequency.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
