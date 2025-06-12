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
    /// 
    /// </summary>
    public class SmartChatVideoConfig 
    {

        /// <summary>
        /// 视频宽度。  单位：像素。  最小值320，最大值2560。 &gt; * clip_mode&#x3D;RESIZE时，当前支持1920x1080、1080x1920、1280x720、720x1280、3840x2160、2160x3840六种分辨率。4K分辨率视频需要分身数字人模型支持4K的情况下才能使用。 &gt; * clip_mode&#x3D;CROP，裁剪后视频，（dx,dy）为原点，保留视频像宽度为width。 &gt; * 分身数字人直播目前只支持1080x1920。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度。  单位：像素。  最小值320，最大值2560。 &gt; * clip_mode&#x3D;RESIZE时，当前支持1920x1080、1080x1920、1280x720、720x1280、3840x2160、2160x3840六种分辨率分辨率。 &gt; * clip_mode&#x3D;CROP，裁剪后视频，（dx,dy）为原点，保留视频像高度为height。 &gt; * 分身数字人直播目前只支持1080x1920。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartChatVideoConfig {\n");
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
            return this.Equals(input as SmartChatVideoConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartChatVideoConfig input)
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
