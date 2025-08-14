using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetSpConfigurationForDirectoryResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sp_oidc_config", NullValueHandling = NullValueHandling.Ignore)]
        public SPOIDCConfig SpOidcConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sp_saml_config", NullValueHandling = NullValueHandling.Ignore)]
        public SPSAMLConfig SpSamlConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSpConfigurationForDirectoryResponse {\n");
            sb.Append("  spOidcConfig: ").Append(SpOidcConfig).Append("\n");
            sb.Append("  spSamlConfig: ").Append(SpSamlConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetSpConfigurationForDirectoryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetSpConfigurationForDirectoryResponse input)
        {
            if (input == null) return false;
            if (this.SpOidcConfig != input.SpOidcConfig || (this.SpOidcConfig != null && !this.SpOidcConfig.Equals(input.SpOidcConfig))) return false;
            if (this.SpSamlConfig != input.SpSamlConfig || (this.SpSamlConfig != null && !this.SpSamlConfig.Equals(input.SpSamlConfig))) return false;

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
                if (this.SpOidcConfig != null) hashCode = hashCode * 59 + this.SpOidcConfig.GetHashCode();
                if (this.SpSamlConfig != null) hashCode = hashCode * 59 + this.SpSamlConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
