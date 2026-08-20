using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 标签创建/编辑参数
    /// </summary>
    public class LabelParam 
    {
        /// <summary>
        /// 标签所属工作项类型，对应工作项的type字段，枚举类型。不推荐使用此参数，建议使用category_types参数。
        /// </summary>
        /// <value>标签所属工作项类型，对应工作项的type字段，枚举类型。不推荐使用此参数，建议使用category_types参数。</value>
        [JsonConverter(typeof(EnumClassConverter<LabelTypeEnum>))]
        public class LabelTypeEnum
        {
            /// <summary>
            /// Enum FEATURE for value: feature
            /// </summary>
            public static readonly LabelTypeEnum FEATURE = new LabelTypeEnum("feature");

            /// <summary>
            /// Enum RAW_REQUIREMENT for value: raw requirement
            /// </summary>
            public static readonly LabelTypeEnum RAW_REQUIREMENT = new LabelTypeEnum("raw requirement");

            /// <summary>
            /// Enum REQUIREMENT for value: requirement
            /// </summary>
            public static readonly LabelTypeEnum REQUIREMENT = new LabelTypeEnum("requirement");

            /// <summary>
            /// Enum TASK for value: task
            /// </summary>
            public static readonly LabelTypeEnum TASK = new LabelTypeEnum("task");

            /// <summary>
            /// Enum BUG for value: bug
            /// </summary>
            public static readonly LabelTypeEnum BUG = new LabelTypeEnum("bug");

            private static readonly Dictionary<string, LabelTypeEnum> StaticFields =
            new Dictionary<string, LabelTypeEnum>()
            {
                { "feature", FEATURE },
                { "raw requirement", RAW_REQUIREMENT },
                { "requirement", REQUIREMENT },
                { "task", TASK },
                { "bug", BUG },
            };

            private string _value;

            public LabelTypeEnum()
            {

            }

            public LabelTypeEnum(string value)
            {
                _value = value;
            }

            public static LabelTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LabelTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LabelTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LabelTypeEnum a, LabelTypeEnum b)
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

            public static bool operator !=(LabelTypeEnum a, LabelTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标签所属工作项类型，对应工作项的type字段，枚举类型。不推荐使用此参数，建议使用category_types参数。
        /// </summary>
        [JsonProperty("label_type", NullValueHandling = NullValueHandling.Ignore)]
        public LabelTypeEnum LabelType { get; set; }
        /// <summary>
        /// 标签颜色，作为更新参数时非必填。
        /// </summary>
        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        /// <summary>
        /// 标签标题。 1~30个字符。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 标签所属工作项类型编码。
        /// </summary>
        [JsonProperty("category_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CategoryTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelParam {\n");
            sb.Append("  labelType: ").Append(LabelType).Append("\n");
            sb.Append("  color: ").Append(Color).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  categoryTypes: ").Append(CategoryTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LabelParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LabelParam input)
        {
            if (input == null) return false;
            if (this.LabelType != input.LabelType) return false;
            if (this.Color != input.Color || (this.Color != null && !this.Color.Equals(input.Color))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.CategoryTypes != input.CategoryTypes || (this.CategoryTypes != null && input.CategoryTypes != null && !this.CategoryTypes.SequenceEqual(input.CategoryTypes))) return false;

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
                hashCode = hashCode * 59 + this.LabelType.GetHashCode();
                if (this.Color != null) hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.CategoryTypes != null) hashCode = hashCode * 59 + this.CategoryTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
