using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 保存租户级tts自定义读法配置请求
    /// </summary>
    public class SaveTtscVocabularyConfigsRequestBody 
    {
        /// <summary>
        /// 支持配置的自定义读法类型。当前读法类型会映射为SSML标签，详见[文本驱动SSML定义](metastudio_02_0038.xml)。  包含如下选项： * CHINESE_G2P：拼音 * PHONETIC_SYMBOL：音标 * CONTINUUM：连读 * ALIAS：别名 * SAY_AS：数字/英文的读法。不同value值有不同的读法，详情如下所示。   数字的读法包括：   - date：读日期   - number：读数字   - figure：读数值   - telephone：读电话    英文的读法包括：   - spell：读字母   - english：读单词
        /// </summary>
        /// <value>支持配置的自定义读法类型。当前读法类型会映射为SSML标签，详见[文本驱动SSML定义](metastudio_02_0038.xml)。  包含如下选项： * CHINESE_G2P：拼音 * PHONETIC_SYMBOL：音标 * CONTINUUM：连读 * ALIAS：别名 * SAY_AS：数字/英文的读法。不同value值有不同的读法，详情如下所示。   数字的读法包括：   - date：读日期   - number：读数字   - figure：读数值   - telephone：读电话    英文的读法包括：   - spell：读字母   - english：读单词</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum CHINESE_G2P for value: CHINESE_G2P
            /// </summary>
            public static readonly TypeEnum CHINESE_G2P = new TypeEnum("CHINESE_G2P");

            /// <summary>
            /// Enum PHONETIC_SYMBOL for value: PHONETIC_SYMBOL
            /// </summary>
            public static readonly TypeEnum PHONETIC_SYMBOL = new TypeEnum("PHONETIC_SYMBOL");

            /// <summary>
            /// Enum CONTINUUM for value: CONTINUUM
            /// </summary>
            public static readonly TypeEnum CONTINUUM = new TypeEnum("CONTINUUM");

            /// <summary>
            /// Enum ALIAS for value: ALIAS
            /// </summary>
            public static readonly TypeEnum ALIAS = new TypeEnum("ALIAS");

            /// <summary>
            /// Enum SAY_AS for value: SAY_AS
            /// </summary>
            public static readonly TypeEnum SAY_AS = new TypeEnum("SAY_AS");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "CHINESE_G2P", CHINESE_G2P },
                { "PHONETIC_SYMBOL", PHONETIC_SYMBOL },
                { "CONTINUUM", CONTINUUM },
                { "ALIAS", ALIAS },
                { "SAY_AS", SAY_AS },
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
                if (System.Object.ReferenceEquals(a, b))
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
        /// 支持配置的自定义读法类型。当前读法类型会映射为SSML标签，详见[文本驱动SSML定义](metastudio_02_0038.xml)。  包含如下选项： * CHINESE_G2P：拼音 * PHONETIC_SYMBOL：音标 * CONTINUUM：连读 * ALIAS：别名 * SAY_AS：数字/英文的读法。不同value值有不同的读法，详情如下所示。   数字的读法包括：   - date：读日期   - number：读数字   - figure：读数值   - telephone：读电话    英文的读法包括：   - spell：读字母   - english：读单词
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 原始词。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 自定义读法。其中，音标的读法请参考[词典](https://www.youdao.com/)。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveTtscVocabularyConfigsRequestBody {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaveTtscVocabularyConfigsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SaveTtscVocabularyConfigsRequestBody input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
