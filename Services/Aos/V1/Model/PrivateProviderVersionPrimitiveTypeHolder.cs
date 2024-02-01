using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivateProviderVersionPrimitiveTypeHolder 
    {

        /// <summary>
        /// provider的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义
        /// </summary>
        [JsonProperty("provider_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateProviderVersionPrimitiveTypeHolder {\n");
            sb.Append("  providerVersion: ").Append(ProviderVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateProviderVersionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateProviderVersionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderVersion == input.ProviderVersion ||
                    (this.ProviderVersion != null &&
                    this.ProviderVersion.Equals(input.ProviderVersion))
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
                if (this.ProviderVersion != null)
                    hashCode = hashCode * 59 + this.ProviderVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
