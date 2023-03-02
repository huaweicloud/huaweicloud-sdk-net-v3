using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 字体描边配置
    /// </summary>
    public class VideoTranslateInferenceRewriteConfigStroke 
    {

        /// <summary>
        /// 文本描边颜色
        /// </summary>
        [JsonProperty("stroke_color", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> StrokeColor { get; set; }

        /// <summary>
        /// 文本字体颜色
        /// </summary>
        [JsonProperty("font_color", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FontColor { get; set; }

        /// <summary>
        /// 描边宽度
        /// </summary>
        [JsonProperty("stroke_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public float? StrokeRatio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoTranslateInferenceRewriteConfigStroke {\n");
            sb.Append("  strokeColor: ").Append(StrokeColor).Append("\n");
            sb.Append("  fontColor: ").Append(FontColor).Append("\n");
            sb.Append("  strokeRatio: ").Append(StrokeRatio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoTranslateInferenceRewriteConfigStroke);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoTranslateInferenceRewriteConfigStroke input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StrokeColor == input.StrokeColor ||
                    this.StrokeColor != null &&
                    input.StrokeColor != null &&
                    this.StrokeColor.SequenceEqual(input.StrokeColor)
                ) && 
                (
                    this.FontColor == input.FontColor ||
                    this.FontColor != null &&
                    input.FontColor != null &&
                    this.FontColor.SequenceEqual(input.FontColor)
                ) && 
                (
                    this.StrokeRatio == input.StrokeRatio ||
                    (this.StrokeRatio != null &&
                    this.StrokeRatio.Equals(input.StrokeRatio))
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
                if (this.StrokeColor != null)
                    hashCode = hashCode * 59 + this.StrokeColor.GetHashCode();
                if (this.FontColor != null)
                    hashCode = hashCode * 59 + this.FontColor.GetHashCode();
                if (this.StrokeRatio != null)
                    hashCode = hashCode * 59 + this.StrokeRatio.GetHashCode();
                return hashCode;
            }
        }
    }
}
