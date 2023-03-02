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
    /// 回写配置
    /// </summary>
    public class VideoTranslateInferenceRewriteConfig 
    {

        /// <summary>
        /// 字体类型
        /// </summary>
        [JsonProperty("font_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FontType { get; set; }

        /// <summary>
        /// 字幕字体行间距
        /// </summary>
        [JsonProperty("rewrite_row_interval", NullValueHandling = NullValueHandling.Ignore)]
        public float? RewriteRowInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("stroke", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTranslateInferenceRewriteConfigStroke Stroke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("background", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTranslateInferenceRewriteConfigBackground Background { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoTranslateInferenceRewriteConfig {\n");
            sb.Append("  fontType: ").Append(FontType).Append("\n");
            sb.Append("  rewriteRowInterval: ").Append(RewriteRowInterval).Append("\n");
            sb.Append("  stroke: ").Append(Stroke).Append("\n");
            sb.Append("  background: ").Append(Background).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoTranslateInferenceRewriteConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoTranslateInferenceRewriteConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FontType == input.FontType ||
                    (this.FontType != null &&
                    this.FontType.Equals(input.FontType))
                ) && 
                (
                    this.RewriteRowInterval == input.RewriteRowInterval ||
                    (this.RewriteRowInterval != null &&
                    this.RewriteRowInterval.Equals(input.RewriteRowInterval))
                ) && 
                (
                    this.Stroke == input.Stroke ||
                    (this.Stroke != null &&
                    this.Stroke.Equals(input.Stroke))
                ) && 
                (
                    this.Background == input.Background ||
                    (this.Background != null &&
                    this.Background.Equals(input.Background))
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
                if (this.FontType != null)
                    hashCode = hashCode * 59 + this.FontType.GetHashCode();
                if (this.RewriteRowInterval != null)
                    hashCode = hashCode * 59 + this.RewriteRowInterval.GetHashCode();
                if (this.Stroke != null)
                    hashCode = hashCode * 59 + this.Stroke.GetHashCode();
                if (this.Background != null)
                    hashCode = hashCode * 59 + this.Background.GetHashCode();
                return hashCode;
            }
        }
    }
}
