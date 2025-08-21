using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBestPracticeAccountInfoResponse : SdkResponse
    {

        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountType { get; set; }

        /// <summary>
        /// 有效开始时间
        /// </summary>
        [JsonProperty("effective_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectiveStartTime { get; set; }

        /// <summary>
        /// 有效过期时间
        /// </summary>
        [JsonProperty("effective_expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectiveExpirationTime { get; set; }

        /// <summary>
        /// 当前时间
        /// </summary>
        [JsonProperty("current_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CurrentTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBestPracticeAccountInfoResponse {\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  effectiveStartTime: ").Append(EffectiveStartTime).Append("\n");
            sb.Append("  effectiveExpirationTime: ").Append(EffectiveExpirationTime).Append("\n");
            sb.Append("  currentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBestPracticeAccountInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBestPracticeAccountInfoResponse input)
        {
            if (input == null) return false;
            if (this.AccountType != input.AccountType || (this.AccountType != null && !this.AccountType.Equals(input.AccountType))) return false;
            if (this.EffectiveStartTime != input.EffectiveStartTime || (this.EffectiveStartTime != null && !this.EffectiveStartTime.Equals(input.EffectiveStartTime))) return false;
            if (this.EffectiveExpirationTime != input.EffectiveExpirationTime || (this.EffectiveExpirationTime != null && !this.EffectiveExpirationTime.Equals(input.EffectiveExpirationTime))) return false;
            if (this.CurrentTime != input.CurrentTime || (this.CurrentTime != null && !this.CurrentTime.Equals(input.CurrentTime))) return false;

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
                if (this.AccountType != null) hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.EffectiveStartTime != null) hashCode = hashCode * 59 + this.EffectiveStartTime.GetHashCode();
                if (this.EffectiveExpirationTime != null) hashCode = hashCode * 59 + this.EffectiveExpirationTime.GetHashCode();
                if (this.CurrentTime != null) hashCode = hashCode * 59 + this.CurrentTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
