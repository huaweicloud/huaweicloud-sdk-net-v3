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
    /// 图层大小配置。
    /// </summary>
    public class LayerSizeConfig 
    {

        /// <summary>
        /// **参数解释**： 图层图片左上角像素点的Y轴位置值图层图片宽度像素值（相对画布大小）。 横屏（16:9）画布像素为1920x1080；竖屏（9:16）画布像素为1080x1920。  **约束限制**： 该值为相对于画布的像素值，仅表示布局位置关系，与输出画面分辨率无关。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// **参数解释**： 图层图片高度像素值（相对画布大小）。 横屏（16:9）画布像素为1920x1080；竖屏（9:16）画布像素为1080x1920。  **约束限制**： 该值为相对于画布的像素值，仅表示布局位置关系，与输出画面分辨率无关。|
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerSizeConfig {\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LayerSizeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LayerSizeConfig input)
        {
            if (input == null) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;

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
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                return hashCode;
            }
        }
    }
}
