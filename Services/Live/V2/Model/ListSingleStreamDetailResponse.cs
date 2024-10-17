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
    public class ListSingleStreamDetailResponse : SdkResponse
    {

        /// <summary>
        /// 推流域名
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 流名
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 展示流视频帧率情况，帧率单位为fps。  如果出现断流则会出现多个时间段流信息，如： &#x60;&#x60;&#x60; \&quot;video_framerate\&quot;: [     {       \&quot;start_time\&quot;: \&quot;2022-02-04T07:00:00Z\&quot;,       \&quot;end_time\&quot;: \&quot;2022-02-04T07:00:02Z\&quot;,       \&quot;data_list\&quot;: [         21,         22       ]     },     {       \&quot;start_time\&quot;: \&quot;2022-02-04T07:00:05Z\&quot;,       \&quot;end_time\&quot;: \&quot;2022-02-04T07:00:07Z\&quot;,       \&quot;data_list\&quot;: [         13,         34,         21       ]     }   ] 
        /// </summary>
        [JsonProperty("video_framerate", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamDetail> VideoFramerate { get; set; }

        /// <summary>
        /// 展示流视频码率情况，码率单位为Kbps。  如果出现断流则会出现多个时间段流信息，如： &#x60;&#x60;&#x60; \&quot;video_bitrate\&quot;: [     {       \&quot;start_time\&quot;: \&quot;2022-02-04T07:00:00Z\&quot;,       \&quot;end_time\&quot;: \&quot;2022-02-04T07:00:02Z\&quot;,       \&quot;data_list\&quot;: [         1326,         1268,         775       ]     },     {       \&quot;start_time\&quot;: \&quot;2022-02-04T07:00:05Z\&quot;,       \&quot;end_time\&quot;: \&quot;2022-02-04T07:00:07Z\&quot;,       \&quot;data_list\&quot;: [         1021,         2022       ]     }   ] 
        /// </summary>
        [JsonProperty("video_bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamDetail> VideoBitrate { get; set; }

        /// <summary>
        /// 展示流音频帧率情况，帧率单位为fps。  如果出现断流则会出现多个时间段流信息，如： &#x60;&#x60;&#x60; \&quot;audio_framerate\&quot;: [     {       \&quot;start_time\&quot;: \&quot;2022-02-04T07:00:00Z\&quot;,       \&quot;end_time\&quot;: \&quot;2022-02-04T07:00:02Z\&quot;,       \&quot;data_list\&quot;: [         10,         17       ]     },     {       \&quot;start_time\&quot;: \&quot;2022-02-04T07:00:05Z\&quot;,       \&quot;end_time\&quot;: \&quot;2022-02-04T07:00:06Z\&quot;,       \&quot;data_list\&quot;: [         31,         33       ]     }   ] 
        /// </summary>
        [JsonProperty("audio_framerate", NullValueHandling = NullValueHandling.Ignore)]
        public List<StreamDetail> AudioFramerate { get; set; }

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
            sb.Append("class ListSingleStreamDetailResponse {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  videoFramerate: ").Append(VideoFramerate).Append("\n");
            sb.Append("  videoBitrate: ").Append(VideoBitrate).Append("\n");
            sb.Append("  audioFramerate: ").Append(AudioFramerate).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSingleStreamDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSingleStreamDetailResponse input)
        {
            if (input == null) return false;
            if (this.PublishDomain != input.PublishDomain || (this.PublishDomain != null && !this.PublishDomain.Equals(input.PublishDomain))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.VideoFramerate != input.VideoFramerate || (this.VideoFramerate != null && input.VideoFramerate != null && !this.VideoFramerate.SequenceEqual(input.VideoFramerate))) return false;
            if (this.VideoBitrate != input.VideoBitrate || (this.VideoBitrate != null && input.VideoBitrate != null && !this.VideoBitrate.SequenceEqual(input.VideoBitrate))) return false;
            if (this.AudioFramerate != input.AudioFramerate || (this.AudioFramerate != null && input.AudioFramerate != null && !this.AudioFramerate.SequenceEqual(input.AudioFramerate))) return false;
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
                if (this.PublishDomain != null) hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.VideoFramerate != null) hashCode = hashCode * 59 + this.VideoFramerate.GetHashCode();
                if (this.VideoBitrate != null) hashCode = hashCode * 59 + this.VideoBitrate.GetHashCode();
                if (this.AudioFramerate != null) hashCode = hashCode * 59 + this.AudioFramerate.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
