using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowOIDCProviderV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("oidc_provider", NullValueHandling = NullValueHandling.Ignore)]
        public InlineResponse2003OidcProvider OidcProvider { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOIDCProviderV5Response {\n");
            sb.Append("  oidcProvider: ").Append(OidcProvider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOIDCProviderV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOIDCProviderV5Response input)
        {
            if (input == null) return false;
            if (this.OidcProvider != input.OidcProvider || (this.OidcProvider != null && !this.OidcProvider.Equals(input.OidcProvider))) return false;

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
                if (this.OidcProvider != null) hashCode = hashCode * 59 + this.OidcProvider.GetHashCode();
                return hashCode;
            }
        }
    }
}
