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
    public class InferFlavor 
    {
        /// <summary>
        /// **参数解释：** 架构类型。 **取值范围：** - X86_64 - arm64
        /// </summary>
        /// <value>**参数解释：** 架构类型。 **取值范围：** - X86_64 - arm64</value>
        [JsonConverter(typeof(EnumClassConverter<ArchEnum>))]
        public class ArchEnum
        {
            /// <summary>
            /// Enum ARM64 for value: arm64
            /// </summary>
            public static readonly ArchEnum ARM64 = new ArchEnum("arm64");

            /// <summary>
            /// Enum X86_64 for value: X86_64
            /// </summary>
            public static readonly ArchEnum X86_64 = new ArchEnum("X86_64");

            private static readonly Dictionary<string, ArchEnum> StaticFields =
            new Dictionary<string, ArchEnum>()
            {
                { "arm64", ARM64 },
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
        /// **参数解释：** 规格处理器类型。 **取值范围：** - CPU - GPU - [ASCEND](tag:hws,hws_hk,hk,fcs_super)
        /// </summary>
        /// <value>**参数解释：** 规格处理器类型。 **取值范围：** - CPU - GPU - [ASCEND](tag:hws,hws_hk,hk,fcs_super)</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum ASCEND for value: ASCEND
            /// </summary>
            public static readonly CategoryEnum ASCEND = new CategoryEnum("ASCEND");

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
                { "ASCEND", ASCEND },
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
        /// **参数解释：** 规格类别。 **取值范围：** - DEFAULT：CodeLab规格。 - NOTEBOOK：Notebook规格。
        /// </summary>
        /// <value>**参数解释：** 规格类别。 **取值范围：** - DEFAULT：CodeLab规格。 - NOTEBOOK：Notebook规格。</value>
        [JsonConverter(typeof(EnumClassConverter<FeatureEnum>))]
        public class FeatureEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly FeatureEnum DEFAULT = new FeatureEnum("DEFAULT");

            /// <summary>
            /// Enum NOTEBOOK for value: NOTEBOOK
            /// </summary>
            public static readonly FeatureEnum NOTEBOOK = new FeatureEnum("NOTEBOOK");

            private static readonly Dictionary<string, FeatureEnum> StaticFields =
            new Dictionary<string, FeatureEnum>()
            {
                { "DEFAULT", DEFAULT },
                { "NOTEBOOK", NOTEBOOK },
            };

            private string _value;

            public FeatureEnum()
            {

            }

            public FeatureEnum(string value)
            {
                _value = value;
            }

            public static FeatureEnum FromValue(string value)
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

                if (this.Equals(obj as FeatureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FeatureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FeatureEnum a, FeatureEnum b)
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

            public static bool operator !=(FeatureEnum a, FeatureEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines storages
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StoragesEnum>))]
        public class StoragesEnum
        {
            /// <summary>
            /// Enum EFS for value: EFS
            /// </summary>
            public static readonly StoragesEnum EFS = new StoragesEnum("EFS");

            /// <summary>
            /// Enum EFS_DEDICATED for value: EFS_DEDICATED
            /// </summary>
            public static readonly StoragesEnum EFS_DEDICATED = new StoragesEnum("EFS_DEDICATED");

            /// <summary>
            /// Enum EVS for value: EVS
            /// </summary>
            public static readonly StoragesEnum EVS = new StoragesEnum("EVS");

            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly StoragesEnum OBS = new StoragesEnum("OBS");

            /// <summary>
            /// Enum OBSFS for value: OBSFS
            /// </summary>
            public static readonly StoragesEnum OBSFS = new StoragesEnum("OBSFS");

            private static readonly Dictionary<string, StoragesEnum> StaticFields =
            new Dictionary<string, StoragesEnum>()
            {
                { "EFS", EFS },
                { "EFS_DEDICATED", EFS_DEDICATED },
                { "EVS", EVS },
                { "OBS", OBS },
                { "OBSFS", OBSFS },
            };

            private string _value;

            public StoragesEnum()
            {

            }

            public StoragesEnum(string value)
            {
                _value = value;
            }

            public static StoragesEnum FromValue(string value)
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

                if (this.Equals(obj as StoragesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StoragesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StoragesEnum a, StoragesEnum b)
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

            public static bool operator !=(StoragesEnum a, StoragesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// **参数解释：** 架构类型。 **取值范围：** - X86_64 - arm64
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public ArchEnum Arch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ascend", NullValueHandling = NullValueHandling.Ignore)]
        public AscendResource Ascend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public BillingResource Billing { get; set; }

        /// <summary>
        /// **参数解释：** 规格处理器类型。 **取值范围：** - CPU - GPU - [ASCEND](tag:hws,hws_hk,hk,fcs_super)
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释：** 规格描述信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 规格类别。 **取值范围：** - DEFAULT：CodeLab规格。 - NOTEBOOK：Notebook规格。
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public FeatureEnum Feature { get; set; }
        /// <summary>
        /// **参数解释：** 是否为免费规格。 **取值范围：** - true: 免费规格。 - false: 付费规格。
        /// </summary>
        [JsonProperty("free", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Free { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public GPUResource Gpu { get; set; }

        /// <summary>
        /// **参数解释：** 规格ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 内存大小。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public long? Memory { get; set; }

        /// <summary>
        /// **参数解释：** 规格名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 资源是否充足。 **取值范围：** - true 资源不足。 - false 资源充足。
        /// </summary>
        [JsonProperty("sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoldOut { get; set; }

        /// <summary>
        /// **参数解释：** 规格支持的存储类型。
        /// </summary>
        [JsonProperty("storages", NullValueHandling = NullValueHandling.Ignore)]
        public List<StoragesEnum> Storages { get; set; }
        /// <summary>
        /// **参数解释：** CPU核数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// **参数解释：** EVS磁盘最大容量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("evs_max_size", NullValueHandling = NullValueHandling.Ignore)]
        public string EvsMaxSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InferFlavor {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  ascend: ").Append(Ascend).Append("\n");
            sb.Append("  billing: ").Append(Billing).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  free: ").Append(Free).Append("\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  soldOut: ").Append(SoldOut).Append("\n");
            sb.Append("  storages: ").Append(Storages).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  evsMaxSize: ").Append(EvsMaxSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InferFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InferFlavor input)
        {
            if (input == null) return false;
            if (this.Arch != input.Arch) return false;
            if (this.Ascend != input.Ascend || (this.Ascend != null && !this.Ascend.Equals(input.Ascend))) return false;
            if (this.Billing != input.Billing || (this.Billing != null && !this.Billing.Equals(input.Billing))) return false;
            if (this.Category != input.Category) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Feature != input.Feature) return false;
            if (this.Free != input.Free || (this.Free != null && !this.Free.Equals(input.Free))) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SoldOut != input.SoldOut || (this.SoldOut != null && !this.SoldOut.Equals(input.SoldOut))) return false;
            if (this.Storages != input.Storages || (this.Storages != null && input.Storages != null && !this.Storages.SequenceEqual(input.Storages))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.EvsMaxSize != input.EvsMaxSize || (this.EvsMaxSize != null && !this.EvsMaxSize.Equals(input.EvsMaxSize))) return false;

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
                hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.Ascend != null) hashCode = hashCode * 59 + this.Ascend.GetHashCode();
                if (this.Billing != null) hashCode = hashCode * 59 + this.Billing.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Free != null) hashCode = hashCode * 59 + this.Free.GetHashCode();
                if (this.Gpu != null) hashCode = hashCode * 59 + this.Gpu.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SoldOut != null) hashCode = hashCode * 59 + this.SoldOut.GetHashCode();
                hashCode = hashCode * 59 + this.Storages.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.EvsMaxSize != null) hashCode = hashCode * 59 + this.EvsMaxSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
