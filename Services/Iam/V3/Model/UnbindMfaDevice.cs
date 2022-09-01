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
    public class UnbindMfaDevice 
    {

        /// <summary>
        /// 待解绑MFA设备的IAM用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 管理员为IAM用户解绑MFA设备：填写6位任意验证码，不做校验。IAM用户为自己解绑MFA设备：填写虚拟MFA验证码。
        /// </summary>
        [JsonProperty("authentication_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationCode { get; set; }

        /// <summary>
        /// MFA设备序列号。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnbindMfaDevice {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  authenticationCode: ").Append(AuthenticationCode).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnbindMfaDevice);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnbindMfaDevice input)
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
                    this.AuthenticationCode == input.AuthenticationCode ||
                    (this.AuthenticationCode != null &&
                    this.AuthenticationCode.Equals(input.AuthenticationCode))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
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
                if (this.AuthenticationCode != null)
                    hashCode = hashCode * 59 + this.AuthenticationCode.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
