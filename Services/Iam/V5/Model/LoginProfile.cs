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
    /// IAM用户登录信息。
    /// </summary>
    public class LoginProfile 
    {

        /// <summary>
        /// IAM用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// IAM用户下次登录时是否需要修改密码。
        /// </summary>
        [JsonProperty("password_reset_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PasswordResetRequired { get; set; }

        /// <summary>
        /// IAM用户密码过期时间。
        /// </summary>
        [JsonProperty("password_expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PasswordExpiresAt { get; set; }

        /// <summary>
        /// IAM用户登录信息创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginProfile {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  passwordResetRequired: ").Append(PasswordResetRequired).Append("\n");
            sb.Append("  passwordExpiresAt: ").Append(PasswordExpiresAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginProfile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoginProfile input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.PasswordResetRequired != input.PasswordResetRequired || (this.PasswordResetRequired != null && !this.PasswordResetRequired.Equals(input.PasswordResetRequired))) return false;
            if (this.PasswordExpiresAt != input.PasswordExpiresAt || (this.PasswordExpiresAt != null && !this.PasswordExpiresAt.Equals(input.PasswordExpiresAt))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.PasswordResetRequired != null) hashCode = hashCode * 59 + this.PasswordResetRequired.GetHashCode();
                if (this.PasswordExpiresAt != null) hashCode = hashCode * 59 + this.PasswordExpiresAt.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
