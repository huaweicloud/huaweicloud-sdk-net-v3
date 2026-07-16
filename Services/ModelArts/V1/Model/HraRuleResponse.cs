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
    /// HRA规则
    /// </summary>
    public class HraRuleResponse 
    {

        /// <summary>
        /// **参数解释：** 规则ID，在创建HRA策略时即可在返回体中获取，也可通过查询推理单元配比检测信息获取当前用户拥有的HRA策略，其中id字段即为规则ID。 **约束限制：** 不涉及。 **取值范围：** 规则ID。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 规则名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 规则是否禁用。 **取值范围：** - true：禁用。 - false：不禁用。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }

        /// <summary>
        /// **参数解释：** 扩缩容类型。 **取值范围：** - SIMULATOR_ALGO：模拟器算法扩缩容类型。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("scaler_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalerType { get; set; }

        /// <summary>
        /// **参数解释：** HRA规则状态。 **取值范围：** - CREATING：创建。 - CONFIG_SUCCESS：配置HRA策略成功。 - EXECUTE_SUCCESS：执行HRA策略成功。 - DELETED：删除。 - FAILED：失败。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("rule_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// **参数解释：** SLO配置参数信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("slo_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SloInfo> SloInfo { get; set; }

        /// <summary>
        /// **参数解释：** 指标信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Metrics> Metrics { get; set; }

        /// <summary>
        /// **参数解释：** 角色扩缩策略（不会进行实质扩缩，因此该配置值无效）。
        /// </summary>
        [JsonProperty("role_replica", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleReplica> RoleReplica { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HraRuleResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("  scalerType: ").Append(ScalerType).Append("\n");
            sb.Append("  ruleStatus: ").Append(RuleStatus).Append("\n");
            sb.Append("  sloInfo: ").Append(SloInfo).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  roleReplica: ").Append(RoleReplica).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HraRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HraRuleResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;
            if (this.ScalerType != input.ScalerType || (this.ScalerType != null && !this.ScalerType.Equals(input.ScalerType))) return false;
            if (this.RuleStatus != input.RuleStatus || (this.RuleStatus != null && !this.RuleStatus.Equals(input.RuleStatus))) return false;
            if (this.SloInfo != input.SloInfo || (this.SloInfo != null && input.SloInfo != null && !this.SloInfo.SequenceEqual(input.SloInfo))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;
            if (this.RoleReplica != input.RoleReplica || (this.RoleReplica != null && input.RoleReplica != null && !this.RoleReplica.SequenceEqual(input.RoleReplica))) return false;

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
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                if (this.ScalerType != null) hashCode = hashCode * 59 + this.ScalerType.GetHashCode();
                if (this.RuleStatus != null) hashCode = hashCode * 59 + this.RuleStatus.GetHashCode();
                if (this.SloInfo != null) hashCode = hashCode * 59 + this.SloInfo.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.RoleReplica != null) hashCode = hashCode * 59 + this.RoleReplica.GetHashCode();
                return hashCode;
            }
        }
    }
}
