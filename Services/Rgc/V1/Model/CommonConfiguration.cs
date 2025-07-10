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
    /// Landing Zone配置信息。
    /// </summary>
    public class CommonConfiguration 
    {

        /// <summary>
        /// 主区域名。
        /// </summary>
        [JsonProperty("home_region", NullValueHandling = NullValueHandling.Ignore)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// CTS配置状态。
        /// </summary>
        [JsonProperty("cloud_trail_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloudTrailType { get; set; }

        /// <summary>
        /// 是否设置Landing Zone的identity center。
        /// </summary>
        [JsonProperty("identity_center_status", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityCenterStatus { get; set; }

        /// <summary>
        /// 设置organization的类型。STANDARD和NON_STANDARD。
        /// </summary>
        [JsonProperty("organization_structure_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationStructureType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonConfiguration {\n");
            sb.Append("  homeRegion: ").Append(HomeRegion).Append("\n");
            sb.Append("  cloudTrailType: ").Append(CloudTrailType).Append("\n");
            sb.Append("  identityCenterStatus: ").Append(IdentityCenterStatus).Append("\n");
            sb.Append("  organizationStructureType: ").Append(OrganizationStructureType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommonConfiguration input)
        {
            if (input == null) return false;
            if (this.HomeRegion != input.HomeRegion || (this.HomeRegion != null && !this.HomeRegion.Equals(input.HomeRegion))) return false;
            if (this.CloudTrailType != input.CloudTrailType || (this.CloudTrailType != null && !this.CloudTrailType.Equals(input.CloudTrailType))) return false;
            if (this.IdentityCenterStatus != input.IdentityCenterStatus || (this.IdentityCenterStatus != null && !this.IdentityCenterStatus.Equals(input.IdentityCenterStatus))) return false;
            if (this.OrganizationStructureType != input.OrganizationStructureType || (this.OrganizationStructureType != null && !this.OrganizationStructureType.Equals(input.OrganizationStructureType))) return false;

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
                if (this.HomeRegion != null) hashCode = hashCode * 59 + this.HomeRegion.GetHashCode();
                if (this.CloudTrailType != null) hashCode = hashCode * 59 + this.CloudTrailType.GetHashCode();
                if (this.IdentityCenterStatus != null) hashCode = hashCode * 59 + this.IdentityCenterStatus.GetHashCode();
                if (this.OrganizationStructureType != null) hashCode = hashCode * 59 + this.OrganizationStructureType.GetHashCode();
                return hashCode;
            }
        }
    }
}
