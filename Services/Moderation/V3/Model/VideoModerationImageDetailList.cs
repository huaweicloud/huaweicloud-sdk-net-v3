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
    /// 
    /// </summary>
    public class VideoModerationImageDetailList 
    {
        /// <summary>
        /// 检测结果的一级标签。 支持category列表如下： politics: 涉政  terrorism: 暴恐  porn: 色情  image_text: 图文审核
        /// </summary>
        /// <value>检测结果的一级标签。 支持category列表如下： politics: 涉政  terrorism: 暴恐  porn: 色情  image_text: 图文审核</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum POLITICS for value: politics
            /// </summary>
            public static readonly CategoryEnum POLITICS = new CategoryEnum("politics");

            /// <summary>
            /// Enum TERRORISM for value: terrorism
            /// </summary>
            public static readonly CategoryEnum TERRORISM = new CategoryEnum("terrorism");

            /// <summary>
            /// Enum PORN for value: porn
            /// </summary>
            public static readonly CategoryEnum PORN = new CategoryEnum("porn");

            /// <summary>
            /// Enum IMAGE_TEXT for value: image_text
            /// </summary>
            public static readonly CategoryEnum IMAGE_TEXT = new CategoryEnum("image_text");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "politics", POLITICS },
                { "terrorism", TERRORISM },
                { "porn", PORN },
                { "image_text", IMAGE_TEXT },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
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

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 审核结果是否通过。  block：包含敏感信息，不通过  review：需要人工复检
        /// </summary>
        /// <value>审核结果是否通过。  block：包含敏感信息，不通过  review：需要人工复检</value>
        [JsonConverter(typeof(EnumClassConverter<SuggestionEnum>))]
        public class SuggestionEnum
        {
            /// <summary>
            /// Enum BLOCK for value: block
            /// </summary>
            public static readonly SuggestionEnum BLOCK = new SuggestionEnum("block");

            /// <summary>
            /// Enum REVIEW for value: review
            /// </summary>
            public static readonly SuggestionEnum REVIEW = new SuggestionEnum("review");

            private static readonly Dictionary<string, SuggestionEnum> StaticFields =
            new Dictionary<string, SuggestionEnum>()
            {
                { "block", BLOCK },
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
        /// 置信度，可选值在0-1之间，值越大，可信度越高。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 检测结果的一级标签。 支持category列表如下： politics: 涉政  terrorism: 暴恐  porn: 色情  image_text: 图文审核
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// 审核结果是否通过。  block：包含敏感信息，不通过  review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public SuggestionEnum Suggestion { get; set; }
        /// <summary>
        /// 识别的详细标签。
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("face_location", NullValueHandling = NullValueHandling.Ignore)]
        public VideoModerationImageDetailListFaceLocation FaceLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qr_location", NullValueHandling = NullValueHandling.Ignore)]
        public VideoModerationImageDetailListQrLocation QrLocation { get; set; }

        /// <summary>
        /// 图片中二维码指向的链接，当请求参数categories中包含image_text时存在。
        /// </summary>
        [JsonProperty("qr_content", NullValueHandling = NullValueHandling.Ignore)]
        public string QrContent { get; set; }

        /// <summary>
        /// image_text场景下命中的文本片段。
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<VideoModerationDetailSegment> Segments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoModerationImageDetailList {\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  faceLocation: ").Append(FaceLocation).Append("\n");
            sb.Append("  qrLocation: ").Append(QrLocation).Append("\n");
            sb.Append("  qrContent: ").Append(QrContent).Append("\n");
            sb.Append("  segments: ").Append(Segments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoModerationImageDetailList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoModerationImageDetailList input)
        {
            if (input == null) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.Category != input.Category) return false;
            if (this.Suggestion != input.Suggestion) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.FaceLocation != input.FaceLocation || (this.FaceLocation != null && !this.FaceLocation.Equals(input.FaceLocation))) return false;
            if (this.QrLocation != input.QrLocation || (this.QrLocation != null && !this.QrLocation.Equals(input.QrLocation))) return false;
            if (this.QrContent != input.QrContent || (this.QrContent != null && !this.QrContent.Equals(input.QrContent))) return false;
            if (this.Segments != input.Segments || (this.Segments != null && input.Segments != null && !this.Segments.SequenceEqual(input.Segments))) return false;

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
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.FaceLocation != null) hashCode = hashCode * 59 + this.FaceLocation.GetHashCode();
                if (this.QrLocation != null) hashCode = hashCode * 59 + this.QrLocation.GetHashCode();
                if (this.QrContent != null) hashCode = hashCode * 59 + this.QrContent.GetHashCode();
                if (this.Segments != null) hashCode = hashCode * 59 + this.Segments.GetHashCode();
                return hashCode;
            }
        }
    }
}
