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
    public class CreateSAMLProviderV5Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("saml_provider", NullValueHandling = NullValueHandling.Ignore)]
        public InlineResponse201SamlProvider SamlProvider { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSAMLProviderV5Response {\n");
            sb.Append("  samlProvider: ").Append(SamlProvider).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSAMLProviderV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSAMLProviderV5Response input)
        {
            if (input == null) return false;
            if (this.SamlProvider != input.SamlProvider || (this.SamlProvider != null && !this.SamlProvider.Equals(input.SamlProvider))) return false;

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
                if (this.SamlProvider != null) hashCode = hashCode * 59 + this.SamlProvider.GetHashCode();
                return hashCode;
            }
        }
    }
}
