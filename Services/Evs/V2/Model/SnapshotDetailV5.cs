using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SnapshotDetailV5 
    {

        /// <summary>
        /// **参数解释** 云硬盘快照ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘快照名称。 名称以autobk_snapshot_为前缀的快照是创建云硬盘备份时系统自动创建的，请不要进行“删除云硬盘快照”和“回滚快照到云硬盘”操作。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘快照描述信息。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘快照创建时间。 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘快照更新时间。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释** 快照所属的云硬盘ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘快照大小，单位为GiB。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘快照的状态。 **取值范围** 具体请参见[云硬盘快照状态](evs_04_0041.xml)。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释** 项目ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释** 快照所属的企业项目ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释** 是否为加密快照。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// **参数解释** 快照所属的云硬盘ID的密钥ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("cmk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkId { get; set; }

        /// <summary>
        /// **参数解释** 快照类型。 **取值范围** 枚举值：standard/flash。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释** 快照所属AZ。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释** 快照所属标签。 标签的key：String类型，最大长度36个字符。 由英文字母、数字、下划线、中划线、UNICODE字符（\\u4E00-\\u9FFF）组成。  标签的value：String类型，最大长度43个字符，可以为空字符串。 由英文字母、数字、下划线、点、中划线、UNICODE字符（\\u4E00-\\u9FFF）组成。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// **参数解释** 是否开启了快照极速可用功能。 **取值范围** true：开启。仅SSD系列云盘支持开启该功能。 false：关闭。即快照为未开启快照极速可用功能的存量快照。
        /// </summary>
        [JsonProperty("instant_access", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// **参数解释** 快照保留的时间。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("retention_at", NullValueHandling = NullValueHandling.Ignore)]
        public string RetentionAt { get; set; }

        /// <summary>
        /// **参数解释** 设置快照极速可用功能的保留时间，保留时间到期后自动关闭快照极速可用功能。 **取值范围** 默认与参数retention_at的值一致。
        /// </summary>
        [JsonProperty("instant_access_retention_at", NullValueHandling = NullValueHandling.Ignore)]
        public string InstantAccessRetentionAt { get; set; }

        /// <summary>
        /// **参数解释** 是否增量快照。 **取值范围** true，false。
        /// </summary>
        [JsonProperty("incremental", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incremental { get; set; }

        /// <summary>
        /// **参数解释** 快照创建来源。 **取值范围** auto：自动创建快照。 user：手动创建快照。 copy：复制快照。
        /// </summary>
        [JsonProperty("snapshot_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// **参数解释** 快照创建进度，单位为百分比。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// **参数解释** 加密快照的加密算法。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("encrypt_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// **参数解释** 快照所属的快照链信息。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("snapshot_chains", NullValueHandling = NullValueHandling.Ignore)]
        public List<SnapshotChains> SnapshotChains { get; set; }

        /// <summary>
        /// **参数解释** 快照所属的一致性快照组id。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("snapshot_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnapshotDetailV5 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  cmkId: ").Append(CmkId).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  instantAccess: ").Append(InstantAccess).Append("\n");
            sb.Append("  retentionAt: ").Append(RetentionAt).Append("\n");
            sb.Append("  instantAccessRetentionAt: ").Append(InstantAccessRetentionAt).Append("\n");
            sb.Append("  incremental: ").Append(Incremental).Append("\n");
            sb.Append("  snapshotType: ").Append(SnapshotType).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  encryptAlgorithm: ").Append(EncryptAlgorithm).Append("\n");
            sb.Append("  snapshotChains: ").Append(SnapshotChains).Append("\n");
            sb.Append("  snapshotGroupId: ").Append(SnapshotGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SnapshotDetailV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SnapshotDetailV5 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.VolumeId != input.VolumeId || (this.VolumeId != null && !this.VolumeId.Equals(input.VolumeId))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Encrypted != input.Encrypted || (this.Encrypted != null && !this.Encrypted.Equals(input.Encrypted))) return false;
            if (this.CmkId != input.CmkId || (this.CmkId != null && !this.CmkId.Equals(input.CmkId))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.InstantAccess != input.InstantAccess || (this.InstantAccess != null && !this.InstantAccess.Equals(input.InstantAccess))) return false;
            if (this.RetentionAt != input.RetentionAt || (this.RetentionAt != null && !this.RetentionAt.Equals(input.RetentionAt))) return false;
            if (this.InstantAccessRetentionAt != input.InstantAccessRetentionAt || (this.InstantAccessRetentionAt != null && !this.InstantAccessRetentionAt.Equals(input.InstantAccessRetentionAt))) return false;
            if (this.Incremental != input.Incremental || (this.Incremental != null && !this.Incremental.Equals(input.Incremental))) return false;
            if (this.SnapshotType != input.SnapshotType || (this.SnapshotType != null && !this.SnapshotType.Equals(input.SnapshotType))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.EncryptAlgorithm != input.EncryptAlgorithm || (this.EncryptAlgorithm != null && !this.EncryptAlgorithm.Equals(input.EncryptAlgorithm))) return false;
            if (this.SnapshotChains != input.SnapshotChains || (this.SnapshotChains != null && input.SnapshotChains != null && !this.SnapshotChains.SequenceEqual(input.SnapshotChains))) return false;
            if (this.SnapshotGroupId != input.SnapshotGroupId || (this.SnapshotGroupId != null && !this.SnapshotGroupId.Equals(input.SnapshotGroupId))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VolumeId != null) hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Encrypted != null) hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.CmkId != null) hashCode = hashCode * 59 + this.CmkId.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.InstantAccess != null) hashCode = hashCode * 59 + this.InstantAccess.GetHashCode();
                if (this.RetentionAt != null) hashCode = hashCode * 59 + this.RetentionAt.GetHashCode();
                if (this.InstantAccessRetentionAt != null) hashCode = hashCode * 59 + this.InstantAccessRetentionAt.GetHashCode();
                if (this.Incremental != null) hashCode = hashCode * 59 + this.Incremental.GetHashCode();
                if (this.SnapshotType != null) hashCode = hashCode * 59 + this.SnapshotType.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.EncryptAlgorithm != null) hashCode = hashCode * 59 + this.EncryptAlgorithm.GetHashCode();
                if (this.SnapshotChains != null) hashCode = hashCode * 59 + this.SnapshotChains.GetHashCode();
                if (this.SnapshotGroupId != null) hashCode = hashCode * 59 + this.SnapshotGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
