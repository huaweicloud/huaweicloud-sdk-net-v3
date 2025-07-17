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
    /// 会议其他配置信息。
    /// </summary>
    public class RestConfConfigDTO 
    {

        /// <summary>
        /// 是否需要发送会议邮件通知。默认值由企业级配置决定。 - true: 需要 - false: 不需要
        /// </summary>
        [JsonProperty("isSendNotify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSendNotify { get; set; }

        /// <summary>
        /// 是否需要发送会议短信通知。默认值由企业级配置决定。 - true: 需要 - false: 不需要 &gt; 只有正式商用企业才有发送会议短信通知的权限，免费企业即使isSendSms设置成true也不会发送会议短信通知。
        /// </summary>
        [JsonProperty("isSendSms", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSendSms { get; set; }

        /// <summary>
        /// 是否需要发送会议邮件日历通知。默认值由企业级配置决定。 - true: 需要 - false: 不需要
        /// </summary>
        [JsonProperty("isSendCalendar", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSendCalendar { get; set; }

        /// <summary>
        /// 来宾入会,软终端是否自动静音。默认值由企业级配置决定。 - true: 自动静音 - false: 不自动静音
        /// </summary>
        [JsonProperty("isAutoMute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoMute { get; set; }

        /// <summary>
        /// 来宾入会,硬终端是否自动静音。默认值由企业级配置决定。 - true: 自动静音 - false: 不自动静音
        /// </summary>
        [JsonProperty("isHardTerminalAutoMute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHardTerminalAutoMute { get; set; }

        /// <summary>
        /// 是否来宾免密。 - true: 免密 - false: 需要密码 &gt; 仅随机会议ID的会议生效。
        /// </summary>
        [JsonProperty("isGuestFreePwd", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGuestFreePwd { get; set; }

        /// <summary>
        /// 允许加入会议的范围。 - 0: 所有用户 - 2: 企业内用户 - 3: 被邀请用户
        /// </summary>
        [JsonProperty("callInRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public int? CallInRestriction { get; set; }

        /// <summary>
        /// 是否允许来宾启动会议。 - true: 允许来宾启动会议 - false: 禁止来宾启动会议 &gt; 仅随机会议ID的会议生效。
        /// </summary>
        [JsonProperty("allowGuestStartConf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowGuestStartConf { get; set; }

        /// <summary>
        /// 来宾密码（4-16位长度的纯数字）。
        /// </summary>
        [JsonProperty("guestPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string GuestPwd { get; set; }

        /// <summary>
        /// 云会议室的会议ID模式。 * 0：固定会议ID * 1：随机会议ID
        /// </summary>
        [JsonProperty("vmrIDType", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrIDType { get; set; }

        /// <summary>
        /// 自动延长会议时长（取值范围0-60）。 * 0：表示会议到点自动结束，不延长会议 * 其他：表示自动延长的时长 &gt; * 自动结束会议是按照会议时长计算。比如预定的会议是9:00开始11:00结束，会议时长2个小时，如果与会者8:00就加入会议了，那会议在10:00就会自动结束 &gt; * 设置成其他值时，只要会中还有与会者，会议自动多次延长
        /// </summary>
        [JsonProperty("prolongLength", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProlongLength { get; set; }

        /// <summary>
        /// 开启或者关闭等候室。 * true：开启 * false：不开启
        /// </summary>
        [JsonProperty("enableWaitingRoom", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWaitingRoom { get; set; }

        /// <summary>
        /// 主持人入会是否开启摄像头。 * true：开启 * false：不开启
        /// </summary>
        [JsonProperty("isHostCameraOn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHostCameraOn { get; set; }

        /// <summary>
        /// 来宾入会是否开启摄像头。 * true：开启 * false：不开启
        /// </summary>
        [JsonProperty("isGuestCameraOn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGuestCameraOn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestConfConfigDTO {\n");
            sb.Append("  isSendNotify: ").Append(IsSendNotify).Append("\n");
            sb.Append("  isSendSms: ").Append(IsSendSms).Append("\n");
            sb.Append("  isSendCalendar: ").Append(IsSendCalendar).Append("\n");
            sb.Append("  isAutoMute: ").Append(IsAutoMute).Append("\n");
            sb.Append("  isHardTerminalAutoMute: ").Append(IsHardTerminalAutoMute).Append("\n");
            sb.Append("  isGuestFreePwd: ").Append(IsGuestFreePwd).Append("\n");
            sb.Append("  callInRestriction: ").Append(CallInRestriction).Append("\n");
            sb.Append("  allowGuestStartConf: ").Append(AllowGuestStartConf).Append("\n");
            sb.Append("  guestPwd: ").Append(GuestPwd).Append("\n");
            sb.Append("  vmrIDType: ").Append(VmrIDType).Append("\n");
            sb.Append("  prolongLength: ").Append(ProlongLength).Append("\n");
            sb.Append("  enableWaitingRoom: ").Append(EnableWaitingRoom).Append("\n");
            sb.Append("  isHostCameraOn: ").Append(IsHostCameraOn).Append("\n");
            sb.Append("  isGuestCameraOn: ").Append(IsGuestCameraOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestConfConfigDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestConfConfigDTO input)
        {
            if (input == null) return false;
            if (this.IsSendNotify != input.IsSendNotify || (this.IsSendNotify != null && !this.IsSendNotify.Equals(input.IsSendNotify))) return false;
            if (this.IsSendSms != input.IsSendSms || (this.IsSendSms != null && !this.IsSendSms.Equals(input.IsSendSms))) return false;
            if (this.IsSendCalendar != input.IsSendCalendar || (this.IsSendCalendar != null && !this.IsSendCalendar.Equals(input.IsSendCalendar))) return false;
            if (this.IsAutoMute != input.IsAutoMute || (this.IsAutoMute != null && !this.IsAutoMute.Equals(input.IsAutoMute))) return false;
            if (this.IsHardTerminalAutoMute != input.IsHardTerminalAutoMute || (this.IsHardTerminalAutoMute != null && !this.IsHardTerminalAutoMute.Equals(input.IsHardTerminalAutoMute))) return false;
            if (this.IsGuestFreePwd != input.IsGuestFreePwd || (this.IsGuestFreePwd != null && !this.IsGuestFreePwd.Equals(input.IsGuestFreePwd))) return false;
            if (this.CallInRestriction != input.CallInRestriction || (this.CallInRestriction != null && !this.CallInRestriction.Equals(input.CallInRestriction))) return false;
            if (this.AllowGuestStartConf != input.AllowGuestStartConf || (this.AllowGuestStartConf != null && !this.AllowGuestStartConf.Equals(input.AllowGuestStartConf))) return false;
            if (this.GuestPwd != input.GuestPwd || (this.GuestPwd != null && !this.GuestPwd.Equals(input.GuestPwd))) return false;
            if (this.VmrIDType != input.VmrIDType || (this.VmrIDType != null && !this.VmrIDType.Equals(input.VmrIDType))) return false;
            if (this.ProlongLength != input.ProlongLength || (this.ProlongLength != null && !this.ProlongLength.Equals(input.ProlongLength))) return false;
            if (this.EnableWaitingRoom != input.EnableWaitingRoom || (this.EnableWaitingRoom != null && !this.EnableWaitingRoom.Equals(input.EnableWaitingRoom))) return false;
            if (this.IsHostCameraOn != input.IsHostCameraOn || (this.IsHostCameraOn != null && !this.IsHostCameraOn.Equals(input.IsHostCameraOn))) return false;
            if (this.IsGuestCameraOn != input.IsGuestCameraOn || (this.IsGuestCameraOn != null && !this.IsGuestCameraOn.Equals(input.IsGuestCameraOn))) return false;

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
                if (this.IsSendNotify != null) hashCode = hashCode * 59 + this.IsSendNotify.GetHashCode();
                if (this.IsSendSms != null) hashCode = hashCode * 59 + this.IsSendSms.GetHashCode();
                if (this.IsSendCalendar != null) hashCode = hashCode * 59 + this.IsSendCalendar.GetHashCode();
                if (this.IsAutoMute != null) hashCode = hashCode * 59 + this.IsAutoMute.GetHashCode();
                if (this.IsHardTerminalAutoMute != null) hashCode = hashCode * 59 + this.IsHardTerminalAutoMute.GetHashCode();
                if (this.IsGuestFreePwd != null) hashCode = hashCode * 59 + this.IsGuestFreePwd.GetHashCode();
                if (this.CallInRestriction != null) hashCode = hashCode * 59 + this.CallInRestriction.GetHashCode();
                if (this.AllowGuestStartConf != null) hashCode = hashCode * 59 + this.AllowGuestStartConf.GetHashCode();
                if (this.GuestPwd != null) hashCode = hashCode * 59 + this.GuestPwd.GetHashCode();
                if (this.VmrIDType != null) hashCode = hashCode * 59 + this.VmrIDType.GetHashCode();
                if (this.ProlongLength != null) hashCode = hashCode * 59 + this.ProlongLength.GetHashCode();
                if (this.EnableWaitingRoom != null) hashCode = hashCode * 59 + this.EnableWaitingRoom.GetHashCode();
                if (this.IsHostCameraOn != null) hashCode = hashCode * 59 + this.IsHostCameraOn.GetHashCode();
                if (this.IsGuestCameraOn != null) hashCode = hashCode * 59 + this.IsGuestCameraOn.GetHashCode();
                return hashCode;
            }
        }
    }
}
