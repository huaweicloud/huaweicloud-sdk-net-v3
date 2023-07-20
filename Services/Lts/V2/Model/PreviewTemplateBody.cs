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
    /// 预览邮件格式请求体
    /// </summary>
    public class PreviewTemplateBody 
    {
        /// <summary>
        /// 语言 zh-cn中文，en-us英文
        /// </summary>
        /// <value>语言 zh-cn中文，en-us英文</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly LanguageEnum ZH_CN = new LanguageEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly LanguageEnum EN_US = new LanguageEnum("en-us");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
            };

            private string _value;

            public LanguageEnum()
            {

            }

            public LanguageEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 邮件模板内容
        /// </summary>
        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public string Templates { get; set; }

        /// <summary>
        /// 语言 zh-cn中文，en-us英文
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 来源，只能填LTS
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviewTemplateBody {\n");
            sb.Append("  templates: ").Append(Templates).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreviewTemplateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreviewTemplateBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Templates == input.Templates ||
                    (this.Templates != null &&
                    this.Templates.Equals(input.Templates))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Templates != null)
                    hashCode = hashCode * 59 + this.Templates.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                return hashCode;
            }
        }
    }
}
