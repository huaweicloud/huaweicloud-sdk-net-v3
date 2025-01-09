using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// obs访问凭据。
    /// </summary>
    public class ObsCredential 
    {

        /// <summary>
        /// access key。
        /// </summary>
        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public string Access { get; set; }

        /// <summary>
        /// secret key。
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// 安全校验token。
        /// </summary>
        [JsonProperty("security_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsCredential {\n");
            sb.Append("  access: ").Append(Access).Append("\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("  securityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsCredential);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsCredential input)
        {
            if (input == null) return false;
            if (this.Access != input.Access || (this.Access != null && !this.Access.Equals(input.Access))) return false;
            if (this.Secret != input.Secret || (this.Secret != null && !this.Secret.Equals(input.Secret))) return false;
            if (this.SecurityToken != input.SecurityToken || (this.SecurityToken != null && !this.SecurityToken.Equals(input.SecurityToken))) return false;

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
                if (this.Access != null) hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Secret != null) hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.SecurityToken != null) hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
