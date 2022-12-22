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
    public class ScopeTokenResult 
    {

        /// <summary>
        /// 获取token的方式。
        /// </summary>
        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Methods { get; set; }

        /// <summary>
        /// token过期时间。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// 服务目录信息。
        /// </summary>
        [JsonProperty("catalog", NullValueHandling = NullValueHandling.Ignore)]
        public List<TokenCatalog> Catalog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public TokenDomainResult Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public TokenProjectResult Project { get; set; }

        /// <summary>
        /// token的权限信息。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<TokenRole> Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public ScopedTokenUser User { get; set; }

        /// <summary>
        /// token下发时间。
        /// </summary>
        [JsonProperty("issued_at", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScopeTokenResult {\n");
            sb.Append("  methods: ").Append(Methods).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  catalog: ").Append(Catalog).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  issuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScopeTokenResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScopeTokenResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Methods == input.Methods ||
                    this.Methods != null &&
                    input.Methods != null &&
                    this.Methods.SequenceEqual(input.Methods)
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Catalog == input.Catalog ||
                    this.Catalog != null &&
                    input.Catalog != null &&
                    this.Catalog.SequenceEqual(input.Catalog)
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
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
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Catalog != null)
                    hashCode = hashCode * 59 + this.Catalog.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.IssuedAt != null)
                    hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
