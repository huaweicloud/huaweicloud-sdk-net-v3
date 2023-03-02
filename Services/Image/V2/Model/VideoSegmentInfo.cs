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
    /// 视频剪切分段参数信息
    /// </summary>
    public class VideoSegmentInfo 
    {

        /// <summary>
        /// 视频分段起始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public float? StartTime { get; set; }

        /// <summary>
        /// 视频分段持续时间
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 视频剪切服务生成视频或gif开关，1生成gif，0生成视频，默认为视频
        /// </summary>
        [JsonProperty("to_gif", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToGif { get; set; }

        /// <summary>
        /// 视频或gif倍速，默认1
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public float? Speed { get; set; }

        /// <summary>
        /// gif分辨率压缩率，gif最终分辨率为最终合成视频分辨率*gif_compress
        /// </summary>
        [JsonProperty("gif_compress", NullValueHandling = NullValueHandling.Ignore)]
        public float? GifCompress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoSegmentInfo {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  toGif: ").Append(ToGif).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  gifCompress: ").Append(GifCompress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoSegmentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoSegmentInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ToGif == input.ToGif ||
                    (this.ToGif != null &&
                    this.ToGif.Equals(input.ToGif))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
                ) && 
                (
                    this.GifCompress == input.GifCompress ||
                    (this.GifCompress != null &&
                    this.GifCompress.Equals(input.GifCompress))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ToGif != null)
                    hashCode = hashCode * 59 + this.ToGif.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.GifCompress != null)
                    hashCode = hashCode * 59 + this.GifCompress.GetHashCode();
                return hashCode;
            }
        }
    }
}
