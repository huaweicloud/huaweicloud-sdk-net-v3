using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PutUpdateVocabReq 
    {
        /// <summary>
        /// 热词表语言类型。 language取值范围： chinese_mandarin  汉语普通话
        /// </summary>
        /// <value>热词表语言类型。 language取值范围： chinese_mandarin  汉语普通话</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum CHINESE_MANDARIN for value: chinese_mandarin
            /// </summary>
            public static readonly LanguageEnum CHINESE_MANDARIN = new LanguageEnum("chinese_mandarin");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "chinese_mandarin", CHINESE_MANDARIN },
            };

            private string Value;

            public LanguageEnum(string value)
            {
                Value = value;
            }

            public static LanguageEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as LanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(LanguageEnum a, LanguageEnum b)
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 热词表名，不可重复。内容限制为字母，数字，下中划线和井号，长度不超过32字节。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 热词表描述，长度不超过255字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 热词表语言类型。 language取值范围： chinese_mandarin  汉语普通话
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 支持中英混编热词，单个热词只能由英文字母和unicode编码的汉字组成，不能有其他符号，包括空格。  单词库支持热词数上限1024。 单个热词长度上限32字节。
        /// </summary>
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Contents { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutUpdateVocabReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  contents: ").Append(Contents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutUpdateVocabReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutUpdateVocabReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Contents == input.Contents ||
                    this.Contents != null &&
                    input.Contents != null &&
                    this.Contents.SequenceEqual(input.Contents)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Contents != null)
                    hashCode = hashCode * 59 + this.Contents.GetHashCode();
                return hashCode;
            }
        }
    }
}
