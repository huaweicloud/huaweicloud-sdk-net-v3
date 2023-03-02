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
    /// 背景框配置
    /// </summary>
    public class VideoTranslateInferenceRewriteConfigBackground 
    {

        /// <summary>
        /// 文本背景框颜色
        /// </summary>
        [JsonProperty("box_color", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> BoxColor { get; set; }

        /// <summary>
        /// 文本字体颜色
        /// </summary>
        [JsonProperty("background_font_color", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> BackgroundFontColor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoTranslateInferenceRewriteConfigBackground {\n");
            sb.Append("  boxColor: ").Append(BoxColor).Append("\n");
            sb.Append("  backgroundFontColor: ").Append(BackgroundFontColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoTranslateInferenceRewriteConfigBackground);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoTranslateInferenceRewriteConfigBackground input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoxColor == input.BoxColor ||
                    this.BoxColor != null &&
                    input.BoxColor != null &&
                    this.BoxColor.SequenceEqual(input.BoxColor)
                ) && 
                (
                    this.BackgroundFontColor == input.BackgroundFontColor ||
                    this.BackgroundFontColor != null &&
                    input.BackgroundFontColor != null &&
                    this.BackgroundFontColor.SequenceEqual(input.BackgroundFontColor)
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
                if (this.BoxColor != null)
                    hashCode = hashCode * 59 + this.BoxColor.GetHashCode();
                if (this.BackgroundFontColor != null)
                    hashCode = hashCode * 59 + this.BackgroundFontColor.GetHashCode();
                return hashCode;
            }
        }
    }
}
