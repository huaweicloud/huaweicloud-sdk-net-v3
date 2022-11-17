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
    public class ScopedTokenUser 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public TokenDomainResult Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OS-FEDERATION", NullValueHandling = NullValueHandling.Ignore)]
        public TokenUserOsfederation OsFederation { get; set; }

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 密码过期时间（UTC时间），“”表示密码不过期。
        /// </summary>
        [JsonProperty("password_expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordExpiresAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScopedTokenUser {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  osFederation: ").Append(OsFederation).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  passwordExpiresAt: ").Append(PasswordExpiresAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScopedTokenUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScopedTokenUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.OsFederation == input.OsFederation ||
                    (this.OsFederation != null &&
                    this.OsFederation.Equals(input.OsFederation))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PasswordExpiresAt == input.PasswordExpiresAt ||
                    (this.PasswordExpiresAt != null &&
                    this.PasswordExpiresAt.Equals(input.PasswordExpiresAt))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.OsFederation != null)
                    hashCode = hashCode * 59 + this.OsFederation.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PasswordExpiresAt != null)
                    hashCode = hashCode * 59 + this.PasswordExpiresAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
