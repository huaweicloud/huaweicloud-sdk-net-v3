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
    /// 与会嘉宾列表。
    /// </summary>
    public class OpenAttendeeEntity 
    {

        /// <summary>
        /// App ID。如果是APP ID鉴权场景，此项必填。参考[[App ID的申请](https://support.huaweicloud.com/devg-meeting/meeting_20_0011.html#section1)](tag:hws)[[App ID的申请](https://support.huaweicloud.com/intl/zh-cn/devg-meeting/meeting_20_0011.html#section1)](tag:hk)。
        /// </summary>
        [JsonProperty("appId", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 嘉宾的帐号。 * 如果是帐号/密码鉴权场景: 选填，表示华为云会议帐号ID * 如果是APP ID鉴权场景：必填，表示第三方的User ID，同时需要携带参数appId 
        /// </summary>
        [JsonProperty("userAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAccount { get; set; }

        /// <summary>
        /// 嘉宾的名称。长度限制为96个字符。
        /// </summary>
        [JsonProperty("userName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 部门名称，最大128字符。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 号码。支持SIP号码或者手机号码。 * 如果是帐号/密码鉴权场景：必填 * 如果是APP ID鉴权场景：选填 &gt; * 号码可以通过[[查询企业通讯](https://support.huaweicloud.com/api-meeting/meeting_21_0512.html)](tag:hws)[[查询企业通讯](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0512.html)](tag:hk)接口录获取。返回的number是SIP号码，phone是手机号码 &gt; * 填SIP号码系统会呼叫对应的软终端或者硬终端；填手机号码系统会呼叫手机 &gt; * 呼叫手机需要开通PSTN权限，否则无法呼叫 
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 邮件地址。需要发邮件通知时填写。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 短信通知的手机号码。需要发短信通知时填写。
        /// </summary>
        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public string Sms { get; set; }

        /// <summary>
        /// 是否硬终端（会议室或硬终端）。
        /// </summary>
        [JsonProperty("isHardTerminal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsHardTerminal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenAttendeeEntity {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  userAccount: ").Append(UserAccount).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  sms: ").Append(Sms).Append("\n");
            sb.Append("  isHardTerminal: ").Append(IsHardTerminal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenAttendeeEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenAttendeeEntity input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.UserAccount != input.UserAccount || (this.UserAccount != null && !this.UserAccount.Equals(input.UserAccount))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Sms != input.Sms || (this.Sms != null && !this.Sms.Equals(input.Sms))) return false;
            if (this.IsHardTerminal != input.IsHardTerminal || (this.IsHardTerminal != null && !this.IsHardTerminal.Equals(input.IsHardTerminal))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.UserAccount != null) hashCode = hashCode * 59 + this.UserAccount.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Sms != null) hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.IsHardTerminal != null) hashCode = hashCode * 59 + this.IsHardTerminal.GetHashCode();
                return hashCode;
            }
        }
    }
}
