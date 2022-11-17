using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageDetectionResultDetailPolitics 
    {

        /// <summary>
        /// 置信度，取值范围 0-1。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }

        /// <summary>
        /// 对应的政治人物信息。
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("face_detail", NullValueHandling = NullValueHandling.Ignore)]
        public ImageDetectionResultDetailFaceDetail FaceDetail { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageDetectionResultDetailPolitics {\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  faceDetail: ").Append(FaceDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageDetectionResultDetailPolitics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageDetectionResultDetailPolitics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.FaceDetail == input.FaceDetail ||
                    (this.FaceDetail != null &&
                    this.FaceDetail.Equals(input.FaceDetail))
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
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.FaceDetail != null)
                    hashCode = hashCode * 59 + this.FaceDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
