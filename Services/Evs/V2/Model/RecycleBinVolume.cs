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
    /// 回收站云硬盘详情
    /// </summary>
    public class RecycleBinVolume 
    {

        /// <summary>
        /// **参数解释** 云硬盘ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘名称。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘描述。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘状态，具体请参见[云硬盘状态](evs_04_0040.xml)。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘的挂载信息。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘是否共享。 **取值范围** - true：表示为共享云硬盘。 - false：表示为普通云硬盘。
        /// </summary>
        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘大小，单位为GiB。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘的metadata信息 ，调用方可以添加或删除metadata信息。 **取值范围** 当前部分key在EVS服务中有业务场景含义，这部分key的描述如下： - __system__cmkid    metadata中的加密cmkid字段，与__system__encrypted配合表示需要加密，cmkid长度固定为36个字节。    请求获取密钥ID的方法请参考：\&quot;[查询密钥列表](https://support.huaweicloud.com/api-dew/ListKeys.html)\&quot;。      - __system__encrypted    metadata中的表示加密功能的字段，0代表不加密，1代表加密。    不指定该字段时，云硬盘的加密属性与数据源保持一致，如果不是从数据源创建的场景，则默认不加密。   - hw:passthrough    - true表示云硬盘的设备类型为SCSI类型，即允许ECS操作系统直接访问底层存储介质。支持SCSI锁命令。    - false表示云硬盘的设备类型为VBD (虚拟块存储设备 , Virtual Block Device)类型，即为默认类型，VBD只能支持简单的SCSI读写命令。    - 该字段不存在时，云硬盘默认为VBD类型。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘是否为启动盘。 **取值范围** - true：表示为启动云硬盘。 - false：表示为非启动云硬盘。
        /// </summary>
        [JsonProperty("bootable", NullValueHandling = NullValueHandling.Ignore)]
        public string Bootable { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘标签。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘所属可用区。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘创建时间。 **取值范围** 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘所属的服务类型。 **取值范围** - EVS：云硬盘。 - DSS：专属分布式存储服务。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘信息被更新的时间。 **取值范围** 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘类型。 **取值范围** 目前支持\&quot;SATA\&quot;，\&quot;SAS\&quot;，\&quot;GPSSD\&quot;，\&quot;SSD\&quot;，\&quot;ESSD\&quot;，\&quot;GPSSD2\&quot;，\&quot;ESSD2\&quot;七种。   - \&quot;SATA\&quot;为普通IO云硬盘(已售罄) - \&quot;SAS\&quot;为高IO云硬盘 - \&quot;GPSSD\&quot;为通用型SSD云硬盘 - \&quot;SSD\&quot;为超高IO云硬盘 - \&quot;ESSD\&quot;为极速型SSD云硬盘 - \&quot;GPSSD2\&quot;为通用型SSD V2云硬盘 - \&quot;ESSD2\&quot;为极速型SSD V2云硬盘
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// **参数解释** 企业项目ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释** 预计到期清理的时间。 **取值范围** 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("plan_delete_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanDeleteAt { get; set; }

        /// <summary>
        /// **参数解释** 放入回收站的时间。 **取值范围** 时间格式：UTC YYYY-MM-DDTHH:MM:SS.XXXXXX
        /// </summary>
        [JsonProperty("pre_deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public string PreDeletedAt { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘所属的专属存储池ID。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("dedicated_storage_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageId { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘所属的专属存储池的名称。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("dedicated_storage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedStorageName { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘镜像的元数据。 关于“volume_image_metadata”字段的详细说明，具体请参见：\&quot;[查询镜像详情](https://support.huaweicloud.com/api-ims/ims_03_0703.html)\&quot;。  **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("volume_image_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> VolumeImageMetadata { get; set; }

        /// <summary>
        /// **参数解释** 云硬盘的唯一标识。 **取值范围** 不涉及。
        /// </summary>
        [JsonProperty("wwn", NullValueHandling = NullValueHandling.Ignore)]
        public string Wwn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleBinVolume {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  attachments: ").Append(Attachments).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  bootable: ").Append(Bootable).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  planDeleteAt: ").Append(PlanDeleteAt).Append("\n");
            sb.Append("  preDeletedAt: ").Append(PreDeletedAt).Append("\n");
            sb.Append("  dedicatedStorageId: ").Append(DedicatedStorageId).Append("\n");
            sb.Append("  dedicatedStorageName: ").Append(DedicatedStorageName).Append("\n");
            sb.Append("  volumeImageMetadata: ").Append(VolumeImageMetadata).Append("\n");
            sb.Append("  wwn: ").Append(Wwn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleBinVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleBinVolume input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Attachments != input.Attachments || (this.Attachments != null && input.Attachments != null && !this.Attachments.SequenceEqual(input.Attachments))) return false;
            if (this.Multiattach != input.Multiattach || (this.Multiattach != null && !this.Multiattach.Equals(input.Multiattach))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.Bootable != input.Bootable || (this.Bootable != null && !this.Bootable.Equals(input.Bootable))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.PlanDeleteAt != input.PlanDeleteAt || (this.PlanDeleteAt != null && !this.PlanDeleteAt.Equals(input.PlanDeleteAt))) return false;
            if (this.PreDeletedAt != input.PreDeletedAt || (this.PreDeletedAt != null && !this.PreDeletedAt.Equals(input.PreDeletedAt))) return false;
            if (this.DedicatedStorageId != input.DedicatedStorageId || (this.DedicatedStorageId != null && !this.DedicatedStorageId.Equals(input.DedicatedStorageId))) return false;
            if (this.DedicatedStorageName != input.DedicatedStorageName || (this.DedicatedStorageName != null && !this.DedicatedStorageName.Equals(input.DedicatedStorageName))) return false;
            if (this.VolumeImageMetadata != input.VolumeImageMetadata || (this.VolumeImageMetadata != null && input.VolumeImageMetadata != null && !this.VolumeImageMetadata.SequenceEqual(input.VolumeImageMetadata))) return false;
            if (this.Wwn != input.Wwn || (this.Wwn != null && !this.Wwn.Equals(input.Wwn))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Attachments != null) hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Multiattach != null) hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Bootable != null) hashCode = hashCode * 59 + this.Bootable.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PlanDeleteAt != null) hashCode = hashCode * 59 + this.PlanDeleteAt.GetHashCode();
                if (this.PreDeletedAt != null) hashCode = hashCode * 59 + this.PreDeletedAt.GetHashCode();
                if (this.DedicatedStorageId != null) hashCode = hashCode * 59 + this.DedicatedStorageId.GetHashCode();
                if (this.DedicatedStorageName != null) hashCode = hashCode * 59 + this.DedicatedStorageName.GetHashCode();
                if (this.VolumeImageMetadata != null) hashCode = hashCode * 59 + this.VolumeImageMetadata.GetHashCode();
                if (this.Wwn != null) hashCode = hashCode * 59 + this.Wwn.GetHashCode();
                return hashCode;
            }
        }
    }
}
