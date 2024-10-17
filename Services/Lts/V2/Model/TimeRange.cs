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
    /// 此参数在请求实体中，采用json字符串格式。
    /// </summary>
    public class TimeRange 
    {

        /// <summary>
        /// 时区信息，默认为“UTC”。
        /// </summary>
        [JsonProperty("sql_time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlTimeZone { get; set; }

        /// <summary>
        /// 搜索起始时间（UTC时间，毫秒级）
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 搜索结束时间（UTC时间，毫秒级）。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 搜索是否包含起始时间点，默认为false。
        /// </summary>
        [JsonProperty("start_time_gt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StartTimeGt { get; set; }

        /// <summary>
        /// 搜索是否包含结束时间点，默认为false。
        /// </summary>
        [JsonProperty("end_time_lt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EndTimeLt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeRange {\n");
            sb.Append("  sqlTimeZone: ").Append(SqlTimeZone).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startTimeGt: ").Append(StartTimeGt).Append("\n");
            sb.Append("  endTimeLt: ").Append(EndTimeLt).Append("\n");
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
            if (this.SqlTimeZone != input.SqlTimeZone || (this.SqlTimeZone != null && !this.SqlTimeZone.Equals(input.SqlTimeZone))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StartTimeGt != input.StartTimeGt || (this.StartTimeGt != null && !this.StartTimeGt.Equals(input.StartTimeGt))) return false;
            if (this.EndTimeLt != input.EndTimeLt || (this.EndTimeLt != null && !this.EndTimeLt.Equals(input.EndTimeLt))) return false;

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
                if (this.SqlTimeZone != null) hashCode = hashCode * 59 + this.SqlTimeZone.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartTimeGt != null) hashCode = hashCode * 59 + this.StartTimeGt.GetHashCode();
                if (this.EndTimeLt != null) hashCode = hashCode * 59 + this.EndTimeLt.GetHashCode();
                return hashCode;
            }
        }
    }
}
