using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 文本检测结果
    /// </summary>
    public class TextReviewRet 
    {
        /// <summary>
        /// 检测结果是否通过。  取值如下： - block：包含敏感信息，不通过。 - pass：不包含敏感信息，通过。 - review：需要人工复检。
        /// </summary>
        /// <value>检测结果是否通过。  取值如下： - block：包含敏感信息，不通过。 - pass：不包含敏感信息，通过。 - review：需要人工复检。</value>
        [JsonConverter(typeof(EnumClassConverter<SuggestionEnum>))]
        public class SuggestionEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly SuggestionEnum BLOCK = new SuggestionEnum("block");

            /// <summary>
            /// Enum PASS for value: pass
            /// </summary>
            public static readonly SuggestionEnum PASS = new SuggestionEnum("pass");

            /// <summary>
            /// Enum REVIEW for value: review
            /// </summary>
            public static readonly SuggestionEnum REVIEW = new SuggestionEnum("review");

            private static readonly Dictionary<string, SuggestionEnum> StaticFields =
            new Dictionary<string, SuggestionEnum>()
            {
                { "block", BLOCK },
                { "pass", PASS },
                { "review", REVIEW },
            };

            private string _value;

            public SuggestionEnum()
            {

            }

            public SuggestionEnum(string value)
            {
                _value = value;
            }

            public static SuggestionEnum FromValue(string value)
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

                if (this.Equals(obj as SuggestionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SuggestionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SuggestionEnum a, SuggestionEnum b)
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

            public static bool operator !=(SuggestionEnum a, SuggestionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 检测结果是否通过。  取值如下： - block：包含敏感信息，不通过。 - pass：不包含敏感信息，通过。 - review：需要人工复检。
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public SuggestionEnum Suggestion { get; set; }
        /// <summary>
        /// 涉政敏感词列表
        /// </summary>
        [JsonProperty("politics", NullValueHandling = NullValueHandling.Ignore)]
        public string Politics { get; set; }

        /// <summary>
        /// 涉黄敏感词列表
        /// </summary>
        [JsonProperty("porn", NullValueHandling = NullValueHandling.Ignore)]
        public string Porn { get; set; }

        /// <summary>
        /// 辱骂敏感词列表
        /// </summary>
        [JsonProperty("abuse", NullValueHandling = NullValueHandling.Ignore)]
        public string Abuse { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextReviewRet {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  politics: ").Append(Politics).Append("\n");
            sb.Append("  porn: ").Append(Porn).Append("\n");
            sb.Append("  abuse: ").Append(Abuse).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextReviewRet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextReviewRet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Suggestion == input.Suggestion ||
                    (this.Suggestion != null &&
                    this.Suggestion.Equals(input.Suggestion))
                ) && 
                (
                    this.Politics == input.Politics ||
                    (this.Politics != null &&
                    this.Politics.Equals(input.Politics))
                ) && 
                (
                    this.Porn == input.Porn ||
                    (this.Porn != null &&
                    this.Porn.Equals(input.Porn))
                ) && 
                (
                    this.Abuse == input.Abuse ||
                    (this.Abuse != null &&
                    this.Abuse.Equals(input.Abuse))
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
                if (this.Suggestion != null)
                    hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.Politics != null)
                    hashCode = hashCode * 59 + this.Politics.GetHashCode();
                if (this.Porn != null)
                    hashCode = hashCode * 59 + this.Porn.GetHashCode();
                if (this.Abuse != null)
                    hashCode = hashCode * 59 + this.Abuse.GetHashCode();
                return hashCode;
            }
        }
    }
}
