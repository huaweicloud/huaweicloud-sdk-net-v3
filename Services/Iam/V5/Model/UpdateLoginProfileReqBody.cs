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
    /// The request body of update login profile request.
    /// </summary>
    public class UpdateLoginProfileReqBody 
    {

        /// <summary>
        /// IAM用户的密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// IAM用户下次登录时是否需要修改密码。
        /// </summary>
        [JsonProperty("password_reset_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasswordResetRequired { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoginProfileReqBody {\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  passwordResetRequired: ").Append(PasswordResetRequired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLoginProfileReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLoginProfileReqBody input)
        {
            if (input == null) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.PasswordResetRequired != input.PasswordResetRequired || (this.PasswordResetRequired != null && !this.PasswordResetRequired.Equals(input.PasswordResetRequired))) return false;

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
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PasswordResetRequired != null) hashCode = hashCode * 59 + this.PasswordResetRequired.GetHashCode();
                return hashCode;
            }
        }
    }
}
