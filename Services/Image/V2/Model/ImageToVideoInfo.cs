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
    /// 图像合成视频参数配置信息
    /// </summary>
    public class ImageToVideoInfo 
    {

        /// <summary>
        /// 背景音乐url
        /// </summary>
        [JsonProperty("bgm_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BgmUrl { get; set; }

        /// <summary>
        /// 生成视频或gif开关，1生成gif，0生成视频，默认为视频
        /// </summary>
        [JsonProperty("to_gif", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToGif { get; set; }

        /// <summary>
        /// gif分辨率压缩率，gif最终分辨率为最终合成视频分辨率*gif_compress
        /// </summary>
        [JsonProperty("gif_compress", NullValueHandling = NullValueHandling.Ignore)]
        public float? GifCompress { get; set; }

        /// <summary>
        /// 图像展示时间List
        /// </summary>
        [JsonProperty("image_durations", NullValueHandling = NullValueHandling.Ignore)]
        public List<float?> ImageDurations { get; set; }

        /// <summary>
        /// 分辨率
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Resolution { get; set; }

        /// <summary>
        /// 视频帧率，默认30
        /// </summary>
        [JsonProperty("fps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fps { get; set; }

        /// <summary>
        /// 动画转场时间，默认1s
        /// </summary>
        [JsonProperty("animation_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? AnimationDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageToVideoInfo {\n");
            sb.Append("  bgmUrl: ").Append(BgmUrl).Append("\n");
            sb.Append("  toGif: ").Append(ToGif).Append("\n");
            sb.Append("  gifCompress: ").Append(GifCompress).Append("\n");
            sb.Append("  imageDurations: ").Append(ImageDurations).Append("\n");
            sb.Append("  resolution: ").Append(Resolution).Append("\n");
            sb.Append("  fps: ").Append(Fps).Append("\n");
            sb.Append("  animationDuration: ").Append(AnimationDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageToVideoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageToVideoInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BgmUrl == input.BgmUrl ||
                    (this.BgmUrl != null &&
                    this.BgmUrl.Equals(input.BgmUrl))
                ) && 
                (
                    this.ToGif == input.ToGif ||
                    (this.ToGif != null &&
                    this.ToGif.Equals(input.ToGif))
                ) && 
                (
                    this.GifCompress == input.GifCompress ||
                    (this.GifCompress != null &&
                    this.GifCompress.Equals(input.GifCompress))
                ) && 
                (
                    this.ImageDurations == input.ImageDurations ||
                    this.ImageDurations != null &&
                    input.ImageDurations != null &&
                    this.ImageDurations.SequenceEqual(input.ImageDurations)
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    this.Resolution != null &&
                    input.Resolution != null &&
                    this.Resolution.SequenceEqual(input.Resolution)
                ) && 
                (
                    this.Fps == input.Fps ||
                    (this.Fps != null &&
                    this.Fps.Equals(input.Fps))
                ) && 
                (
                    this.AnimationDuration == input.AnimationDuration ||
                    (this.AnimationDuration != null &&
                    this.AnimationDuration.Equals(input.AnimationDuration))
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
                if (this.BgmUrl != null)
                    hashCode = hashCode * 59 + this.BgmUrl.GetHashCode();
                if (this.ToGif != null)
                    hashCode = hashCode * 59 + this.ToGif.GetHashCode();
                if (this.GifCompress != null)
                    hashCode = hashCode * 59 + this.GifCompress.GetHashCode();
                if (this.ImageDurations != null)
                    hashCode = hashCode * 59 + this.ImageDurations.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Fps != null)
                    hashCode = hashCode * 59 + this.Fps.GetHashCode();
                if (this.AnimationDuration != null)
                    hashCode = hashCode * 59 + this.AnimationDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
