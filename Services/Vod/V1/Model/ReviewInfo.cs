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
    /// 审核信息数组。  &gt; 仅当审核成功后才能查询到此信息，未审核、正在审核以及审核失败时，无此字段信息。
    /// </summary>
    public class ReviewInfo 
    {
        /// <summary>
        /// 检测结果是否通过。  取值如下： - block：包含敏感信息，不通过。 - pass：不包含敏感信息，通过。 - review：需要人工复检。  &gt; 当同时检测多个场景时，suggestion的值以最可能包含敏感信息的场景为准。即任一场景出现了block则总的suggestion为block，所有场景都pass时suggestion为pass，这两种情况之外则一定有场景需要review，此时suggestion为review。
        /// </summary>
        /// <value>检测结果是否通过。  取值如下： - block：包含敏感信息，不通过。 - pass：不包含敏感信息，通过。 - review：需要人工复检。  &gt; 当同时检测多个场景时，suggestion的值以最可能包含敏感信息的场景为准。即任一场景出现了block则总的suggestion为block，所有场景都pass时suggestion为pass，这两种情况之外则一定有场景需要review，此时suggestion为review。</value>
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

            private string Value;

            public SuggestionEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 检测结果是否通过。  取值如下： - block：包含敏感信息，不通过。 - pass：不包含敏感信息，通过。 - review：需要人工复检。  &gt; 当同时检测多个场景时，suggestion的值以最可能包含敏感信息的场景为准。即任一场景出现了block则总的suggestion为block，所有场景都pass时suggestion为pass，这两种情况之外则一定有场景需要review，此时suggestion为review。
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public SuggestionEnum Suggestion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public TextReviewRet Text { get; set; }

        /// <summary>
        /// 封面检测结果。
        /// </summary>
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public List<PictureReviewRet> Cover { get; set; }

        /// <summary>
        /// 视频检测结果。
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public List<PictureReviewRet> Video { get; set; }

        /// <summary>
        /// 执行情况描述。
        /// </summary>
        [JsonProperty("exec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecDesc { get; set; }

        /// <summary>
        /// 审核状态。  取值如下： - UN_REVIEW：未审核 - REVIEWING：审核中 - REVIEW_SUSPICIOUS：审核可疑，需要人工审核 - REVIEW_PASSED：审核通过 - REVIEW_FAILED：审核失败。 - REVIEW_BLOCKED：已屏蔽。
        /// </summary>
        [JsonProperty("review_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewInfo {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  cover: ").Append(Cover).Append("\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  execDesc: ").Append(ExecDesc).Append("\n");
            sb.Append("  reviewStatus: ").Append(ReviewStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewInfo input)
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
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Cover == input.Cover ||
                    this.Cover != null &&
                    input.Cover != null &&
                    this.Cover.SequenceEqual(input.Cover)
                ) && 
                (
                    this.Video == input.Video ||
                    this.Video != null &&
                    input.Video != null &&
                    this.Video.SequenceEqual(input.Video)
                ) && 
                (
                    this.ExecDesc == input.ExecDesc ||
                    (this.ExecDesc != null &&
                    this.ExecDesc.Equals(input.ExecDesc))
                ) && 
                (
                    this.ReviewStatus == input.ReviewStatus ||
                    (this.ReviewStatus != null &&
                    this.ReviewStatus.Equals(input.ReviewStatus))
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
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Cover != null)
                    hashCode = hashCode * 59 + this.Cover.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.ExecDesc != null)
                    hashCode = hashCode * 59 + this.ExecDesc.GetHashCode();
                if (this.ReviewStatus != null)
                    hashCode = hashCode * 59 + this.ReviewStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
