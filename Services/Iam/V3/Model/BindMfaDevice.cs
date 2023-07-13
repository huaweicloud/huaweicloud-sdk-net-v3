using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BindMfaDevice 
    {

        /// <summary>
        /// 待绑定MFA设备的IAM用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// MFA设备序列号。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 第一组验证码。
        /// </summary>
        [JsonProperty("authentication_code_first", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationCodeFirst { get; set; }

        /// <summary>
        /// 第二组验证码。
        /// </summary>
        [JsonProperty("authentication_code_second", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationCodeSecond { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindMfaDevice {\n");
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
            return this.Equals(input as BindMfaDevice);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindMfaDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.AuthenticationCodeFirst == input.AuthenticationCodeFirst ||
                    (this.AuthenticationCodeFirst != null &&
                    this.AuthenticationCodeFirst.Equals(input.AuthenticationCodeFirst))
                ) && 
                (
                    this.AuthenticationCodeSecond == input.AuthenticationCodeSecond ||
                    (this.AuthenticationCodeSecond != null &&
                    this.AuthenticationCodeSecond.Equals(input.AuthenticationCodeSecond))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.AuthenticationCodeFirst != null)
                    hashCode = hashCode * 59 + this.AuthenticationCodeFirst.GetHashCode();
                if (this.AuthenticationCodeSecond != null)
                    hashCode = hashCode * 59 + this.AuthenticationCodeSecond.GetHashCode();
                return hashCode;
            }
        }
    }
}
