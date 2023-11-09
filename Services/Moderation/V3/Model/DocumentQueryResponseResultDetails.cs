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
    public class DocumentQueryResponseResultDetails 
    {

        /// <summary>
        /// 当前内容片段的处置建议： block：包含敏感信息，不通过 review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 当前内容片段的类型，可取值有： text: 文本 image: 图像 video: 视频
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 当前内容片段的风险类型： politics：涉政 terrorism：暴恐 porn：色情 sexy：性感 abuse：辱骂 ad：广告 qr_code：二维码 watermark：水印 meaningless：无意义 ban：违禁 bad_scene：不良场景 moan：娇喘
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 当前处理的片段索引
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }

        /// <summary>
        /// 当前内容片段中的文本内容
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 命中的风险片段信息列表，仅在有命中敏感词时才返回
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<DocumentQueryResponseResultSegments> Segments { get; set; }

        /// <summary>
        /// 网页视频中截帧部分审核详情
        /// </summary>
        [JsonProperty("video_image_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<DocumentVideoImageDetail> VideoImageDetails { get; set; }

        /// <summary>
        /// 网页视频中音频部分审核详情
        /// </summary>
        [JsonProperty("audio_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<DocumentAudioDetail> AudioDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentQueryResponseResultDetails {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  segments: ").Append(Segments).Append("\n");
            sb.Append("  videoImageDetails: ").Append(VideoImageDetails).Append("\n");
            sb.Append("  audioDetails: ").Append(AudioDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentQueryResponseResultDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentQueryResponseResultDetails input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    input.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
                ) && 
                (
                    this.VideoImageDetails == input.VideoImageDetails ||
                    this.VideoImageDetails != null &&
                    input.VideoImageDetails != null &&
                    this.VideoImageDetails.SequenceEqual(input.VideoImageDetails)
                ) && 
                (
                    this.AudioDetails == input.AudioDetails ||
                    this.AudioDetails != null &&
                    input.AudioDetails != null &&
                    this.AudioDetails.SequenceEqual(input.AudioDetails)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.VideoImageDetails != null)
                    hashCode = hashCode * 59 + this.VideoImageDetails.GetHashCode();
                if (this.AudioDetails != null)
                    hashCode = hashCode * 59 + this.AudioDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
