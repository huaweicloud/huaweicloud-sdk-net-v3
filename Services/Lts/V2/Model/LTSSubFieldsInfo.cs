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
    /// json子字段信息
    /// </summary>
    public class LTSSubFieldsInfo 
    {
        /// <summary>
        /// 字段类型
        /// </summary>
        /// <value>字段类型</value>
        [JsonConverter(typeof(EnumClassConverter<FieldTypeEnum>))]
        public class FieldTypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly FieldTypeEnum STRING = new FieldTypeEnum("string");

            /// <summary>
            /// Enum LONG for value: long
            /// </summary>
            public static readonly FieldTypeEnum LONG = new FieldTypeEnum("long");

            /// <summary>
            /// Enum FLOAT for value: float
            /// </summary>
            public static readonly FieldTypeEnum FLOAT = new FieldTypeEnum("float");

            private static readonly Dictionary<string, FieldTypeEnum> StaticFields =
            new Dictionary<string, FieldTypeEnum>()
            {
                { "string", STRING },
                { "long", LONG },
                { "float", FLOAT },
            };

            private string _value;

            public FieldTypeEnum()
            {

            }

            public FieldTypeEnum(string value)
            {
                _value = value;
            }

            public static FieldTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FieldTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FieldTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FieldTypeEnum a, FieldTypeEnum b)
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

            public static bool operator !=(FieldTypeEnum a, FieldTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("fieldType", NullValueHandling = NullValueHandling.Ignore)]
        public FieldTypeEnum FieldType { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("fieldName", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 是否大小写敏感
        /// </summary>
        [JsonProperty("caseSensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// 是否包含中文
        /// </summary>
        [JsonProperty("includeChinese", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeChinese { get; set; }

        /// <summary>
        /// 分词符
        /// </summary>
        [JsonProperty("tokenizer", NullValueHandling = NullValueHandling.Ignore)]
        public string Tokenizer { get; set; }

        /// <summary>
        /// 是否快速分析
        /// </summary>
        [JsonProperty("quickAnalysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuickAnalysis { get; set; }

        /// <summary>
        /// 特殊分词符
        /// </summary>
        [JsonProperty("ascii", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ascii { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LTSSubFieldsInfo {\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  caseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  includeChinese: ").Append(IncludeChinese).Append("\n");
            sb.Append("  tokenizer: ").Append(Tokenizer).Append("\n");
            sb.Append("  quickAnalysis: ").Append(QuickAnalysis).Append("\n");
            sb.Append("  ascii: ").Append(Ascii).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LTSSubFieldsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LTSSubFieldsInfo input)
        {
            if (input == null) return false;
            if (this.FieldType != input.FieldType) return false;
            if (this.FieldName != input.FieldName || (this.FieldName != null && !this.FieldName.Equals(input.FieldName))) return false;
            if (this.CaseSensitive != input.CaseSensitive || (this.CaseSensitive != null && !this.CaseSensitive.Equals(input.CaseSensitive))) return false;
            if (this.IncludeChinese != input.IncludeChinese || (this.IncludeChinese != null && !this.IncludeChinese.Equals(input.IncludeChinese))) return false;
            if (this.Tokenizer != input.Tokenizer || (this.Tokenizer != null && !this.Tokenizer.Equals(input.Tokenizer))) return false;
            if (this.QuickAnalysis != input.QuickAnalysis || (this.QuickAnalysis != null && !this.QuickAnalysis.Equals(input.QuickAnalysis))) return false;
            if (this.Ascii != input.Ascii || (this.Ascii != null && input.Ascii != null && !this.Ascii.SequenceEqual(input.Ascii))) return false;

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
                hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldName != null) hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.CaseSensitive != null) hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.IncludeChinese != null) hashCode = hashCode * 59 + this.IncludeChinese.GetHashCode();
                if (this.Tokenizer != null) hashCode = hashCode * 59 + this.Tokenizer.GetHashCode();
                if (this.QuickAnalysis != null) hashCode = hashCode * 59 + this.QuickAnalysis.GetHashCode();
                if (this.Ascii != null) hashCode = hashCode * 59 + this.Ascii.GetHashCode();
                return hashCode;
            }
        }
    }
}
