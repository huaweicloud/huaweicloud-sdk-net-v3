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
    /// 素材文字图层配置。
    /// </summary>
    public class TextLayerConfig 
    {

        /// <summary>
        /// **参数解释**： 文字图层的文本，内容需做Base64编码。  示例：若想添加文字水印“测试文字水印”，那么text_context的值为：5rWL6K+V5paH5a2X5rC05Y2w **约束限制**： 不涉及。 **取值范围**： 字符长度0-1024位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("text_context", NullValueHandling = NullValueHandling.Ignore)]
        public string TextContext { get; set; }

        /// <summary>
        /// 字体。当前支持的字体请参考[服务支持的字体](metastudio_02_0041.xml) **约束限制**： 不涉及。 **取值范围**： 字符长度0-64位
        /// </summary>
        [JsonProperty("font_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FontName { get; set; }

        /// <summary>
        /// **参数解释**： 字体大小（像素）。接口的取值范围为0-120，实际业务使用的取值范围要求为4-120，请以业务实际使用要求为准。  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("font_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FontSize { get; set; }

        /// <summary>
        /// **参数解释**： 字体颜色。RGB颜色值。  **约束限制**： 不涉及。 **取值范围**： 字符长度0-16位
        /// </summary>
        [JsonProperty("font_color", NullValueHandling = NullValueHandling.Ignore)]
        public string FontColor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextLayerConfig {\n");
            sb.Append("  textContext: ").Append(TextContext).Append("\n");
            sb.Append("  fontName: ").Append(FontName).Append("\n");
            sb.Append("  fontSize: ").Append(FontSize).Append("\n");
            sb.Append("  fontColor: ").Append(FontColor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextLayerConfig input)
        {
            if (input == null) return false;
            if (this.TextContext != input.TextContext || (this.TextContext != null && !this.TextContext.Equals(input.TextContext))) return false;
            if (this.FontName != input.FontName || (this.FontName != null && !this.FontName.Equals(input.FontName))) return false;
            if (this.FontSize != input.FontSize || (this.FontSize != null && !this.FontSize.Equals(input.FontSize))) return false;
            if (this.FontColor != input.FontColor || (this.FontColor != null && !this.FontColor.Equals(input.FontColor))) return false;

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
                if (this.TextContext != null) hashCode = hashCode * 59 + this.TextContext.GetHashCode();
                if (this.FontName != null) hashCode = hashCode * 59 + this.FontName.GetHashCode();
                if (this.FontSize != null) hashCode = hashCode * 59 + this.FontSize.GetHashCode();
                if (this.FontColor != null) hashCode = hashCode * 59 + this.FontColor.GetHashCode();
                return hashCode;
            }
        }
    }
}
