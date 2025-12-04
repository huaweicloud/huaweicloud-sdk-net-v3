using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCarouselTaskDetailResponse : SdkResponse
    {

        /// <summary>
        /// 采样开始时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 采样结束时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 视频帧率信息列表，单位为fps。
        /// </summary>
        [JsonProperty("video_framerate_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> VideoFramerateList { get; set; }

        /// <summary>
        /// 视频码率信息列表，单位为kbps。
        /// </summary>
        [JsonProperty("video_bitrate_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> VideoBitrateList { get; set; }

        /// <summary>
        /// 音频帧率信息列表，单位为fps。
        /// </summary>
        [JsonProperty("audio_framerate_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> AudioFramerateList { get; set; }

        /// <summary>
        /// 音频码率信息列表，单位为kbps。
        /// </summary>
        [JsonProperty("audio_bitrate_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> AudioBitrateList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCarouselTaskDetailResponse {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  videoFramerateList: ").Append(VideoFramerateList).Append("\n");
            sb.Append("  videoBitrateList: ").Append(VideoBitrateList).Append("\n");
            sb.Append("  audioFramerateList: ").Append(AudioFramerateList).Append("\n");
            sb.Append("  audioBitrateList: ").Append(AudioBitrateList).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCarouselTaskDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCarouselTaskDetailResponse input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.VideoFramerateList != input.VideoFramerateList || (this.VideoFramerateList != null && input.VideoFramerateList != null && !this.VideoFramerateList.SequenceEqual(input.VideoFramerateList))) return false;
            if (this.VideoBitrateList != input.VideoBitrateList || (this.VideoBitrateList != null && input.VideoBitrateList != null && !this.VideoBitrateList.SequenceEqual(input.VideoBitrateList))) return false;
            if (this.AudioFramerateList != input.AudioFramerateList || (this.AudioFramerateList != null && input.AudioFramerateList != null && !this.AudioFramerateList.SequenceEqual(input.AudioFramerateList))) return false;
            if (this.AudioBitrateList != input.AudioBitrateList || (this.AudioBitrateList != null && input.AudioBitrateList != null && !this.AudioBitrateList.SequenceEqual(input.AudioBitrateList))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.VideoFramerateList != null) hashCode = hashCode * 59 + this.VideoFramerateList.GetHashCode();
                if (this.VideoBitrateList != null) hashCode = hashCode * 59 + this.VideoBitrateList.GetHashCode();
                if (this.AudioFramerateList != null) hashCode = hashCode * 59 + this.AudioFramerateList.GetHashCode();
                if (this.AudioBitrateList != null) hashCode = hashCode * 59 + this.AudioBitrateList.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
