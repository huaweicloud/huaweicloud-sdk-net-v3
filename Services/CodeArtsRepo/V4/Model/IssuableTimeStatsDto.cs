using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 合并请求的时间统计信息
    /// </summary>
    public class IssuableTimeStatsDto 
    {

        /// <summary>
        /// 合并请求时间估计
        /// </summary>
        [JsonProperty("time_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeEstimate { get; set; }

        /// <summary>
        /// 合并请求总时长
        /// </summary>
        [JsonProperty("total_time_spent", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTimeSpent { get; set; }

        /// <summary>
        /// 合并请求人类时间估计
        /// </summary>
        [JsonProperty("human_time_estimate", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanTimeEstimate { get; set; }

        /// <summary>
        /// 合并请求人类总时长
        /// </summary>
        [JsonProperty("human_total_time_spent", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanTotalTimeSpent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssuableTimeStatsDto {\n");
            sb.Append("  timeEstimate: ").Append(TimeEstimate).Append("\n");
            sb.Append("  totalTimeSpent: ").Append(TotalTimeSpent).Append("\n");
            sb.Append("  humanTimeEstimate: ").Append(HumanTimeEstimate).Append("\n");
            sb.Append("  humanTotalTimeSpent: ").Append(HumanTotalTimeSpent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssuableTimeStatsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssuableTimeStatsDto input)
        {
            if (input == null) return false;
            if (this.TimeEstimate != input.TimeEstimate || (this.TimeEstimate != null && !this.TimeEstimate.Equals(input.TimeEstimate))) return false;
            if (this.TotalTimeSpent != input.TotalTimeSpent || (this.TotalTimeSpent != null && !this.TotalTimeSpent.Equals(input.TotalTimeSpent))) return false;
            if (this.HumanTimeEstimate != input.HumanTimeEstimate || (this.HumanTimeEstimate != null && !this.HumanTimeEstimate.Equals(input.HumanTimeEstimate))) return false;
            if (this.HumanTotalTimeSpent != input.HumanTotalTimeSpent || (this.HumanTotalTimeSpent != null && !this.HumanTotalTimeSpent.Equals(input.HumanTotalTimeSpent))) return false;

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
                if (this.TimeEstimate != null) hashCode = hashCode * 59 + this.TimeEstimate.GetHashCode();
                if (this.TotalTimeSpent != null) hashCode = hashCode * 59 + this.TotalTimeSpent.GetHashCode();
                if (this.HumanTimeEstimate != null) hashCode = hashCode * 59 + this.HumanTimeEstimate.GetHashCode();
                if (this.HumanTotalTimeSpent != null) hashCode = hashCode * 59 + this.HumanTotalTimeSpent.GetHashCode();
                return hashCode;
            }
        }
    }
}
