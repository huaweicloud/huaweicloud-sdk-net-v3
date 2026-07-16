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
    /// 节点annotations
    /// </summary>
    public class NodeVOAnnotations 
    {

        /// <summary>
        /// **参数解释**：NPU卡的资源使用拓扑信息，长度为16的二进制编码，右起第一位编码代表卡1。其中，1表示占用，0表示空闲。例如，16卡的机型中卡1和卡15被占用，值为0100000000000001；8卡的机型中卡1和卡7被占用，返回值为0000000001000001。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("os.modelarts/npu-topology-placement", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsNpuTopologyPlacement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeVOAnnotations {\n");
            sb.Append("  osModelartsNpuTopologyPlacement: ").Append(OsModelartsNpuTopologyPlacement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeVOAnnotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeVOAnnotations input)
        {
            if (input == null) return false;
            if (this.OsModelartsNpuTopologyPlacement != input.OsModelartsNpuTopologyPlacement || (this.OsModelartsNpuTopologyPlacement != null && !this.OsModelartsNpuTopologyPlacement.Equals(input.OsModelartsNpuTopologyPlacement))) return false;

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
                if (this.OsModelartsNpuTopologyPlacement != null) hashCode = hashCode * 59 + this.OsModelartsNpuTopologyPlacement.GetHashCode();
                return hashCode;
            }
        }
    }
}
