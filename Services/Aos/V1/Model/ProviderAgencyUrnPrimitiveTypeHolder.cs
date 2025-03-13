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
    public class ProviderAgencyUrnPrimitiveTypeHolder 
    {

        /// <summary>
        /// 自定义provider所绑定的IAM委托URN，provider_agency_name和provider_agency_urn最多只能提供一个。
        /// </summary>
        [JsonProperty("provider_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderAgencyUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderAgencyUrnPrimitiveTypeHolder {\n");
            sb.Append("  providerAgencyUrn: ").Append(ProviderAgencyUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProviderAgencyUrnPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProviderAgencyUrnPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ProviderAgencyUrn != input.ProviderAgencyUrn || (this.ProviderAgencyUrn != null && !this.ProviderAgencyUrn.Equals(input.ProviderAgencyUrn))) return false;

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
                if (this.ProviderAgencyUrn != null) hashCode = hashCode * 59 + this.ProviderAgencyUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
