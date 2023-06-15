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
    /// 
    /// </summary>
    public class HistoryStreamInfo 
    {

        /// <summary>
        /// 推流域名。  - type为0表主播推流域名。  - type为1表示第三方推流域名 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 流名。
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 推流类型，取值如下：  - 0：表示主播推流  - 1：表示第三方推流 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 视频编码格式。
        /// </summary>
        [JsonProperty("video_codec", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCodec { get; set; }

        /// <summary>
        /// 音频编码格式。
        /// </summary>
        [JsonProperty("audio_codec", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// 主播ip。
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryStreamInfo {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  videoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  audioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistoryStreamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HistoryStreamInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VideoCodec == input.VideoCodec ||
                    (this.VideoCodec != null &&
                    this.VideoCodec.Equals(input.VideoCodec))
                ) && 
                (
                    this.AudioCodec == input.AudioCodec ||
                    (this.AudioCodec != null &&
                    this.AudioCodec.Equals(input.AudioCodec))
                ) && 
                (
                    this.ClientIp == input.ClientIp ||
                    (this.ClientIp != null &&
                    this.ClientIp.Equals(input.ClientIp))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VideoCodec != null)
                    hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                if (this.AudioCodec != null)
                    hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.ClientIp != null)
                    hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
