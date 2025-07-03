using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TemplateData 
    {

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// AZ
        /// </summary>
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 开启自动恢复
        /// </summary>
        [JsonProperty("auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRecovery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os_profile", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateOsProfile OsProfile { get; set; }

        /// <summary>
        /// 安全组ID列表。全网卡生效。
        /// </summary>
        [JsonProperty("security_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroupIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_interfaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateNetworkInterfaceOption> NetworkInterfaces { get; set; }

        /// <summary>
        /// BDM挂载信息。按flavor限制为准。 1. 整机镜像，不修改卷属性，按原镜像配置创建。 2. 整机镜像，修改卷属性，要用户解开填写BDM。 3. 提供解镜像为BDM接口。
        /// </summary>
        [JsonProperty("block_device_mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateBlockDeviceMappingOption> BlockDeviceMappings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("market_options", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateMarketOptions MarketOptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internet_access", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateInternetAccessOption InternetAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 创建虚拟机标签，目前仅支持给虚拟机打标签，后续会支持同时给相关资源如卷等打标签
        /// </summary>
        [JsonProperty("tag_options", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateTagOptions> TagOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateData {\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  autoRecovery: ").Append(AutoRecovery).Append("\n");
            sb.Append("  osProfile: ").Append(OsProfile).Append("\n");
            sb.Append("  securityGroupIds: ").Append(SecurityGroupIds).Append("\n");
            sb.Append("  networkInterfaces: ").Append(NetworkInterfaces).Append("\n");
            sb.Append("  blockDeviceMappings: ").Append(BlockDeviceMappings).Append("\n");
            sb.Append("  marketOptions: ").Append(MarketOptions).Append("\n");
            sb.Append("  internetAccess: ").Append(InternetAccess).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  tagOptions: ").Append(TagOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateData input)
        {
            if (input == null) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && !this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.AutoRecovery != input.AutoRecovery || (this.AutoRecovery != null && !this.AutoRecovery.Equals(input.AutoRecovery))) return false;
            if (this.OsProfile != input.OsProfile || (this.OsProfile != null && !this.OsProfile.Equals(input.OsProfile))) return false;
            if (this.SecurityGroupIds != input.SecurityGroupIds || (this.SecurityGroupIds != null && input.SecurityGroupIds != null && !this.SecurityGroupIds.SequenceEqual(input.SecurityGroupIds))) return false;
            if (this.NetworkInterfaces != input.NetworkInterfaces || (this.NetworkInterfaces != null && input.NetworkInterfaces != null && !this.NetworkInterfaces.SequenceEqual(input.NetworkInterfaces))) return false;
            if (this.BlockDeviceMappings != input.BlockDeviceMappings || (this.BlockDeviceMappings != null && input.BlockDeviceMappings != null && !this.BlockDeviceMappings.SequenceEqual(input.BlockDeviceMappings))) return false;
            if (this.MarketOptions != input.MarketOptions || (this.MarketOptions != null && !this.MarketOptions.Equals(input.MarketOptions))) return false;
            if (this.InternetAccess != input.InternetAccess || (this.InternetAccess != null && !this.InternetAccess.Equals(input.InternetAccess))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.TagOptions != input.TagOptions || (this.TagOptions != null && input.TagOptions != null && !this.TagOptions.SequenceEqual(input.TagOptions))) return false;

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
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.AutoRecovery != null) hashCode = hashCode * 59 + this.AutoRecovery.GetHashCode();
                if (this.OsProfile != null) hashCode = hashCode * 59 + this.OsProfile.GetHashCode();
                if (this.SecurityGroupIds != null) hashCode = hashCode * 59 + this.SecurityGroupIds.GetHashCode();
                if (this.NetworkInterfaces != null) hashCode = hashCode * 59 + this.NetworkInterfaces.GetHashCode();
                if (this.BlockDeviceMappings != null) hashCode = hashCode * 59 + this.BlockDeviceMappings.GetHashCode();
                if (this.MarketOptions != null) hashCode = hashCode * 59 + this.MarketOptions.GetHashCode();
                if (this.InternetAccess != null) hashCode = hashCode * 59 + this.InternetAccess.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.TagOptions != null) hashCode = hashCode * 59 + this.TagOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
