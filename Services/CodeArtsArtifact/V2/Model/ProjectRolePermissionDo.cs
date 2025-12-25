using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectRolePermissionDo 
    {

        /// <summary>
        /// **参数解释**: ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**: 角色ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

        /// <summary>
        /// **参数解释**: DEVUC角色ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("devuc_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DevucRoleId { get; set; }

        /// <summary>
        /// **参数解释**: 项目ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**: 是否具有权限配置能力。 **取值范围**: - true：能够配置权限。 - false：不能配置权限。
        /// </summary>
        [JsonProperty("is_permission_config", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPermissionConfig { get; set; }

        /// <summary>
        /// **参数解释**: 能否更改软件包状态。 **取值范围**: - true：能够更改软件包状态。 - false：不能更改软件包状态。
        /// </summary>
        [JsonProperty("is_change_pkg_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsChangePkgStatus { get; set; }

        /// <summary>
        /// **参数解释**: 能否进行上传。 **取值范围**: - true：能够进行上传。 - false：不能上传。
        /// </summary>
        [JsonProperty("is_upload", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUpload { get; set; }

        /// <summary>
        /// **参数解释**: 能否删除和还原测试状态的软件包。 **取值范围**: - true：能够删除和还原测试状态的软件包。 - false：不能删除和还原测试状态的软件包。
        /// </summary>
        [JsonProperty("is_delete_restore_test_pkg", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleteRestoreTestPkg { get; set; }

        /// <summary>
        /// **参数解释**: 能否删除和还原生产状态的软件包。 **取值范围**: - true：能够删除和还原生产状态的软件包。 - false：不能删除和还原生产状态的软件包。
        /// </summary>
        [JsonProperty("is_delete_restore_prod_pkg", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleteRestoreProdPkg { get; set; }

        /// <summary>
        /// **参数解释**: 能否编辑测试状态的软件包。 **取值范围**: - true：能够编辑测试状态的软件包。 - false：不能编辑测试状态的软件包。
        /// </summary>
        [JsonProperty("is_edit_test_pkg", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEditTestPkg { get; set; }

        /// <summary>
        /// **参数解释**: 能否创建文件夹。 **取值范围**: - true：能够创建目录。 - false：不能创建目录。
        /// </summary>
        [JsonProperty("is_mkdir", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMkdir { get; set; }

        /// <summary>
        /// **参数解释**: 能否进行下载。 **取值范围**: - true：能够下载。 - false：不能下载。
        /// </summary>
        [JsonProperty("is_download", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDownload { get; set; }

        /// <summary>
        /// **参数解释**: 能否还原回收站。 **取值范围**: - true：能够在回收站还原所有。 - false：不能在回收站还原所有。
        /// </summary>
        [JsonProperty("is_restore_all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRestoreAll { get; set; }

        /// <summary>
        /// **参数解释**: 能否清空回收站。 **取值范围**: - true：能够清空回收站。 - false：不能清空回收站。
        /// </summary>
        [JsonProperty("is_empty", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// **参数解释**: 创建时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**: 更新时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**: 权限迁移状态。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("migrated_630", NullValueHandling = NullValueHandling.Ignore)]
        public int? Migrated630 { get; set; }

        /// <summary>
        /// **参数解释**: 区域。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**: 用户id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**: 角色。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public string Roles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectRolePermissionDo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  devucRoleId: ").Append(DevucRoleId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  isPermissionConfig: ").Append(IsPermissionConfig).Append("\n");
            sb.Append("  isChangePkgStatus: ").Append(IsChangePkgStatus).Append("\n");
            sb.Append("  isUpload: ").Append(IsUpload).Append("\n");
            sb.Append("  isDeleteRestoreTestPkg: ").Append(IsDeleteRestoreTestPkg).Append("\n");
            sb.Append("  isDeleteRestoreProdPkg: ").Append(IsDeleteRestoreProdPkg).Append("\n");
            sb.Append("  isEditTestPkg: ").Append(IsEditTestPkg).Append("\n");
            sb.Append("  isMkdir: ").Append(IsMkdir).Append("\n");
            sb.Append("  isDownload: ").Append(IsDownload).Append("\n");
            sb.Append("  isRestoreAll: ").Append(IsRestoreAll).Append("\n");
            sb.Append("  isEmpty: ").Append(IsEmpty).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  migrated630: ").Append(Migrated630).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectRolePermissionDo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectRolePermissionDo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.DevucRoleId != input.DevucRoleId || (this.DevucRoleId != null && !this.DevucRoleId.Equals(input.DevucRoleId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IsPermissionConfig != input.IsPermissionConfig || (this.IsPermissionConfig != null && !this.IsPermissionConfig.Equals(input.IsPermissionConfig))) return false;
            if (this.IsChangePkgStatus != input.IsChangePkgStatus || (this.IsChangePkgStatus != null && !this.IsChangePkgStatus.Equals(input.IsChangePkgStatus))) return false;
            if (this.IsUpload != input.IsUpload || (this.IsUpload != null && !this.IsUpload.Equals(input.IsUpload))) return false;
            if (this.IsDeleteRestoreTestPkg != input.IsDeleteRestoreTestPkg || (this.IsDeleteRestoreTestPkg != null && !this.IsDeleteRestoreTestPkg.Equals(input.IsDeleteRestoreTestPkg))) return false;
            if (this.IsDeleteRestoreProdPkg != input.IsDeleteRestoreProdPkg || (this.IsDeleteRestoreProdPkg != null && !this.IsDeleteRestoreProdPkg.Equals(input.IsDeleteRestoreProdPkg))) return false;
            if (this.IsEditTestPkg != input.IsEditTestPkg || (this.IsEditTestPkg != null && !this.IsEditTestPkg.Equals(input.IsEditTestPkg))) return false;
            if (this.IsMkdir != input.IsMkdir || (this.IsMkdir != null && !this.IsMkdir.Equals(input.IsMkdir))) return false;
            if (this.IsDownload != input.IsDownload || (this.IsDownload != null && !this.IsDownload.Equals(input.IsDownload))) return false;
            if (this.IsRestoreAll != input.IsRestoreAll || (this.IsRestoreAll != null && !this.IsRestoreAll.Equals(input.IsRestoreAll))) return false;
            if (this.IsEmpty != input.IsEmpty || (this.IsEmpty != null && !this.IsEmpty.Equals(input.IsEmpty))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Migrated630 != input.Migrated630 || (this.Migrated630 != null && !this.Migrated630.Equals(input.Migrated630))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Roles != input.Roles || (this.Roles != null && !this.Roles.Equals(input.Roles))) return false;

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
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.DevucRoleId != null) hashCode = hashCode * 59 + this.DevucRoleId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.IsPermissionConfig != null) hashCode = hashCode * 59 + this.IsPermissionConfig.GetHashCode();
                if (this.IsChangePkgStatus != null) hashCode = hashCode * 59 + this.IsChangePkgStatus.GetHashCode();
                if (this.IsUpload != null) hashCode = hashCode * 59 + this.IsUpload.GetHashCode();
                if (this.IsDeleteRestoreTestPkg != null) hashCode = hashCode * 59 + this.IsDeleteRestoreTestPkg.GetHashCode();
                if (this.IsDeleteRestoreProdPkg != null) hashCode = hashCode * 59 + this.IsDeleteRestoreProdPkg.GetHashCode();
                if (this.IsEditTestPkg != null) hashCode = hashCode * 59 + this.IsEditTestPkg.GetHashCode();
                if (this.IsMkdir != null) hashCode = hashCode * 59 + this.IsMkdir.GetHashCode();
                if (this.IsDownload != null) hashCode = hashCode * 59 + this.IsDownload.GetHashCode();
                if (this.IsRestoreAll != null) hashCode = hashCode * 59 + this.IsRestoreAll.GetHashCode();
                if (this.IsEmpty != null) hashCode = hashCode * 59 + this.IsEmpty.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Migrated630 != null) hashCode = hashCode * 59 + this.Migrated630.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }
    }
}
