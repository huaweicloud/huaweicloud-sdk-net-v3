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
    /// 配置训练作业自定义规格。
    /// </summary>
    public class MainContainerCustomizedFlavor 
    {

        /// <summary>
        /// **参数解释**：cpu核数。 **取值范围**：大于零。
        /// </summary>
        [JsonProperty("cpu_core_num", NullValueHandling = NullValueHandling.Ignore)]
        public float? CpuCoreNum { get; set; }

        /// <summary>
        /// **参数解释**：内存大小。 **取值范围**：大于零。
        /// </summary>
        [JsonProperty("mem_size", NullValueHandling = NullValueHandling.Ignore)]
        public float? MemSize { get; set; }

        /// <summary>
        /// **参数解释**：加速卡卡数。 **取值范围**：大于等于零。
        /// </summary>
        [JsonProperty("accelerator_num", NullValueHandling = NullValueHandling.Ignore)]
        public float? AcceleratorNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MainContainerCustomizedFlavor {\n");
            sb.Append("  cpuCoreNum: ").Append(CpuCoreNum).Append("\n");
            sb.Append("  memSize: ").Append(MemSize).Append("\n");
            sb.Append("  acceleratorNum: ").Append(AcceleratorNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MainContainerCustomizedFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MainContainerCustomizedFlavor input)
        {
            if (input == null) return false;
            if (this.CpuCoreNum != input.CpuCoreNum || (this.CpuCoreNum != null && !this.CpuCoreNum.Equals(input.CpuCoreNum))) return false;
            if (this.MemSize != input.MemSize || (this.MemSize != null && !this.MemSize.Equals(input.MemSize))) return false;
            if (this.AcceleratorNum != input.AcceleratorNum || (this.AcceleratorNum != null && !this.AcceleratorNum.Equals(input.AcceleratorNum))) return false;

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
                if (this.CpuCoreNum != null) hashCode = hashCode * 59 + this.CpuCoreNum.GetHashCode();
                if (this.MemSize != null) hashCode = hashCode * 59 + this.MemSize.GetHashCode();
                if (this.AcceleratorNum != null) hashCode = hashCode * 59 + this.AcceleratorNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
