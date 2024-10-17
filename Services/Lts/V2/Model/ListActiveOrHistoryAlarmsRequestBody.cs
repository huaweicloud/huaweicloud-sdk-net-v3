using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListActiveOrHistoryAlarmsRequestBody 
    {

        /// <summary>
        /// 关键字检索条件
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public int? Step { get; set; }

        /// <summary>
        /// 是否自定义查询时间段
        /// </summary>
        [JsonProperty("whether_custom_field", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhetherCustomField { get; set; }

        /// <summary>
        /// 自定义时间段开始时间(时间戳)
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 自定义时间段结束时间(时间戳)
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 非自定义时间段时间范围(单位为分钟)
        /// </summary>
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeRange { get; set; }

        /// <summary>
        /// 关键字检索条件
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// 告警级别(\&quot;Critical\&quot;,\&quot;Major\&quot;,\&quot;Minor\&quot;,\&quot;Info\&quot;)
        /// </summary>
        [JsonProperty("alarm_level_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AlarmLevelIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public Sort Sort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListActiveOrHistoryAlarmsRequestBody {\n");
            sb.Append("  step: ").Append(Step).Append("\n");
            sb.Append("  whetherCustomField: ").Append(WhetherCustomField).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  alarmLevelIds: ").Append(AlarmLevelIds).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListActiveOrHistoryAlarmsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListActiveOrHistoryAlarmsRequestBody input)
        {
            if (input == null) return false;
            if (this.Step != input.Step || (this.Step != null && !this.Step.Equals(input.Step))) return false;
            if (this.WhetherCustomField != input.WhetherCustomField || (this.WhetherCustomField != null && !this.WhetherCustomField.Equals(input.WhetherCustomField))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.TimeRange != input.TimeRange || (this.TimeRange != null && !this.TimeRange.Equals(input.TimeRange))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.AlarmLevelIds != input.AlarmLevelIds || (this.AlarmLevelIds != null && input.AlarmLevelIds != null && !this.AlarmLevelIds.SequenceEqual(input.AlarmLevelIds))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;

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
                if (this.Step != null) hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.WhetherCustomField != null) hashCode = hashCode * 59 + this.WhetherCustomField.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.TimeRange != null) hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.AlarmLevelIds != null) hashCode = hashCode * 59 + this.AlarmLevelIds.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                return hashCode;
            }
        }
    }
}
