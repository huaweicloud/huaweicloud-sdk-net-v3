using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 单文件下单侧检视意见详情。
    /// </summary>
    public class LineDiscussionDto 
    {
        /// <summary>
        /// **参数解释：** 所在的行的类型。 **取值范围：** old: 左侧删除行。 new: 右侧新增行。 unchanged-l: 左侧不变行。 unchanged-r: 右侧不变行。
        /// </summary>
        /// <value>**参数解释：** 所在的行的类型。 **取值范围：** old: 左侧删除行。 new: 右侧新增行。 unchanged-l: 左侧不变行。 unchanged-r: 右侧不变行。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum OLD for value: old
            /// </summary>
            public static readonly TypeEnum OLD = new TypeEnum("old");

            /// <summary>
            /// Enum NEW for value: new
            /// </summary>
            public static readonly TypeEnum NEW = new TypeEnum("new");

            /// <summary>
            /// Enum UNCHANGED_L for value: unchanged-l
            /// </summary>
            public static readonly TypeEnum UNCHANGED_L = new TypeEnum("unchanged-l");

            /// <summary>
            /// Enum UNCHANGED_R for value: unchanged-r
            /// </summary>
            public static readonly TypeEnum UNCHANGED_R = new TypeEnum("unchanged-r");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "old", OLD },
                { "new", NEW },
                { "unchanged-l", UNCHANGED_L },
                { "unchanged-r", UNCHANGED_R },
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
        /// **参数解释：** 位于某一侧某行的检视意见集合。
        /// </summary>
        [JsonProperty("discussions", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestBasicDiscussionDto> Discussions { get; set; }

        /// <summary>
        /// **参数解释：** 所在的行号。
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public int? Line { get; set; }

        /// <summary>
        /// **参数解释：** 所在的行的类型。 **取值范围：** old: 左侧删除行。 new: 右侧新增行。 unchanged-l: 左侧不变行。 unchanged-r: 右侧不变行。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineDiscussionDto {\n");
            sb.Append("  discussions: ").Append(Discussions).Append("\n");
            sb.Append("  line: ").Append(Line).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LineDiscussionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LineDiscussionDto input)
        {
            if (input == null) return false;
            if (this.Discussions != input.Discussions || (this.Discussions != null && input.Discussions != null && !this.Discussions.SequenceEqual(input.Discussions))) return false;
            if (this.Line != input.Line || (this.Line != null && !this.Line.Equals(input.Line))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.Discussions != null) hashCode = hashCode * 59 + this.Discussions.GetHashCode();
                if (this.Line != null) hashCode = hashCode * 59 + this.Line.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
