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
    public class ServerLimits 
    {

        /// <summary>
        /// 镜像元数据最大的长度。
        /// </summary>
        [JsonProperty("maxImageMeta", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxImageMeta { get; set; }

        /// <summary>
        /// 可注入文件的最大个数。
        /// </summary>
        [JsonProperty("maxPersonality", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPersonality { get; set; }

        /// <summary>
        /// 注入文件内容的最大长度（单位：Byte）。
        /// </summary>
        [JsonProperty("maxPersonalitySize", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPersonalitySize { get; set; }

        /// <summary>
        /// 安全组中安全组规则最大的配置个数。   &gt; 说明：  - 具体配额限制请以VPC配额限制为准。
        /// </summary>
        [JsonProperty("maxSecurityGroupRules", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSecurityGroupRules { get; set; }

        /// <summary>
        /// 安全组最大使用个数。  &gt; 说明：  - 具体配额限制请以VPC配额限制为准。
        /// </summary>
        [JsonProperty("maxSecurityGroups", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxSecurityGroups { get; set; }

        /// <summary>
        /// 服务器组中的最大虚拟机数。
        /// </summary>
        [JsonProperty("maxServerGroupMembers", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxServerGroupMembers { get; set; }

        /// <summary>
        /// 服务器组的最大个数。
        /// </summary>
        [JsonProperty("maxServerGroups", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxServerGroups { get; set; }

        /// <summary>
        /// 可输入元数据的最大长度。
        /// </summary>
        [JsonProperty("maxServerMeta", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxServerMeta { get; set; }

        /// <summary>
        /// CPU核数最大申请数量。
        /// </summary>
        [JsonProperty("maxTotalCores", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalCores { get; set; }

        /// <summary>
        /// 最大的浮动IP使用个数。
        /// </summary>
        [JsonProperty("maxTotalFloatingIps", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalFloatingIps { get; set; }

        /// <summary>
        /// 云服务器最大申请数量。
        /// </summary>
        [JsonProperty("maxTotalInstances", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalInstances { get; set; }

        /// <summary>
        /// 可以申请的SSH密钥对最大数量。
        /// </summary>
        [JsonProperty("maxTotalKeypairs", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalKeypairs { get; set; }

        /// <summary>
        /// 内存最大申请容量（单位：MB）。
        /// </summary>
        [JsonProperty("maxTotalRAMSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalRAMSize { get; set; }

        /// <summary>
        /// 当前已使用CPU核数。
        /// </summary>
        [JsonProperty("totalCoresUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCoresUsed { get; set; }

        /// <summary>
        /// 当前浮动IP使用个数。
        /// </summary>
        [JsonProperty("totalFloatingIpsUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalFloatingIpsUsed { get; set; }

        /// <summary>
        /// 当前云服务器使用个数。
        /// </summary>
        [JsonProperty("totalInstancesUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalInstancesUsed { get; set; }

        /// <summary>
        /// 当前内存使用容量（单位：MB）。
        /// </summary>
        [JsonProperty("totalRAMUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRAMUsed { get; set; }

        /// <summary>
        /// 当前安全组使用个数。
        /// </summary>
        [JsonProperty("totalSecurityGroupsUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSecurityGroupsUsed { get; set; }

        /// <summary>
        /// 已使用的服务器组个数。
        /// </summary>
        [JsonProperty("totalServerGroupsUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServerGroupsUsed { get; set; }

        /// <summary>
        /// 竞价实例的最大申请数量。
        /// </summary>
        [JsonProperty("maxTotalSpotInstances", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalSpotInstances { get; set; }

        /// <summary>
        /// 竞价实例的CPU核数最大申请数量。
        /// </summary>
        [JsonProperty("maxTotalSpotCores", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalSpotCores { get; set; }

        /// <summary>
        /// 竞价实例的内存最大申请容量（单位：MB）。
        /// </summary>
        [JsonProperty("maxTotalSpotRAMSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTotalSpotRAMSize { get; set; }

        /// <summary>
        /// 当前竞价实例的使用个数。
        /// </summary>
        [JsonProperty("totalSpotInstancesUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSpotInstancesUsed { get; set; }

        /// <summary>
        /// 当前竞价实例已使用的CPU核数。
        /// </summary>
        [JsonProperty("totalSpotCoresUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSpotCoresUsed { get; set; }

        /// <summary>
        /// 当前竞价实例的内存使用容量（单位：MB）。
        /// </summary>
        [JsonProperty("totalSpotRAMUsed", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSpotRAMUsed { get; set; }

        /// <summary>
        /// 使用该flavor可以申请的弹性云服务器数量。  值为“-1”时，表示无数量限制。
        /// </summary>
        [JsonProperty("limit_by_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectFlavorLimit> LimitByFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerLimits {\n");
            sb.Append("  maxImageMeta: ").Append(MaxImageMeta).Append("\n");
            sb.Append("  maxPersonality: ").Append(MaxPersonality).Append("\n");
            sb.Append("  maxPersonalitySize: ").Append(MaxPersonalitySize).Append("\n");
            sb.Append("  maxSecurityGroupRules: ").Append(MaxSecurityGroupRules).Append("\n");
            sb.Append("  maxSecurityGroups: ").Append(MaxSecurityGroups).Append("\n");
            sb.Append("  maxServerGroupMembers: ").Append(MaxServerGroupMembers).Append("\n");
            sb.Append("  maxServerGroups: ").Append(MaxServerGroups).Append("\n");
            sb.Append("  maxServerMeta: ").Append(MaxServerMeta).Append("\n");
            sb.Append("  maxTotalCores: ").Append(MaxTotalCores).Append("\n");
            sb.Append("  maxTotalFloatingIps: ").Append(MaxTotalFloatingIps).Append("\n");
            sb.Append("  maxTotalInstances: ").Append(MaxTotalInstances).Append("\n");
            sb.Append("  maxTotalKeypairs: ").Append(MaxTotalKeypairs).Append("\n");
            sb.Append("  maxTotalRAMSize: ").Append(MaxTotalRAMSize).Append("\n");
            sb.Append("  totalCoresUsed: ").Append(TotalCoresUsed).Append("\n");
            sb.Append("  totalFloatingIpsUsed: ").Append(TotalFloatingIpsUsed).Append("\n");
            sb.Append("  totalInstancesUsed: ").Append(TotalInstancesUsed).Append("\n");
            sb.Append("  totalRAMUsed: ").Append(TotalRAMUsed).Append("\n");
            sb.Append("  totalSecurityGroupsUsed: ").Append(TotalSecurityGroupsUsed).Append("\n");
            sb.Append("  totalServerGroupsUsed: ").Append(TotalServerGroupsUsed).Append("\n");
            sb.Append("  maxTotalSpotInstances: ").Append(MaxTotalSpotInstances).Append("\n");
            sb.Append("  maxTotalSpotCores: ").Append(MaxTotalSpotCores).Append("\n");
            sb.Append("  maxTotalSpotRAMSize: ").Append(MaxTotalSpotRAMSize).Append("\n");
            sb.Append("  totalSpotInstancesUsed: ").Append(TotalSpotInstancesUsed).Append("\n");
            sb.Append("  totalSpotCoresUsed: ").Append(TotalSpotCoresUsed).Append("\n");
            sb.Append("  totalSpotRAMUsed: ").Append(TotalSpotRAMUsed).Append("\n");
            sb.Append("  limitByFlavor: ").Append(LimitByFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerLimits);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerLimits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxImageMeta == input.MaxImageMeta ||
                    (this.MaxImageMeta != null &&
                    this.MaxImageMeta.Equals(input.MaxImageMeta))
                ) && 
                (
                    this.MaxPersonality == input.MaxPersonality ||
                    (this.MaxPersonality != null &&
                    this.MaxPersonality.Equals(input.MaxPersonality))
                ) && 
                (
                    this.MaxPersonalitySize == input.MaxPersonalitySize ||
                    (this.MaxPersonalitySize != null &&
                    this.MaxPersonalitySize.Equals(input.MaxPersonalitySize))
                ) && 
                (
                    this.MaxSecurityGroupRules == input.MaxSecurityGroupRules ||
                    (this.MaxSecurityGroupRules != null &&
                    this.MaxSecurityGroupRules.Equals(input.MaxSecurityGroupRules))
                ) && 
                (
                    this.MaxSecurityGroups == input.MaxSecurityGroups ||
                    (this.MaxSecurityGroups != null &&
                    this.MaxSecurityGroups.Equals(input.MaxSecurityGroups))
                ) && 
                (
                    this.MaxServerGroupMembers == input.MaxServerGroupMembers ||
                    (this.MaxServerGroupMembers != null &&
                    this.MaxServerGroupMembers.Equals(input.MaxServerGroupMembers))
                ) && 
                (
                    this.MaxServerGroups == input.MaxServerGroups ||
                    (this.MaxServerGroups != null &&
                    this.MaxServerGroups.Equals(input.MaxServerGroups))
                ) && 
                (
                    this.MaxServerMeta == input.MaxServerMeta ||
                    (this.MaxServerMeta != null &&
                    this.MaxServerMeta.Equals(input.MaxServerMeta))
                ) && 
                (
                    this.MaxTotalCores == input.MaxTotalCores ||
                    (this.MaxTotalCores != null &&
                    this.MaxTotalCores.Equals(input.MaxTotalCores))
                ) && 
                (
                    this.MaxTotalFloatingIps == input.MaxTotalFloatingIps ||
                    (this.MaxTotalFloatingIps != null &&
                    this.MaxTotalFloatingIps.Equals(input.MaxTotalFloatingIps))
                ) && 
                (
                    this.MaxTotalInstances == input.MaxTotalInstances ||
                    (this.MaxTotalInstances != null &&
                    this.MaxTotalInstances.Equals(input.MaxTotalInstances))
                ) && 
                (
                    this.MaxTotalKeypairs == input.MaxTotalKeypairs ||
                    (this.MaxTotalKeypairs != null &&
                    this.MaxTotalKeypairs.Equals(input.MaxTotalKeypairs))
                ) && 
                (
                    this.MaxTotalRAMSize == input.MaxTotalRAMSize ||
                    (this.MaxTotalRAMSize != null &&
                    this.MaxTotalRAMSize.Equals(input.MaxTotalRAMSize))
                ) && 
                (
                    this.TotalCoresUsed == input.TotalCoresUsed ||
                    (this.TotalCoresUsed != null &&
                    this.TotalCoresUsed.Equals(input.TotalCoresUsed))
                ) && 
                (
                    this.TotalFloatingIpsUsed == input.TotalFloatingIpsUsed ||
                    (this.TotalFloatingIpsUsed != null &&
                    this.TotalFloatingIpsUsed.Equals(input.TotalFloatingIpsUsed))
                ) && 
                (
                    this.TotalInstancesUsed == input.TotalInstancesUsed ||
                    (this.TotalInstancesUsed != null &&
                    this.TotalInstancesUsed.Equals(input.TotalInstancesUsed))
                ) && 
                (
                    this.TotalRAMUsed == input.TotalRAMUsed ||
                    (this.TotalRAMUsed != null &&
                    this.TotalRAMUsed.Equals(input.TotalRAMUsed))
                ) && 
                (
                    this.TotalSecurityGroupsUsed == input.TotalSecurityGroupsUsed ||
                    (this.TotalSecurityGroupsUsed != null &&
                    this.TotalSecurityGroupsUsed.Equals(input.TotalSecurityGroupsUsed))
                ) && 
                (
                    this.TotalServerGroupsUsed == input.TotalServerGroupsUsed ||
                    (this.TotalServerGroupsUsed != null &&
                    this.TotalServerGroupsUsed.Equals(input.TotalServerGroupsUsed))
                ) && 
                (
                    this.MaxTotalSpotInstances == input.MaxTotalSpotInstances ||
                    (this.MaxTotalSpotInstances != null &&
                    this.MaxTotalSpotInstances.Equals(input.MaxTotalSpotInstances))
                ) && 
                (
                    this.MaxTotalSpotCores == input.MaxTotalSpotCores ||
                    (this.MaxTotalSpotCores != null &&
                    this.MaxTotalSpotCores.Equals(input.MaxTotalSpotCores))
                ) && 
                (
                    this.MaxTotalSpotRAMSize == input.MaxTotalSpotRAMSize ||
                    (this.MaxTotalSpotRAMSize != null &&
                    this.MaxTotalSpotRAMSize.Equals(input.MaxTotalSpotRAMSize))
                ) && 
                (
                    this.TotalSpotInstancesUsed == input.TotalSpotInstancesUsed ||
                    (this.TotalSpotInstancesUsed != null &&
                    this.TotalSpotInstancesUsed.Equals(input.TotalSpotInstancesUsed))
                ) && 
                (
                    this.TotalSpotCoresUsed == input.TotalSpotCoresUsed ||
                    (this.TotalSpotCoresUsed != null &&
                    this.TotalSpotCoresUsed.Equals(input.TotalSpotCoresUsed))
                ) && 
                (
                    this.TotalSpotRAMUsed == input.TotalSpotRAMUsed ||
                    (this.TotalSpotRAMUsed != null &&
                    this.TotalSpotRAMUsed.Equals(input.TotalSpotRAMUsed))
                ) && 
                (
                    this.LimitByFlavor == input.LimitByFlavor ||
                    this.LimitByFlavor != null &&
                    input.LimitByFlavor != null &&
                    this.LimitByFlavor.SequenceEqual(input.LimitByFlavor)
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
                if (this.MaxImageMeta != null)
                    hashCode = hashCode * 59 + this.MaxImageMeta.GetHashCode();
                if (this.MaxPersonality != null)
                    hashCode = hashCode * 59 + this.MaxPersonality.GetHashCode();
                if (this.MaxPersonalitySize != null)
                    hashCode = hashCode * 59 + this.MaxPersonalitySize.GetHashCode();
                if (this.MaxSecurityGroupRules != null)
                    hashCode = hashCode * 59 + this.MaxSecurityGroupRules.GetHashCode();
                if (this.MaxSecurityGroups != null)
                    hashCode = hashCode * 59 + this.MaxSecurityGroups.GetHashCode();
                if (this.MaxServerGroupMembers != null)
                    hashCode = hashCode * 59 + this.MaxServerGroupMembers.GetHashCode();
                if (this.MaxServerGroups != null)
                    hashCode = hashCode * 59 + this.MaxServerGroups.GetHashCode();
                if (this.MaxServerMeta != null)
                    hashCode = hashCode * 59 + this.MaxServerMeta.GetHashCode();
                if (this.MaxTotalCores != null)
                    hashCode = hashCode * 59 + this.MaxTotalCores.GetHashCode();
                if (this.MaxTotalFloatingIps != null)
                    hashCode = hashCode * 59 + this.MaxTotalFloatingIps.GetHashCode();
                if (this.MaxTotalInstances != null)
                    hashCode = hashCode * 59 + this.MaxTotalInstances.GetHashCode();
                if (this.MaxTotalKeypairs != null)
                    hashCode = hashCode * 59 + this.MaxTotalKeypairs.GetHashCode();
                if (this.MaxTotalRAMSize != null)
                    hashCode = hashCode * 59 + this.MaxTotalRAMSize.GetHashCode();
                if (this.TotalCoresUsed != null)
                    hashCode = hashCode * 59 + this.TotalCoresUsed.GetHashCode();
                if (this.TotalFloatingIpsUsed != null)
                    hashCode = hashCode * 59 + this.TotalFloatingIpsUsed.GetHashCode();
                if (this.TotalInstancesUsed != null)
                    hashCode = hashCode * 59 + this.TotalInstancesUsed.GetHashCode();
                if (this.TotalRAMUsed != null)
                    hashCode = hashCode * 59 + this.TotalRAMUsed.GetHashCode();
                if (this.TotalSecurityGroupsUsed != null)
                    hashCode = hashCode * 59 + this.TotalSecurityGroupsUsed.GetHashCode();
                if (this.TotalServerGroupsUsed != null)
                    hashCode = hashCode * 59 + this.TotalServerGroupsUsed.GetHashCode();
                if (this.MaxTotalSpotInstances != null)
                    hashCode = hashCode * 59 + this.MaxTotalSpotInstances.GetHashCode();
                if (this.MaxTotalSpotCores != null)
                    hashCode = hashCode * 59 + this.MaxTotalSpotCores.GetHashCode();
                if (this.MaxTotalSpotRAMSize != null)
                    hashCode = hashCode * 59 + this.MaxTotalSpotRAMSize.GetHashCode();
                if (this.TotalSpotInstancesUsed != null)
                    hashCode = hashCode * 59 + this.TotalSpotInstancesUsed.GetHashCode();
                if (this.TotalSpotCoresUsed != null)
                    hashCode = hashCode * 59 + this.TotalSpotCoresUsed.GetHashCode();
                if (this.TotalSpotRAMUsed != null)
                    hashCode = hashCode * 59 + this.TotalSpotRAMUsed.GetHashCode();
                if (this.LimitByFlavor != null)
                    hashCode = hashCode * 59 + this.LimitByFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
