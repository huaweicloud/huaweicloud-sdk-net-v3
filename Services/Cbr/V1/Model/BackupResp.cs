using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BackupResp 
    {
        /// <summary>
        /// 备份状态 - available: 可用 - protecting: 保护中 - deleting: 删除中 - restoring: 恢复中 - error: 异常 - waiting_protect: 等待保护 - waiting_delete: 等待删除 - waiting_restore: 等待恢复
        /// </summary>
        /// <value>备份状态 - available: 可用 - protecting: 保护中 - deleting: 删除中 - restoring: 恢复中 - error: 异常 - waiting_protect: 等待保护 - waiting_delete: 等待删除 - waiting_restore: 等待恢复</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("available");

            /// <summary>
            /// Enum PROTECTING for value: protecting
            /// </summary>
            public static readonly StatusEnum PROTECTING = new StatusEnum("protecting");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            /// <summary>
            /// Enum RESTORING for value: restoring
            /// </summary>
            public static readonly StatusEnum RESTORING = new StatusEnum("restoring");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("error");

            /// <summary>
            /// Enum WAITING_PROTECT for value: waiting_protect
            /// </summary>
            public static readonly StatusEnum WAITING_PROTECT = new StatusEnum("waiting_protect");

            /// <summary>
            /// Enum WAITING_DELETE for value: waiting_delete
            /// </summary>
            public static readonly StatusEnum WAITING_DELETE = new StatusEnum("waiting_delete");

            /// <summary>
            /// Enum WAITING_RESTORE for value: waiting_restore
            /// </summary>
            public static readonly StatusEnum WAITING_RESTORE = new StatusEnum("waiting_restore");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "available", AVAILABLE },
                { "protecting", PROTECTING },
                { "deleting", DELETING },
                { "restoring", RESTORING },
                { "error", ERROR },
                { "waiting_protect", WAITING_PROTECT },
                { "waiting_delete", WAITING_DELETE },
                { "waiting_restore", WAITING_RESTORE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 还原点ID
        /// </summary>
        [JsonProperty("checkpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointId { get; set; }

        /// <summary>
        /// 创建时间，例如:\&quot;2020-02-05T10:38:34.209782\&quot;
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 备份描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 过期时间，例如:\&quot;2020-02-05T10:38:34.209782\&quot;
        /// </summary>
        [JsonProperty("expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiredAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public BackupExtendInfo ExtendInfo { get; set; }

        /// <summary>
        /// 备份ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// [备份类型。取值为backup和replication。](tag:hws,hws_hk,ocb) [备份类型。取值为backup。](tag:g42,hk_g42,sbc,dt,fcs_vm,ctc,tm,tlf,cmcc,hcso_dt)
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 父备份ID
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 备份时间
        /// </summary>
        [JsonProperty("protected_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ProtectedAt { get; set; }

        /// <summary>
        /// 资源可用区
        /// </summary>
        [JsonProperty("resource_az", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceAz { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源大小，单位为GB
        /// </summary>
        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// [资源类型: OS::Nova::Server, OS::Cinder::Volume, OS::Ironic::BareMetalServer, OS::Native::Server, OS::Sfs::Turbo, OS::Workspace::DesktopV2](tag:hws,hws_hk) [资源类型: OS::Nova::Server, OS::Cinder::Volume, OS::Sfs::Turbo](tag:hk_g42,sbc,dt) [资源类型: OS::Nova::Server, OS::Cinder::Volume, OS::Ironic::BareMetalServer, OS::Sfs::Turbo](tag:fcs_vm,ctc,ocb,tm) [资源类型: OS::Nova::Server, OS::Cinder::Volume](tag:tlf,cmcc,hcso_dt) [资源类型: OS::Nova::Server, OS::Cinder::Volume, OS::Sfs::Turbo, OS::Workspace::DesktopV2](tag:g42)
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 备份状态 - available: 可用 - protecting: 保护中 - deleting: 删除中 - restoring: 恢复中 - error: 异常 - waiting_protect: 等待保护 - waiting_delete: 等待删除 - waiting_restore: 等待恢复
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 更新时间，例如:\&quot;2020-02-05T10:38:34.209782\&quot;
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 存储库ID
        /// </summary>
        [JsonProperty("vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VaultId { get; set; }

        /// <summary>
        /// 复制记录
        /// </summary>
        [JsonProperty("replication_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplicationRecordGet> ReplicationRecords { get; set; }

        /// <summary>
        /// 企业项目id,默认为‘0’。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 备份提供商ID，用于区分备份对象。当前取值包含： [0daac4c5-6707-4851-97ba-169e36266b66，该值代表备份对象为云服务器。d1603440-187d-4516-af25-121250c7cc97，该值代表备份对象为云硬盘。3f3c3220-245c-4805-b811-758870015881， 该值代表备份对象为SFS Turbo。a13639de-00be-4e94-af30-26912d75e4a2，该值代表备份对象为混合云VMware备份。](tag:hws,hws_hk) [0daac4c5-6707-4851-97ba-169e36266b66，该值代表备份对象为云服务器。d1603440-187d-4516-af25-121250c7cc97，该值代表备份对象为云硬盘。3f3c3220-245c-4805-b811-758870015881，该值代表备份对象为SFS Turbo。](tag:ocb,tlf,sbc,fcs_vm,g42,tm,dt,cmcc) [0daac4c5-6707-4851-97ba-169e36266b66，该值代表备份对象为云服务器。d1603440-187d-4516-af25-121250c7cc97，该值代表备份对象为云硬盘。3f3c3220-245c-4805-b811-758870015881，该值代表备份对象为SFS Turbo。86a80900-71bf-4961-956a-d52df944f84a，该值代表备份对象为Workspace。](tag:ctc) [0daac4c5-6707-4851-97ba-169e36266b66，该值代表备份对象为云服务器。d1603440-187d-4516-af25-121250c7cc97，该值代表备份对象为云硬盘。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 子副本列表
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<BackupResp> Children { get; set; }

        /// <summary>
        /// 是否是增备
        /// </summary>
        [JsonProperty("incremental", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incremental { get; set; }

        /// <summary>
        /// 备份副本快照类型
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int? Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupResp {\n");
            sb.Append("  checkpointId: ").Append(CheckpointId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  expiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protectedAt: ").Append(ProtectedAt).Append("\n");
            sb.Append("  resourceAz: ").Append(ResourceAz).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  vaultId: ").Append(VaultId).Append("\n");
            sb.Append("  replicationRecords: ").Append(ReplicationRecords).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  incremental: ").Append(Incremental).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupResp input)
        {
            if (input == null) return false;
            if (this.CheckpointId != input.CheckpointId || (this.CheckpointId != null && !this.CheckpointId.Equals(input.CheckpointId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ExpiredAt != input.ExpiredAt || (this.ExpiredAt != null && !this.ExpiredAt.Equals(input.ExpiredAt))) return false;
            if (this.ExtendInfo != input.ExtendInfo || (this.ExtendInfo != null && !this.ExtendInfo.Equals(input.ExtendInfo))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProtectedAt != input.ProtectedAt || (this.ProtectedAt != null && !this.ProtectedAt.Equals(input.ProtectedAt))) return false;
            if (this.ResourceAz != input.ResourceAz || (this.ResourceAz != null && !this.ResourceAz.Equals(input.ResourceAz))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceSize != input.ResourceSize || (this.ResourceSize != null && !this.ResourceSize.Equals(input.ResourceSize))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Status != input.Status) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.VaultId != input.VaultId || (this.VaultId != null && !this.VaultId.Equals(input.VaultId))) return false;
            if (this.ReplicationRecords != input.ReplicationRecords || (this.ReplicationRecords != null && input.ReplicationRecords != null && !this.ReplicationRecords.SequenceEqual(input.ReplicationRecords))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.Incremental != input.Incremental || (this.Incremental != null && !this.Incremental.Equals(input.Incremental))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.CheckpointId != null) hashCode = hashCode * 59 + this.CheckpointId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExpiredAt != null) hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                if (this.ExtendInfo != null) hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProtectedAt != null) hashCode = hashCode * 59 + this.ProtectedAt.GetHashCode();
                if (this.ResourceAz != null) hashCode = hashCode * 59 + this.ResourceAz.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceSize != null) hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VaultId != null) hashCode = hashCode * 59 + this.VaultId.GetHashCode();
                if (this.ReplicationRecords != null) hashCode = hashCode * 59 + this.ReplicationRecords.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Incremental != null) hashCode = hashCode * 59 + this.Incremental.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
