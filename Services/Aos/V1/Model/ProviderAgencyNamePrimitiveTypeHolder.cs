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
    public class ProviderAgencyNamePrimitiveTypeHolder 
    {

        /// <summary>
        /// 自定义provider所绑定的IAM委托名称，provider_agency_name和provider_agency_urn最多只能提供一个。
        /// </summary>
        [JsonProperty("provider_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderAgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderAgencyNamePrimitiveTypeHolder {\n");
            sb.Append("  providerAgencyName: ").Append(ProviderAgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProviderAgencyNamePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProviderAgencyNamePrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ProviderAgencyName != input.ProviderAgencyName || (this.ProviderAgencyName != null && !this.ProviderAgencyName.Equals(input.ProviderAgencyName))) return false;

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
                if (this.ProviderAgencyName != null) hashCode = hashCode * 59 + this.ProviderAgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
