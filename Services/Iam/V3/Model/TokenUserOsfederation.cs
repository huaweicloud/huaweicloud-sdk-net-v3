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
    public class TokenUserOsfederation 
    {

        /// <summary>
        /// 用户组信息列表。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<OsfederationGroups> Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity_provider", NullValueHandling = NullValueHandling.Ignore)]
        public OsfederationIdentityprovider IdentityProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public OsfederationProtocol Protocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenUserOsfederation {\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  identityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenUserOsfederation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TokenUserOsfederation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.IdentityProvider == input.IdentityProvider ||
                    (this.IdentityProvider != null &&
                    this.IdentityProvider.Equals(input.IdentityProvider))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.IdentityProvider != null)
                    hashCode = hashCode * 59 + this.IdentityProvider.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
