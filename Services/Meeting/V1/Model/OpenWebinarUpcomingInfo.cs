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
    /// 即将召开研讨会议信息。
    /// </summary>
    public class OpenWebinarUpcomingInfo 
    {

        /// <summary>
        /// 网络研讨会ID。
        /// </summary>
        [JsonProperty("conferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 企业ID。
        /// </summary>
        [JsonProperty("corpId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpId { get; set; }

        /// <summary>
        /// 网络研讨会主题。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 网络研讨会描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 网络研讨会开始时间（UTC时间），格式“yyyy-MM-dd HH:mm”。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 网络研讨会开始时间（UTC时间），格式“yyyy-MM-dd HH:mm”。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 会议通知中会议时间的时区信息。时区信息，参考[[时区映射关系](https://support.huaweicloud.com/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hws)[[时区映射关系](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hk)。 &gt; * 举例：“timeZoneID”:\&quot;26\&quot;，则通过华为云会议发送的会议通知中的时间将会标记为如“2021/11/11 星期四 00:00 - 02:00 (GMT) 格林威治标准时间:都柏林, 爱丁堡, 里斯本, 伦敦”。 
        /// </summary>
        [JsonProperty("timeZoneId", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeZoneId { get; set; }

        /// <summary>
        /// 网络研讨会预订者的用户UUID。
        /// </summary>
        [JsonProperty("scheduserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduserId { get; set; }

        /// <summary>
        /// 预订人部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 预订者名称。
        /// </summary>
        [JsonProperty("scheduserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduserName { get; set; }

        /// <summary>
        /// 网络研讨会VMR名称。
        /// </summary>
        [JsonProperty("vmrPkgName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgName { get; set; }

        /// <summary>
        /// 主持人入会地址。
        /// </summary>
        [JsonProperty("chairJoinUri", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairJoinUri { get; set; }

        /// <summary>
        /// 主持人密码。
        /// </summary>
        [JsonProperty("chairPasswd", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairPasswd { get; set; }

        /// <summary>
        /// 嘉宾入会地址。
        /// </summary>
        [JsonProperty("guestJoinUri", NullValueHandling = NullValueHandling.Ignore)]
        public string GuestJoinUri { get; set; }

        /// <summary>
        /// 嘉宾密码。
        /// </summary>
        [JsonProperty("guestPasswd", NullValueHandling = NullValueHandling.Ignore)]
        public string GuestPasswd { get; set; }

        /// <summary>
        /// 观众入会地址。
        /// </summary>
        [JsonProperty("audienceJoinUri", NullValueHandling = NullValueHandling.Ignore)]
        public string AudienceJoinUri { get; set; }

        /// <summary>
        /// 观众密码。
        /// </summary>
        [JsonProperty("audiencePasswd", NullValueHandling = NullValueHandling.Ignore)]
        public string AudiencePasswd { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenWebinarUpcomingInfo {\n");
            sb.Append("  conferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  corpId: ").Append(CorpId).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  timeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  scheduserId: ").Append(ScheduserId).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  scheduserName: ").Append(ScheduserName).Append("\n");
            sb.Append("  vmrPkgName: ").Append(VmrPkgName).Append("\n");
            sb.Append("  chairJoinUri: ").Append(ChairJoinUri).Append("\n");
            sb.Append("  chairPasswd: ").Append(ChairPasswd).Append("\n");
            sb.Append("  guestJoinUri: ").Append(GuestJoinUri).Append("\n");
            sb.Append("  guestPasswd: ").Append(GuestPasswd).Append("\n");
            sb.Append("  audienceJoinUri: ").Append(AudienceJoinUri).Append("\n");
            sb.Append("  audiencePasswd: ").Append(AudiencePasswd).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenWebinarUpcomingInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenWebinarUpcomingInfo input)
        {
            if (input == null) return false;
            if (this.ConferenceId != input.ConferenceId || (this.ConferenceId != null && !this.ConferenceId.Equals(input.ConferenceId))) return false;
            if (this.CorpId != input.CorpId || (this.CorpId != null && !this.CorpId.Equals(input.CorpId))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.TimeZoneId != input.TimeZoneId || (this.TimeZoneId != null && !this.TimeZoneId.Equals(input.TimeZoneId))) return false;
            if (this.ScheduserId != input.ScheduserId || (this.ScheduserId != null && !this.ScheduserId.Equals(input.ScheduserId))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.ScheduserName != input.ScheduserName || (this.ScheduserName != null && !this.ScheduserName.Equals(input.ScheduserName))) return false;
            if (this.VmrPkgName != input.VmrPkgName || (this.VmrPkgName != null && !this.VmrPkgName.Equals(input.VmrPkgName))) return false;
            if (this.ChairJoinUri != input.ChairJoinUri || (this.ChairJoinUri != null && !this.ChairJoinUri.Equals(input.ChairJoinUri))) return false;
            if (this.ChairPasswd != input.ChairPasswd || (this.ChairPasswd != null && !this.ChairPasswd.Equals(input.ChairPasswd))) return false;
            if (this.GuestJoinUri != input.GuestJoinUri || (this.GuestJoinUri != null && !this.GuestJoinUri.Equals(input.GuestJoinUri))) return false;
            if (this.GuestPasswd != input.GuestPasswd || (this.GuestPasswd != null && !this.GuestPasswd.Equals(input.GuestPasswd))) return false;
            if (this.AudienceJoinUri != input.AudienceJoinUri || (this.AudienceJoinUri != null && !this.AudienceJoinUri.Equals(input.AudienceJoinUri))) return false;
            if (this.AudiencePasswd != input.AudiencePasswd || (this.AudiencePasswd != null && !this.AudiencePasswd.Equals(input.AudiencePasswd))) return false;

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
                if (this.CorpId != null) hashCode = hashCode * 59 + this.CorpId.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.TimeZoneId != null) hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                if (this.ScheduserId != null) hashCode = hashCode * 59 + this.ScheduserId.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.ScheduserName != null) hashCode = hashCode * 59 + this.ScheduserName.GetHashCode();
                if (this.VmrPkgName != null) hashCode = hashCode * 59 + this.VmrPkgName.GetHashCode();
                if (this.ChairJoinUri != null) hashCode = hashCode * 59 + this.ChairJoinUri.GetHashCode();
                if (this.ChairPasswd != null) hashCode = hashCode * 59 + this.ChairPasswd.GetHashCode();
                if (this.GuestJoinUri != null) hashCode = hashCode * 59 + this.GuestJoinUri.GetHashCode();
                if (this.GuestPasswd != null) hashCode = hashCode * 59 + this.GuestPasswd.GetHashCode();
                if (this.AudienceJoinUri != null) hashCode = hashCode * 59 + this.AudienceJoinUri.GetHashCode();
                if (this.AudiencePasswd != null) hashCode = hashCode * 59 + this.AudiencePasswd.GetHashCode();
                return hashCode;
            }
        }
    }
}
