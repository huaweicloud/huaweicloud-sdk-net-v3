using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 会议总体数据的单个时间点数据。
    /// </summary>
    public class StatisticConferenceDataItem 
    {

        /// <summary>
        /// 日期/月份，category &#x3D; conference_info时有效。 小时，category &#x3D; conference_hourly_info时有效。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 会议数(含VMR)。 category &#x3D; conference_info时有效。
        /// </summary>
        [JsonProperty("confCount", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfCount { get; set; }

        /// <summary>
        /// 会议时长(秒)(含VMR)。 category &#x3D; conference_info时有效。
        /// </summary>
        [JsonProperty("confDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfDuration { get; set; }

        /// <summary>
        /// 与会人次(含VMR)。 category &#x3D; conference_info时有效。
        /// </summary>
        [JsonProperty("attendeeCount", NullValueHandling = NullValueHandling.Ignore)]
        public string AttendeeCount { get; set; }

        /// <summary>
        /// 并发会议使用数。 category &#x3D; conference_info时有效。
        /// </summary>
        [JsonProperty("confConcurrentUsedCount", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfConcurrentUsedCount { get; set; }

        /// <summary>
        /// 小时单位会议数(含VMR)。 category &#x3D; conference_hourly_info时有效。
        /// </summary>
        [JsonProperty("conf24hCount", NullValueHandling = NullValueHandling.Ignore)]
        public string Conf24hCount { get; set; }

        /// <summary>
        /// 小时单位与会人次(含VMR)。 category &#x3D; conference_hourly_info时有效。
        /// </summary>
        [JsonProperty("conf24hAttendeeCount", NullValueHandling = NullValueHandling.Ignore)]
        public string Conf24hAttendeeCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticConferenceDataItem {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  confCount: ").Append(ConfCount).Append("\n");
            sb.Append("  confDuration: ").Append(ConfDuration).Append("\n");
            sb.Append("  attendeeCount: ").Append(AttendeeCount).Append("\n");
            sb.Append("  confConcurrentUsedCount: ").Append(ConfConcurrentUsedCount).Append("\n");
            sb.Append("  conf24hCount: ").Append(Conf24hCount).Append("\n");
            sb.Append("  conf24hAttendeeCount: ").Append(Conf24hAttendeeCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticConferenceDataItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticConferenceDataItem input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.ConfCount != input.ConfCount || (this.ConfCount != null && !this.ConfCount.Equals(input.ConfCount))) return false;
            if (this.ConfDuration != input.ConfDuration || (this.ConfDuration != null && !this.ConfDuration.Equals(input.ConfDuration))) return false;
            if (this.AttendeeCount != input.AttendeeCount || (this.AttendeeCount != null && !this.AttendeeCount.Equals(input.AttendeeCount))) return false;
            if (this.ConfConcurrentUsedCount != input.ConfConcurrentUsedCount || (this.ConfConcurrentUsedCount != null && !this.ConfConcurrentUsedCount.Equals(input.ConfConcurrentUsedCount))) return false;
            if (this.Conf24hCount != input.Conf24hCount || (this.Conf24hCount != null && !this.Conf24hCount.Equals(input.Conf24hCount))) return false;
            if (this.Conf24hAttendeeCount != input.Conf24hAttendeeCount || (this.Conf24hAttendeeCount != null && !this.Conf24hAttendeeCount.Equals(input.Conf24hAttendeeCount))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.ConfCount != null) hashCode = hashCode * 59 + this.ConfCount.GetHashCode();
                if (this.ConfDuration != null) hashCode = hashCode * 59 + this.ConfDuration.GetHashCode();
                if (this.AttendeeCount != null) hashCode = hashCode * 59 + this.AttendeeCount.GetHashCode();
                if (this.ConfConcurrentUsedCount != null) hashCode = hashCode * 59 + this.ConfConcurrentUsedCount.GetHashCode();
                if (this.Conf24hCount != null) hashCode = hashCode * 59 + this.Conf24hCount.GetHashCode();
                if (this.Conf24hAttendeeCount != null) hashCode = hashCode * 59 + this.Conf24hAttendeeCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
