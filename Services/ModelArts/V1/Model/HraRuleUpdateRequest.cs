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
    public class HraRuleUpdateRequest 
    {

        /// <summary>
        /// 规则ID，在[创建HRA策略](CreateInferHra.xml)时即可在返回体中获取，也可通过[获取推理单元配比检测信息](ShowInferHra.xml)获取当前用户拥有的HRA策略，其中id字段即为规则ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 操作类型。 **取值范围：** - UPDATE：修改HRA策略规则。 - DELETE：删除HRA策略规则。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("operate", NullValueHandling = NullValueHandling.Ignore)]
        public string Operate { get; set; }

        /// <summary>
        /// **参数解释：** 扩缩容类型。 **取值范围：** - SIMULATOR_ALGO：模拟器算法扩缩容类型。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("scaler_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalerType { get; set; }

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
        /// **参数解释：** 角色扩缩策略（不会进行实质扩缩，因此该配置值无效）。 **取值范围：** 1~128。
        /// </summary>
        [JsonProperty("role_replica", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleReplica> RoleReplica { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HraRuleUpdateRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  operate: ").Append(Operate).Append("\n");
            sb.Append("  scalerType: ").Append(ScalerType).Append("\n");
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
            return this.Equals(input as HraRuleUpdateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HraRuleUpdateRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Operate != input.Operate || (this.Operate != null && !this.Operate.Equals(input.Operate))) return false;
            if (this.ScalerType != input.ScalerType || (this.ScalerType != null && !this.ScalerType.Equals(input.ScalerType))) return false;
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
                if (this.Operate != null) hashCode = hashCode * 59 + this.Operate.GetHashCode();
                if (this.ScalerType != null) hashCode = hashCode * 59 + this.ScalerType.GetHashCode();
                if (this.SloInfo != null) hashCode = hashCode * 59 + this.SloInfo.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.RoleReplica != null) hashCode = hashCode * 59 + this.RoleReplica.GetHashCode();
                return hashCode;
            }
        }
    }
}
