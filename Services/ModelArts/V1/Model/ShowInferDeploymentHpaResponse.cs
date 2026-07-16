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
    public class ShowInferDeploymentHpaResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 自动扩缩容策略ID **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容策略名称 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容策略绑定的目标ID **取值范围：** 实例组ID
        /// </summary>
        [JsonProperty("target_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容策略绑定的目标类型。 **取值范围：** - GROUP：实例组
        /// </summary>
        [JsonProperty("target_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResourceType { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容最小实例数。 **取值范围：** 1-128
        /// </summary>
        [JsonProperty("min_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容最大实例数。 **取值范围：** 1-128
        /// </summary>
        [JsonProperty("max_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// 参数解释：** 自动扩缩容策略状态。 **取值范围：** - INACTIVE：不启用 - ACTIVE：配置成功 - DELETED：已删除
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 工作空间ID。 **取值范围：** - 0：默认空间ID - 由数字和小写字母组成的32位字符：其他空间ID，可参考[工作空间创建](CreateWorkspace.xml)
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则列表
        /// </summary>
        [JsonProperty("hpa_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<HpaRule> HpaRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInferDeploymentHpaResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  targetResourceId: ").Append(TargetResourceId).Append("\n");
            sb.Append("  targetResourceType: ").Append(TargetResourceType).Append("\n");
            sb.Append("  minReplicas: ").Append(MinReplicas).Append("\n");
            sb.Append("  maxReplicas: ").Append(MaxReplicas).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  hpaRules: ").Append(HpaRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInferDeploymentHpaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInferDeploymentHpaResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TargetResourceId != input.TargetResourceId || (this.TargetResourceId != null && !this.TargetResourceId.Equals(input.TargetResourceId))) return false;
            if (this.TargetResourceType != input.TargetResourceType || (this.TargetResourceType != null && !this.TargetResourceType.Equals(input.TargetResourceType))) return false;
            if (this.MinReplicas != input.MinReplicas || (this.MinReplicas != null && !this.MinReplicas.Equals(input.MinReplicas))) return false;
            if (this.MaxReplicas != input.MaxReplicas || (this.MaxReplicas != null && !this.MaxReplicas.Equals(input.MaxReplicas))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.HpaRules != input.HpaRules || (this.HpaRules != null && input.HpaRules != null && !this.HpaRules.SequenceEqual(input.HpaRules))) return false;

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
                if (this.TargetResourceId != null) hashCode = hashCode * 59 + this.TargetResourceId.GetHashCode();
                if (this.TargetResourceType != null) hashCode = hashCode * 59 + this.TargetResourceType.GetHashCode();
                if (this.MinReplicas != null) hashCode = hashCode * 59 + this.MinReplicas.GetHashCode();
                if (this.MaxReplicas != null) hashCode = hashCode * 59 + this.MaxReplicas.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.HpaRules != null) hashCode = hashCode * 59 + this.HpaRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
