using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLandingZoneConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public CommonConfiguration CommonConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logging_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organization_structure", NullValueHandling = NullValueHandling.Ignore)]
        public List<OrganizationStructureBaseLineRsp> OrganizationStructure { get; set; }

        /// <summary>
        /// 纳管的区域信息。
        /// </summary>
        [JsonProperty("regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionConfigurationList> Regions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLandingZoneConfigurationResponse {\n");
            sb.Append("  commonConfiguration: ").Append(CommonConfiguration).Append("\n");
            sb.Append("  loggingConfiguration: ").Append(LoggingConfiguration).Append("\n");
            sb.Append("  organizationStructure: ").Append(OrganizationStructure).Append("\n");
            sb.Append("  regions: ").Append(Regions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLandingZoneConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLandingZoneConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.CommonConfiguration != input.CommonConfiguration || (this.CommonConfiguration != null && !this.CommonConfiguration.Equals(input.CommonConfiguration))) return false;
            if (this.LoggingConfiguration != input.LoggingConfiguration || (this.LoggingConfiguration != null && !this.LoggingConfiguration.Equals(input.LoggingConfiguration))) return false;
            if (this.OrganizationStructure != input.OrganizationStructure || (this.OrganizationStructure != null && input.OrganizationStructure != null && !this.OrganizationStructure.SequenceEqual(input.OrganizationStructure))) return false;
            if (this.Regions != input.Regions || (this.Regions != null && input.Regions != null && !this.Regions.SequenceEqual(input.Regions))) return false;

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
                if (this.CommonConfiguration != null) hashCode = hashCode * 59 + this.CommonConfiguration.GetHashCode();
                if (this.LoggingConfiguration != null) hashCode = hashCode * 59 + this.LoggingConfiguration.GetHashCode();
                if (this.OrganizationStructure != null) hashCode = hashCode * 59 + this.OrganizationStructure.GetHashCode();
                if (this.Regions != null) hashCode = hashCode * 59 + this.Regions.GetHashCode();
                return hashCode;
            }
        }
    }
}
