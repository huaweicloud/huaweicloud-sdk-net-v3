using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAlarmStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 告警总数。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("total_alarm_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalAlarmCount { get; set; }

        /// <summary>
        /// **参数解释**: 环比比率。 **取值范围**: 值为0表示环比没有变化，值为空表示上一周期没有告警。
        /// </summary>
        [JsonProperty("ring_percentage", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RingPercentage { get; set; }

        /// <summary>
        /// **参数解释**: 实例级别的告警统计。
        /// </summary>
        [JsonProperty("instance_alarm_level_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceAlarmLevelStatisticResult> InstanceAlarmLevelStatistics { get; set; }

        /// <summary>
        /// **参数解释**: 全量告警统计。
        /// </summary>
        [JsonProperty("total_alarm_level_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmLevelStatisticsResult> TotalAlarmLevelStatistics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAlarmStatisticsResponse {\n");
            sb.Append("  totalAlarmCount: ").Append(TotalAlarmCount).Append("\n");
            sb.Append("  ringPercentage: ").Append(RingPercentage).Append("\n");
            sb.Append("  instanceAlarmLevelStatistics: ").Append(InstanceAlarmLevelStatistics).Append("\n");
            sb.Append("  totalAlarmLevelStatistics: ").Append(TotalAlarmLevelStatistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAlarmStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAlarmStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.TotalAlarmCount != input.TotalAlarmCount || (this.TotalAlarmCount != null && !this.TotalAlarmCount.Equals(input.TotalAlarmCount))) return false;
            if (this.RingPercentage != input.RingPercentage || (this.RingPercentage != null && !this.RingPercentage.Equals(input.RingPercentage))) return false;
            if (this.InstanceAlarmLevelStatistics != input.InstanceAlarmLevelStatistics || (this.InstanceAlarmLevelStatistics != null && input.InstanceAlarmLevelStatistics != null && !this.InstanceAlarmLevelStatistics.SequenceEqual(input.InstanceAlarmLevelStatistics))) return false;
            if (this.TotalAlarmLevelStatistics != input.TotalAlarmLevelStatistics || (this.TotalAlarmLevelStatistics != null && input.TotalAlarmLevelStatistics != null && !this.TotalAlarmLevelStatistics.SequenceEqual(input.TotalAlarmLevelStatistics))) return false;

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
                if (this.TotalAlarmCount != null) hashCode = hashCode * 59 + this.TotalAlarmCount.GetHashCode();
                if (this.RingPercentage != null) hashCode = hashCode * 59 + this.RingPercentage.GetHashCode();
                if (this.InstanceAlarmLevelStatistics != null) hashCode = hashCode * 59 + this.InstanceAlarmLevelStatistics.GetHashCode();
                if (this.TotalAlarmLevelStatistics != null) hashCode = hashCode * 59 + this.TotalAlarmLevelStatistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
