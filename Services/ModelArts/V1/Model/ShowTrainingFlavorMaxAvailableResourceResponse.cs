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
    /// Response Object
    /// </summary>
    public class ShowTrainingFlavorMaxAvailableResourceResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：最大可用CPU核数。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("cpu_core_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuCoreNum { get; set; }

        /// <summary>
        /// **参数解释**：最大可用内存大小，单位为GB。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("mem_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingFlavorMaxAvailableResourceResponse {\n");
            sb.Append("  cpuCoreNum: ").Append(CpuCoreNum).Append("\n");
            sb.Append("  memSize: ").Append(MemSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingFlavorMaxAvailableResourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingFlavorMaxAvailableResourceResponse input)
        {
            if (input == null) return false;
            if (this.CpuCoreNum != input.CpuCoreNum || (this.CpuCoreNum != null && !this.CpuCoreNum.Equals(input.CpuCoreNum))) return false;
            if (this.MemSize != input.MemSize || (this.MemSize != null && !this.MemSize.Equals(input.MemSize))) return false;

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
                return hashCode;
            }
        }
    }
}
