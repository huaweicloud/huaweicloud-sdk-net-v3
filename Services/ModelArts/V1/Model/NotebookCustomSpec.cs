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
    /// **参数描述**：自定义规格参数信息。 **约束限制**：CPU、GPU专属池下，支持的自定义规格参数，此字段与请求体中的flavor字段不可同时填写。
    /// </summary>
    public class NotebookCustomSpec 
    {

        /// <summary>
        /// **参数描述**：实例申请的GPU卡数。 **约束限制**：CPU专属池场景下无此字段，GPU专属池场景必填。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public float? Gpu { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的CPU核数大小。 **约束限制**：CPU/GPU专属池场景下自定义规格必填。 **取值范围**：整数部分最多10位，小数部分最多2位，且数值不得小于0.4。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public float? Cpu { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的内存大小。 **约束限制**：CPU/GPU专属池场景下自定义规格必填。 **取值范围**：必须是整数，整数部分最多10位，且数值不得小于513。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public float? Memory { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的GPU加速卡类型。 **约束限制**：CPU专属池场景下无此字段，GPU专属池场景下必填。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuType { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的CPU架构。 **约束限制**：CPU/GPU专属池场景下自定义规格必填。 **取值范围**：枚举类型，取值如下： - X86_64：x86架构 - AARCH64：ARM架构  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的规格类型。 **约束限制**：CPU/GPU专属池场景下自定义规格必填。 **取值范围**：枚举类型，取值如下： - CPU：CPU规格。 - GPU：GPU规格。  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**：实例选择的目标资源池节点实例规格。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotebookCustomSpec {\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  gpuType: ").Append(GpuType).Append("\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  resourceFlavor: ").Append(ResourceFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotebookCustomSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotebookCustomSpec input)
        {
            if (input == null) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.GpuType != input.GpuType || (this.GpuType != null && !this.GpuType.Equals(input.GpuType))) return false;
            if (this.Arch != input.Arch || (this.Arch != null && !this.Arch.Equals(input.Arch))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.ResourceFlavor != input.ResourceFlavor || (this.ResourceFlavor != null && !this.ResourceFlavor.Equals(input.ResourceFlavor))) return false;

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
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.GpuType != null) hashCode = hashCode * 59 + this.GpuType.GetHashCode();
                if (this.Arch != null) hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
