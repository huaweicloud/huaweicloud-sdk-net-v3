using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetSsoConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sso_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public SSOConfigurationDto SsoConfiguration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSsoConfigurationResponse {\n");
            sb.Append("  ssoConfiguration: ").Append(SsoConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetSsoConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetSsoConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.SsoConfiguration != input.SsoConfiguration || (this.SsoConfiguration != null && !this.SsoConfiguration.Equals(input.SsoConfiguration))) return false;

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
                if (this.SsoConfiguration != null) hashCode = hashCode * 59 + this.SsoConfiguration.GetHashCode();
                return hashCode;
            }
        }
    }
}
