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
    /// 历史召开研讨会议信息。
    /// </summary>
    public class OpenWebinarHistoryInfo 
    {

        /// <summary>
        /// 网络研讨会ID。
        /// </summary>
        [JsonProperty("conferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 网络研讨会UUID。
        /// </summary>
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 网络研讨会主题。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 网络研讨会预定者名称。
        /// </summary>
        [JsonProperty("scheduserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduserName { get; set; }

        /// <summary>
        /// 网络研讨主持人名称。
        /// </summary>
        [JsonProperty("moderator", NullValueHandling = NullValueHandling.Ignore)]
        public string Moderator { get; set; }

        /// <summary>
        /// 预订人部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 会议通知中会议时间的时区信息。时区信息，参考[[时区映射关系](https://support.huaweicloud.com/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hws)[[时区映射关系](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hk)。 &gt; * 举例：“timeZoneID”:\&quot;26\&quot;，则通过华为云会议发送的会议通知中的时间将会标记为如“2021/11/11 星期四 00:00 - 02:00 (GMT) 格林威治标准时间:都柏林, 爱丁堡, 里斯本, 伦敦”。 
        /// </summary>
        [JsonProperty("timeZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeZoneId { get; set; }

        /// <summary>
        /// 网络研讨会开始时间（UTC时间），格式“yyyy-MM-dd HH:mm”。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 网络研讨会持续时长，单位分钟。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 网络研讨会实际召开时间（UTC时间），格式“yyyy-MM-dd HH:mm”。
        /// </summary>
        [JsonProperty("actualStartTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualStartTime { get; set; }

        /// <summary>
        /// 网络研讨会结束时间（UTC时间），格式“yyyy-MM-dd HH:mm”。
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 网络研讨会实际时长，单位分钟。
        /// </summary>
        [JsonProperty("actualDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActualDuration { get; set; }

        /// <summary>
        /// 与会人数。
        /// </summary>
        [JsonProperty("attendeeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttendeeCount { get; set; }

        /// <summary>
        /// 主持人数。
        /// </summary>
        [JsonProperty("chairCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChairCount { get; set; }

        /// <summary>
        /// 嘉宾数。
        /// </summary>
        [JsonProperty("guestCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? GuestCount { get; set; }

        /// <summary>
        /// 观众人数。
        /// </summary>
        [JsonProperty("audienceCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudienceCount { get; set; }

        /// <summary>
        /// VMR ID。
        /// </summary>
        [JsonProperty("vmrId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrId { get; set; }

        /// <summary>
        /// 网络研讨会VMR最大观众数。
        /// </summary>
        [JsonProperty("vmrPkgAudienceParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgAudienceParties { get; set; }

        /// <summary>
        /// 网络研讨会VMR名称。
        /// </summary>
        [JsonProperty("vmrPkgName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenWebinarHistoryInfo {\n");
            sb.Append("  conferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  scheduserName: ").Append(ScheduserName).Append("\n");
            sb.Append("  moderator: ").Append(Moderator).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  timeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  actualStartTime: ").Append(ActualStartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  actualDuration: ").Append(ActualDuration).Append("\n");
            sb.Append("  attendeeCount: ").Append(AttendeeCount).Append("\n");
            sb.Append("  chairCount: ").Append(ChairCount).Append("\n");
            sb.Append("  guestCount: ").Append(GuestCount).Append("\n");
            sb.Append("  audienceCount: ").Append(AudienceCount).Append("\n");
            sb.Append("  vmrId: ").Append(VmrId).Append("\n");
            sb.Append("  vmrPkgAudienceParties: ").Append(VmrPkgAudienceParties).Append("\n");
            sb.Append("  vmrPkgName: ").Append(VmrPkgName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenWebinarHistoryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenWebinarHistoryInfo input)
        {
            if (input == null) return false;
            if (this.ConferenceId != input.ConferenceId || (this.ConferenceId != null && !this.ConferenceId.Equals(input.ConferenceId))) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ScheduserName != input.ScheduserName || (this.ScheduserName != null && !this.ScheduserName.Equals(input.ScheduserName))) return false;
            if (this.Moderator != input.Moderator || (this.Moderator != null && !this.Moderator.Equals(input.Moderator))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.TimeZoneId != input.TimeZoneId || (this.TimeZoneId != null && !this.TimeZoneId.Equals(input.TimeZoneId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.ActualStartTime != input.ActualStartTime || (this.ActualStartTime != null && !this.ActualStartTime.Equals(input.ActualStartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ActualDuration != input.ActualDuration || (this.ActualDuration != null && !this.ActualDuration.Equals(input.ActualDuration))) return false;
            if (this.AttendeeCount != input.AttendeeCount || (this.AttendeeCount != null && !this.AttendeeCount.Equals(input.AttendeeCount))) return false;
            if (this.ChairCount != input.ChairCount || (this.ChairCount != null && !this.ChairCount.Equals(input.ChairCount))) return false;
            if (this.GuestCount != input.GuestCount || (this.GuestCount != null && !this.GuestCount.Equals(input.GuestCount))) return false;
            if (this.AudienceCount != input.AudienceCount || (this.AudienceCount != null && !this.AudienceCount.Equals(input.AudienceCount))) return false;
            if (this.VmrId != input.VmrId || (this.VmrId != null && !this.VmrId.Equals(input.VmrId))) return false;
            if (this.VmrPkgAudienceParties != input.VmrPkgAudienceParties || (this.VmrPkgAudienceParties != null && !this.VmrPkgAudienceParties.Equals(input.VmrPkgAudienceParties))) return false;
            if (this.VmrPkgName != input.VmrPkgName || (this.VmrPkgName != null && !this.VmrPkgName.Equals(input.VmrPkgName))) return false;

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
                if (this.ConferenceId != null) hashCode = hashCode * 59 + this.ConferenceId.GetHashCode();
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ScheduserName != null) hashCode = hashCode * 59 + this.ScheduserName.GetHashCode();
                if (this.Moderator != null) hashCode = hashCode * 59 + this.Moderator.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.TimeZoneId != null) hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ActualStartTime != null) hashCode = hashCode * 59 + this.ActualStartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ActualDuration != null) hashCode = hashCode * 59 + this.ActualDuration.GetHashCode();
                if (this.AttendeeCount != null) hashCode = hashCode * 59 + this.AttendeeCount.GetHashCode();
                if (this.ChairCount != null) hashCode = hashCode * 59 + this.ChairCount.GetHashCode();
                if (this.GuestCount != null) hashCode = hashCode * 59 + this.GuestCount.GetHashCode();
                if (this.AudienceCount != null) hashCode = hashCode * 59 + this.AudienceCount.GetHashCode();
                if (this.VmrId != null) hashCode = hashCode * 59 + this.VmrId.GetHashCode();
                if (this.VmrPkgAudienceParties != null) hashCode = hashCode * 59 + this.VmrPkgAudienceParties.GetHashCode();
                if (this.VmrPkgName != null) hashCode = hashCode * 59 + this.VmrPkgName.GetHashCode();
                return hashCode;
            }
        }
    }
}
