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
    /// 训练作业的训练容器实际到手的资源规格。
    /// </summary>
    public class MainContainerAllocatedResources 
    {

        /// <summary>
        /// **参数解释**： cpu架构。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("cpu_arch", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuArch { get; set; }

        /// <summary>
        /// **参数解释**： 核数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("cpu_core_num", NullValueHandling = NullValueHandling.Ignore)]
        public float? CpuCoreNum { get; set; }

        /// <summary>
        /// **参数解释**： 内存信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("mem_size", NullValueHandling = NullValueHandling.Ignore)]
        public float? MemSize { get; set; }

        /// <summary>
        /// **参数解释**： 加速卡卡数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("accelerator_num", NullValueHandling = NullValueHandling.Ignore)]
        public float? AcceleratorNum { get; set; }

        /// <summary>
        /// **参数解释**： 加速卡类型。如：ascend-Snt9b，ascend-snt9c等 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("accelerator_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceleratorType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MainContainerAllocatedResources {\n");
            sb.Append("  cpuArch: ").Append(CpuArch).Append("\n");
            sb.Append("  cpuCoreNum: ").Append(CpuCoreNum).Append("\n");
            sb.Append("  memSize: ").Append(MemSize).Append("\n");
            sb.Append("  acceleratorNum: ").Append(AcceleratorNum).Append("\n");
            sb.Append("  acceleratorType: ").Append(AcceleratorType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MainContainerAllocatedResources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MainContainerAllocatedResources input)
        {
            if (input == null) return false;
            if (this.CpuArch != input.CpuArch || (this.CpuArch != null && !this.CpuArch.Equals(input.CpuArch))) return false;
            if (this.CpuCoreNum != input.CpuCoreNum || (this.CpuCoreNum != null && !this.CpuCoreNum.Equals(input.CpuCoreNum))) return false;
            if (this.MemSize != input.MemSize || (this.MemSize != null && !this.MemSize.Equals(input.MemSize))) return false;
            if (this.AcceleratorNum != input.AcceleratorNum || (this.AcceleratorNum != null && !this.AcceleratorNum.Equals(input.AcceleratorNum))) return false;
            if (this.AcceleratorType != input.AcceleratorType || (this.AcceleratorType != null && !this.AcceleratorType.Equals(input.AcceleratorType))) return false;

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
                if (this.CpuArch != null) hashCode = hashCode * 59 + this.CpuArch.GetHashCode();
                if (this.CpuCoreNum != null) hashCode = hashCode * 59 + this.CpuCoreNum.GetHashCode();
                if (this.MemSize != null) hashCode = hashCode * 59 + this.MemSize.GetHashCode();
                if (this.AcceleratorNum != null) hashCode = hashCode * 59 + this.AcceleratorNum.GetHashCode();
                if (this.AcceleratorType != null) hashCode = hashCode * 59 + this.AcceleratorType.GetHashCode();
                return hashCode;
            }
        }
    }
}
