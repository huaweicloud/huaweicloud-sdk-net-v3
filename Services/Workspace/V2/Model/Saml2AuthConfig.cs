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
    /// SAML2认证配置信息。
    /// </summary>
    public class Saml2AuthConfig 
    {

        /// <summary>
        /// 身份提供者名称。
        /// </summary>
        [JsonProperty("identity_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityProvider { get; set; }

        /// <summary>
        /// 接入服务器地址。
        /// </summary>
        [JsonProperty("access_server_address", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessServerAddress { get; set; }

        /// <summary>
        /// 唯一用户标识符。
        /// </summary>
        [JsonProperty("unique_user_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueUserIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("idp_metadata_info", NullValueHandling = NullValueHandling.Ignore)]
        public IdpMetadataInfo IdpMetadataInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Saml2AuthConfig {\n");
            sb.Append("  identityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("  accessServerAddress: ").Append(AccessServerAddress).Append("\n");
            sb.Append("  uniqueUserIdentifier: ").Append(UniqueUserIdentifier).Append("\n");
            sb.Append("  idpMetadataInfo: ").Append(IdpMetadataInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Saml2AuthConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Saml2AuthConfig input)
        {
            if (input == null) return false;
            if (this.IdentityProvider != input.IdentityProvider || (this.IdentityProvider != null && !this.IdentityProvider.Equals(input.IdentityProvider))) return false;
            if (this.AccessServerAddress != input.AccessServerAddress || (this.AccessServerAddress != null && !this.AccessServerAddress.Equals(input.AccessServerAddress))) return false;
            if (this.UniqueUserIdentifier != input.UniqueUserIdentifier || (this.UniqueUserIdentifier != null && !this.UniqueUserIdentifier.Equals(input.UniqueUserIdentifier))) return false;
            if (this.IdpMetadataInfo != input.IdpMetadataInfo || (this.IdpMetadataInfo != null && !this.IdpMetadataInfo.Equals(input.IdpMetadataInfo))) return false;

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
                if (this.IdentityProvider != null) hashCode = hashCode * 59 + this.IdentityProvider.GetHashCode();
                if (this.AccessServerAddress != null) hashCode = hashCode * 59 + this.AccessServerAddress.GetHashCode();
                if (this.UniqueUserIdentifier != null) hashCode = hashCode * 59 + this.UniqueUserIdentifier.GetHashCode();
                if (this.IdpMetadataInfo != null) hashCode = hashCode * 59 + this.IdpMetadataInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
