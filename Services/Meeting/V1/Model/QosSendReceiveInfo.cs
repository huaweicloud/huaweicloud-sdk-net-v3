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
    /// 会议与会者发送QoS数据。当qosType &#x3D; audio/video/screen 时有效。
    /// </summary>
    public class QosSendReceiveInfo 
    {

        /// <summary>
        /// 码率, 单位kbps，不含阈值告警。当qosType &#x3D; audio/video/screen 时有效。
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataNoThrElement> Bitrate { get; set; }

        /// <summary>
        /// 时延，单位毫秒, 含阈值告警。当qosType &#x3D; audio/video/screen 时有效。
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataElement> Latency { get; set; }

        /// <summary>
        /// 抖动, 单位毫秒，含阈值告警。当qosType &#x3D; audio/video/screen 时有效。
        /// </summary>
        [JsonProperty("jitter", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataElement> Jitter { get; set; }

        /// <summary>
        /// 最大丢包率, 单位百分比 含阈值告警。当qosType &#x3D; audio/video/screen 时有效。
        /// </summary>
        [JsonProperty("packet_loss_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataElement> PacketLossMax { get; set; }

        /// <summary>
        /// 分辨率, 不含阈值告警。当qosType &#x3D; video/screen 时有效。
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataNoThrElement> Resolution { get; set; }

        /// <summary>
        /// 帧率, 单位fps，不含阈值告警。当qosType &#x3D; video/screen 时有效。
        /// </summary>
        [JsonProperty("frame", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataNoThrElement> Frame { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosSendReceiveInfo {\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  latency: ").Append(Latency).Append("\n");
            sb.Append("  jitter: ").Append(Jitter).Append("\n");
            sb.Append("  packetLossMax: ").Append(PacketLossMax).Append("\n");
            sb.Append("  resolution: ").Append(Resolution).Append("\n");
            sb.Append("  frame: ").Append(Frame).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosSendReceiveInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosSendReceiveInfo input)
        {
            if (input == null) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && input.Bitrate != null && !this.Bitrate.SequenceEqual(input.Bitrate))) return false;
            if (this.Latency != input.Latency || (this.Latency != null && input.Latency != null && !this.Latency.SequenceEqual(input.Latency))) return false;
            if (this.Jitter != input.Jitter || (this.Jitter != null && input.Jitter != null && !this.Jitter.SequenceEqual(input.Jitter))) return false;
            if (this.PacketLossMax != input.PacketLossMax || (this.PacketLossMax != null && input.PacketLossMax != null && !this.PacketLossMax.SequenceEqual(input.PacketLossMax))) return false;
            if (this.Resolution != input.Resolution || (this.Resolution != null && input.Resolution != null && !this.Resolution.SequenceEqual(input.Resolution))) return false;
            if (this.Frame != input.Frame || (this.Frame != null && input.Frame != null && !this.Frame.SequenceEqual(input.Frame))) return false;

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
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Latency != null) hashCode = hashCode * 59 + this.Latency.GetHashCode();
                if (this.Jitter != null) hashCode = hashCode * 59 + this.Jitter.GetHashCode();
                if (this.PacketLossMax != null) hashCode = hashCode * 59 + this.PacketLossMax.GetHashCode();
                if (this.Resolution != null) hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.Frame != null) hashCode = hashCode * 59 + this.Frame.GetHashCode();
                return hashCode;
            }
        }
    }
}
