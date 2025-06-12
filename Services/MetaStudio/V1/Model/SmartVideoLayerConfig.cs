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
    public class SmartVideoLayerConfig 
    {

        /// <summary>
        /// 视频文件的URL。
        /// </summary>
        [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// 视频封面文件的URL。
        /// </summary>
        [JsonProperty("video_cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCoverUrl { get; set; }

        /// <summary>
        /// **参数解释**： 图片显示时长，单位s。  显示时长规则为，若携带reply_texts、reply_audios，则与播放语音内容时长保持一致。若未携带，则与匹配的关键词语音内容时长保持一致。
        /// </summary>
        [JsonProperty("display_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisplayDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartVideoLayerConfig {\n");
            sb.Append("  videoUrl: ").Append(VideoUrl).Append("\n");
            sb.Append("  videoCoverUrl: ").Append(VideoCoverUrl).Append("\n");
            sb.Append("  displayDuration: ").Append(DisplayDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartVideoLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartVideoLayerConfig input)
        {
            if (input == null) return false;
            if (this.VideoUrl != input.VideoUrl || (this.VideoUrl != null && !this.VideoUrl.Equals(input.VideoUrl))) return false;
            if (this.VideoCoverUrl != input.VideoCoverUrl || (this.VideoCoverUrl != null && !this.VideoCoverUrl.Equals(input.VideoCoverUrl))) return false;
            if (this.DisplayDuration != input.DisplayDuration || (this.DisplayDuration != null && !this.DisplayDuration.Equals(input.DisplayDuration))) return false;

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
                if (this.DisplayDuration != null) hashCode = hashCode * 59 + this.DisplayDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
