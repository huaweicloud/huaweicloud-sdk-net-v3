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
    public class SmartChatSubtitleConfig 
    {

        /// <summary>
        /// 字幕左上角像素点坐标。  &gt; *横屏（16:9）视频像素为1920x1080；竖屏（9:16）视频像素为1080x1920。
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dx { get; set; }

        /// <summary>
        /// 字幕左上角像素点坐标。  &gt; *横屏（16:9）视频像素为1920x1080；竖屏（9:16）视频像素为1080x1920。
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dy { get; set; }

        /// <summary>
        /// 图层图片宽度像素值（相对画布大小）。 &gt; 横屏（16:9）画布像素为1920x1080；竖屏（9:16）画布像素为1080x1920。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 图层图片高度像素值（相对画布大小）。 &gt; 横屏（16:9）画布像素为1920x1080；竖屏（9:16）画布像素为1080x1920。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartChatSubtitleConfig {\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
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
            return this.Equals(input as SmartChatSubtitleConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartChatSubtitleConfig input)
        {
            if (input == null) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
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
                if (this.Dx != null) hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null) hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                return hashCode;
            }
        }
    }
}
