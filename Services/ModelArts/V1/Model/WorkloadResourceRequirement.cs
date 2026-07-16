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
    /// **参数解释**：作业运行请求的资源量。
    /// </summary>
    public class WorkloadResourceRequirement 
    {

        /// <summary>
        /// **参数解释**：作业的运行使用的CPU资源量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// **参数解释**：作业的运行使用的内存资源量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// **参数解释**：作业的运行使用的GPU资源量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("nvidia.com/gpu", NullValueHandling = NullValueHandling.Ignore)]
        public string NvidiaComGpu { get; set; }

        /// <summary>
        /// **参数解释**：作业的运行使用的snt3类型NPU资源量。 **取值范围**：不涉及
        /// </summary>
        [JsonProperty("huawei.com/ascend-310", NullValueHandling = NullValueHandling.Ignore)]
        public string HuaweiComAscend310 { get; set; }

        /// <summary>
        /// **参数解释**：作业的运行使用的snt9类型NPU资源量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("huawei.com/ascend-1980", NullValueHandling = NullValueHandling.Ignore)]
        public string HuaweiComAscend1980 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkloadResourceRequirement {\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  nvidiaComGpu: ").Append(NvidiaComGpu).Append("\n");
            sb.Append("  huaweiComAscend310: ").Append(HuaweiComAscend310).Append("\n");
            sb.Append("  huaweiComAscend1980: ").Append(HuaweiComAscend1980).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkloadResourceRequirement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkloadResourceRequirement input)
        {
            if (input == null) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.NvidiaComGpu != input.NvidiaComGpu || (this.NvidiaComGpu != null && !this.NvidiaComGpu.Equals(input.NvidiaComGpu))) return false;
            if (this.HuaweiComAscend310 != input.HuaweiComAscend310 || (this.HuaweiComAscend310 != null && !this.HuaweiComAscend310.Equals(input.HuaweiComAscend310))) return false;
            if (this.HuaweiComAscend1980 != input.HuaweiComAscend1980 || (this.HuaweiComAscend1980 != null && !this.HuaweiComAscend1980.Equals(input.HuaweiComAscend1980))) return false;

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
                if (this.HuaweiComAscend310 != null) hashCode = hashCode * 59 + this.HuaweiComAscend310.GetHashCode();
                if (this.HuaweiComAscend1980 != null) hashCode = hashCode * 59 + this.HuaweiComAscend1980.GetHashCode();
                return hashCode;
            }
        }
    }
}
