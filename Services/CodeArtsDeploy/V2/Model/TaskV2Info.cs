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
    /// 部署任务详情信息
    /// </summary>
    public class TaskV2Info 
    {

        /// <summary>
        /// 部署任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 部署任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 部署任务状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 部署任务所属人
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 部署步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Step> Steps { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 部署类型模式，包括deployTemplate、ansible、shell
        /// </summary>
        [JsonProperty("deploy_system", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploySystem { get; set; }

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
        /// 角色id
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

        /// <summary>
        /// 是否为默认角色
        /// </summary>
        [JsonProperty("is_defaut_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefautPermission { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 应用创建者昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 应用创建者用户id
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 应用创建者租户id
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 应用创建者租户名
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

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
        /// 是否有禁用应用的权限
        /// </summary>
        [JsonProperty("can_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDisable { get; set; }

        /// <summary>
        /// 应用组件列表
        /// </summary>
        [JsonProperty("app_component_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppComponentDao> AppComponentList { get; set; }

        /// <summary>
        /// 部署记录序列号
        /// </summary>
        [JsonProperty("release_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// 部署任务所属应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 当前应用是否被禁用
        /// </summary>
        [JsonProperty("is_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskV2Info {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  deploySystem: ").Append(DeploySystem).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  isDefautPermission: ").Append(IsDefautPermission).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  isCare: ").Append(IsCare).Append("\n");
            sb.Append("  canModify: ").Append(CanModify).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canCreateEnv: ").Append(CanCreateEnv).Append("\n");
            sb.Append("  canDisable: ").Append(CanDisable).Append("\n");
            sb.Append("  appComponentList: ").Append(AppComponentList).Append("\n");
            sb.Append("  releaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  isDisable: ").Append(IsDisable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskV2Info);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskV2Info input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                    this.DeploySystem == input.DeploySystem ||
                    (this.DeploySystem != null &&
                    this.DeploySystem.Equals(input.DeploySystem))
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
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.IsDefautPermission == input.IsDefautPermission ||
                    (this.IsDefautPermission != null &&
                    this.IsDefautPermission.Equals(input.IsDefautPermission))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.TenantName == input.TenantName ||
                    (this.TenantName != null &&
                    this.TenantName.Equals(input.TenantName))
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
                    this.CanDisable == input.CanDisable ||
                    (this.CanDisable != null &&
                    this.CanDisable.Equals(input.CanDisable))
                ) && 
                (
                    this.AppComponentList == input.AppComponentList ||
                    this.AppComponentList != null &&
                    input.AppComponentList != null &&
                    this.AppComponentList.SequenceEqual(input.AppComponentList)
                ) && 
                (
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.IsDisable == input.IsDisable ||
                    (this.IsDisable != null &&
                    this.IsDisable.Equals(input.IsDisable))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Steps != null)
                    hashCode = hashCode * 59 + this.Steps.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.DeploySystem != null)
                    hashCode = hashCode * 59 + this.DeploySystem.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.IsDefautPermission != null)
                    hashCode = hashCode * 59 + this.IsDefautPermission.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
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
                if (this.CanDisable != null)
                    hashCode = hashCode * 59 + this.CanDisable.GetHashCode();
                if (this.AppComponentList != null)
                    hashCode = hashCode * 59 + this.AppComponentList.GetHashCode();
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.IsDisable != null)
                    hashCode = hashCode * 59 + this.IsDisable.GetHashCode();
                return hashCode;
            }
        }
    }
}
