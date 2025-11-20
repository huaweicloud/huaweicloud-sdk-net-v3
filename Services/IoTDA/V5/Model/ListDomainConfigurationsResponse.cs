using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDomainConfigurationsResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：域配置列表。
        /// </summary>
        [JsonProperty("domain_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public List<DomainConfigurationDTO> DomainConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainConfigurationsResponse {\n");
            sb.Append("  domainConfigurations: ").Append(DomainConfigurations).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainConfigurationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainConfigurationsResponse input)
        {
            if (input == null) return false;
            if (this.DomainConfigurations != input.DomainConfigurations || (this.DomainConfigurations != null && input.DomainConfigurations != null && !this.DomainConfigurations.SequenceEqual(input.DomainConfigurations))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;

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
                if (this.DomainConfigurations != null) hashCode = hashCode * 59 + this.DomainConfigurations.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
