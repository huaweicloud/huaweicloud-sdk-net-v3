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
    /// 返回结果的详细内容。
    /// </summary>
    public class ImageDetectionResultDetail 
    {

        /// <summary>
        /// 审核结果是否通过。 block：包含敏感信息，不通过 review：需要人工复检
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }

        /// <summary>
        /// 检测结果的一级标签。 支持category列表如下： politics: 涉政 terrorism: 暴恐 porn: 色情 image_text: 图文审核
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 置信度，可选值在0-1之间，值越大，可信度越高。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("face_location", NullValueHandling = NullValueHandling.Ignore)]
        public FaceLocationDetail FaceLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qr_location", NullValueHandling = NullValueHandling.Ignore)]
        public QRLocationDetail QrLocation { get; set; }

        /// <summary>
        /// 图片中二维码指向的链接，当请求参数categories中包含image_text时存在。
        /// </summary>
        [JsonProperty("qr_content", NullValueHandling = NullValueHandling.Ignore)]
        public string QrContent { get; set; }

        /// <summary>
        /// image_text场景下命中的文本片段。
        /// </summary>
        [JsonProperty("segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<OCRTextDetail> Segments { get; set; }

        /// <summary>
        /// 识别的详细标签。
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultDetail {\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  faceLocation: ").Append(FaceLocation).Append("\n");
            sb.Append("  qrLocation: ").Append(QrLocation).Append("\n");
            sb.Append("  qrContent: ").Append(QrContent).Append("\n");
            sb.Append("  segments: ").Append(Segments).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultDetail input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.FaceLocation == input.FaceLocation ||
                    (this.FaceLocation != null &&
                    this.FaceLocation.Equals(input.FaceLocation))
                ) && 
                (
                    this.QrLocation == input.QrLocation ||
                    (this.QrLocation != null &&
                    this.QrLocation.Equals(input.QrLocation))
                ) && 
                (
                    this.QrContent == input.QrContent ||
                    (this.QrContent != null &&
                    this.QrContent.Equals(input.QrContent))
                ) && 
                (
                    this.Segments == input.Segments ||
                    this.Segments != null &&
                    input.Segments != null &&
                    this.Segments.SequenceEqual(input.Segments)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.FaceLocation != null)
                    hashCode = hashCode * 59 + this.FaceLocation.GetHashCode();
                if (this.QrLocation != null)
                    hashCode = hashCode * 59 + this.QrLocation.GetHashCode();
                if (this.QrContent != null)
                    hashCode = hashCode * 59 + this.QrContent.GetHashCode();
                if (this.Segments != null)
                    hashCode = hashCode * 59 + this.Segments.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }
}
