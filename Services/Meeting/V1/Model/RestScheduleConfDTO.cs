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
    /// 会议信息。
    /// </summary>
    public class RestScheduleConfDTO 
    {

        /// <summary>
        /// 会议开始时间（UTC时间）。格式：yyyy-MM-dd HH:mm。 &gt; * 创建预约会议时，如果没有指定开始时间或填空串，则表示会议马上开始 &gt; * 时间是UTC时间，即0时区的时间
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 会议持续时长，单位分钟。默认30分钟。最大1440分钟（24小时），最小15分钟。
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public int? Length { get; set; }

        /// <summary>
        /// 会议主题。最多128个字符。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 会议的媒体类型。 - Voice: 语音会议 - HDVideo: 视频会议
        /// </summary>
        [JsonProperty("mediaTypes", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaTypes { get; set; }

        /// <summary>
        /// 软终端创建即时会议时在当前字段带临时群组ID，由服务器在邀请其他与会者时在或者conference-info头域中携带。长度限制为31个字符。
        /// </summary>
        [JsonProperty("groupuri", NullValueHandling = NullValueHandling.Ignore)]
        public string Groupuri { get; set; }

        /// <summary>
        /// 与会者列表。
        /// </summary>
        [JsonProperty("attendees", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestAttendeeDTO> Attendees { get; set; }

        /// <summary>
        /// 会议是否自动启动录制，在录播类型为:录播、直播+录播时有效。默认为不自动启动。 - 0: 不自动启动录制 - 1: 自动启动录制
        /// </summary>
        [JsonProperty("isAutoRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRecord { get; set; }

        /// <summary>
        /// 会议媒体加密模式。默认值由企业级的配置填充。 - 0: 自适应加密 - 1: 强制加密 - 2: 不加密
        /// </summary>
        [JsonProperty("encryptMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? EncryptMode { get; set; }

        /// <summary>
        /// 会议通知短信或邮件的语言。默认中文。 - zh-CN: 简体中文 - en-US: 美国英文
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 会议通知中会议时间的时区信息。时区信息，参考[[时区映射关系](https://support.huaweicloud.com/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hws)[[时区映射关系](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0110.html#ZH-CN_TOPIC_0212714472__table137407441463)](tag:hk)。 &gt; * 举例：“timeZoneID”:\&quot;26\&quot;，则通过华为云会议发送的会议通知中的时间将会标记为如“2021/11/11 星期四 00:00 - 02:00 (GMT) 格林威治标准时间:都柏林, 爱丁堡, 里斯本, 伦敦”。 &gt; * 非周期会议，如果会议通知是通过第三方系统发送，则这个字段不用填写。
        /// </summary>
        [JsonProperty("timeZoneID", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneID { get; set; }

        /// <summary>
        /// 录播类型。默认为禁用。 - 0: 禁用 - 1: 直播 - 2: 录播 - 3: 直播+录播
        /// </summary>
        [JsonProperty("recordType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordType { get; set; }

        /// <summary>
        /// 主流直播推流地址，在录播类型为 :直播、直播+录播时有效。最大不超过255个字符。
        /// </summary>
        [JsonProperty("liveAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveAddress { get; set; }

        /// <summary>
        /// 辅流直播推流地址，在录播类型为 :直播、直播+录播时有效。最大不超过255个字符。
        /// </summary>
        [JsonProperty("auxAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string AuxAddress { get; set; }

        /// <summary>
        /// 是否录制辅流，在录播类型为：录播、录播+直播时有效。默认只录制视频主流，不录制辅流。  - 0: 不录制  - 1: 录制
        /// </summary>
        [JsonProperty("recordAuxStream", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuxStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confConfigInfo", NullValueHandling = NullValueHandling.Ignore)]
        public RestConfConfigDTO ConfConfigInfo { get; set; }

        /// <summary>
        /// 录播观看鉴权方式，在录播类型为:录播、直播+录播时有效。 - 0: 可通过链接观看/下载 - 1: 企业用户可观看/下载 - 2: 与会者可观看/下载
        /// </summary>
        [JsonProperty("recordAuthType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuthType { get; set; }

        /// <summary>
        /// 是否使用云会议室或者个人会议ID召开预约会议。默认0。 - 0: 不使用云会议室或者个人会议ID - 1: 使用云会议室或者个人会议ID
        /// </summary>
        [JsonProperty("vmrFlag", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cycleParams", NullValueHandling = NullValueHandling.Ignore)]
        public CycleParams CycleParams { get; set; }

        /// <summary>
        /// 绑定给当前创会帐号的VMR ID。通过[[查询云会议室及个人会议ID](https://support.huaweicloud.com/api-meeting/meeting_21_1106.html)](tag:hws)[[查询云会议室及个人会议ID](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_1106.html)](tag:hk)接口获取。 &gt; * vmrID取上述查询接口中返回的id，不是vmrId &gt; * 创建个人会议ID的会议时，使用vmrMode&#x3D;0的VMR；创建云会议室的会议时，使用vmrMode&#x3D;1的VMR
        /// </summary>
        [JsonProperty("vmrID", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrID { get; set; }

        /// <summary>
        /// 会议最大与会人数。默认值0。 * 0：无限制 * 大于0：会议最大与会人数 
        /// </summary>
        [JsonProperty("concurrentParticipants", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentParticipants { get; set; }

        /// <summary>
        /// 会议是否支持同声传译。默认值false。 * true:支持 * false:不支持 
        /// </summary>
        [JsonProperty("supportSimultaneousInterpretation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSimultaneousInterpretation { get; set; }

        /// <summary>
        /// 会议资源类型，此参数创建后不支持修改：  * 0: 并发 * 1: 云会议室 * 2: 网络研讨会 * 3: 预留模式，暂未开放 
        /// </summary>
        [JsonProperty("confResType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfResType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestScheduleConfDTO {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  length: ").Append(Length).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  mediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  groupuri: ").Append(Groupuri).Append("\n");
            sb.Append("  attendees: ").Append(Attendees).Append("\n");
            sb.Append("  isAutoRecord: ").Append(IsAutoRecord).Append("\n");
            sb.Append("  encryptMode: ").Append(EncryptMode).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  timeZoneID: ").Append(TimeZoneID).Append("\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  liveAddress: ").Append(LiveAddress).Append("\n");
            sb.Append("  auxAddress: ").Append(AuxAddress).Append("\n");
            sb.Append("  recordAuxStream: ").Append(RecordAuxStream).Append("\n");
            sb.Append("  confConfigInfo: ").Append(ConfConfigInfo).Append("\n");
            sb.Append("  recordAuthType: ").Append(RecordAuthType).Append("\n");
            sb.Append("  vmrFlag: ").Append(VmrFlag).Append("\n");
            sb.Append("  cycleParams: ").Append(CycleParams).Append("\n");
            sb.Append("  vmrID: ").Append(VmrID).Append("\n");
            sb.Append("  concurrentParticipants: ").Append(ConcurrentParticipants).Append("\n");
            sb.Append("  supportSimultaneousInterpretation: ").Append(SupportSimultaneousInterpretation).Append("\n");
            sb.Append("  confResType: ").Append(ConfResType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestScheduleConfDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestScheduleConfDTO input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Length != input.Length || (this.Length != null && !this.Length.Equals(input.Length))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.MediaTypes != input.MediaTypes || (this.MediaTypes != null && !this.MediaTypes.Equals(input.MediaTypes))) return false;
            if (this.Groupuri != input.Groupuri || (this.Groupuri != null && !this.Groupuri.Equals(input.Groupuri))) return false;
            if (this.Attendees != input.Attendees || (this.Attendees != null && input.Attendees != null && !this.Attendees.SequenceEqual(input.Attendees))) return false;
            if (this.IsAutoRecord != input.IsAutoRecord || (this.IsAutoRecord != null && !this.IsAutoRecord.Equals(input.IsAutoRecord))) return false;
            if (this.EncryptMode != input.EncryptMode || (this.EncryptMode != null && !this.EncryptMode.Equals(input.EncryptMode))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.TimeZoneID != input.TimeZoneID || (this.TimeZoneID != null && !this.TimeZoneID.Equals(input.TimeZoneID))) return false;
            if (this.RecordType != input.RecordType || (this.RecordType != null && !this.RecordType.Equals(input.RecordType))) return false;
            if (this.LiveAddress != input.LiveAddress || (this.LiveAddress != null && !this.LiveAddress.Equals(input.LiveAddress))) return false;
            if (this.AuxAddress != input.AuxAddress || (this.AuxAddress != null && !this.AuxAddress.Equals(input.AuxAddress))) return false;
            if (this.RecordAuxStream != input.RecordAuxStream || (this.RecordAuxStream != null && !this.RecordAuxStream.Equals(input.RecordAuxStream))) return false;
            if (this.ConfConfigInfo != input.ConfConfigInfo || (this.ConfConfigInfo != null && !this.ConfConfigInfo.Equals(input.ConfConfigInfo))) return false;
            if (this.RecordAuthType != input.RecordAuthType || (this.RecordAuthType != null && !this.RecordAuthType.Equals(input.RecordAuthType))) return false;
            if (this.VmrFlag != input.VmrFlag || (this.VmrFlag != null && !this.VmrFlag.Equals(input.VmrFlag))) return false;
            if (this.CycleParams != input.CycleParams || (this.CycleParams != null && !this.CycleParams.Equals(input.CycleParams))) return false;
            if (this.VmrID != input.VmrID || (this.VmrID != null && !this.VmrID.Equals(input.VmrID))) return false;
            if (this.ConcurrentParticipants != input.ConcurrentParticipants || (this.ConcurrentParticipants != null && !this.ConcurrentParticipants.Equals(input.ConcurrentParticipants))) return false;
            if (this.SupportSimultaneousInterpretation != input.SupportSimultaneousInterpretation || (this.SupportSimultaneousInterpretation != null && !this.SupportSimultaneousInterpretation.Equals(input.SupportSimultaneousInterpretation))) return false;
            if (this.ConfResType != input.ConfResType || (this.ConfResType != null && !this.ConfResType.Equals(input.ConfResType))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Length != null) hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.MediaTypes != null) hashCode = hashCode * 59 + this.MediaTypes.GetHashCode();
                if (this.Groupuri != null) hashCode = hashCode * 59 + this.Groupuri.GetHashCode();
                if (this.Attendees != null) hashCode = hashCode * 59 + this.Attendees.GetHashCode();
                if (this.IsAutoRecord != null) hashCode = hashCode * 59 + this.IsAutoRecord.GetHashCode();
                if (this.EncryptMode != null) hashCode = hashCode * 59 + this.EncryptMode.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TimeZoneID != null) hashCode = hashCode * 59 + this.TimeZoneID.GetHashCode();
                if (this.RecordType != null) hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.LiveAddress != null) hashCode = hashCode * 59 + this.LiveAddress.GetHashCode();
                if (this.AuxAddress != null) hashCode = hashCode * 59 + this.AuxAddress.GetHashCode();
                if (this.RecordAuxStream != null) hashCode = hashCode * 59 + this.RecordAuxStream.GetHashCode();
                if (this.ConfConfigInfo != null) hashCode = hashCode * 59 + this.ConfConfigInfo.GetHashCode();
                if (this.RecordAuthType != null) hashCode = hashCode * 59 + this.RecordAuthType.GetHashCode();
                if (this.VmrFlag != null) hashCode = hashCode * 59 + this.VmrFlag.GetHashCode();
                if (this.CycleParams != null) hashCode = hashCode * 59 + this.CycleParams.GetHashCode();
                if (this.VmrID != null) hashCode = hashCode * 59 + this.VmrID.GetHashCode();
                if (this.ConcurrentParticipants != null) hashCode = hashCode * 59 + this.ConcurrentParticipants.GetHashCode();
                if (this.SupportSimultaneousInterpretation != null) hashCode = hashCode * 59 + this.SupportSimultaneousInterpretation.GetHashCode();
                if (this.ConfResType != null) hashCode = hashCode * 59 + this.ConfResType.GetHashCode();
                return hashCode;
            }
        }
    }
}
