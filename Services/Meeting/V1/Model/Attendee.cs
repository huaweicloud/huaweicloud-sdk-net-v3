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
    /// 与会者信息。
    /// </summary>
    public class Attendee 
    {

        /// <summary>
        /// 与会者的用户UUID。
        /// </summary>
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 与会者的华为云会议帐号。
        /// </summary>
        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 与会者名称，长度限制为96个字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 会议中的角色。默认为普通与会者。 - 0: 普通与会者 - 1: 会议主持人
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

        /// <summary>
        /// 号码。支持SIP号码或者手机号码。 &gt; * 号码可以通过[[查询企业通讯](https://support.huaweicloud.com/api-meeting/meeting_21_0512.html)](tag:hws)[[查询企业通讯](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0512.html)](tag:hk)接口录获取。返回的number是SIP号码，phone是手机号码 &gt; * 填SIP号码系统会呼叫对应的软终端或者硬终端；填手机号码系统会呼叫手机 &gt; * 呼叫手机需要开通PSTN权限，否则无法呼叫 
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 预留字段，取值类型同参数“phone”。
        /// </summary>
        [JsonProperty("phone2", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone2 { get; set; }

        /// <summary>
        /// 预留字段，取值类型同参数“phone”。
        /// </summary>
        [JsonProperty("phone3", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone3 { get; set; }

        /// <summary>
        /// 邮件地址。 &gt; 会中邀请不发会议通知，不用填写。 
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 短信通知的手机号码。 &gt; 会中邀请不发会议通知，不用填写。 
        /// </summary>
        [JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
        public string Sms { get; set; }

        /// <summary>
        /// 终端类型，类型枚举如下： * normal：软终端 * terminal：硬终端 * outside：外部与会人 * mobile：用户手机号码 * ideahub：ideahub * board: 电子白板（SmartRooms）。含Maxhub、海信大屏、IdeaHub B2hwvision：华为智慧屏TV
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 部门编码。
        /// </summary>
        [JsonProperty("deptUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptUUID { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Attendee {\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  phone2: ").Append(Phone2).Append("\n");
            sb.Append("  phone3: ").Append(Phone3).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  sms: ").Append(Sms).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  deptUUID: ").Append(DeptUUID).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Attendee);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Attendee input)
        {
            if (input == null) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.Phone2 != input.Phone2 || (this.Phone2 != null && !this.Phone2.Equals(input.Phone2))) return false;
            if (this.Phone3 != input.Phone3 || (this.Phone3 != null && !this.Phone3.Equals(input.Phone3))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Sms != input.Sms || (this.Sms != null && !this.Sms.Equals(input.Sms))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DeptUUID != input.DeptUUID || (this.DeptUUID != null && !this.DeptUUID.Equals(input.DeptUUID))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;

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
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Phone2 != null) hashCode = hashCode * 59 + this.Phone2.GetHashCode();
                if (this.Phone3 != null) hashCode = hashCode * 59 + this.Phone3.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Sms != null) hashCode = hashCode * 59 + this.Sms.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeptUUID != null) hashCode = hashCode * 59 + this.DeptUUID.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                return hashCode;
            }
        }
    }
}
