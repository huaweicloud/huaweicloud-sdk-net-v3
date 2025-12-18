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
    /// The request body of change password request.
    /// </summary>
    public class ChangePasswordReqBody 
    {

        /// <summary>
        /// IAM用户的新密码。
        /// </summary>
        [JsonProperty("new_password", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        /// <summary>
        /// IAM用户的旧密码。
        /// </summary>
        [JsonProperty("old_password", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordReqBody {\n");
            sb.Append("  newPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  oldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangePasswordReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangePasswordReqBody input)
        {
            if (input == null) return false;
            if (this.NewPassword != input.NewPassword || (this.NewPassword != null && !this.NewPassword.Equals(input.NewPassword))) return false;
            if (this.OldPassword != input.OldPassword || (this.OldPassword != null && !this.OldPassword.Equals(input.OldPassword))) return false;

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
                if (this.NewPassword != null) hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
                if (this.OldPassword != null) hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
