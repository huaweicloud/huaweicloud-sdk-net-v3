using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 详细信息结构体
    /// </summary>
    public class DetailsBody 
    {

        /// <summary>
        /// 变更前的容量，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("old_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string OldCapacity { get; set; }

        /// <summary>
        /// 变更后的容量，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("new_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCapacity { get; set; }

        /// <summary>
        /// 是否开启公网访问，仅在开启公网访问时有值。
        /// </summary>
        [JsonProperty("enable_public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicIp { get; set; }

        /// <summary>
        /// 公网IP的ID，仅在开启公网访问时有值。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// 公网IP地址，仅在开启公网访问时有值。
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// 是否开启SSL，仅在开启SSL时有值。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 变更前的缓存类型，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("old_cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string OldCacheMode { get; set; }

        /// <summary>
        /// 变更后的缓存类型，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("new_cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCacheMode { get; set; }

        /// <summary>
        /// 变更前的规格参数，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("old_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string OldResourceSpecCode { get; set; }

        /// <summary>
        /// 变更后的规格参数，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("new_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NewResourceSpecCode { get; set; }

        /// <summary>
        /// 变更前的副本数量，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("old_replica_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? OldReplicaNum { get; set; }

        /// <summary>
        /// 变更后的副本数量，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("new_replica_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewReplicaNum { get; set; }

        /// <summary>
        /// 变更前的缓存类型，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("old_cache_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OldCacheType { get; set; }

        /// <summary>
        /// 变更后的规格类型，仅在变更规格时有值。
        /// </summary>
        [JsonProperty("new_cache_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NewCacheType { get; set; }

        /// <summary>
        /// 副本IP。
        /// </summary>
        [JsonProperty("replica_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicaIp { get; set; }

        /// <summary>
        /// 副本所在可用区。
        /// </summary>
        [JsonProperty("replica_az", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicaAz { get; set; }

        /// <summary>
        /// 组名。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 旧端口。
        /// </summary>
        [JsonProperty("old_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? OldPort { get; set; }

        /// <summary>
        /// 新端口。
        /// </summary>
        [JsonProperty("new_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPort { get; set; }

        /// <summary>
        /// 是否只是调整计费模式。
        /// </summary>
        [JsonProperty("is_only_adjust_charging", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnlyAdjustCharging { get; set; }

        /// <summary>
        /// 账号名称。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 源IP。
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 目标IP。
        /// </summary>
        [JsonProperty("target_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetIp { get; set; }

        /// <summary>
        /// 节点信息。
        /// </summary>
        [JsonProperty("node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// 重命名的指令。
        /// </summary>
        [JsonProperty("rename_commands", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RenameCommands { get; set; }

        /// <summary>
        /// 更新配置项的长度。
        /// </summary>
        [JsonProperty("updated_config_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdatedConfigLength { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailsBody {\n");
            sb.Append("  oldCapacity: ").Append(OldCapacity).Append("\n");
            sb.Append("  newCapacity: ").Append(NewCapacity).Append("\n");
            sb.Append("  enablePublicIp: ").Append(EnablePublicIp).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  oldCacheMode: ").Append(OldCacheMode).Append("\n");
            sb.Append("  newCacheMode: ").Append(NewCacheMode).Append("\n");
            sb.Append("  oldResourceSpecCode: ").Append(OldResourceSpecCode).Append("\n");
            sb.Append("  newResourceSpecCode: ").Append(NewResourceSpecCode).Append("\n");
            sb.Append("  oldReplicaNum: ").Append(OldReplicaNum).Append("\n");
            sb.Append("  newReplicaNum: ").Append(NewReplicaNum).Append("\n");
            sb.Append("  oldCacheType: ").Append(OldCacheType).Append("\n");
            sb.Append("  newCacheType: ").Append(NewCacheType).Append("\n");
            sb.Append("  replicaIp: ").Append(ReplicaIp).Append("\n");
            sb.Append("  replicaAz: ").Append(ReplicaAz).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  oldPort: ").Append(OldPort).Append("\n");
            sb.Append("  newPort: ").Append(NewPort).Append("\n");
            sb.Append("  isOnlyAdjustCharging: ").Append(IsOnlyAdjustCharging).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  targetIp: ").Append(TargetIp).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  renameCommands: ").Append(RenameCommands).Append("\n");
            sb.Append("  updatedConfigLength: ").Append(UpdatedConfigLength).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailsBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetailsBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldCapacity == input.OldCapacity ||
                    (this.OldCapacity != null &&
                    this.OldCapacity.Equals(input.OldCapacity))
                ) && 
                (
                    this.NewCapacity == input.NewCapacity ||
                    (this.NewCapacity != null &&
                    this.NewCapacity.Equals(input.NewCapacity))
                ) && 
                (
                    this.EnablePublicIp == input.EnablePublicIp ||
                    (this.EnablePublicIp != null &&
                    this.EnablePublicIp.Equals(input.EnablePublicIp))
                ) && 
                (
                    this.PublicIpId == input.PublicIpId ||
                    (this.PublicIpId != null &&
                    this.PublicIpId.Equals(input.PublicIpId))
                ) && 
                (
                    this.PublicIpAddress == input.PublicIpAddress ||
                    (this.PublicIpAddress != null &&
                    this.PublicIpAddress.Equals(input.PublicIpAddress))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.OldCacheMode == input.OldCacheMode ||
                    (this.OldCacheMode != null &&
                    this.OldCacheMode.Equals(input.OldCacheMode))
                ) && 
                (
                    this.NewCacheMode == input.NewCacheMode ||
                    (this.NewCacheMode != null &&
                    this.NewCacheMode.Equals(input.NewCacheMode))
                ) && 
                (
                    this.OldResourceSpecCode == input.OldResourceSpecCode ||
                    (this.OldResourceSpecCode != null &&
                    this.OldResourceSpecCode.Equals(input.OldResourceSpecCode))
                ) && 
                (
                    this.NewResourceSpecCode == input.NewResourceSpecCode ||
                    (this.NewResourceSpecCode != null &&
                    this.NewResourceSpecCode.Equals(input.NewResourceSpecCode))
                ) && 
                (
                    this.OldReplicaNum == input.OldReplicaNum ||
                    (this.OldReplicaNum != null &&
                    this.OldReplicaNum.Equals(input.OldReplicaNum))
                ) && 
                (
                    this.NewReplicaNum == input.NewReplicaNum ||
                    (this.NewReplicaNum != null &&
                    this.NewReplicaNum.Equals(input.NewReplicaNum))
                ) && 
                (
                    this.OldCacheType == input.OldCacheType ||
                    (this.OldCacheType != null &&
                    this.OldCacheType.Equals(input.OldCacheType))
                ) && 
                (
                    this.NewCacheType == input.NewCacheType ||
                    (this.NewCacheType != null &&
                    this.NewCacheType.Equals(input.NewCacheType))
                ) && 
                (
                    this.ReplicaIp == input.ReplicaIp ||
                    (this.ReplicaIp != null &&
                    this.ReplicaIp.Equals(input.ReplicaIp))
                ) && 
                (
                    this.ReplicaAz == input.ReplicaAz ||
                    (this.ReplicaAz != null &&
                    this.ReplicaAz.Equals(input.ReplicaAz))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.OldPort == input.OldPort ||
                    (this.OldPort != null &&
                    this.OldPort.Equals(input.OldPort))
                ) && 
                (
                    this.NewPort == input.NewPort ||
                    (this.NewPort != null &&
                    this.NewPort.Equals(input.NewPort))
                ) && 
                (
                    this.IsOnlyAdjustCharging == input.IsOnlyAdjustCharging ||
                    (this.IsOnlyAdjustCharging != null &&
                    this.IsOnlyAdjustCharging.Equals(input.IsOnlyAdjustCharging))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.SourceIp == input.SourceIp ||
                    (this.SourceIp != null &&
                    this.SourceIp.Equals(input.SourceIp))
                ) && 
                (
                    this.TargetIp == input.TargetIp ||
                    (this.TargetIp != null &&
                    this.TargetIp.Equals(input.TargetIp))
                ) && 
                (
                    this.NodeName == input.NodeName ||
                    (this.NodeName != null &&
                    this.NodeName.Equals(input.NodeName))
                ) && 
                (
                    this.RenameCommands == input.RenameCommands ||
                    this.RenameCommands != null &&
                    input.RenameCommands != null &&
                    this.RenameCommands.SequenceEqual(input.RenameCommands)
                ) && 
                (
                    this.UpdatedConfigLength == input.UpdatedConfigLength ||
                    (this.UpdatedConfigLength != null &&
                    this.UpdatedConfigLength.Equals(input.UpdatedConfigLength))
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
                if (this.OldCapacity != null)
                    hashCode = hashCode * 59 + this.OldCapacity.GetHashCode();
                if (this.NewCapacity != null)
                    hashCode = hashCode * 59 + this.NewCapacity.GetHashCode();
                if (this.EnablePublicIp != null)
                    hashCode = hashCode * 59 + this.EnablePublicIp.GetHashCode();
                if (this.PublicIpId != null)
                    hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.PublicIpAddress != null)
                    hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.OldCacheMode != null)
                    hashCode = hashCode * 59 + this.OldCacheMode.GetHashCode();
                if (this.NewCacheMode != null)
                    hashCode = hashCode * 59 + this.NewCacheMode.GetHashCode();
                if (this.OldResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.OldResourceSpecCode.GetHashCode();
                if (this.NewResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.NewResourceSpecCode.GetHashCode();
                if (this.OldReplicaNum != null)
                    hashCode = hashCode * 59 + this.OldReplicaNum.GetHashCode();
                if (this.NewReplicaNum != null)
                    hashCode = hashCode * 59 + this.NewReplicaNum.GetHashCode();
                if (this.OldCacheType != null)
                    hashCode = hashCode * 59 + this.OldCacheType.GetHashCode();
                if (this.NewCacheType != null)
                    hashCode = hashCode * 59 + this.NewCacheType.GetHashCode();
                if (this.ReplicaIp != null)
                    hashCode = hashCode * 59 + this.ReplicaIp.GetHashCode();
                if (this.ReplicaAz != null)
                    hashCode = hashCode * 59 + this.ReplicaAz.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.OldPort != null)
                    hashCode = hashCode * 59 + this.OldPort.GetHashCode();
                if (this.NewPort != null)
                    hashCode = hashCode * 59 + this.NewPort.GetHashCode();
                if (this.IsOnlyAdjustCharging != null)
                    hashCode = hashCode * 59 + this.IsOnlyAdjustCharging.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.SourceIp != null)
                    hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                if (this.TargetIp != null)
                    hashCode = hashCode * 59 + this.TargetIp.GetHashCode();
                if (this.NodeName != null)
                    hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.RenameCommands != null)
                    hashCode = hashCode * 59 + this.RenameCommands.GetHashCode();
                if (this.UpdatedConfigLength != null)
                    hashCode = hashCode * 59 + this.UpdatedConfigLength.GetHashCode();
                return hashCode;
            }
        }
    }
}
