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
    /// 创建定时扩缩容策略请求体
    /// </summary>
    public class CreateHpaRequestBody 
    {

        /// <summary>
        /// **参数解释：** 自动扩缩容类型。 **取值范围：** - CRON_HPA：定时扩缩容策略 - METRIC_HPA：指标扩缩容策略 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容策略绑定的目标ID **取值范围：** 实例组ID **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("target_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容策略绑定的目标类型。 **取值范围：** - GROUP：实例组 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("target_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResourceType { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩缩容规则。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("hpa_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<HpaRules> HpaRules { get; set; }

        /// <summary>
        /// **参数解释：** 工作空间ID。 **取值范围：** - 0：默认空间ID - 由数字和小写字母组成的32位字符：其他空间ID，可参考[工作空间创建](CreateWorkspace.xml) **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHpaRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  targetResourceId: ").Append(TargetResourceId).Append("\n");
            sb.Append("  targetResourceType: ").Append(TargetResourceType).Append("\n");
            sb.Append("  hpaRules: ").Append(HpaRules).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateHpaRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateHpaRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.TargetResourceId != input.TargetResourceId || (this.TargetResourceId != null && !this.TargetResourceId.Equals(input.TargetResourceId))) return false;
            if (this.TargetResourceType != input.TargetResourceType || (this.TargetResourceType != null && !this.TargetResourceType.Equals(input.TargetResourceType))) return false;
            if (this.HpaRules != input.HpaRules || (this.HpaRules != null && input.HpaRules != null && !this.HpaRules.SequenceEqual(input.HpaRules))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TargetResourceId != null) hashCode = hashCode * 59 + this.TargetResourceId.GetHashCode();
                if (this.TargetResourceType != null) hashCode = hashCode * 59 + this.TargetResourceType.GetHashCode();
                if (this.HpaRules != null) hashCode = hashCode * 59 + this.HpaRules.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
