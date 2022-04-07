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
    /// 云硬盘详情。
    /// </summary>
    public class VolumeDetail 
    {

        /// <summary>
        /// 云硬盘的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云硬盘URI自描述信息。请参见 [links参数说明](https://support.huaweicloud.com/api-evs/evs_04_2006.html#evs_04_2006__evs_04_2010_li1077125119136)。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// 云硬盘名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云硬盘状态，请参见[云硬盘状态](https://support.huaweicloud.com/api-evs/evs_04_0040.html)。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 云硬盘的挂载信息，请参见•[attachments参数说明](https://support.huaweicloud.com/api-evs/evs_04_2006.html#evs_04_2006__evs_04_2010_li12430153610291)。
        /// </summary>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// 云硬盘所属的AZ信息。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("os-vol-host-attr:host", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolHostAttrhost { get; set; }

        /// <summary>
        /// 源云硬盘ID，如果是从源云硬盘创建，则有值。  当前云硬盘服务不支持该字段。
        /// </summary>
        [JsonProperty("source_volid", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceVolid { get; set; }

        /// <summary>
        /// 快照ID，如果是从快照创建，则有值。
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 云硬盘描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 云硬盘创建时间。 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 云硬盘所属的租户ID。租户ID就是项目ID。
        /// </summary>
        [JsonProperty("os-vol-tenant-attr:tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolTenantAttrtenantId { get; set; }

        /// <summary>
        /// 云硬盘镜像的元数据。 &gt; 说明： &gt;  &gt; 关于“volume_image_metadata”字段的详细说明，具体请参见：\&quot;[查询镜像详情](https://support.huaweicloud.com/api-ims/ims_03_0703.html)\&quot;。
        /// </summary>
        [JsonProperty("volume_image_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> VolumeImageMetadata { get; set; }

        /// <summary>
        /// 云硬盘类型。 目前支持\&quot;SATA\&quot;，\&quot;SAS\&quot;，\&quot;GPSSD\&quot;，\&quot;SSD\&quot;和\&quot;ESSD\&quot;五种。  - \&quot;SATA\&quot;为普通IO云硬盘 - \&quot;SAS\&quot;为高IO云硬盘 - \&quot;GPSSD\&quot;为通用型SSD云硬盘 - \&quot;SSD\&quot;为超高IO云硬盘 - \&quot;ESSD\&quot;为极速IO云硬盘
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 云硬盘大小，单位为GB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("consistencygroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsistencygroupId { get; set; }

        /// <summary>
        /// 是否为启动云硬盘。 true：表示为启动云硬盘。 false：表示为非启动云硬盘。
        /// </summary>
        [JsonProperty("bootable", NullValueHandling = NullValueHandling.Ignore)]
        public string Bootable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeMetadata Metadata { get; set; }

        /// <summary>
        /// 云硬盘更新时间。 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 当前云硬盘服务不支持该字段。
        /// </summary>
        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("replication_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationStatus { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("os-volume-replication:extended_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolumeReplicationextendedStatus { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("os-vol-mig-status-attr:migstat", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolMigStatusAttrmigstat { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("os-vol-mig-status-attr:name_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVolMigStatusAttrnameId { get; set; }

        /// <summary>
        /// 是否为共享云硬盘。true为共享盘，false为普通云硬盘。 该字段已经废弃，请使用multiattach。
        /// </summary>
        [JsonProperty("shareable", NullValueHandling = NullValueHandling.Ignore)]
        public string Shareable { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 服务类型，结果为EVS、DSS、DESS。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 是否为共享云硬盘。
        /// </summary>
        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        /// <summary>
        /// 云硬盘所属的专属存储池ID。
        /// </summary>
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        /// <summary>
        /// 云硬盘所属的专属存储池的名称。
        /// </summary>
        [JsonProperty("dedicated_storage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageName { get; set; }

        /// <summary>
        /// 云硬盘的标签。 如果云硬盘有标签，则会有该字段，否则该字段为空。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// 云硬盘挂载时的唯一标识。
        /// </summary>
        [JsonProperty("wwn", NullValueHandling = NullValueHandling.Ignore)]
        public string Wwn { get; set; }

        /// <summary>
        /// 云硬盘上绑定的企业项目ID。 &gt; 说明： &gt;  &gt; 关于企业项目ID的获取及企业项目特性的详细信息，请参见：\&quot;[企业管理用户指南](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0123692049.html)\&quot;。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 云硬盘序列号。 只有SCSI类型的非双活卷才会返回该字段，用于与虚拟机中的盘做对应关系。
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  attachments: ").Append(Attachments).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  osVolHostAttrhost: ").Append(OsVolHostAttrhost).Append("\n");
            sb.Append("  sourceVolid: ").Append(SourceVolid).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  osVolTenantAttrtenantId: ").Append(OsVolTenantAttrtenantId).Append("\n");
            sb.Append("  volumeImageMetadata: ").Append(VolumeImageMetadata).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  consistencygroupId: ").Append(ConsistencygroupId).Append("\n");
            sb.Append("  bootable: ").Append(Bootable).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  replicationStatus: ").Append(ReplicationStatus).Append("\n");
            sb.Append("  osVolumeReplicationextendedStatus: ").Append(OsVolumeReplicationextendedStatus).Append("\n");
            sb.Append("  osVolMigStatusAttrmigstat: ").Append(OsVolMigStatusAttrmigstat).Append("\n");
            sb.Append("  osVolMigStatusAttrnameId: ").Append(OsVolMigStatusAttrnameId).Append("\n");
            sb.Append("  shareable: ").Append(Shareable).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  dedicatedStorageName: ").Append(DedicatedStorageName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  wwn: ").Append(Wwn).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.OsVolHostAttrhost == input.OsVolHostAttrhost ||
                    (this.OsVolHostAttrhost != null &&
                    this.OsVolHostAttrhost.Equals(input.OsVolHostAttrhost))
                ) && 
                (
                    this.SourceVolid == input.SourceVolid ||
                    (this.SourceVolid != null &&
                    this.SourceVolid.Equals(input.SourceVolid))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.OsVolTenantAttrtenantId == input.OsVolTenantAttrtenantId ||
                    (this.OsVolTenantAttrtenantId != null &&
                    this.OsVolTenantAttrtenantId.Equals(input.OsVolTenantAttrtenantId))
                ) && 
                (
                    this.VolumeImageMetadata == input.VolumeImageMetadata ||
                    this.VolumeImageMetadata != null &&
                    input.VolumeImageMetadata != null &&
                    this.VolumeImageMetadata.SequenceEqual(input.VolumeImageMetadata)
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ConsistencygroupId == input.ConsistencygroupId ||
                    (this.ConsistencygroupId != null &&
                    this.ConsistencygroupId.Equals(input.ConsistencygroupId))
                ) && 
                (
                    this.Bootable == input.Bootable ||
                    (this.Bootable != null &&
                    this.Bootable.Equals(input.Bootable))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Encrypted == input.Encrypted ||
                    (this.Encrypted != null &&
                    this.Encrypted.Equals(input.Encrypted))
                ) && 
                (
                    this.ReplicationStatus == input.ReplicationStatus ||
                    (this.ReplicationStatus != null &&
                    this.ReplicationStatus.Equals(input.ReplicationStatus))
                ) && 
                (
                    this.OsVolumeReplicationextendedStatus == input.OsVolumeReplicationextendedStatus ||
                    (this.OsVolumeReplicationextendedStatus != null &&
                    this.OsVolumeReplicationextendedStatus.Equals(input.OsVolumeReplicationextendedStatus))
                ) && 
                (
                    this.OsVolMigStatusAttrmigstat == input.OsVolMigStatusAttrmigstat ||
                    (this.OsVolMigStatusAttrmigstat != null &&
                    this.OsVolMigStatusAttrmigstat.Equals(input.OsVolMigStatusAttrmigstat))
                ) && 
                (
                    this.OsVolMigStatusAttrnameId == input.OsVolMigStatusAttrnameId ||
                    (this.OsVolMigStatusAttrnameId != null &&
                    this.OsVolMigStatusAttrnameId.Equals(input.OsVolMigStatusAttrnameId))
                ) && 
                (
                    this.Shareable == input.Shareable ||
                    (this.Shareable != null &&
                    this.Shareable.Equals(input.Shareable))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.Multiattach == input.Multiattach ||
                    (this.Multiattach != null &&
                    this.Multiattach.Equals(input.Multiattach))
                ) && 
                (
                    this.DedicatedStorageId == input.DedicatedStorageId ||
                    (this.DedicatedStorageId != null &&
                    this.DedicatedStorageId.Equals(input.DedicatedStorageId))
                ) && 
                (
                    this.DedicatedStorageName == input.DedicatedStorageName ||
                    (this.DedicatedStorageName != null &&
                    this.DedicatedStorageName.Equals(input.DedicatedStorageName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Wwn == input.Wwn ||
                    (this.Wwn != null &&
                    this.Wwn.Equals(input.Wwn))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.OsVolHostAttrhost != null)
                    hashCode = hashCode * 59 + this.OsVolHostAttrhost.GetHashCode();
                if (this.SourceVolid != null)
                    hashCode = hashCode * 59 + this.SourceVolid.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.OsVolTenantAttrtenantId != null)
                    hashCode = hashCode * 59 + this.OsVolTenantAttrtenantId.GetHashCode();
                if (this.VolumeImageMetadata != null)
                    hashCode = hashCode * 59 + this.VolumeImageMetadata.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ConsistencygroupId != null)
                    hashCode = hashCode * 59 + this.ConsistencygroupId.GetHashCode();
                if (this.Bootable != null)
                    hashCode = hashCode * 59 + this.Bootable.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Encrypted != null)
                    hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.ReplicationStatus != null)
                    hashCode = hashCode * 59 + this.ReplicationStatus.GetHashCode();
                if (this.OsVolumeReplicationextendedStatus != null)
                    hashCode = hashCode * 59 + this.OsVolumeReplicationextendedStatus.GetHashCode();
                if (this.OsVolMigStatusAttrmigstat != null)
                    hashCode = hashCode * 59 + this.OsVolMigStatusAttrmigstat.GetHashCode();
                if (this.OsVolMigStatusAttrnameId != null)
                    hashCode = hashCode * 59 + this.OsVolMigStatusAttrnameId.GetHashCode();
                if (this.Shareable != null)
                    hashCode = hashCode * 59 + this.Shareable.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Multiattach != null)
                    hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.DedicatedStorageId != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.DedicatedStorageName != null)
                    hashCode = hashCode * 59 + this.DedicatedStorageName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Wwn != null)
                    hashCode = hashCode * 59 + this.Wwn.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
