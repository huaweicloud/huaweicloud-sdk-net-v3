using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EnableMfaDeviceReqBody 
    {

        /// <summary>
        /// IAM用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// MFA设备序列号。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 设备发出的验证码。
        /// </summary>
        [JsonProperty("authentication_code_first", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationCodeFirst { get; set; }

        /// <summary>
        /// 设备发出的后续验证码。
        /// </summary>
        [JsonProperty("authentication_code_second", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationCodeSecond { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableMfaDeviceReqBody {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  authenticationCodeFirst: ").Append(AuthenticationCodeFirst).Append("\n");
            sb.Append("  authenticationCodeSecond: ").Append(AuthenticationCodeSecond).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableMfaDeviceReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableMfaDeviceReqBody input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.SerialNumber != input.SerialNumber || (this.SerialNumber != null && !this.SerialNumber.Equals(input.SerialNumber))) return false;
            if (this.AuthenticationCodeFirst != input.AuthenticationCodeFirst || (this.AuthenticationCodeFirst != null && !this.AuthenticationCodeFirst.Equals(input.AuthenticationCodeFirst))) return false;
            if (this.AuthenticationCodeSecond != input.AuthenticationCodeSecond || (this.AuthenticationCodeSecond != null && !this.AuthenticationCodeSecond.Equals(input.AuthenticationCodeSecond))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.SerialNumber != null) hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.AuthenticationCodeFirst != null) hashCode = hashCode * 59 + this.AuthenticationCodeFirst.GetHashCode();
                if (this.AuthenticationCodeSecond != null) hashCode = hashCode * 59 + this.AuthenticationCodeSecond.GetHashCode();
                return hashCode;
            }
        }
    }
}
