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
    public class ServerVolume 
    {
        /// <summary>
        /// **参数解释**：存储类型。表示系统盘或数据盘。 **约束限制**：不涉及。 **取值范围**： - ROOT：系统盘 - DATA：数据盘  **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：存储类型。表示系统盘或数据盘。 **约束限制**：不涉及。 **取值范围**： - ROOT：系统盘 - DATA：数据盘  **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ROOT for value: ROOT
            /// </summary>
            public static readonly TypeEnum ROOT = new TypeEnum("ROOT");

            /// <summary>
            /// Enum DATA for value: DATA
            /// </summary>
            public static readonly TypeEnum DATA = new TypeEnum("DATA");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ROOT", ROOT },
                { "DATA", DATA },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：EVS盘类型。表示EVS盘的存储类型。 **约束限制**：不涉及。 **取值范围**： - ESSD：极速型SSD云硬盘 - GPSSD：通用型SSD云硬盘 - SAS：高IO云硬盘 - SATA：普通IO云硬盘 - SSD：超高IO云硬盘  **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：EVS盘类型。表示EVS盘的存储类型。 **约束限制**：不涉及。 **取值范围**： - ESSD：极速型SSD云硬盘 - GPSSD：通用型SSD云硬盘 - SAS：高IO云硬盘 - SATA：普通IO云硬盘 - SSD：超高IO云硬盘  **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<EvsTypeEnum>))]
        public class EvsTypeEnum
        {
            /// <summary>
            /// Enum ESSD for value: ESSD
            /// </summary>
            public static readonly EvsTypeEnum ESSD = new EvsTypeEnum("ESSD");

            /// <summary>
            /// Enum GPSSD for value: GPSSD
            /// </summary>
            public static readonly EvsTypeEnum GPSSD = new EvsTypeEnum("GPSSD");

            /// <summary>
            /// Enum SAS for value: SAS
            /// </summary>
            public static readonly EvsTypeEnum SAS = new EvsTypeEnum("SAS");

            /// <summary>
            /// Enum SATA for value: SATA
            /// </summary>
            public static readonly EvsTypeEnum SATA = new EvsTypeEnum("SATA");

            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly EvsTypeEnum SSD = new EvsTypeEnum("SSD");

            private static readonly Dictionary<string, EvsTypeEnum> StaticFields =
            new Dictionary<string, EvsTypeEnum>()
            {
                { "ESSD", ESSD },
                { "GPSSD", GPSSD },
                { "SAS", SAS },
                { "SATA", SATA },
                { "SSD", SSD },
            };

            private string _value;

            public EvsTypeEnum()
            {

            }

            public EvsTypeEnum(string value)
            {
                _value = value;
            }

            public static EvsTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EvsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EvsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EvsTypeEnum a, EvsTypeEnum b)
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

            public static bool operator !=(EvsTypeEnum a, EvsTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：EVS盘大小。表示分配给系统盘的存储空间大小。 **约束限制**：不涉及。 **取值范围**：100 - 1024 GB **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// **参数解释**：存储类型。表示系统盘或数据盘。 **约束限制**：不涉及。 **取值范围**： - ROOT：系统盘 - DATA：数据盘  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**：EVS盘类型。表示EVS盘的存储类型。 **约束限制**：不涉及。 **取值范围**： - ESSD：极速型SSD云硬盘 - GPSSD：通用型SSD云硬盘 - SAS：高IO云硬盘 - SATA：普通IO云硬盘 - SSD：超高IO云硬盘  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("evs_type", NullValueHandling = NullValueHandling.Ignore)]
        public EvsTypeEnum EvsType { get; set; }
        /// <summary>
        /// **参数解释**：EVS盘的ID。 **取值范围**：^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$。
        /// </summary>
        [JsonProperty("evs_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EvsId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerVolume {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  evsType: ").Append(EvsType).Append("\n");
            sb.Append("  evsId: ").Append(EvsId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerVolume input)
        {
            if (input == null) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Type != input.Type) return false;
            if (this.EvsType != input.EvsType) return false;
            if (this.EvsId != input.EvsId || (this.EvsId != null && !this.EvsId.Equals(input.EvsId))) return false;

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
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.EvsType.GetHashCode();
                if (this.EvsId != null) hashCode = hashCode * 59 + this.EvsId.GetHashCode();
                return hashCode;
            }
        }
    }
}
