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
    /// 在线与会者信息
    /// </summary>
    public class OnlineAttendeeRecordInfo 
    {

        /// <summary>
        /// 与会者标识
        /// </summary>
        [JsonProperty("participant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 与会者名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 呼叫号码
        /// </summary>
        [JsonProperty("call_number", NullValueHandling = NullValueHandling.Ignore)]
        public string CallNumber { get; set; }

        /// <summary>
        /// 会议中的角色，枚举值如下： 1：会议主席 0：普通与会者
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

        /// <summary>
        /// 开放性场景标识第三方账号信息
        /// </summary>
        [JsonProperty("third_account", NullValueHandling = NullValueHandling.Ignore)]
        public string ThirdAccount { get; set; }

        /// <summary>
        /// 用户账号
        /// </summary>
        [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
        public string Account { get; set; }

        /// <summary>
        /// 用户UUID
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineAttendeeRecordInfo {\n");
            sb.Append("  participantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  callNumber: ").Append(CallNumber).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  thirdAccount: ").Append(ThirdAccount).Append("\n");
            sb.Append("  account: ").Append(Account).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnlineAttendeeRecordInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnlineAttendeeRecordInfo input)
        {
            if (input == null) return false;
            if (this.ParticipantId != input.ParticipantId || (this.ParticipantId != null && !this.ParticipantId.Equals(input.ParticipantId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CallNumber != input.CallNumber || (this.CallNumber != null && !this.CallNumber.Equals(input.CallNumber))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.ThirdAccount != input.ThirdAccount || (this.ThirdAccount != null && !this.ThirdAccount.Equals(input.ThirdAccount))) return false;
            if (this.Account != input.Account || (this.Account != null && !this.Account.Equals(input.Account))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;

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
                if (this.ParticipantId != null) hashCode = hashCode * 59 + this.ParticipantId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CallNumber != null) hashCode = hashCode * 59 + this.CallNumber.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.ThirdAccount != null) hashCode = hashCode * 59 + this.ThirdAccount.GetHashCode();
                if (this.Account != null) hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
