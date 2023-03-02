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
    /// 视频合成参数配置信息
    /// </summary>
    public class VideoSynthesisInfo 
    {

        /// <summary>
        /// 背景音乐url
        /// </summary>
        [JsonProperty("bgm_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BgmUrl { get; set; }

        /// <summary>
        /// 视频分辨率
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Resolution { get; set; }

        /// <summary>
        /// 视频帧率
        /// </summary>
        [JsonProperty("fps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Fps { get; set; }

        /// <summary>
        /// 转场动画时间
        /// </summary>
        [JsonProperty("animation_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? AnimationDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSynthesisInfo {\n");
            sb.Append("  bgmUrl: ").Append(BgmUrl).Append("\n");
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
            return this.Equals(input as VideoSynthesisInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoSynthesisInfo input)
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
