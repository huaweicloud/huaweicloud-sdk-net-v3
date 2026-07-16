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
    /// 节点资源量。
    /// </summary>
    public class NodeResource 
    {

        /// <summary>
        /// **参数解释**：节点的CPU核心数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// **参数解释**：节点的内存大小。以Gi为单位。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// **参数解释**：节点的GPU卡数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("nvidia.com/gpu", NullValueHandling = NullValueHandling.Ignore)]
        public string NvidiaComGpu { get; set; }

        /// <summary>
        /// **参数解释**：节点的snt3型NPU卡数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("huawei.com/ascend-snt3", NullValueHandling = NullValueHandling.Ignore)]
        public string HuaweiComAscendSnt3 { get; set; }

        /// <summary>
        /// **参数解释**：节点的snt9型NPU卡数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("huawei.com/ascend-snt9", NullValueHandling = NullValueHandling.Ignore)]
        public string HuaweiComAscendSnt9 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeResource {\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  nvidiaComGpu: ").Append(NvidiaComGpu).Append("\n");
            sb.Append("  huaweiComAscendSnt3: ").Append(HuaweiComAscendSnt3).Append("\n");
            sb.Append("  huaweiComAscendSnt9: ").Append(HuaweiComAscendSnt9).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeResource input)
        {
            if (input == null) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.NvidiaComGpu != input.NvidiaComGpu || (this.NvidiaComGpu != null && !this.NvidiaComGpu.Equals(input.NvidiaComGpu))) return false;
            if (this.HuaweiComAscendSnt3 != input.HuaweiComAscendSnt3 || (this.HuaweiComAscendSnt3 != null && !this.HuaweiComAscendSnt3.Equals(input.HuaweiComAscendSnt3))) return false;
            if (this.HuaweiComAscendSnt9 != input.HuaweiComAscendSnt9 || (this.HuaweiComAscendSnt9 != null && !this.HuaweiComAscendSnt9.Equals(input.HuaweiComAscendSnt9))) return false;

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
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.NvidiaComGpu != null) hashCode = hashCode * 59 + this.NvidiaComGpu.GetHashCode();
                if (this.HuaweiComAscendSnt3 != null) hashCode = hashCode * 59 + this.HuaweiComAscendSnt3.GetHashCode();
                if (this.HuaweiComAscendSnt9 != null) hashCode = hashCode * 59 + this.HuaweiComAscendSnt9.GetHashCode();
                return hashCode;
            }
        }
    }
}
