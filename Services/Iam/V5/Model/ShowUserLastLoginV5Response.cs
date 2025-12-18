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
    /// Response Object
    /// </summary>
    public class ShowUserLastLoginV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_last_login", NullValueHandling = NullValueHandling.Ignore)]
        public UserLastLogin UserLastLogin { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserLastLoginV5Response {\n");
            sb.Append("  userLastLogin: ").Append(UserLastLogin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserLastLoginV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserLastLoginV5Response input)
        {
            if (input == null) return false;
            if (this.UserLastLogin != input.UserLastLogin || (this.UserLastLogin != null && !this.UserLastLogin.Equals(input.UserLastLogin))) return false;

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
                if (this.UserLastLogin != null) hashCode = hashCode * 59 + this.UserLastLogin.GetHashCode();
                return hashCode;
            }
        }
    }
}
