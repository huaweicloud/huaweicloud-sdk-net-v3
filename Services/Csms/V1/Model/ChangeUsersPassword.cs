using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeUsersPassword 
    {

        /// <summary>
        /// 新密码。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 旧密码。
        /// </summary>
        [JsonProperty("old_password", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeUsersPassword {\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  oldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeUsersPassword);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeUsersPassword input)
        {
            if (input == null) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
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
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.OldPassword != null) hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
