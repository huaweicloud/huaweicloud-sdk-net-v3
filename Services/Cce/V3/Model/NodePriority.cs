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
    /// **参数解释：** 节点优先级批量配置，通过节点标签选择器匹配节点并为匹配的节点设置升级优先级。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class NodePriority 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeSelector", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSelector NodeSelector { get; set; }

        /// <summary>
        /// **参数解释：** 该批次节点的优先级，数值越大优先级越高 **约束限制：** 不涉及 **取值范围：** 非负整数 **默认取值：** 0
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePriority {\n");
            sb.Append("  nodeSelector: ").Append(NodeSelector).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePriority);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePriority input)
        {
            if (input == null) return false;
            if (this.NodeSelector != input.NodeSelector || (this.NodeSelector != null && !this.NodeSelector.Equals(input.NodeSelector))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;

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
                if (this.NodeSelector != null) hashCode = hashCode * 59 + this.NodeSelector.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                return hashCode;
            }
        }
    }
}
