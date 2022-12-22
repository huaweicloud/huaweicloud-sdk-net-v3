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
    public class ProtocolLinks 
    {

        /// <summary>
        /// 身份提供商的资源链接地址。
        /// </summary>
        [JsonProperty("identity_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityProvider { get; set; }

        /// <summary>
        /// 资源链接地址。
        /// </summary>
        [JsonProperty("self", NullValueHandling = NullValueHandling.Ignore)]
        public string Self { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolLinks {\n");
            sb.Append("  identityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("  self: ").Append(Self).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtocolLinks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtocolLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityProvider == input.IdentityProvider ||
                    (this.IdentityProvider != null &&
                    this.IdentityProvider.Equals(input.IdentityProvider))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
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
                if (this.IdentityProvider != null)
                    hashCode = hashCode * 59 + this.IdentityProvider.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                return hashCode;
            }
        }
    }
}
