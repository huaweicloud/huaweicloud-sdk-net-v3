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
    public class PrivateProviderDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有provider（private-provider）的描述。可用于客户识别被管理的私有provider。
        /// </summary>
        [JsonProperty("provider_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateProviderDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  providerDescription: ").Append(ProviderDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateProviderDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateProviderDescriptionPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ProviderDescription != input.ProviderDescription || (this.ProviderDescription != null && !this.ProviderDescription.Equals(input.ProviderDescription))) return false;

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
                if (this.ProviderDescription != null) hashCode = hashCode * 59 + this.ProviderDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
