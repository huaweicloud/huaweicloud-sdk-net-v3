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
    public class CreateLoginProfileV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login_profile", NullValueHandling = NullValueHandling.Ignore)]
        public LoginProfile LoginProfile { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoginProfileV5Response {\n");
            sb.Append("  loginProfile: ").Append(LoginProfile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoginProfileV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoginProfileV5Response input)
        {
            if (input == null) return false;
            if (this.LoginProfile != input.LoginProfile || (this.LoginProfile != null && !this.LoginProfile.Equals(input.LoginProfile))) return false;

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
                if (this.LoginProfile != null) hashCode = hashCode * 59 + this.LoginProfile.GetHashCode();
                return hashCode;
            }
        }
    }
}
