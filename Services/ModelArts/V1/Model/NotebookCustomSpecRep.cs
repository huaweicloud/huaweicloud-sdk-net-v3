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
    /// **参数描述**：CPU、GPU专属池下，用户指定自定义规格的响应体信息
    /// </summary>
    public class NotebookCustomSpecRep 
    {
        /// <summary>
        /// **参数描述**：实例申请的CPU架构。 **取值范围**：枚举类型，取值如下：  - X86_64：x86架构 - AARCH64：ARM架构
        /// </summary>
        /// <value>**参数描述**：实例申请的CPU架构。 **取值范围**：枚举类型，取值如下：  - X86_64：x86架构 - AARCH64：ARM架构</value>
        [JsonConverter(typeof(EnumClassConverter<ArchEnum>))]
        public class ArchEnum
        {
            /// <summary>
            /// Enum AARCH64 for value: AARCH64
            /// </summary>
            public static readonly ArchEnum AARCH64 = new ArchEnum("AARCH64");

            /// <summary>
            /// Enum X86_64 for value: X86_64
            /// </summary>
            public static readonly ArchEnum X86_64 = new ArchEnum("X86_64");

            private static readonly Dictionary<string, ArchEnum> StaticFields =
            new Dictionary<string, ArchEnum>()
            {
                { "AARCH64", AARCH64 },
                { "X86_64", X86_64 },
            };

            private string _value;

            public ArchEnum()
            {

            }

            public ArchEnum(string value)
            {
                _value = value;
            }

            public static ArchEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ArchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchEnum a, ArchEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ArchEnum a, ArchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数描述**：实例申请的规格类型。 **取值范围**：枚举类型，取值如下：  - CPU：CPU规格。 - GPU：GPU规格。
        /// </summary>
        /// <value>**参数描述**：实例申请的规格类型。 **取值范围**：枚举类型，取值如下：  - CPU：CPU规格。 - GPU：GPU规格。</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum CPU for value: CPU
            /// </summary>
            public static readonly CategoryEnum CPU = new CategoryEnum("CPU");

            /// <summary>
            /// Enum GPU for value: GPU
            /// </summary>
            public static readonly CategoryEnum GPU = new CategoryEnum("GPU");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "CPU", CPU },
                { "GPU", GPU },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数描述**：实例申请的GPU卡数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public float? Gpu { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的GPU加速卡类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GpuType { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的CPU核数大小。 **取值范围**：整数部分最多10位，小数部分最多2位，且数值不得小于0.4。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public float? Cpu { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的内存大小。 **取值范围**：必须是整数，整数部分最多10位，且数值不得小于513。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public float? Memory { get; set; }

        /// <summary>
        /// **参数描述**：实例申请的CPU架构。 **取值范围**：枚举类型，取值如下：  - X86_64：x86架构 - AARCH64：ARM架构
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public ArchEnum Arch { get; set; }
        /// <summary>
        /// **参数描述**：实例申请的规格类型。 **取值范围**：枚举类型，取值如下：  - CPU：CPU规格。 - GPU：GPU规格。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**：实例选择的目标资源池节点实例规格。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotebookCustomSpecRep {\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  gpuType: ").Append(GpuType).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
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
            return this.Equals(input as NotebookCustomSpecRep);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotebookCustomSpecRep input)
        {
            if (input == null) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.GpuType != input.GpuType || (this.GpuType != null && !this.GpuType.Equals(input.GpuType))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Arch != input.Arch) return false;
            if (this.Category != input.Category) return false;
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
                if (this.GpuType != null) hashCode = hashCode * 59 + this.GpuType.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                hashCode = hashCode * 59 + this.Arch.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
