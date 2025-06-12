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
    /// 图层位置配置。
    /// </summary>
    public class LayerPositionConfig 
    {

        /// <summary>
        /// **参数解释**： 图层左上角像素点的X轴位置值（画布左上角坐标是0x0）。 横屏（16:9）画布像素为1920x1080；竖屏（9:16）画布像素为1080x1920。  **约束限制**： 该值为相对于画布的像素值，仅表示布局位置关系，与输出画面分辨率无关。
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dx { get; set; }

        /// <summary>
        /// **参数解释**： 图层图片左上角像素点的Y轴位置值（画布左上角坐标是0x0）。 横屏（16:9）画布像素为1920x1080；竖屏（9:16）画布像素为1080x1920。  **约束限制**： 该值为相对于画布的像素值，仅表示布局位置关系，与输出画面分辨率无关。
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dy { get; set; }

        /// <summary>
        /// **参数解释**： 图片、视频、人物图的层顺序。 &gt; 图层顺序为从1开始的整数，底层图层顺序是1，往上依次增加。  **约束限制**： 如果出现重复则重复图层叠加关系随机。
        /// </summary>
        [JsonProperty("layer_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? LayerIndex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerPositionConfig {\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  layerIndex: ").Append(LayerIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LayerPositionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LayerPositionConfig input)
        {
            if (input == null) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.LayerIndex != input.LayerIndex || (this.LayerIndex != null && !this.LayerIndex.Equals(input.LayerIndex))) return false;

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
                if (this.LayerIndex != null) hashCode = hashCode * 59 + this.LayerIndex.GetHashCode();
                return hashCode;
            }
        }
    }
}
