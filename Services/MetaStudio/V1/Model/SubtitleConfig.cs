using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 字幕配置。
    /// </summary>
    public class SubtitleConfig 
    {

        /// <summary>
        /// **参数解释**： 字幕框左下角像素点坐标。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dx { get; set; }

        /// <summary>
        /// **参数解释**： 字幕框左下角像素点坐标。 **约束限制**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dy { get; set; }

        /// <summary>
        /// **参数解释**： 字幕框高度。 **约束限制**： 参数h用于方便前端计算字幕框左上角坐标，后台不使用该参数。
        /// </summary>
        [JsonProperty("h", NullValueHandling = NullValueHandling.Ignore)]
        public int? H { get; set; }

        /// <summary>
        /// **参数解释**： 字幕框宽度。 **约束限制**： * 字幕框宽度固定为屏幕宽度的80% * 参数w用于方便前端计算字幕框左上角坐标，后台不使用该参数
        /// </summary>
        [JsonProperty("w", NullValueHandling = NullValueHandling.Ignore)]
        public int? W { get; set; }

        /// <summary>
        /// **参数解释**： 字体。当前支持的字体请参考[服务支持的字体](metastudio_02_0041.xml) **约束限制**： 不涉及。 **取值范围**： 字符长度0-64位
        /// </summary>
        [JsonProperty("font_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FontName { get; set; }

        /// <summary>
        /// **参数解释**： 字体大小。接口的取值范围为0-120，实际业务使用的取值范围要求为24-120，请以业务实际使用要求为准。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("font_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FontSize { get; set; }

        /// <summary>
        /// **参数解释**： 字幕字体颜色的RGB颜色值。 **约束限制**： 无 **取值范围**： 字符长度0-7位，固定长度
        /// </summary>
        [JsonProperty("font_color", NullValueHandling = NullValueHandling.Ignore)]
        public string FontColor { get; set; }

        /// <summary>
        /// **参数解释**： 字幕字体描边颜色的RGB颜色值。 **约束限制**： 无 **取值范围**： 字符长度0-7位，固定长度
        /// </summary>
        [JsonProperty("stroke_color", NullValueHandling = NullValueHandling.Ignore)]
        public string StrokeColor { get; set; }

        /// <summary>
        /// **参数解释**： 字幕字体描边粗细像素值。 **约束限制**： 无 **取值范围**： 0-50
        /// </summary>
        [JsonProperty("stroke_thickness", NullValueHandling = NullValueHandling.Ignore)]
        public float? StrokeThickness { get; set; }

        /// <summary>
        /// **参数解释**： 字幕字体不透明度，0表示完全透明，1表示完全不透明。默认1。 **约束限制**： 无 **取值范围**： 0-1
        /// </summary>
        [JsonProperty("opacity", NullValueHandling = NullValueHandling.Ignore)]
        public float? Opacity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubtitleConfig {\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  h: ").Append(H).Append("\n");
            sb.Append("  w: ").Append(W).Append("\n");
            sb.Append("  fontName: ").Append(FontName).Append("\n");
            sb.Append("  fontSize: ").Append(FontSize).Append("\n");
            sb.Append("  fontColor: ").Append(FontColor).Append("\n");
            sb.Append("  strokeColor: ").Append(StrokeColor).Append("\n");
            sb.Append("  strokeThickness: ").Append(StrokeThickness).Append("\n");
            sb.Append("  opacity: ").Append(Opacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubtitleConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubtitleConfig input)
        {
            if (input == null) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.H != input.H || (this.H != null && !this.H.Equals(input.H))) return false;
            if (this.W != input.W || (this.W != null && !this.W.Equals(input.W))) return false;
            if (this.FontName != input.FontName || (this.FontName != null && !this.FontName.Equals(input.FontName))) return false;
            if (this.FontSize != input.FontSize || (this.FontSize != null && !this.FontSize.Equals(input.FontSize))) return false;
            if (this.FontColor != input.FontColor || (this.FontColor != null && !this.FontColor.Equals(input.FontColor))) return false;
            if (this.StrokeColor != input.StrokeColor || (this.StrokeColor != null && !this.StrokeColor.Equals(input.StrokeColor))) return false;
            if (this.StrokeThickness != input.StrokeThickness || (this.StrokeThickness != null && !this.StrokeThickness.Equals(input.StrokeThickness))) return false;
            if (this.Opacity != input.Opacity || (this.Opacity != null && !this.Opacity.Equals(input.Opacity))) return false;

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
                if (this.Dx != null) hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null) hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.H != null) hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.W != null) hashCode = hashCode * 59 + this.W.GetHashCode();
                if (this.FontName != null) hashCode = hashCode * 59 + this.FontName.GetHashCode();
                if (this.FontSize != null) hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.FontColor != null) hashCode = hashCode * 59 + this.FontColor.GetHashCode();
                if (this.StrokeColor != null) hashCode = hashCode * 59 + this.StrokeColor.GetHashCode();
                if (this.StrokeThickness != null) hashCode = hashCode * 59 + this.StrokeThickness.GetHashCode();
                if (this.Opacity != null) hashCode = hashCode * 59 + this.Opacity.GetHashCode();
                return hashCode;
            }
        }
    }
}
