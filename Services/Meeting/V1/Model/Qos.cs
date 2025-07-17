using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 网络质量对象，音频不涉及分辨率和帧率（注：所有媒体流的数据均为服务器视角，Portal展示时需要转换为端侧视角）
    /// </summary>
    public class Qos 
    {

        /// <summary>
        /// 网络质量评级
        /// </summary>
        [JsonProperty("networkQuality", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkQuality { get; set; }

        /// <summary>
        /// 编解码类型
        /// </summary>
        [JsonProperty("codecType", NullValueHandling = NullValueHandling.Ignore)]
        public string CodecType { get; set; }

        /// <summary>
        /// 带宽(kbit/s)
        /// </summary>
        [JsonProperty("bandWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandWidth { get; set; }

        /// <summary>
        /// 丢包率（千分数）
        /// </summary>
        [JsonProperty("lostPacketRate", NullValueHandling = NullValueHandling.Ignore)]
        public int? LostPacketRate { get; set; }

        /// <summary>
        /// 时延(ms)
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        /// <summary>
        /// 抖动(ms)
        /// </summary>
        [JsonProperty("jitter", NullValueHandling = NullValueHandling.Ignore)]
        public int? Jitter { get; set; }

        /// <summary>
        /// 分辨率:高
        /// </summary>
        [JsonProperty("resolutionHeight", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// 分辨率：宽
        /// </summary>
        [JsonProperty("resolutionWidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// 帧率
        /// </summary>
        [JsonProperty("frameRate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// 该媒体流编码会场ID，仅服务器向端侧发送方向涉及(视频)，如路径A- -&gt;服务器- -&gt;B，即B观看A，该媒体流的codec_user_id为A
        /// </summary>
        [JsonProperty("codecUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string CodecUserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Qos {\n");
            sb.Append("  networkQuality: ").Append(NetworkQuality).Append("\n");
            sb.Append("  codecType: ").Append(CodecType).Append("\n");
            sb.Append("  bandWidth: ").Append(BandWidth).Append("\n");
            sb.Append("  lostPacketRate: ").Append(LostPacketRate).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  jitter: ").Append(Jitter).Append("\n");
            sb.Append("  resolutionHeight: ").Append(ResolutionHeight).Append("\n");
            sb.Append("  resolutionWidth: ").Append(ResolutionWidth).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  codecUserId: ").Append(CodecUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Qos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Qos input)
        {
            if (input == null) return false;
            if (this.NetworkQuality != input.NetworkQuality || (this.NetworkQuality != null && !this.NetworkQuality.Equals(input.NetworkQuality))) return false;
            if (this.CodecType != input.CodecType || (this.CodecType != null && !this.CodecType.Equals(input.CodecType))) return false;
            if (this.BandWidth != input.BandWidth || (this.BandWidth != null && !this.BandWidth.Equals(input.BandWidth))) return false;
            if (this.LostPacketRate != input.LostPacketRate || (this.LostPacketRate != null && !this.LostPacketRate.Equals(input.LostPacketRate))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.Jitter != input.Jitter || (this.Jitter != null && !this.Jitter.Equals(input.Jitter))) return false;
            if (this.ResolutionHeight != input.ResolutionHeight || (this.ResolutionHeight != null && !this.ResolutionHeight.Equals(input.ResolutionHeight))) return false;
            if (this.ResolutionWidth != input.ResolutionWidth || (this.ResolutionWidth != null && !this.ResolutionWidth.Equals(input.ResolutionWidth))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.CodecUserId != input.CodecUserId || (this.CodecUserId != null && !this.CodecUserId.Equals(input.CodecUserId))) return false;

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
                if (this.NetworkQuality != null) hashCode = hashCode * 59 + this.NetworkQuality.GetHashCode();
                if (this.CodecType != null) hashCode = hashCode * 59 + this.CodecType.GetHashCode();
                if (this.BandWidth != null) hashCode = hashCode * 59 + this.BandWidth.GetHashCode();
                if (this.LostPacketRate != null) hashCode = hashCode * 59 + this.LostPacketRate.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.Jitter != null) hashCode = hashCode * 59 + this.Jitter.GetHashCode();
                if (this.ResolutionHeight != null) hashCode = hashCode * 59 + this.ResolutionHeight.GetHashCode();
                if (this.ResolutionWidth != null) hashCode = hashCode * 59 + this.ResolutionWidth.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.CodecUserId != null) hashCode = hashCode * 59 + this.CodecUserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
