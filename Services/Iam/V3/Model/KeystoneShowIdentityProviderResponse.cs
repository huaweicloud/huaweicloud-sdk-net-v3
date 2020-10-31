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
    public class KeystoneShowIdentityProviderResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity_provider", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityprovidersResult IdentityProvider { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneShowIdentityProviderResponse {\n");
            sb.Append("  identityProvider: ").Append(IdentityProvider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneShowIdentityProviderResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneShowIdentityProviderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityProvider == input.IdentityProvider ||
                    (this.IdentityProvider != null &&
                    this.IdentityProvider.Equals(input.IdentityProvider))
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
                return hashCode;
            }
        }
    }
}
