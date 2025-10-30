using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyAutoNodeExpansionPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释：** 节点扩容是否开启。 **约束限制：** 不涉及。 **取值范围：**   true为开启。   false为关闭。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("switch_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchOption { get; set; }

        /// <summary>
        /// **参数解释：** 超负载节点比例。如当前实例3个节点，需要当2个节点满足阈值时触发扩容，因2÷3≈67%，可设置为67（向上取整） **约束限制：** 不涉及。 **取值范围：** 1-100的正整数。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("overload_node_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverloadNodeThreshold { get; set; }

        /// <summary>
        /// **参数解释：** 触发节点自动扩容的CPU使用率。 **约束限制：** 不涉及。 **取值范围：** 1-100的正整数 **默认取值：** 默认为80。
        /// </summary>
        [JsonProperty("cpu_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuThreshold { get; set; }

        /// <summary>
        /// **参数解释：** 触发节点自动扩容的内存使用率。 **约束限制：** 不涉及。 **取值范围：** 1-100的数字 **默认取值：** 默认为80。
        /// </summary>
        [JsonProperty("mem_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemThreshold { get; set; }

        /// <summary>
        /// **参数解释：** 每次扩容的节点个数。 **约束限制：** 不涉及。 **取值范围：** 大等于1的正整数，最大不超过可扩容的节点上限。 **默认取值：** 默认为3。
        /// </summary>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public int? Step { get; set; }

        /// <summary>
        /// **参数解释：** 自动扩容所能达到的节点上限。 **约束限制：** 不涉及。 **取值范围：** 大等于1的正整数，最大不超过当前实例可扩容的节点上限。 **默认取值：** 默认为当前实例可扩容的节点上限。
        /// </summary>
        [JsonProperty("node_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyAutoNodeExpansionPolicyRequestBody {\n");
            sb.Append("  switchOption: ").Append(SwitchOption).Append("\n");
            sb.Append("  overloadNodeThreshold: ").Append(OverloadNodeThreshold).Append("\n");
            sb.Append("  cpuThreshold: ").Append(CpuThreshold).Append("\n");
            sb.Append("  memThreshold: ").Append(MemThreshold).Append("\n");
            sb.Append("  step: ").Append(Step).Append("\n");
            sb.Append("  nodeLimit: ").Append(NodeLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyAutoNodeExpansionPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyAutoNodeExpansionPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.SwitchOption != input.SwitchOption || (this.SwitchOption != null && !this.SwitchOption.Equals(input.SwitchOption))) return false;
            if (this.OverloadNodeThreshold != input.OverloadNodeThreshold || (this.OverloadNodeThreshold != null && !this.OverloadNodeThreshold.Equals(input.OverloadNodeThreshold))) return false;
            if (this.CpuThreshold != input.CpuThreshold || (this.CpuThreshold != null && !this.CpuThreshold.Equals(input.CpuThreshold))) return false;
            if (this.MemThreshold != input.MemThreshold || (this.MemThreshold != null && !this.MemThreshold.Equals(input.MemThreshold))) return false;
            if (this.Step != input.Step || (this.Step != null && !this.Step.Equals(input.Step))) return false;
            if (this.NodeLimit != input.NodeLimit || (this.NodeLimit != null && !this.NodeLimit.Equals(input.NodeLimit))) return false;

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
                if (this.SwitchOption != null) hashCode = hashCode * 59 + this.SwitchOption.GetHashCode();
                if (this.OverloadNodeThreshold != null) hashCode = hashCode * 59 + this.OverloadNodeThreshold.GetHashCode();
                if (this.CpuThreshold != null) hashCode = hashCode * 59 + this.CpuThreshold.GetHashCode();
                if (this.MemThreshold != null) hashCode = hashCode * 59 + this.MemThreshold.GetHashCode();
                if (this.Step != null) hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.NodeLimit != null) hashCode = hashCode * 59 + this.NodeLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
