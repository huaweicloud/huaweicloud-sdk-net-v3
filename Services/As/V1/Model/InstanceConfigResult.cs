using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 实例配置信息
    /// </summary>
    public class InstanceConfigResult 
    {

        /// <summary>
        /// 云服务器的规格ID。
        /// </summary>
        [JsonProperty("flavorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 镜像ID，同image_id。
        /// </summary>
        [JsonProperty("imageRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageRef { get; set; }

        /// <summary>
        /// 磁盘组信息。
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiskResult> Disk { get; set; }

        /// <summary>
        /// 登录云服务器的SSH密钥名称。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 登录云服务器的SSH密钥指纹。
        /// </summary>
        [JsonProperty("key_fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyFingerprint { get; set; }

        /// <summary>
        /// 该参数为预留字段。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 该参数为预留字段。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 登录云服务器的密码，非明文回显。
        /// </summary>
        [JsonProperty("adminPass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// 个人信息
        /// </summary>
        [JsonProperty("personality", NullValueHandling = NullValueHandling.Ignore)]
        public List<PersonalityResult> Personality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicipResult PublicIp { get; set; }

        /// <summary>
        /// cloud-init用户数据，base64格式编码。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VmMetaData Metadata { get; set; }

        /// <summary>
        /// 安全组信息。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroups> SecurityGroups { get; set; }

        /// <summary>
        /// 云服务器组ID。
        /// </summary>
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 在专属主机上创建弹性云服务器。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenancy { get; set; }

        /// <summary>
        /// 专属主机的ID。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// 云服务器的计费模式，可以选择竞价计费或按需计费。
        /// </summary>
        [JsonProperty("market_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MarketType { get; set; }

        /// <summary>
        /// 使用伸缩配置创建云主机的时候，多规格使用的优先级策略。  PICK_FIRST（默认）：选择优先，虚拟机扩容时规格的选择按照flavorRef列表的顺序进行优先级排序。 COST_FIRST：成本优化，虚拟机扩容时规格的选择按照价格最优原则进行优先级排序。
        /// </summary>
        [JsonProperty("multi_flavor_priority_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string MultiFlavorPriorityPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu_options", NullValueHandling = NullValueHandling.Ignore)]
        public CpuOptions CpuOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceConfigResult {\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  keyFingerprint: ").Append(KeyFingerprint).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  personality: ").Append(Personality).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  marketType: ").Append(MarketType).Append("\n");
            sb.Append("  multiFlavorPriorityPolicy: ").Append(MultiFlavorPriorityPolicy).Append("\n");
            sb.Append("  cpuOptions: ").Append(CpuOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceConfigResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceConfigResult input)
        {
            if (input == null) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.ImageRef != input.ImageRef || (this.ImageRef != null && !this.ImageRef.Equals(input.ImageRef))) return false;
            if (this.Disk != input.Disk || (this.Disk != null && input.Disk != null && !this.Disk.SequenceEqual(input.Disk))) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.KeyFingerprint != input.KeyFingerprint || (this.KeyFingerprint != null && !this.KeyFingerprint.Equals(input.KeyFingerprint))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.AdminPass != input.AdminPass || (this.AdminPass != null && !this.AdminPass.Equals(input.AdminPass))) return false;
            if (this.Personality != input.Personality || (this.Personality != null && input.Personality != null && !this.Personality.SequenceEqual(input.Personality))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.Tenancy != input.Tenancy || (this.Tenancy != null && !this.Tenancy.Equals(input.Tenancy))) return false;
            if (this.DedicatedHostId != input.DedicatedHostId || (this.DedicatedHostId != null && !this.DedicatedHostId.Equals(input.DedicatedHostId))) return false;
            if (this.MarketType != input.MarketType || (this.MarketType != null && !this.MarketType.Equals(input.MarketType))) return false;
            if (this.MultiFlavorPriorityPolicy != input.MultiFlavorPriorityPolicy || (this.MultiFlavorPriorityPolicy != null && !this.MultiFlavorPriorityPolicy.Equals(input.MultiFlavorPriorityPolicy))) return false;
            if (this.CpuOptions != input.CpuOptions || (this.CpuOptions != null && !this.CpuOptions.Equals(input.CpuOptions))) return false;

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
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.ImageRef != null) hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.Disk != null) hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.KeyFingerprint != null) hashCode = hashCode * 59 + this.KeyFingerprint.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.AdminPass != null) hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                if (this.Personality != null) hashCode = hashCode * 59 + this.Personality.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.Tenancy != null) hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null) hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.MarketType != null) hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                if (this.MultiFlavorPriorityPolicy != null) hashCode = hashCode * 59 + this.MultiFlavorPriorityPolicy.GetHashCode();
                if (this.CpuOptions != null) hashCode = hashCode * 59 + this.CpuOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
