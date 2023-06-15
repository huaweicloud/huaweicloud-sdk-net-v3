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
    public class StreamPortrait 
    {

        /// <summary>
        /// 统计日期，日期格式按照ISO8601表示法，格式：YYYYMMDD，如20200904。统计该统计日期00:00-23:59时段的播放画像信息。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 累计流量，单位为byte。
        /// </summary>
        [JsonProperty("flow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Flow { get; set; }

        /// <summary>
        /// 累计播放时长,单位为秒。
        /// </summary>
        [JsonProperty("play_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayDuration { get; set; }

        /// <summary>
        /// 累计请求次数。
        /// </summary>
        [JsonProperty("request_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RequestCount { get; set; }

        /// <summary>
        /// 累计观看人数,根据IP去重。
        /// </summary>
        [JsonProperty("user_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserCount { get; set; }

        /// <summary>
        /// 峰值观看人数,flv/rtmp协议是统计Session会话ID，其它协议统计IP,1分钟的采样数据。
        /// </summary>
        [JsonProperty("peak_user_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeakUserCount { get; set; }

        /// <summary>
        /// 峰值带宽，单位bps,5分钟的采样数据。
        /// </summary>
        [JsonProperty("peak_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public long? PeakBandwidth { get; set; }

        /// <summary>
        /// 累计直播(推流)时长,单位为秒。
        /// </summary>
        [JsonProperty("push_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? PushDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamPortrait {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  flow: ").Append(Flow).Append("\n");
            sb.Append("  playDuration: ").Append(PlayDuration).Append("\n");
            sb.Append("  requestCount: ").Append(RequestCount).Append("\n");
            sb.Append("  userCount: ").Append(UserCount).Append("\n");
            sb.Append("  peakUserCount: ").Append(PeakUserCount).Append("\n");
            sb.Append("  peakBandwidth: ").Append(PeakBandwidth).Append("\n");
            sb.Append("  pushDuration: ").Append(PushDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StreamPortrait);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StreamPortrait input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Flow == input.Flow ||
                    (this.Flow != null &&
                    this.Flow.Equals(input.Flow))
                ) && 
                (
                    this.PlayDuration == input.PlayDuration ||
                    (this.PlayDuration != null &&
                    this.PlayDuration.Equals(input.PlayDuration))
                ) && 
                (
                    this.RequestCount == input.RequestCount ||
                    (this.RequestCount != null &&
                    this.RequestCount.Equals(input.RequestCount))
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    (this.UserCount != null &&
                    this.UserCount.Equals(input.UserCount))
                ) && 
                (
                    this.PeakUserCount == input.PeakUserCount ||
                    (this.PeakUserCount != null &&
                    this.PeakUserCount.Equals(input.PeakUserCount))
                ) && 
                (
                    this.PeakBandwidth == input.PeakBandwidth ||
                    (this.PeakBandwidth != null &&
                    this.PeakBandwidth.Equals(input.PeakBandwidth))
                ) && 
                (
                    this.PushDuration == input.PushDuration ||
                    (this.PushDuration != null &&
                    this.PushDuration.Equals(input.PushDuration))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Flow != null)
                    hashCode = hashCode * 59 + this.Flow.GetHashCode();
                if (this.PlayDuration != null)
                    hashCode = hashCode * 59 + this.PlayDuration.GetHashCode();
                if (this.RequestCount != null)
                    hashCode = hashCode * 59 + this.RequestCount.GetHashCode();
                if (this.UserCount != null)
                    hashCode = hashCode * 59 + this.UserCount.GetHashCode();
                if (this.PeakUserCount != null)
                    hashCode = hashCode * 59 + this.PeakUserCount.GetHashCode();
                if (this.PeakBandwidth != null)
                    hashCode = hashCode * 59 + this.PeakBandwidth.GetHashCode();
                if (this.PushDuration != null)
                    hashCode = hashCode * 59 + this.PushDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
