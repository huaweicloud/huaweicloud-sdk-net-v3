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
    /// IAM用户最后登录时间。
    /// </summary>
    public class UserLastLogin 
    {

        /// <summary>
        /// IAM用户最后登录时间。若为null，则表示从未登录过。
        /// </summary>
        [JsonProperty("last_login_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastLoginAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLastLogin {\n");
            sb.Append("  lastLoginAt: ").Append(LastLoginAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserLastLogin);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserLastLogin input)
        {
            if (input == null) return false;
            if (this.LastLoginAt != input.LastLoginAt || (this.LastLoginAt != null && !this.LastLoginAt.Equals(input.LastLoginAt))) return false;

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
                if (this.LastLoginAt != null) hashCode = hashCode * 59 + this.LastLoginAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
