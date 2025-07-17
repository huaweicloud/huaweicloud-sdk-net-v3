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
    /// 被邀请的与会者信息。包含预约会议时邀请的与会者和会中主持人邀请的与会者。
    /// </summary>
    public class ParticipantInfo 
    {

        /// <summary>
        /// 与会者的号码。
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 与会者的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 与会者的号码（预留字段）。
        /// </summary>
        [JsonProperty("subscriberID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriberID { get; set; }

        /// <summary>
        /// 与会者的角色。 - 1: 会议主持人 - 0: 普通与会者
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

        /// <summary>
        /// 用户状态。目前固定返回MEETTING。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 终端所在会议室信息（预留字段）。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 与会者终端类型。 - normal: 软终端。 - terminal: 会议室或硬终端。 - outside: 外部与会人。 - mobile: 用户手机号码。
        /// </summary>
        [JsonProperty("attendeeType", NullValueHandling = NullValueHandling.Ignore)]
        public string AttendeeType { get; set; }

        /// <summary>
        /// 预订者的帐号。 * 如果是帐号/密码鉴权场景，表示华为云会议帐号 * 如果是APP ID鉴权场景，表示第三方的User ID 
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 预留字段。
        /// </summary>
        [JsonProperty("phone2", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone2 { get; set; }

        /// <summary>
        /// 预留字段。
        /// </summary>
        [JsonProperty("phone3", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone3 { get; set; }

        /// <summary>
        /// 邮箱地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 短信通知的手机号码。
        /// </summary>
        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public string Sms { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 预订者的用户UUID。
        /// </summary>
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// App ID。参考[[App ID的申请](https://support.huaweicloud.com/devg-meeting/meeting_20_0011.html#section1)](tag:hws)[[App ID的申请](https://support.huaweicloud.com/intl/zh-cn/devg-meeting/meeting_20_0011.html#section1)](tag:hk)。
        /// </summary>
        [JsonProperty("appId", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 会议开始时是否自动邀请该与会者。默认值由企业级配置决定。 * 0： 不自动邀请 * 1： 自动邀请 
        /// </summary>
        [JsonProperty("isAutoInvite", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoInvite { get; set; }

        /// <summary>
        /// 是否不叠加会场名（VDC场景下适用）。
        /// </summary>
        [JsonProperty("isNotOverlayPidName", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNotOverlayPidName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantInfo {\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  subscriberID: ").Append(SubscriberID).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  attendeeType: ").Append(AttendeeType).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  phone2: ").Append(Phone2).Append("\n");
            sb.Append("  phone3: ").Append(Phone3).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  sms: ").Append(Sms).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  isAutoInvite: ").Append(IsAutoInvite).Append("\n");
            sb.Append("  isNotOverlayPidName: ").Append(IsNotOverlayPidName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParticipantInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParticipantInfo input)
        {
            if (input == null) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SubscriberID != input.SubscriberID || (this.SubscriberID != null && !this.SubscriberID.Equals(input.SubscriberID))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AttendeeType != input.AttendeeType || (this.AttendeeType != null && !this.AttendeeType.Equals(input.AttendeeType))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.Phone2 != input.Phone2 || (this.Phone2 != null && !this.Phone2.Equals(input.Phone2))) return false;
            if (this.Phone3 != input.Phone3 || (this.Phone3 != null && !this.Phone3.Equals(input.Phone3))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Sms != input.Sms || (this.Sms != null && !this.Sms.Equals(input.Sms))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.IsAutoInvite != input.IsAutoInvite || (this.IsAutoInvite != null && !this.IsAutoInvite.Equals(input.IsAutoInvite))) return false;
            if (this.IsNotOverlayPidName != input.IsNotOverlayPidName || (this.IsNotOverlayPidName != null && !this.IsNotOverlayPidName.Equals(input.IsNotOverlayPidName))) return false;

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
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SubscriberID != null) hashCode = hashCode * 59 + this.SubscriberID.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AttendeeType != null) hashCode = hashCode * 59 + this.AttendeeType.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Phone2 != null) hashCode = hashCode * 59 + this.Phone2.GetHashCode();
                if (this.Phone3 != null) hashCode = hashCode * 59 + this.Phone3.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Sms != null) hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.IsAutoInvite != null) hashCode = hashCode * 59 + this.IsAutoInvite.GetHashCode();
                if (this.IsNotOverlayPidName != null) hashCode = hashCode * 59 + this.IsNotOverlayPidName.GetHashCode();
                return hashCode;
            }
        }
    }
}
