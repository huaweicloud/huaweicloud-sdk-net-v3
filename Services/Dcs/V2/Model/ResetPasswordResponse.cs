using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResetPasswordResponse : SdkResponse
    {

        /// <summary>
        /// 密码验证剩余次数
        /// </summary>
        [JsonProperty("retry_times_left", NullValueHandling = NullValueHandling.Ignore)]
        public string RetryTimesLeft { get; set; }

        /// <summary>
        /// 锁定时间
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTime { get; set; }

        /// <summary>
        /// 锁定剩余时间
        /// </summary>
        [JsonProperty("lock_time_left", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTimeLeft { get; set; }

        /// <summary>
        /// **参数解释**： 重置密码结果编号。 **取值范围**： - 1：重置密码成功。 - 3：实例被锁定。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 重置密码结果信息。 **取值范围**： - success - instance is locked 
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释**： 重置密码错误信息，若重置密码成功，则为null。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("ext_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetPasswordResponse {\n");
            sb.Append("  retryTimesLeft: ").Append(RetryTimesLeft).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  lockTimeLeft: ").Append(LockTimeLeft).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  extMessage: ").Append(ExtMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetPasswordResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetPasswordResponse input)
        {
            if (input == null) return false;
            if (this.RetryTimesLeft != input.RetryTimesLeft || (this.RetryTimesLeft != null && !this.RetryTimesLeft.Equals(input.RetryTimesLeft))) return false;
            if (this.LockTime != input.LockTime || (this.LockTime != null && !this.LockTime.Equals(input.LockTime))) return false;
            if (this.LockTimeLeft != input.LockTimeLeft || (this.LockTimeLeft != null && !this.LockTimeLeft.Equals(input.LockTimeLeft))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ExtMessage != input.ExtMessage || (this.ExtMessage != null && !this.ExtMessage.Equals(input.ExtMessage))) return false;

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
                if (this.RetryTimesLeft != null) hashCode = hashCode * 59 + this.RetryTimesLeft.GetHashCode();
                if (this.LockTime != null) hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.LockTimeLeft != null) hashCode = hashCode * 59 + this.LockTimeLeft.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ExtMessage != null) hashCode = hashCode * 59 + this.ExtMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
