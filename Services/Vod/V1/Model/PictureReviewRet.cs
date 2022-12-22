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
    /// 图片审核结果
    /// </summary>
    public class PictureReviewRet 
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
        /// 截图在视频中的时间偏移值。封面不涉及此字段  单位：秒。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 对应截图/封面的访问URL。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 政治因素审核结果。
        /// </summary>
        [JsonProperty("politics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewDetail> Politics { get; set; }

        /// <summary>
        /// 暴恐元素审核结果。
        /// </summary>
        [JsonProperty("terrorism", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewDetail> Terrorism { get; set; }

        /// <summary>
        /// 涉黄内容审核结果。
        /// </summary>
        [JsonProperty("porn", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewDetail> Porn { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PictureReviewRet {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  politics: ").Append(Politics).Append("\n");
            sb.Append("  terrorism: ").Append(Terrorism).Append("\n");
            sb.Append("  porn: ").Append(Porn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PictureReviewRet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PictureReviewRet input)
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
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Politics == input.Politics ||
                    this.Politics != null &&
                    input.Politics != null &&
                    this.Politics.SequenceEqual(input.Politics)
                ) && 
                (
                    this.Terrorism == input.Terrorism ||
                    this.Terrorism != null &&
                    input.Terrorism != null &&
                    this.Terrorism.SequenceEqual(input.Terrorism)
                ) && 
                (
                    this.Porn == input.Porn ||
                    this.Porn != null &&
                    input.Porn != null &&
                    this.Porn.SequenceEqual(input.Porn)
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Politics != null)
                    hashCode = hashCode * 59 + this.Politics.GetHashCode();
                if (this.Terrorism != null)
                    hashCode = hashCode * 59 + this.Terrorism.GetHashCode();
                if (this.Porn != null)
                    hashCode = hashCode * 59 + this.Porn.GetHashCode();
                return hashCode;
            }
        }
    }
}
