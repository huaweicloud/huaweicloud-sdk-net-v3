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
    public class VideoModerationResultResult 
    {
        /// <summary>
        /// 视频审核结果是否通过。 block：包含敏感信息，不通过  review：需要人工复检 pass：不包含敏感信息，通过
        /// </summary>
        /// <value>视频审核结果是否通过。 block：包含敏感信息，不通过  review：需要人工复检 pass：不包含敏感信息，通过</value>
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
        /// 视频审核结果是否通过。 block：包含敏感信息，不通过  review：需要人工复检 pass：不包含敏感信息，通过
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public SuggestionEnum Suggestion { get; set; }
        /// <summary>
        /// 图像审核详情
        /// </summary>
        [JsonProperty("image_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoModerationImageDetail> ImageDetail { get; set; }

        /// <summary>
        /// 音频审核详情
        /// </summary>
        [JsonProperty("audio_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoModerationVideoDetail> AudioDetail { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoModerationResultResult {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  imageDetail: ").Append(ImageDetail).Append("\n");
            sb.Append("  audioDetail: ").Append(AudioDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoModerationResultResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoModerationResultResult input)
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
                    this.ImageDetail == input.ImageDetail ||
                    this.ImageDetail != null &&
                    input.ImageDetail != null &&
                    this.ImageDetail.SequenceEqual(input.ImageDetail)
                ) && 
                (
                    this.AudioDetail == input.AudioDetail ||
                    this.AudioDetail != null &&
                    input.AudioDetail != null &&
                    this.AudioDetail.SequenceEqual(input.AudioDetail)
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
                if (this.ImageDetail != null)
                    hashCode = hashCode * 59 + this.ImageDetail.GetHashCode();
                if (this.AudioDetail != null)
                    hashCode = hashCode * 59 + this.AudioDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
