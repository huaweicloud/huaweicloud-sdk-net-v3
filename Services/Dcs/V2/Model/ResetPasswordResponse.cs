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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetPasswordResponse {\n");
            sb.Append("  retryTimesLeft: ").Append(RetryTimesLeft).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  lockTimeLeft: ").Append(LockTimeLeft).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.RetryTimesLeft == input.RetryTimesLeft ||
                    (this.RetryTimesLeft != null &&
                    this.RetryTimesLeft.Equals(input.RetryTimesLeft))
                ) && 
                (
                    this.LockTime == input.LockTime ||
                    (this.LockTime != null &&
                    this.LockTime.Equals(input.LockTime))
                ) && 
                (
                    this.LockTimeLeft == input.LockTimeLeft ||
                    (this.LockTimeLeft != null &&
                    this.LockTimeLeft.Equals(input.LockTimeLeft))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RetryTimesLeft != null)
                    hashCode = hashCode * 59 + this.RetryTimesLeft.GetHashCode();
                if (this.LockTime != null)
                    hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.LockTimeLeft != null)
                    hashCode = hashCode * 59 + this.LockTimeLeft.GetHashCode();
                return hashCode;
            }
        }
    }
}
