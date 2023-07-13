using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoInfo 
    {

        /// <summary>
        /// 视频宽度
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 视频码率，单位: kbit/s 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 视频码率，单位: bit/s 
        /// </summary>
        [JsonProperty("bitrate_bps", NullValueHandling = NullValueHandling.Ignore)]
        public long? BitrateBps { get; set; }

        /// <summary>
        /// 帧率。    取值范围：0或[5,60]，0表示自适应。    单位：帧每秒。    &gt; 若设置的帧率不在取值范围内，则自动调整为0，若设置的帧率高于片源帧率，则自动调整为片源帧率。 
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// 视频编码格式
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoInfo {\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  bitrateBps: ").Append(BitrateBps).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Bitrate == input.Bitrate ||
                    (this.Bitrate != null &&
                    this.Bitrate.Equals(input.Bitrate))
                ) && 
                (
                    this.BitrateBps == input.BitrateBps ||
                    (this.BitrateBps != null &&
                    this.BitrateBps.Equals(input.BitrateBps))
                ) && 
                (
                    this.FrameRate == input.FrameRate ||
                    (this.FrameRate != null &&
                    this.FrameRate.Equals(input.FrameRate))
                ) && 
                (
                    this.Codec == input.Codec ||
                    (this.Codec != null &&
                    this.Codec.Equals(input.Codec))
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
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Bitrate != null)
                    hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.BitrateBps != null)
                    hashCode = hashCode * 59 + this.BitrateBps.GetHashCode();
                if (this.FrameRate != null)
                    hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.Codec != null)
                    hashCode = hashCode * 59 + this.Codec.GetHashCode();
                return hashCode;
            }
        }
    }
}
