using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 应用详情信息
    /// </summary>
    public class AppDetailInfo 
    {

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用所属区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 创建方式
        /// </summary>
        [JsonProperty("create_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateType { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// slave集群id，默认为null时使用默认slave集群，用户自定义slave时为slave集群id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 当前用户是否已收藏
        /// </summary>
        [JsonProperty("is_care", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCare { get; set; }

        /// <summary>
        /// 是否有编辑权限
        /// </summary>
        [JsonProperty("can_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanModify { get; set; }

        /// <summary>
        /// 是否有删除的权限
        /// </summary>
        [JsonProperty("can_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// 是否有查看权限
        /// </summary>
        [JsonProperty("can_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanView { get; set; }

        /// <summary>
        /// 是否有部署权限
        /// </summary>
        [JsonProperty("can_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanExecute { get; set; }

        /// <summary>
        /// 是否有复制权限
        /// </summary>
        [JsonProperty("can_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCopy { get; set; }

        /// <summary>
        /// 是否有编辑应用权限矩阵的权限
        /// </summary>
        [JsonProperty("can_manage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanManage { get; set; }

        /// <summary>
        /// 是否有创建环境的权限
        /// </summary>
        [JsonProperty("can_create_env", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanCreateEnv { get; set; }

        /// <summary>
        /// 应用所属人租户ID
        /// </summary>
        [JsonProperty("owner_tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerTenantId { get; set; }

        /// <summary>
        /// 应用创建者用户名
        /// </summary>
        [JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 应用创建人租户ID
        /// </summary>
        [JsonProperty("create_tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTenantId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 权限等级
        /// </summary>
        [JsonProperty("permission_level", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionLevel { get; set; }

        /// <summary>
        /// 部署任务信息
        /// </summary>
        [JsonProperty("arrange_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskV2Info> ArrangeInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppDetailInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createType: ").Append(CreateType).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  isCare: ").Append(IsCare).Append("\n");
            sb.Append("  canModify: ").Append(CanModify).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canCreateEnv: ").Append(CanCreateEnv).Append("\n");
            sb.Append("  ownerTenantId: ").Append(OwnerTenantId).Append("\n");
            sb.Append("  createUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  createTenantId: ").Append(CreateTenantId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  permissionLevel: ").Append(PermissionLevel).Append("\n");
            sb.Append("  arrangeInfos: ").Append(ArrangeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppDetailInfo input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreateType == input.CreateType ||
                    (this.CreateType != null &&
                    this.CreateType.Equals(input.CreateType))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.SlaveClusterId == input.SlaveClusterId ||
                    (this.SlaveClusterId != null &&
                    this.SlaveClusterId.Equals(input.SlaveClusterId))
                ) && 
                (
                    this.IsCare == input.IsCare ||
                    (this.IsCare != null &&
                    this.IsCare.Equals(input.IsCare))
                ) && 
                (
                    this.CanModify == input.CanModify ||
                    (this.CanModify != null &&
                    this.CanModify.Equals(input.CanModify))
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.CanView == input.CanView ||
                    (this.CanView != null &&
                    this.CanView.Equals(input.CanView))
                ) && 
                (
                    this.CanExecute == input.CanExecute ||
                    (this.CanExecute != null &&
                    this.CanExecute.Equals(input.CanExecute))
                ) && 
                (
                    this.CanCopy == input.CanCopy ||
                    (this.CanCopy != null &&
                    this.CanCopy.Equals(input.CanCopy))
                ) && 
                (
                    this.CanManage == input.CanManage ||
                    (this.CanManage != null &&
                    this.CanManage.Equals(input.CanManage))
                ) && 
                (
                    this.CanCreateEnv == input.CanCreateEnv ||
                    (this.CanCreateEnv != null &&
                    this.CanCreateEnv.Equals(input.CanCreateEnv))
                ) && 
                (
                    this.OwnerTenantId == input.OwnerTenantId ||
                    (this.OwnerTenantId != null &&
                    this.OwnerTenantId.Equals(input.OwnerTenantId))
                ) && 
                (
                    this.CreateUserId == input.CreateUserId ||
                    (this.CreateUserId != null &&
                    this.CreateUserId.Equals(input.CreateUserId))
                ) && 
                (
                    this.CreateTenantId == input.CreateTenantId ||
                    (this.CreateTenantId != null &&
                    this.CreateTenantId.Equals(input.CreateTenantId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.PermissionLevel == input.PermissionLevel ||
                    (this.PermissionLevel != null &&
                    this.PermissionLevel.Equals(input.PermissionLevel))
                ) && 
                (
                    this.ArrangeInfos == input.ArrangeInfos ||
                    this.ArrangeInfos != null &&
                    input.ArrangeInfos != null &&
                    this.ArrangeInfos.SequenceEqual(input.ArrangeInfos)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateType != null)
                    hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.SlaveClusterId != null)
                    hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.IsCare != null)
                    hashCode = hashCode * 59 + this.IsCare.GetHashCode();
                if (this.CanModify != null)
                    hashCode = hashCode * 59 + this.CanModify.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanView != null)
                    hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanExecute != null)
                    hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanCopy != null)
                    hashCode = hashCode * 59 + this.CanCopy.GetHashCode();
                if (this.CanManage != null)
                    hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CanCreateEnv != null)
                    hashCode = hashCode * 59 + this.CanCreateEnv.GetHashCode();
                if (this.OwnerTenantId != null)
                    hashCode = hashCode * 59 + this.OwnerTenantId.GetHashCode();
                if (this.CreateUserId != null)
                    hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.CreateTenantId != null)
                    hashCode = hashCode * 59 + this.CreateTenantId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.PermissionLevel != null)
                    hashCode = hashCode * 59 + this.PermissionLevel.GetHashCode();
                if (this.ArrangeInfos != null)
                    hashCode = hashCode * 59 + this.ArrangeInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
