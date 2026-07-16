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
    public class ShowInferHraResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** hra策略ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 工作空间ID。未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释：** HRA规则列表。
        /// </summary>
        [JsonProperty("hra_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<HraRuleResponse> HraRules { get; set; }

        /// <summary>
        /// **参数解释：** 用户控制的启用/禁用开关。 **取值范围：** true表示禁用，false表示启用 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// **参数解释：** 策略状态。 **取值范围：** - CREATING 创建。 - ACTIVE 可用。 - INACTIVE 不可用。 - DELETED 已删除。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("policy_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// **参数解释：** 最小副本数，由于当前版本不会进行实质扩缩，因此该配置值无效。 **取值范围：** 1~128。
        /// </summary>
        [JsonProperty("min_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 最大副本数，由于当前版本不会进行实质扩缩，因此该配置值无效。 **取值范围：** 1~128。
        /// </summary>
        [JsonProperty("max_replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReplicas { get; set; }

        /// <summary>
        /// **参数解释：** 扩缩容时间窗，由于当前版本不会进行实质扩缩，因此该配置值无效。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("scale_window", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScaleWindow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInferHraResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  hraRules: ").Append(HraRules).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  policyStatus: ").Append(PolicyStatus).Append("\n");
            sb.Append("  minReplicas: ").Append(MinReplicas).Append("\n");
            sb.Append("  maxReplicas: ").Append(MaxReplicas).Append("\n");
            sb.Append("  scaleWindow: ").Append(ScaleWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInferHraResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInferHraResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.HraRules != input.HraRules || (this.HraRules != null && input.HraRules != null && !this.HraRules.SequenceEqual(input.HraRules))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.PolicyStatus != input.PolicyStatus || (this.PolicyStatus != null && !this.PolicyStatus.Equals(input.PolicyStatus))) return false;
            if (this.MinReplicas != input.MinReplicas || (this.MinReplicas != null && !this.MinReplicas.Equals(input.MinReplicas))) return false;
            if (this.MaxReplicas != input.MaxReplicas || (this.MaxReplicas != null && !this.MaxReplicas.Equals(input.MaxReplicas))) return false;
            if (this.ScaleWindow != input.ScaleWindow || (this.ScaleWindow != null && !this.ScaleWindow.Equals(input.ScaleWindow))) return false;

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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.HraRules != null) hashCode = hashCode * 59 + this.HraRules.GetHashCode();
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.PolicyStatus != null) hashCode = hashCode * 59 + this.PolicyStatus.GetHashCode();
                if (this.MinReplicas != null) hashCode = hashCode * 59 + this.MinReplicas.GetHashCode();
                if (this.MaxReplicas != null) hashCode = hashCode * 59 + this.MaxReplicas.GetHashCode();
                if (this.ScaleWindow != null) hashCode = hashCode * 59 + this.ScaleWindow.GetHashCode();
                return hashCode;
            }
        }
    }
}
