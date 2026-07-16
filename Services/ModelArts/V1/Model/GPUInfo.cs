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
    /// 
    /// </summary>
    public class GPUInfo 
    {

        /// <summary>
        /// **参数解释**：GPU卡数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Gpu { get; set; }

        /// <summary>
        /// **参数解释**：GPU内存。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("gpu_memory", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuMemory { get; set; }

        /// <summary>
        /// **参数解释**：GPU类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GPUInfo {\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  gpuMemory: ").Append(GpuMemory).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GPUInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GPUInfo input)
        {
            if (input == null) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.GpuMemory != input.GpuMemory || (this.GpuMemory != null && !this.GpuMemory.Equals(input.GpuMemory))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Gpu != null) hashCode = hashCode * 59 + this.Gpu.GetHashCode();
                if (this.GpuMemory != null) hashCode = hashCode * 59 + this.GpuMemory.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
