using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 作业审核结果，当作业状态为succeeded时存在
    /// </summary>
    public class AudioModerationResultResult 
    {
        /// <summary>
        /// 音频审核结果是否通过。 block：包含敏感信息，不通过 pass：不包含敏感信息，通过 review：需要人工复检
        /// </summary>
        /// <value>音频审核结果是否通过。 block：包含敏感信息，不通过 pass：不包含敏感信息，通过 review：需要人工复检</value>
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
        /// 音频审核结果是否通过。 block：包含敏感信息，不通过 pass：不包含敏感信息，通过 review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public SuggestionEnum Suggestion { get; set; }
        /// <summary>
        /// 审核详情
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioModerationResultDetail> Details { get; set; }

        /// <summary>
        /// 音频文本内容
        /// </summary>
        [JsonProperty("audio_text", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioModerationResultResult {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  details: ").Append(Details).Append("\n");
            sb.Append("  audioText: ").Append(AudioText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioModerationResultResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioModerationResultResult input)
        {
            if (input == null) return false;
            if (this.Suggestion != input.Suggestion) return false;
            if (this.Details != input.Details || (this.Details != null && input.Details != null && !this.Details.SequenceEqual(input.Details))) return false;
            if (this.AudioText != input.AudioText || (this.AudioText != null && !this.AudioText.Equals(input.AudioText))) return false;

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
                hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.Details != null) hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.AudioText != null) hashCode = hashCode * 59 + this.AudioText.GetHashCode();
                return hashCode;
            }
        }
    }
}
