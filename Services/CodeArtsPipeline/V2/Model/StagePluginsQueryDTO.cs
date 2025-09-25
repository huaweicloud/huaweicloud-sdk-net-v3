using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StagePluginsQueryDTO 
    {

        /// <summary>
        /// **参数解释**： 用于区分插件为流水线可使用/模板可使用。 **约束限制**： 不涉及。 **取值范围**： - pipeline：流水线可使用。 - template：模板可使用。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("use_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string UseCondition { get; set; }

        /// <summary>
        /// **参数解释**： 微服务ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("comp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompId { get; set; }

        /// <summary>
        /// **参数解释**： 微服务名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("comp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CompName { get; set; }

        /// <summary>
        /// **参数解释**： 局点ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("cloud_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudId { get; set; }

        /// <summary>
        /// **参数解释**： 策略ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("strategy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StrategyId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 是否发布流水线。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("publish_tab", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTab { get; set; }

        /// <summary>
        /// **参数解释**： 部署平台。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// **参数解释**： 组件类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("comp_extend_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompExtendType { get; set; }

        /// <summary>
        /// **参数解释**： 部署类型。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("deploy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StagePluginsQueryDTO {\n");
            sb.Append("  useCondition: ").Append(UseCondition).Append("\n");
            sb.Append("  compId: ").Append(CompId).Append("\n");
            sb.Append("  compName: ").Append(CompName).Append("\n");
            sb.Append("  cloudId: ").Append(CloudId).Append("\n");
            sb.Append("  strategyId: ").Append(StrategyId).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  publishTab: ").Append(PublishTab).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  compExtendType: ").Append(CompExtendType).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StagePluginsQueryDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StagePluginsQueryDTO input)
        {
            if (input == null) return false;
            if (this.UseCondition != input.UseCondition || (this.UseCondition != null && !this.UseCondition.Equals(input.UseCondition))) return false;
            if (this.CompId != input.CompId || (this.CompId != null && !this.CompId.Equals(input.CompId))) return false;
            if (this.CompName != input.CompName || (this.CompName != null && !this.CompName.Equals(input.CompName))) return false;
            if (this.CloudId != input.CloudId || (this.CloudId != null && !this.CloudId.Equals(input.CloudId))) return false;
            if (this.StrategyId != input.StrategyId || (this.StrategyId != null && !this.StrategyId.Equals(input.StrategyId))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.PublishTab != input.PublishTab || (this.PublishTab != null && !this.PublishTab.Equals(input.PublishTab))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.CompExtendType != input.CompExtendType || (this.CompExtendType != null && !this.CompExtendType.Equals(input.CompExtendType))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;

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
                if (this.UseCondition != null) hashCode = hashCode * 59 + this.UseCondition.GetHashCode();
                if (this.CompId != null) hashCode = hashCode * 59 + this.CompId.GetHashCode();
                if (this.CompName != null) hashCode = hashCode * 59 + this.CompName.GetHashCode();
                if (this.CloudId != null) hashCode = hashCode * 59 + this.CloudId.GetHashCode();
                if (this.StrategyId != null) hashCode = hashCode * 59 + this.StrategyId.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.PublishTab != null) hashCode = hashCode * 59 + this.PublishTab.GetHashCode();
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.CompExtendType != null) hashCode = hashCode * 59 + this.CompExtendType.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                return hashCode;
            }
        }
    }
}
