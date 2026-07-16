using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowClusterResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 逻辑资源池ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("logic_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicClusterId { get; set; }

        /// <summary>
        /// **参数解释**：资源池状态。 **取值范围**：枚举类型，取值如下： - PENDING：等待中。 - INITIALIZING：初始化中。 - INITIALIZE_FAILED：初始化失败。 - ACTIVE：可用。 - DELETING：删除中。 - DELETED：已删除。 - DELETE_FAILED：删除失败。 - MIGRATING：迁移中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：资源池ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释**：资源池类型。  **取值范围**：枚举类型，取值如下： - MANAGED：公共池。 - DEDICATED：专属池。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：资源类别。 **取值范围**：枚举类型，取值如下： - GPU - CPU - ASCEND
        /// </summary>
        [JsonProperty("resource_categories", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceCategories { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。获取方法请参见[[查询工作空间列表](ListWorkspace.xml)](tag:hc,hk)。未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：实例创建的时间，UTC毫秒。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// **参数解释**：实例最后更新的时间，UTC毫秒。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// **参数解释**：用户项目ID，获取方法请参见[获取项目ID和名称](modelarts_03_0147.xml)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：账号ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**：资源池规格。
        /// </summary>
        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Flavor> Flavors { get; set; }

        /// <summary>
        /// **参数解释**：资源池是否允许实例以root启动。
        /// </summary>
        [JsonProperty("is_allow_root", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAllowRoot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterResponse {\n");
            sb.Append("  logicClusterId: ").Append(LogicClusterId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  resourceCategories: ").Append(ResourceCategories).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("  isAllowRoot: ").Append(IsAllowRoot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterResponse input)
        {
            if (input == null) return false;
            if (this.LogicClusterId != input.LogicClusterId || (this.LogicClusterId != null && !this.LogicClusterId.Equals(input.LogicClusterId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ResourceCategories != input.ResourceCategories || (this.ResourceCategories != null && !this.ResourceCategories.Equals(input.ResourceCategories))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Flavors != input.Flavors || (this.Flavors != null && input.Flavors != null && !this.Flavors.SequenceEqual(input.Flavors))) return false;
            if (this.IsAllowRoot != input.IsAllowRoot || (this.IsAllowRoot != null && !this.IsAllowRoot.Equals(input.IsAllowRoot))) return false;

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
                if (this.LogicClusterId != null) hashCode = hashCode * 59 + this.LogicClusterId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ResourceCategories != null) hashCode = hashCode * 59 + this.ResourceCategories.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Flavors != null) hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                if (this.IsAllowRoot != null) hashCode = hashCode * 59 + this.IsAllowRoot.GetHashCode();
                return hashCode;
            }
        }
    }
}
