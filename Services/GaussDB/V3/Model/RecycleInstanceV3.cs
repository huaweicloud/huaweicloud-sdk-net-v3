using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecycleInstanceV3 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例类型。
        /// </summary>
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HaMode { get; set; }

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 计费模式。
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// 删除时间。
        /// </summary>
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? DeletedAt { get; set; }

        /// <summary>
        /// 磁盘类型。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 磁盘大小。
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeSize { get; set; }

        /// <summary>
        /// 数据面VIP。
        /// </summary>
        [JsonProperty("data_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVip { get; set; }

        /// <summary>
        /// 数据面IPV6。
        /// </summary>
        [JsonProperty("data_vip_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVipIpv6 { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 备份级别。
        /// </summary>
        [JsonProperty("backup_level", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// 备份ID。
        /// </summary>
        [JsonProperty("recycle_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecycleBackupId { get; set; }

        /// <summary>
        /// 回收状态。
        /// </summary>
        [JsonProperty("recycle_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RecycleStatus { get; set; }

        /// <summary>
        /// **参数解释**：  实例所有的回收站备份列表。
        /// </summary>
        [JsonProperty("recycle_bakcups", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecycleBackupV3> RecycleBakcups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleInstanceV3 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  deletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  dataVip: ").Append(DataVip).Append("\n");
            sb.Append("  dataVipIpv6: ").Append(DataVipIpv6).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  backupLevel: ").Append(BackupLevel).Append("\n");
            sb.Append("  recycleBackupId: ").Append(RecycleBackupId).Append("\n");
            sb.Append("  recycleStatus: ").Append(RecycleStatus).Append("\n");
            sb.Append("  recycleBakcups: ").Append(RecycleBakcups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleInstanceV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleInstanceV3 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.HaMode != input.HaMode || (this.HaMode != null && !this.HaMode.Equals(input.HaMode))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.PayModel != input.PayModel || (this.PayModel != null && !this.PayModel.Equals(input.PayModel))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.DeletedAt != input.DeletedAt || (this.DeletedAt != null && !this.DeletedAt.Equals(input.DeletedAt))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;
            if (this.VolumeSize != input.VolumeSize || (this.VolumeSize != null && !this.VolumeSize.Equals(input.VolumeSize))) return false;
            if (this.DataVip != input.DataVip || (this.DataVip != null && !this.DataVip.Equals(input.DataVip))) return false;
            if (this.DataVipIpv6 != input.DataVipIpv6 || (this.DataVipIpv6 != null && !this.DataVipIpv6.Equals(input.DataVipIpv6))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.BackupLevel != input.BackupLevel || (this.BackupLevel != null && !this.BackupLevel.Equals(input.BackupLevel))) return false;
            if (this.RecycleBackupId != input.RecycleBackupId || (this.RecycleBackupId != null && !this.RecycleBackupId.Equals(input.RecycleBackupId))) return false;
            if (this.RecycleStatus != input.RecycleStatus || (this.RecycleStatus != null && !this.RecycleStatus.Equals(input.RecycleStatus))) return false;
            if (this.RecycleBakcups != input.RecycleBakcups || (this.RecycleBakcups != null && input.RecycleBakcups != null && !this.RecycleBakcups.SequenceEqual(input.RecycleBakcups))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HaMode != null) hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.PayModel != null) hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.DeletedAt != null) hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.VolumeSize != null) hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.DataVip != null) hashCode = hashCode * 59 + this.DataVip.GetHashCode();
                if (this.DataVipIpv6 != null) hashCode = hashCode * 59 + this.DataVipIpv6.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.BackupLevel != null) hashCode = hashCode * 59 + this.BackupLevel.GetHashCode();
                if (this.RecycleBackupId != null) hashCode = hashCode * 59 + this.RecycleBackupId.GetHashCode();
                if (this.RecycleStatus != null) hashCode = hashCode * 59 + this.RecycleStatus.GetHashCode();
                if (this.RecycleBakcups != null) hashCode = hashCode * 59 + this.RecycleBakcups.GetHashCode();
                return hashCode;
            }
        }
    }
}
