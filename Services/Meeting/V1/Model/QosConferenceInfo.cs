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
    /// 会议QoS告警信息。
    /// </summary>
    public class QosConferenceInfo 
    {

        /// <summary>
        /// 会议UUID。
        /// </summary>
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 会议主题。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 会议预订者名称。
        /// </summary>
        [JsonProperty("scheduserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduserName { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 总体告警 。 * YES：会议的音频、视频、屏幕共享、CPU任一项产生告警，总体告警就为YES * NO：无告警
        /// </summary>
        [JsonProperty("alarm", NullValueHandling = NullValueHandling.Ignore)]
        public string Alarm { get; set; }

        /// <summary>
        /// 音频告警 。 * YES：会议中任一与会者存在音频告警，会议音频告警就为YES * NO：无音频告警
        /// </summary>
        [JsonProperty("audioAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioAlarm { get; set; }

        /// <summary>
        /// 视频告警。 * YES：会议中任一与会者存在视频告警，会议视频告警就为YES * NO：无音视频警
        /// </summary>
        [JsonProperty("videoAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoAlarm { get; set; }

        /// <summary>
        /// 屏幕共享告警 YES/NO。 * YES：会议中任一与会者存在屏幕共享告警，会议屏幕共享告警就为YES * NO：无屏幕共享告警
        /// </summary>
        [JsonProperty("screenAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenAlarm { get; set; }

        /// <summary>
        /// CPU告警。 * YES：会议中任一与会者存在CPU告警，会议CPU告警就为YES * NO：无CPU告警
        /// </summary>
        [JsonProperty("cpuAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuAlarm { get; set; }

        /// <summary>
        /// 时区信息，参考[[时区映射关系](https://support.huaweicloud.com/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hws)[[时区映射关系](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hk)。 &gt; 举例：“timeZoneID”:\&quot;26\&quot;，则通过华为云会议发送的会议通知中的时间将会标记为如“2021/11/11 星期四 00:00 - 02:00 (GMT) 格林威治标准时间:都柏林, 爱丁堡, 里斯本, 伦敦”。 
        /// </summary>
        [JsonProperty("timeZoneID", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneID { get; set; }

        /// <summary>
        /// 会议开始时间(UTC时间), Unix时间戳（单位毫秒）。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 会议结束时间(UTC时间), Unix时间戳（单位毫秒）。 &gt; * 在线会议：会议召开中，endTime &#x3D; 会议预计结束时间 &gt; * 历史会议：会议已结束，endTime &#x3D; 会议实际结束时间
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 会议召开时长（分钟）。 &gt; * 在线会议：会议召开中，duration &#x3D; 0 &gt; * 历史会议：会议已结束，duration &#x3D; 会议实际召开时间
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 与会方数。 &gt; 同一用户多次进出会议属于不同的与会方，与会方数计算多次。
        /// </summary>
        [JsonProperty("participants", NullValueHandling = NullValueHandling.Ignore)]
        public int? Participants { get; set; }

        /// <summary>
        /// 是否网络研讨会。
        /// </summary>
        [JsonProperty("webinar", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Webinar { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosConferenceInfo {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  scheduserName: ").Append(ScheduserName).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  alarm: ").Append(Alarm).Append("\n");
            sb.Append("  audioAlarm: ").Append(AudioAlarm).Append("\n");
            sb.Append("  videoAlarm: ").Append(VideoAlarm).Append("\n");
            sb.Append("  screenAlarm: ").Append(ScreenAlarm).Append("\n");
            sb.Append("  cpuAlarm: ").Append(CpuAlarm).Append("\n");
            sb.Append("  timeZoneID: ").Append(TimeZoneID).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  participants: ").Append(Participants).Append("\n");
            sb.Append("  webinar: ").Append(Webinar).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosConferenceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosConferenceInfo input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ScheduserName != input.ScheduserName || (this.ScheduserName != null && !this.ScheduserName.Equals(input.ScheduserName))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.Alarm != input.Alarm || (this.Alarm != null && !this.Alarm.Equals(input.Alarm))) return false;
            if (this.AudioAlarm != input.AudioAlarm || (this.AudioAlarm != null && !this.AudioAlarm.Equals(input.AudioAlarm))) return false;
            if (this.VideoAlarm != input.VideoAlarm || (this.VideoAlarm != null && !this.VideoAlarm.Equals(input.VideoAlarm))) return false;
            if (this.ScreenAlarm != input.ScreenAlarm || (this.ScreenAlarm != null && !this.ScreenAlarm.Equals(input.ScreenAlarm))) return false;
            if (this.CpuAlarm != input.CpuAlarm || (this.CpuAlarm != null && !this.CpuAlarm.Equals(input.CpuAlarm))) return false;
            if (this.TimeZoneID != input.TimeZoneID || (this.TimeZoneID != null && !this.TimeZoneID.Equals(input.TimeZoneID))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Participants != input.Participants || (this.Participants != null && !this.Participants.Equals(input.Participants))) return false;
            if (this.Webinar != input.Webinar || (this.Webinar != null && !this.Webinar.Equals(input.Webinar))) return false;

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
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                if (this.ConferenceID != null) hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ScheduserName != null) hashCode = hashCode * 59 + this.ScheduserName.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.Alarm != null) hashCode = hashCode * 59 + this.Alarm.GetHashCode();
                if (this.AudioAlarm != null) hashCode = hashCode * 59 + this.AudioAlarm.GetHashCode();
                if (this.VideoAlarm != null) hashCode = hashCode * 59 + this.VideoAlarm.GetHashCode();
                if (this.ScreenAlarm != null) hashCode = hashCode * 59 + this.ScreenAlarm.GetHashCode();
                if (this.CpuAlarm != null) hashCode = hashCode * 59 + this.CpuAlarm.GetHashCode();
                if (this.TimeZoneID != null) hashCode = hashCode * 59 + this.TimeZoneID.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Participants != null) hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.Webinar != null) hashCode = hashCode * 59 + this.Webinar.GetHashCode();
                return hashCode;
            }
        }
    }
}
