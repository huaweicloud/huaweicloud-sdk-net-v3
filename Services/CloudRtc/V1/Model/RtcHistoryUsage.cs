using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RtcHistoryUsage 
    {

        /// <summary>
        /// 采样时间。日期格式按照ISO8601表示法，并使用UTC时间。格式为YYYY-MM-DD
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 标清视频时长，单位秒
        /// </summary>
        [JsonProperty("video_sd", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoSd { get; set; }

        /// <summary>
        /// 高清视频时长，单位秒
        /// </summary>
        [JsonProperty("video_hd", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoHd { get; set; }

        /// <summary>
        /// 超高清视频时长，单位秒
        /// </summary>
        [JsonProperty("video_hdp", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoHdp { get; set; }

        /// <summary>
        /// 音频时长，单位秒
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public long? Audio { get; set; }

        /// <summary>
        /// 音视频总时长，单位秒
        /// </summary>
        [JsonProperty("total_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtcHistoryUsage {\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  videoSd: ").Append(VideoSd).Append("\n");
            sb.Append("  videoHd: ").Append(VideoHd).Append("\n");
            sb.Append("  videoHdp: ").Append(VideoHdp).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  totalDuration: ").Append(TotalDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RtcHistoryUsage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RtcHistoryUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.VideoSd == input.VideoSd ||
                    (this.VideoSd != null &&
                    this.VideoSd.Equals(input.VideoSd))
                ) && 
                (
                    this.VideoHd == input.VideoHd ||
                    (this.VideoHd != null &&
                    this.VideoHd.Equals(input.VideoHd))
                ) && 
                (
                    this.VideoHdp == input.VideoHdp ||
                    (this.VideoHdp != null &&
                    this.VideoHdp.Equals(input.VideoHdp))
                ) && 
                (
                    this.Audio == input.Audio ||
                    (this.Audio != null &&
                    this.Audio.Equals(input.Audio))
                ) && 
                (
                    this.TotalDuration == input.TotalDuration ||
                    (this.TotalDuration != null &&
                    this.TotalDuration.Equals(input.TotalDuration))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.VideoSd != null)
                    hashCode = hashCode * 59 + this.VideoSd.GetHashCode();
                if (this.VideoHd != null)
                    hashCode = hashCode * 59 + this.VideoHd.GetHashCode();
                if (this.VideoHdp != null)
                    hashCode = hashCode * 59 + this.VideoHdp.GetHashCode();
                if (this.Audio != null)
                    hashCode = hashCode * 59 + this.Audio.GetHashCode();
                if (this.TotalDuration != null)
                    hashCode = hashCode * 59 + this.TotalDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
