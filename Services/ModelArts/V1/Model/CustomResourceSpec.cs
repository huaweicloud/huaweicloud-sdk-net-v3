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
    /// **参数解释：** 自定义规格配置。当需要使用自定义规格时需要填写此参数。 **约束限制：** 不涉及。 **参数示例：** \&quot;custom_spec\&quot;: {     \&quot;arch\&quot;: \&quot;x86\&quot;,     \&quot;cpu\&quot;: 0.51,     \&quot;memory\&quot;: 1024.0 }
    /// </summary>
    public class CustomResourceSpec 
    {

        /// <summary>
        /// **参数解释：** GPU个数。 **约束限制：** 不涉及。 **取值范围：** 支持配置小数，输入值不能小于0（最多支持2位小数，小数点后第3位做四舍五入处理）。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public float? Gpu { get; set; }

        /// <summary>
        /// **参数解释：** 内存，单位为MB。 **约束限制：** 不涉及。 **取值范围：** 仅支持整数。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? Memory { get; set; }

        /// <summary>
        /// **参数解释：** CPU核数。 **约束限制：** 不涉及。 **取值范围：** 支持配置小数，输入值不能小于0.01（最多支持2位小数，小数点后第3位做四舍五入处理）。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public float? Cpu { get; set; }

        /// <summary>
        /// **参数解释：** Ascend芯片个数。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("ascend", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ascend { get; set; }

        /// <summary>
        /// **参数解释：** 架构类型。 **约束限制：** 不涉及。 **取值范围：** 枚举值：x86 | arm64。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomResourceSpec {\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  ascend: ").Append(Ascend).Append("\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomResourceSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomResourceSpec input)
        {
            if (input == null) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Ascend != input.Ascend || (this.Ascend != null && !this.Ascend.Equals(input.Ascend))) return false;
            if (this.Arch != input.Arch || (this.Arch != null && !this.Arch.Equals(input.Arch))) return false;

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
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Ascend != null) hashCode = hashCode * 59 + this.Ascend.GetHashCode();
                if (this.Arch != null) hashCode = hashCode * 59 + this.Arch.GetHashCode();
                return hashCode;
            }
        }
    }
}
