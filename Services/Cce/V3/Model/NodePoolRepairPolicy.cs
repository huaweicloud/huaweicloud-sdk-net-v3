using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点故障自愈配置
    /// </summary>
    public class NodePoolRepairPolicy 
    {

        /// <summary>
        /// **参数解释**： 系统与 K8s 组件异常时是否启用policy中配置的自愈策略。 **约束限制**： 不涉及 **取值范围**： - false：使用基础自愈策略 - true：使用policy中配置的自愈策略  **默认取值**： false
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// **参数解释**： 节点自愈的恢复策略 **约束限制**： - 当 enable 为 true 时，此字段必填。 - 当 enable 为 false 时，此字段无效，用户填写任意值均不会生效，系统使用基础自愈策略。  **取值范围**： - restartNode：系统与 K8s 组件异常时允许通过重启节点自愈  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolRepairPolicy {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolRepairPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolRepairPolicy input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                return hashCode;
            }
        }
    }
}
