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
    public class TaskInfo 
    {
        /// <summary>
        /// 应用状态，Draft表示草稿状态，Available表示可用状态
        /// </summary>
        /// <value>应用状态，Draft表示草稿状态，Available表示可用状态</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: Available
            /// </summary>
            public static readonly StateEnum AVAILABLE = new StateEnum("Available");

            /// <summary>
            /// Enum DRAFT for value: Draft
            /// </summary>
            public static readonly StateEnum DRAFT = new StateEnum("Draft");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "Available", AVAILABLE },
                { "Draft", DRAFT },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部署任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// 部署类型模式，包括deployTemplate，ansible，shell
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
        /// 应用状态，Draft表示草稿状态，Available表示可用状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 最后一次部署时间
        /// </summary>
        [JsonProperty("execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否使用默认权限矩阵
        /// </summary>
        [JsonProperty("is_defaut_permission", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefautPermission { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 应用创建者用户名
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

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
        /// 是否有禁用应用的权限
        /// </summary>
        [JsonProperty("can_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDisable { get; set; }

        /// <summary>
        /// 应用和AOM应用组件对应关系
        /// </summary>
        [JsonProperty("app_component_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppComponentDao> AppComponentList { get; set; }

        /// <summary>
        /// 角色id,0：应用创建者，-1：项目创建者，3：项目经理，4：开发人员，5：测试经理，6：测试人员，7：参与者，8：浏览者
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

        /// <summary>
        /// 部署任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 部署记录序列号
        /// </summary>
        [JsonProperty("release_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// 当前应用是否被禁用
        /// </summary>
        [JsonProperty("is_disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisable { get; set; }

        /// <summary>
        /// 部署时间
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// 部署状态
        /// </summary>
        [JsonProperty("execution_state", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionState { get; set; }

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
        /// 部署步骤
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Step> Steps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskInfo {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  deploySystem: ").Append(DeploySystem).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  executionTime: ").Append(ExecutionTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isDefautPermission: ").Append(IsDefautPermission).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
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
            sb.Append("  canDisable: ").Append(CanDisable).Append("\n");
            sb.Append("  appComponentList: ").Append(AppComponentList).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  releaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  isDisable: ").Append(IsDisable).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  executionState: ").Append(ExecutionState).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorNickName: ").Append(ExecutorNickName).Append("\n");
            sb.Append("  steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskInfo input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.DeploySystem != input.DeploySystem || (this.DeploySystem != null && !this.DeploySystem.Equals(input.DeploySystem))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.State != input.State) return false;
            if (this.ExecutionTime != input.ExecutionTime || (this.ExecutionTime != null && !this.ExecutionTime.Equals(input.ExecutionTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsDefautPermission != input.IsDefautPermission || (this.IsDefautPermission != null && !this.IsDefautPermission.Equals(input.IsDefautPermission))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.SlaveClusterId != input.SlaveClusterId || (this.SlaveClusterId != null && !this.SlaveClusterId.Equals(input.SlaveClusterId))) return false;
            if (this.IsCare != input.IsCare || (this.IsCare != null && !this.IsCare.Equals(input.IsCare))) return false;
            if (this.CanModify != input.CanModify || (this.CanModify != null && !this.CanModify.Equals(input.CanModify))) return false;
            if (this.CanDelete != input.CanDelete || (this.CanDelete != null && !this.CanDelete.Equals(input.CanDelete))) return false;
            if (this.CanView != input.CanView || (this.CanView != null && !this.CanView.Equals(input.CanView))) return false;
            if (this.CanExecute != input.CanExecute || (this.CanExecute != null && !this.CanExecute.Equals(input.CanExecute))) return false;
            if (this.CanCopy != input.CanCopy || (this.CanCopy != null && !this.CanCopy.Equals(input.CanCopy))) return false;
            if (this.CanManage != input.CanManage || (this.CanManage != null && !this.CanManage.Equals(input.CanManage))) return false;
            if (this.CanDisable != input.CanDisable || (this.CanDisable != null && !this.CanDisable.Equals(input.CanDisable))) return false;
            if (this.AppComponentList != input.AppComponentList || (this.AppComponentList != null && input.AppComponentList != null && !this.AppComponentList.SequenceEqual(input.AppComponentList))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ReleaseId != input.ReleaseId || (this.ReleaseId != null && !this.ReleaseId.Equals(input.ReleaseId))) return false;
            if (this.IsDisable != input.IsDisable || (this.IsDisable != null && !this.IsDisable.Equals(input.IsDisable))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.ExecutionState != input.ExecutionState || (this.ExecutionState != null && !this.ExecutionState.Equals(input.ExecutionState))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorNickName != input.ExecutorNickName || (this.ExecutorNickName != null && !this.ExecutorNickName.Equals(input.ExecutorNickName))) return false;
            if (this.Steps != input.Steps || (this.Steps != null && input.Steps != null && !this.Steps.SequenceEqual(input.Steps))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.DeploySystem != null) hashCode = hashCode * 59 + this.DeploySystem.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ExecutionTime != null) hashCode = hashCode * 59 + this.ExecutionTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsDefautPermission != null) hashCode = hashCode * 59 + this.IsDefautPermission.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.SlaveClusterId != null) hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.IsCare != null) hashCode = hashCode * 59 + this.IsCare.GetHashCode();
                if (this.CanModify != null) hashCode = hashCode * 59 + this.CanModify.GetHashCode();
                if (this.CanDelete != null) hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.CanView != null) hashCode = hashCode * 59 + this.CanView.GetHashCode();
                if (this.CanExecute != null) hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanCopy != null) hashCode = hashCode * 59 + this.CanCopy.GetHashCode();
                if (this.CanManage != null) hashCode = hashCode * 59 + this.CanManage.GetHashCode();
                if (this.CanDisable != null) hashCode = hashCode * 59 + this.CanDisable.GetHashCode();
                if (this.AppComponentList != null) hashCode = hashCode * 59 + this.AppComponentList.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ReleaseId != null) hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.IsDisable != null) hashCode = hashCode * 59 + this.IsDisable.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ExecutionState != null) hashCode = hashCode * 59 + this.ExecutionState.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorNickName != null) hashCode = hashCode * 59 + this.ExecutorNickName.GetHashCode();
                if (this.Steps != null) hashCode = hashCode * 59 + this.Steps.GetHashCode();
                return hashCode;
            }
        }
    }
}
