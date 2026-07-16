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
    public class AscendResource 
    {

        /// <summary>
        /// **参数解释：** NPU数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("npu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Npu { get; set; }

        /// <summary>
        /// **参数解释：** NPU内存。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("npu_memory", NullValueHandling = NullValueHandling.Ignore)]
        public string NpuMemory { get; set; }

        /// <summary>
        /// **参数解释：** NPU类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 切分规格中的ai_core。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("ai_core", NullValueHandling = NullValueHandling.Ignore)]
        public string AiCore { get; set; }

        /// <summary>
        /// **参数解释：** 切分规格中的ai_cpu。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("ai_cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string AiCpu { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AscendResource {\n");
            sb.Append("  npu: ").Append(Npu).Append("\n");
            sb.Append("  npuMemory: ").Append(NpuMemory).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  aiCore: ").Append(AiCore).Append("\n");
            sb.Append("  aiCpu: ").Append(AiCpu).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AscendResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AscendResource input)
        {
            if (input == null) return false;
            if (this.Npu != input.Npu || (this.Npu != null && !this.Npu.Equals(input.Npu))) return false;
            if (this.NpuMemory != input.NpuMemory || (this.NpuMemory != null && !this.NpuMemory.Equals(input.NpuMemory))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.AiCore != input.AiCore || (this.AiCore != null && !this.AiCore.Equals(input.AiCore))) return false;
            if (this.AiCpu != input.AiCpu || (this.AiCpu != null && !this.AiCpu.Equals(input.AiCpu))) return false;

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
                if (this.Npu != null) hashCode = hashCode * 59 + this.Npu.GetHashCode();
                if (this.NpuMemory != null) hashCode = hashCode * 59 + this.NpuMemory.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AiCore != null) hashCode = hashCode * 59 + this.AiCore.GetHashCode();
                if (this.AiCpu != null) hashCode = hashCode * 59 + this.AiCpu.GetHashCode();
                return hashCode;
            }
        }
    }
}
