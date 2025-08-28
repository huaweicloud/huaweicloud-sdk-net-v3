using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 分支网络租户能力详情条目。
    /// </summary>
    public class SiteNetworkCapabilityEntry 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public SiteNetworkSpecificationEnum Specification { get; set; }
        /// <summary>
        /// 是否支持分支网络。
        /// </summary>
        [JsonProperty("is_support", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupport { get; set; }

        /// <summary>
        /// 是否支持分支网络企业项目。
        /// </summary>
        [JsonProperty("is_support_enterprise_project", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportEnterpriseProject { get; set; }

        /// <summary>
        /// 是否支持分支网络标签。
        /// </summary>
        [JsonProperty("is_support_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportTag { get; set; }

        /// <summary>
        /// 是否支持创建同region分支网络。
        /// </summary>
        [JsonProperty("is_support_intra_region", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportIntraRegion { get; set; }

        /// <summary>
        /// 分支网络的拓扑列表。
        /// </summary>
        [JsonProperty("support_topologies", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteNetworkTopologyEnum> SupportTopologies { get; set; }

        /// <summary>
        /// list类型
        /// </summary>
        [JsonProperty("support_regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportRegions { get; set; }

        /// <summary>
        /// list类型
        /// </summary>
        [JsonProperty("support_dscp_regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportDscpRegions { get; set; }

        /// <summary>
        /// list类型
        /// </summary>
        [JsonProperty("support_freeze_regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportFreezeRegions { get; set; }

        /// <summary>
        /// list类型
        /// </summary>
        [JsonProperty("support_locations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportLocations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("size_range", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionBandwidthSizeRange SizeRange { get; set; }

        /// <summary>
        /// list类型
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectionBandwidthChargeModeEnum> ChargeMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteNetworkCapabilityEntry {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  isSupport: ").Append(IsSupport).Append("\n");
            sb.Append("  isSupportEnterpriseProject: ").Append(IsSupportEnterpriseProject).Append("\n");
            sb.Append("  isSupportTag: ").Append(IsSupportTag).Append("\n");
            sb.Append("  isSupportIntraRegion: ").Append(IsSupportIntraRegion).Append("\n");
            sb.Append("  supportTopologies: ").Append(SupportTopologies).Append("\n");
            sb.Append("  supportRegions: ").Append(SupportRegions).Append("\n");
            sb.Append("  supportDscpRegions: ").Append(SupportDscpRegions).Append("\n");
            sb.Append("  supportFreezeRegions: ").Append(SupportFreezeRegions).Append("\n");
            sb.Append("  supportLocations: ").Append(SupportLocations).Append("\n");
            sb.Append("  sizeRange: ").Append(SizeRange).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteNetworkCapabilityEntry);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteNetworkCapabilityEntry input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Specification != input.Specification) return false;
            if (this.IsSupport != input.IsSupport || (this.IsSupport != null && !this.IsSupport.Equals(input.IsSupport))) return false;
            if (this.IsSupportEnterpriseProject != input.IsSupportEnterpriseProject || (this.IsSupportEnterpriseProject != null && !this.IsSupportEnterpriseProject.Equals(input.IsSupportEnterpriseProject))) return false;
            if (this.IsSupportTag != input.IsSupportTag || (this.IsSupportTag != null && !this.IsSupportTag.Equals(input.IsSupportTag))) return false;
            if (this.IsSupportIntraRegion != input.IsSupportIntraRegion || (this.IsSupportIntraRegion != null && !this.IsSupportIntraRegion.Equals(input.IsSupportIntraRegion))) return false;
            if (this.SupportTopologies != input.SupportTopologies || (this.SupportTopologies != null && input.SupportTopologies != null && !this.SupportTopologies.SequenceEqual(input.SupportTopologies))) return false;
            if (this.SupportRegions != input.SupportRegions || (this.SupportRegions != null && input.SupportRegions != null && !this.SupportRegions.SequenceEqual(input.SupportRegions))) return false;
            if (this.SupportDscpRegions != input.SupportDscpRegions || (this.SupportDscpRegions != null && input.SupportDscpRegions != null && !this.SupportDscpRegions.SequenceEqual(input.SupportDscpRegions))) return false;
            if (this.SupportFreezeRegions != input.SupportFreezeRegions || (this.SupportFreezeRegions != null && input.SupportFreezeRegions != null && !this.SupportFreezeRegions.SequenceEqual(input.SupportFreezeRegions))) return false;
            if (this.SupportLocations != input.SupportLocations || (this.SupportLocations != null && input.SupportLocations != null && !this.SupportLocations.SequenceEqual(input.SupportLocations))) return false;
            if (this.SizeRange != input.SizeRange || (this.SizeRange != null && !this.SizeRange.Equals(input.SizeRange))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && input.ChargeMode != null && !this.ChargeMode.SequenceEqual(input.ChargeMode))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.IsSupport != null) hashCode = hashCode * 59 + this.IsSupport.GetHashCode();
                if (this.IsSupportEnterpriseProject != null) hashCode = hashCode * 59 + this.IsSupportEnterpriseProject.GetHashCode();
                if (this.IsSupportTag != null) hashCode = hashCode * 59 + this.IsSupportTag.GetHashCode();
                if (this.IsSupportIntraRegion != null) hashCode = hashCode * 59 + this.IsSupportIntraRegion.GetHashCode();
                if (this.SupportTopologies != null) hashCode = hashCode * 59 + this.SupportTopologies.GetHashCode();
                if (this.SupportRegions != null) hashCode = hashCode * 59 + this.SupportRegions.GetHashCode();
                if (this.SupportDscpRegions != null) hashCode = hashCode * 59 + this.SupportDscpRegions.GetHashCode();
                if (this.SupportFreezeRegions != null) hashCode = hashCode * 59 + this.SupportFreezeRegions.GetHashCode();
                if (this.SupportLocations != null) hashCode = hashCode * 59 + this.SupportLocations.GetHashCode();
                if (this.SizeRange != null) hashCode = hashCode * 59 + this.SizeRange.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
