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
    /// Response Object
    /// </summary>
    public class KeystoneListIdentityProvidersResponse : SdkResponse
    {

        /// <summary>
        /// 身份提供商信息列表。
        /// </summary>
        [JsonProperty("identity_providers", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdentityprovidersResult> IdentityProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public Links Links { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneListIdentityProvidersResponse {\n");
            sb.Append("  identityProviders: ").Append(IdentityProviders).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneListIdentityProvidersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneListIdentityProvidersResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityProviders == input.IdentityProviders ||
                    this.IdentityProviders != null &&
                    input.IdentityProviders != null &&
                    this.IdentityProviders.SequenceEqual(input.IdentityProviders)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.IdentityProviders != null)
                    hashCode = hashCode * 59 + this.IdentityProviders.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }
}
