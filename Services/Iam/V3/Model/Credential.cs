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
    public class Credential 
    {

        /// <summary>
        /// AK/SK和securitytoken的过期时间。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// 获取的AK。
        /// </summary>
        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public string Access { get; set; }

        /// <summary>
        /// 获取的SK。
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// securitytoken是将所获的AK、SK等信息进行加密后的字符串。
        /// </summary>
        [JsonProperty("securitytoken", NullValueHandling = NullValueHandling.Ignore)]
        public string Securitytoken { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Credential {\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  access: ").Append(Access).Append("\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("  securitytoken: ").Append(Securitytoken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Credential);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Credential input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Securitytoken == input.Securitytoken ||
                    (this.Securitytoken != null &&
                    this.Securitytoken.Equals(input.Securitytoken))
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
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Securitytoken != null)
                    hashCode = hashCode * 59 + this.Securitytoken.GetHashCode();
                return hashCode;
            }
        }
    }
}
