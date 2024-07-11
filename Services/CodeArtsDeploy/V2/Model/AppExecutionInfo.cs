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
    /// 查询应用详情响应体
    /// </summary>
    public class AppExecutionInfo 
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
        /// 部署时间
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// 当前应用是否被禁用
        /// </summary>
        [JsonProperty("is_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisable { get; set; }

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
        /// 部署类型模式，包括deployTemplate、ansible、shell
        /// </summary>
        [JsonProperty("deploy_system", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploySystem { get; set; }

        /// <summary>
        /// 应用创建者用户id
        /// </summary>
        [JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 应用创建者租户id
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
        /// 最后一次部署时间
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// 部署结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 部署状态
        /// </summary>
        [JsonProperty("execution_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionState { get; set; }

        /// <summary>
        /// 部署记录序列号
        /// </summary>
        [JsonProperty("release_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// 部署者id
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// 部署者名称
        /// </summary>
        [JsonProperty("executor_nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorNickName { get; set; }

        /// <summary>
        /// 部署任务信息
        /// </summary>
        [JsonProperty("arrange_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskBaseResponseBody> ArrangeInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppExecutionInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  isDisable: ").Append(IsDisable).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  isCare: ").Append(IsCare).Append("\n");
            sb.Append("  canModify: ").Append(CanModify).Append("\n");
            sb.Append("  canDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  canView: ").Append(CanView).Append("\n");
            sb.Append("  canExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  canCopy: ").Append(CanCopy).Append("\n");
            sb.Append("  canManage: ").Append(CanManage).Append("\n");
            sb.Append("  canCreateEnv: ").Append(CanCreateEnv).Append("\n");
            sb.Append("  canDisable: ").Append(CanDisable).Append("\n");
            sb.Append("  deploySystem: ").Append(DeploySystem).Append("\n");
            sb.Append("  createUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  createTenantId: ").Append(CreateTenantId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  executionState: ").Append(ExecutionState).Append("\n");
            sb.Append("  releaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorNickName: ").Append(ExecutorNickName).Append("\n");
            sb.Append("  arrangeInfos: ").Append(ArrangeInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppExecutionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppExecutionInfo input)
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.IsDisable == input.IsDisable ||
                    (this.IsDisable != null &&
                    this.IsDisable.Equals(input.IsDisable))
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
                    this.DeploySystem == input.DeploySystem ||
                    (this.DeploySystem != null &&
                    this.DeploySystem.Equals(input.DeploySystem))
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
                    this.ExecutionTime == input.ExecutionTime ||
                    (this.ExecutionTime != null &&
                    this.ExecutionTime.Equals(input.ExecutionTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ExecutionState == input.ExecutionState ||
                    (this.ExecutionState != null &&
                    this.ExecutionState.Equals(input.ExecutionState))
                ) && 
                (
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
                ) && 
                (
                    this.ExecutorId == input.ExecutorId ||
                    (this.ExecutorId != null &&
                    this.ExecutorId.Equals(input.ExecutorId))
                ) && 
                (
                    this.ExecutorNickName == input.ExecutorNickName ||
                    (this.ExecutorNickName != null &&
                    this.ExecutorNickName.Equals(input.ExecutorNickName))
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.IsDisable != null)
                    hashCode = hashCode * 59 + this.IsDisable.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
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
                if (this.DeploySystem != null)
                    hashCode = hashCode * 59 + this.DeploySystem.GetHashCode();
                if (this.CreateUserId != null)
                    hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.CreateTenantId != null)
                    hashCode = hashCode * 59 + this.CreateTenantId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ExecutionTime != null)
                    hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExecutionState != null)
                    hashCode = hashCode * 59 + this.ExecutionState.GetHashCode();
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.ExecutorId != null)
                    hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorNickName != null)
                    hashCode = hashCode * 59 + this.ExecutorNickName.GetHashCode();
                if (this.ArrangeInfos != null)
                    hashCode = hashCode * 59 + this.ArrangeInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
