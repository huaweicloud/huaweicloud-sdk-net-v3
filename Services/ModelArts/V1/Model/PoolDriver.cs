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
    /// 资源池驱动数据模型。
    /// </summary>
    public class PoolDriver 
    {

        /// <summary>
        /// **参数解释**：资源池默认的GPU驱动版本。物理资源池中包含GPU规格时有效。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("gpuVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuVersion { get; set; }

        /// <summary>
        /// **参数解释**：资源池默认的NPU驱动版本。物理资源池中包含NPU规格时有效。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("npuVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string NpuVersion { get; set; }

        /// <summary>
        /// **参数解释**：资源池驱动升级策略。 **取值范围**：可选值如下： - force：强制升级，立即升级节点驱动，可能影响节点上正在运行的作业。 - idle：安全升级，待节点上没有作业运行时进行驱动升级。
        /// </summary>
        [JsonProperty("updateStrategy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolDriver {\n");
            sb.Append("  gpuVersion: ").Append(GpuVersion).Append("\n");
            sb.Append("  npuVersion: ").Append(NpuVersion).Append("\n");
            sb.Append("  updateStrategy: ").Append(UpdateStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolDriver);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolDriver input)
        {
            if (input == null) return false;
            if (this.GpuVersion != input.GpuVersion || (this.GpuVersion != null && !this.GpuVersion.Equals(input.GpuVersion))) return false;
            if (this.NpuVersion != input.NpuVersion || (this.NpuVersion != null && !this.NpuVersion.Equals(input.NpuVersion))) return false;
            if (this.UpdateStrategy != input.UpdateStrategy || (this.UpdateStrategy != null && !this.UpdateStrategy.Equals(input.UpdateStrategy))) return false;

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
                if (this.GpuVersion != null) hashCode = hashCode * 59 + this.GpuVersion.GetHashCode();
                if (this.NpuVersion != null) hashCode = hashCode * 59 + this.NpuVersion.GetHashCode();
                if (this.UpdateStrategy != null) hashCode = hashCode * 59 + this.UpdateStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
