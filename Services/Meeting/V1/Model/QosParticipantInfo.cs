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
    /// 会议与会者QoS告警信息。
    /// </summary>
    public class QosParticipantInfo 
    {

        /// <summary>
        /// 会议的UUID。
        /// </summary>
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 与会者标识。
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 用户UUID。
        /// </summary>
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 与会者的名称。
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 入会终端类型。 - PC: PC机 - MOBILE: 手机 - PAD：PAD设备 - MAC：MAC设备 - WEB：WEB方式入会，如通过WebRTC入会 - ROOM: 会议室 - 硬件终端：显示具体的硬件设备类型，如TE50, HUAWEI IDEAHUB, CISCO等 - OTHER: 其他设备
        /// </summary>
        [JsonProperty("terminalType", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalType { get; set; }

        /// <summary>
        /// 与会者角色。 - host：主持人 - guest：来宾 - audience：观众
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 与会者的IP地址。
        /// </summary>
        [JsonProperty("ipAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 国家。
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 省市（仅限中国）。
        /// </summary>
        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// 城市（仅限中国）。
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// 华为云会议APP版本。
        /// </summary>
        [JsonProperty("appVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 入会时间(UTC时间), Unix时间戳（单位毫秒）。
        /// </summary>
        [JsonProperty("joinTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? JoinTime { get; set; }

        /// <summary>
        /// 离会时间(UTC时间), Unix时间戳（单位毫秒）。 &gt; * 与会者未离会：leftTime &#x3D; 0 &gt; * 与会者已离会：leftTime &#x3D; 实际离会时间
        /// </summary>
        [JsonProperty("leftTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? LeftTime { get; set; }

        /// <summary>
        /// 终端操作系统信息。
        /// </summary>
        [JsonProperty("systemInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemInfo { get; set; }

        /// <summary>
        /// 网络类型。
        /// </summary>
        [JsonProperty("networkType", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        /// <summary>
        /// 总体告警。 * YES：音频（发送/接收），视频（发送/接收），屏幕共享（发送/接收），CPU任一项产生告警，总体告警状态即为 YES * NO：无告警
        /// </summary>
        [JsonProperty("alarm", NullValueHandling = NullValueHandling.Ignore)]
        public string Alarm { get; set; }

        /// <summary>
        /// 音频发送告警。 * YES ：发送音频的抖动，时延，丢包率任一项产生阈值告警，则音频发送告警状态为YES * NO：发送音频无告警
        /// </summary>
        [JsonProperty("audioAlarmSend", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioAlarmSend { get; set; }

        /// <summary>
        /// 视频发送告警。 * YES ：发送视频的抖动，时延，丢包率任一项产生阈值告警，则视频发送告警状态为YES * NO：发送视频无告警
        /// </summary>
        [JsonProperty("videoAlarmSend", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoAlarmSend { get; set; }

        /// <summary>
        /// 屏幕共享发送告警。 * YES：发送屏幕共享的抖动，时延，丢包率任一项产生阈值告警，则屏幕共享发送告警状态为YES * NO：发送屏幕共享无告警
        /// </summary>
        [JsonProperty("screenAlarmSend", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenAlarmSend { get; set; }

        /// <summary>
        /// 音频接收告警。 * YES：接收音频的抖动，时延，丢包率任一项产生阈值告警，则音频接收告警状态为YES * NO：接收音频无告警
        /// </summary>
        [JsonProperty("audioAlarmRec", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioAlarmRec { get; set; }

        /// <summary>
        /// 视频接收告警。 * YES：接收视频的抖动，时延，丢包率任一项产生阈值告警，则视频接收告警状态为YES * NO：接收视频无告警
        /// </summary>
        [JsonProperty("videoAlarmRec", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoAlarmRec { get; set; }

        /// <summary>
        /// 屏幕共享接收告警。 * YES：接收屏幕共享的抖动，时延，丢包率任一项产生阈值告警，则屏幕共享接收告警状态为YES * NO：接收屏幕共享无告警
        /// </summary>
        [JsonProperty("screenAlarmRec", NullValueHandling = NullValueHandling.Ignore)]
        public string ScreenAlarmRec { get; set; }

        /// <summary>
        /// CPU告警。 * YES：端侧的APP最大CPU使用率或系统最大CPU使用率任一项产生阈值告警，则CPU告警状态为YES * NO：CPU无告警
        /// </summary>
        [JsonProperty("cpuAlarm", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuAlarm { get; set; }

        /// <summary>
        /// 麦克风。
        /// </summary>
        [JsonProperty("microphoneInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string MicrophoneInfo { get; set; }

        /// <summary>
        /// 扬声器。
        /// </summary>
        [JsonProperty("speakerInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string SpeakerInfo { get; set; }

        /// <summary>
        /// 摄像头。
        /// </summary>
        [JsonProperty("cameraInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string CameraInfo { get; set; }

        /// <summary>
        /// 数据中心。
        /// </summary>
        [JsonProperty("dataCenter", NullValueHandling = NullValueHandling.Ignore)]
        public string DataCenter { get; set; }

        /// <summary>
        /// 离会原因。此字段仅标识离会原因，不做为是否已离会的判断依据。正在与会人员的离会原因初始值 &#x3D; 0。 * 0：正常离会 * 1：网络异常离会
        /// </summary>
        [JsonProperty("leftReason", NullValueHandling = NullValueHandling.Ignore)]
        public int? LeftReason { get; set; }

        /// <summary>
        /// 与会者是否存在QoS数据。 * true：存在QoS数据 * false：不存在QoS数据
        /// </summary>
        [JsonProperty("existQos", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExistQos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosParticipantInfo {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  terminalType: ").Append(TerminalType).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  province: ").Append(Province).Append("\n");
            sb.Append("  city: ").Append(City).Append("\n");
            sb.Append("  appVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  joinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  leftTime: ").Append(LeftTime).Append("\n");
            sb.Append("  systemInfo: ").Append(SystemInfo).Append("\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  alarm: ").Append(Alarm).Append("\n");
            sb.Append("  audioAlarmSend: ").Append(AudioAlarmSend).Append("\n");
            sb.Append("  videoAlarmSend: ").Append(VideoAlarmSend).Append("\n");
            sb.Append("  screenAlarmSend: ").Append(ScreenAlarmSend).Append("\n");
            sb.Append("  audioAlarmRec: ").Append(AudioAlarmRec).Append("\n");
            sb.Append("  videoAlarmRec: ").Append(VideoAlarmRec).Append("\n");
            sb.Append("  screenAlarmRec: ").Append(ScreenAlarmRec).Append("\n");
            sb.Append("  cpuAlarm: ").Append(CpuAlarm).Append("\n");
            sb.Append("  microphoneInfo: ").Append(MicrophoneInfo).Append("\n");
            sb.Append("  speakerInfo: ").Append(SpeakerInfo).Append("\n");
            sb.Append("  cameraInfo: ").Append(CameraInfo).Append("\n");
            sb.Append("  dataCenter: ").Append(DataCenter).Append("\n");
            sb.Append("  leftReason: ").Append(LeftReason).Append("\n");
            sb.Append("  existQos: ").Append(ExistQos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosParticipantInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosParticipantInfo input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.TerminalType != input.TerminalType || (this.TerminalType != null && !this.TerminalType.Equals(input.TerminalType))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.Province != input.Province || (this.Province != null && !this.Province.Equals(input.Province))) return false;
            if (this.City != input.City || (this.City != null && !this.City.Equals(input.City))) return false;
            if (this.AppVersion != input.AppVersion || (this.AppVersion != null && !this.AppVersion.Equals(input.AppVersion))) return false;
            if (this.JoinTime != input.JoinTime || (this.JoinTime != null && !this.JoinTime.Equals(input.JoinTime))) return false;
            if (this.LeftTime != input.LeftTime || (this.LeftTime != null && !this.LeftTime.Equals(input.LeftTime))) return false;
            if (this.SystemInfo != input.SystemInfo || (this.SystemInfo != null && !this.SystemInfo.Equals(input.SystemInfo))) return false;
            if (this.NetworkType != input.NetworkType || (this.NetworkType != null && !this.NetworkType.Equals(input.NetworkType))) return false;
            if (this.Alarm != input.Alarm || (this.Alarm != null && !this.Alarm.Equals(input.Alarm))) return false;
            if (this.AudioAlarmSend != input.AudioAlarmSend || (this.AudioAlarmSend != null && !this.AudioAlarmSend.Equals(input.AudioAlarmSend))) return false;
            if (this.VideoAlarmSend != input.VideoAlarmSend || (this.VideoAlarmSend != null && !this.VideoAlarmSend.Equals(input.VideoAlarmSend))) return false;
            if (this.ScreenAlarmSend != input.ScreenAlarmSend || (this.ScreenAlarmSend != null && !this.ScreenAlarmSend.Equals(input.ScreenAlarmSend))) return false;
            if (this.AudioAlarmRec != input.AudioAlarmRec || (this.AudioAlarmRec != null && !this.AudioAlarmRec.Equals(input.AudioAlarmRec))) return false;
            if (this.VideoAlarmRec != input.VideoAlarmRec || (this.VideoAlarmRec != null && !this.VideoAlarmRec.Equals(input.VideoAlarmRec))) return false;
            if (this.ScreenAlarmRec != input.ScreenAlarmRec || (this.ScreenAlarmRec != null && !this.ScreenAlarmRec.Equals(input.ScreenAlarmRec))) return false;
            if (this.CpuAlarm != input.CpuAlarm || (this.CpuAlarm != null && !this.CpuAlarm.Equals(input.CpuAlarm))) return false;
            if (this.MicrophoneInfo != input.MicrophoneInfo || (this.MicrophoneInfo != null && !this.MicrophoneInfo.Equals(input.MicrophoneInfo))) return false;
            if (this.SpeakerInfo != input.SpeakerInfo || (this.SpeakerInfo != null && !this.SpeakerInfo.Equals(input.SpeakerInfo))) return false;
            if (this.CameraInfo != input.CameraInfo || (this.CameraInfo != null && !this.CameraInfo.Equals(input.CameraInfo))) return false;
            if (this.DataCenter != input.DataCenter || (this.DataCenter != null && !this.DataCenter.Equals(input.DataCenter))) return false;
            if (this.LeftReason != input.LeftReason || (this.LeftReason != null && !this.LeftReason.Equals(input.LeftReason))) return false;
            if (this.ExistQos != input.ExistQos || (this.ExistQos != null && !this.ExistQos.Equals(input.ExistQos))) return false;

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
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.TerminalType != null) hashCode = hashCode * 59 + this.TerminalType.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Province != null) hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.City != null) hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.AppVersion != null) hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.JoinTime != null) hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                if (this.LeftTime != null) hashCode = hashCode * 59 + this.LeftTime.GetHashCode();
                if (this.SystemInfo != null) hashCode = hashCode * 59 + this.SystemInfo.GetHashCode();
                if (this.NetworkType != null) hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.Alarm != null) hashCode = hashCode * 59 + this.Alarm.GetHashCode();
                if (this.AudioAlarmSend != null) hashCode = hashCode * 59 + this.AudioAlarmSend.GetHashCode();
                if (this.VideoAlarmSend != null) hashCode = hashCode * 59 + this.VideoAlarmSend.GetHashCode();
                if (this.ScreenAlarmSend != null) hashCode = hashCode * 59 + this.ScreenAlarmSend.GetHashCode();
                if (this.AudioAlarmRec != null) hashCode = hashCode * 59 + this.AudioAlarmRec.GetHashCode();
                if (this.VideoAlarmRec != null) hashCode = hashCode * 59 + this.VideoAlarmRec.GetHashCode();
                if (this.ScreenAlarmRec != null) hashCode = hashCode * 59 + this.ScreenAlarmRec.GetHashCode();
                if (this.CpuAlarm != null) hashCode = hashCode * 59 + this.CpuAlarm.GetHashCode();
                if (this.MicrophoneInfo != null) hashCode = hashCode * 59 + this.MicrophoneInfo.GetHashCode();
                if (this.SpeakerInfo != null) hashCode = hashCode * 59 + this.SpeakerInfo.GetHashCode();
                if (this.CameraInfo != null) hashCode = hashCode * 59 + this.CameraInfo.GetHashCode();
                if (this.DataCenter != null) hashCode = hashCode * 59 + this.DataCenter.GetHashCode();
                if (this.LeftReason != null) hashCode = hashCode * 59 + this.LeftReason.GetHashCode();
                if (this.ExistQos != null) hashCode = hashCode * 59 + this.ExistQos.GetHashCode();
                return hashCode;
            }
        }
    }
}
