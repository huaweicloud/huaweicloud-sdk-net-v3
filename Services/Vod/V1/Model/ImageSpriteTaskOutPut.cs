using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageSpriteTaskOutPut 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_info", NullValueHandling = NullValueHandling.Ignore)]
        public ObsInfo ObsInfo { get; set; }

        /// <summary>
        /// 雪碧图的高度
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 雪碧图的宽度
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 雪碧图对象列表
        /// </summary>
        [JsonProperty("sprite_image_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SpriteImageList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSpriteTaskOutPut {\n");
            sb.Append("  obsInfo: ").Append(ObsInfo).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  spriteImageList: ").Append(SpriteImageList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageSpriteTaskOutPut);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageSpriteTaskOutPut input)
        {
            if (input == null) return false;
            if (this.ObsInfo != input.ObsInfo || (this.ObsInfo != null && !this.ObsInfo.Equals(input.ObsInfo))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.SpriteImageList != input.SpriteImageList || (this.SpriteImageList != null && input.SpriteImageList != null && !this.SpriteImageList.SequenceEqual(input.SpriteImageList))) return false;

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
                if (this.ObsInfo != null) hashCode = hashCode * 59 + this.ObsInfo.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.SpriteImageList != null) hashCode = hashCode * 59 + this.SpriteImageList.GetHashCode();
                return hashCode;
            }
        }
    }
}
