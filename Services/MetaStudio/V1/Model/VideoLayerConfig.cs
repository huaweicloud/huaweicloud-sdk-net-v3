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
    /// 素材视频图层配置。
    /// </summary>
    public class VideoLayerConfig 
    {

        /// <summary>
        /// **参数解释**： 视频文件的URL。 **约束限制**： * 仅直播支持外部URL，其他业务通过资产库查询获取，不支持外部URL。 **取值范围**： 字符长度1-2048位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// **参数解释**： 视频封面文件的URL。 **约束限制**： * 仅直播支持外部URL，其他业务通过资产库查询获取，不支持外部URL。 **取值范围**： 字符长度1-2048位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("video_cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCoverUrl { get; set; }

        /// <summary>
        /// **参数解释**： 循环播放视频次数。  特殊取值： * 0：表示不播放 * -1：表示持续循环播放  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("loop_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LoopCount { get; set; }

        /// <summary>
        /// **参数解释**： 视频声音大小，0 - 100，表示开启视频声音原视频音量的百分比  特殊取值： * 0：表示不开启声音（默认值）  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("video_sound", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoSound { get; set; }

        /// <summary>
        /// **参数解释**： 是否播放完整个视频，true表示播放完整个视频，false表示当场景文本/音频结束时，视频也同时不再播放。  特殊取值： 默认值为false  **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("is_play_the_entire_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlayTheEntireVideo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoLayerConfig {\n");
            sb.Append("  videoUrl: ").Append(VideoUrl).Append("\n");
            sb.Append("  videoCoverUrl: ").Append(VideoCoverUrl).Append("\n");
            sb.Append("  loopCount: ").Append(LoopCount).Append("\n");
            sb.Append("  videoSound: ").Append(VideoSound).Append("\n");
            sb.Append("  isPlayTheEntireVideo: ").Append(IsPlayTheEntireVideo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoLayerConfig input)
        {
            if (input == null) return false;
            if (this.VideoUrl != input.VideoUrl || (this.VideoUrl != null && !this.VideoUrl.Equals(input.VideoUrl))) return false;
            if (this.VideoCoverUrl != input.VideoCoverUrl || (this.VideoCoverUrl != null && !this.VideoCoverUrl.Equals(input.VideoCoverUrl))) return false;
            if (this.LoopCount != input.LoopCount || (this.LoopCount != null && !this.LoopCount.Equals(input.LoopCount))) return false;
            if (this.VideoSound != input.VideoSound || (this.VideoSound != null && !this.VideoSound.Equals(input.VideoSound))) return false;
            if (this.IsPlayTheEntireVideo != input.IsPlayTheEntireVideo || (this.IsPlayTheEntireVideo != null && !this.IsPlayTheEntireVideo.Equals(input.IsPlayTheEntireVideo))) return false;

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
                if (this.VideoUrl != null) hashCode = hashCode * 59 + this.VideoUrl.GetHashCode();
                if (this.VideoCoverUrl != null) hashCode = hashCode * 59 + this.VideoCoverUrl.GetHashCode();
                if (this.LoopCount != null) hashCode = hashCode * 59 + this.LoopCount.GetHashCode();
                if (this.VideoSound != null) hashCode = hashCode * 59 + this.VideoSound.GetHashCode();
                if (this.IsPlayTheEntireVideo != null) hashCode = hashCode * 59 + this.IsPlayTheEntireVideo.GetHashCode();
                return hashCode;
            }
        }
    }
}
