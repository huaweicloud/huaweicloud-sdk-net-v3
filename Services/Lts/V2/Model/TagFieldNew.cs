using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Tag字段对象
    /// </summary>
    public class TagFieldNew 
    {
        /// <summary>
        /// 字段数据类型。 可选范围：string、long、float
        /// </summary>
        /// <value>字段数据类型。 可选范围：string、long、float</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly TypeEnum STRING = new TypeEnum("string");

            /// <summary>
            /// Enum LONG for value: long
            /// </summary>
            public static readonly TypeEnum LONG = new TypeEnum("long");

            /// <summary>
            /// Enum FLOAT for value: float
            /// </summary>
            public static readonly TypeEnum FLOAT = new TypeEnum("float");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "string", STRING },
                { "long", LONG },
                { "float", FLOAT },
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
        /// 字段名称
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段示例内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 字段数据类型。 可选范围：string、long、float
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 是否开启快速分析
        /// </summary>
        [JsonProperty("is_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnalysis { get; set; }

        /// <summary>
        /// 序号，从0开始
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagFieldNew {\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isAnalysis: ").Append(IsAnalysis).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagFieldNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagFieldNew input)
        {
            if (input == null) return false;
            if (this.FieldName != input.FieldName || (this.FieldName != null && !this.FieldName.Equals(input.FieldName))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Type != input.Type) return false;
            if (this.IsAnalysis != input.IsAnalysis || (this.IsAnalysis != null && !this.IsAnalysis.Equals(input.IsAnalysis))) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;

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
                if (this.FieldName != null) hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsAnalysis != null) hashCode = hashCode * 59 + this.IsAnalysis.GetHashCode();
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                return hashCode;
            }
        }
    }
}
