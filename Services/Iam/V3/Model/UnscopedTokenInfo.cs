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
    /// token详细信息。
    /// </summary>
    public class UnscopedTokenInfo 
    {

        /// <summary>
        /// 过期时间。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// token获取方式，联邦认证默认为mapped。
        /// </summary>
        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// 生成时间。
        /// </summary>
        [JsonProperty("issued_at", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public FederationUserBody User { get; set; }

        /// <summary>
        /// roles信息。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnscopedTokenInfoRoles> Roles { get; set; }

        /// <summary>
        /// catalog信息。
        /// </summary>
        [JsonProperty("catalog", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnscopedTokenInfoCatalog> Catalog { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnscopedTokenInfo {\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  methods: ").Append(Methods).Append("\n");
            sb.Append("  issuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("  catalog: ").Append(Catalog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnscopedTokenInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnscopedTokenInfo input)
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
                    this.Methods == input.Methods ||
                    this.Methods != null &&
                    input.Methods != null &&
                    this.Methods.SequenceEqual(input.Methods)
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.Catalog == input.Catalog ||
                    this.Catalog != null &&
                    input.Catalog != null &&
                    this.Catalog.SequenceEqual(input.Catalog)
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
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.IssuedAt != null)
                    hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Catalog != null)
                    hashCode = hashCode * 59 + this.Catalog.GetHashCode();
                return hashCode;
            }
        }
    }
}
