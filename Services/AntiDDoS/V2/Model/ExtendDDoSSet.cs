using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V2.Model
{
    /// <summary>
    /// 扩展配置列表
    /// </summary>
    public class ExtendDDoSSet 
    {

        /// <summary>
        /// 配置分段ID
        /// </summary>
        [JsonProperty("SetID", NullValueHandling = NullValueHandling.Ignore)]
        public long? SetID { get; set; }

        /// <summary>
        /// 单一源IP新建连接个数
        /// </summary>
        [JsonProperty("new_connection_limited", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewConnectionLimited { get; set; }

        /// <summary>
        /// 单一源IP连接数总个数
        /// </summary>
        [JsonProperty("total_connection_limited", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalConnectionLimited { get; set; }

        /// <summary>
        /// 每秒HTTP请求数（个/s）阈值
        /// </summary>
        [JsonProperty("http_packet_per_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpPacketPerSecond { get; set; }

        /// <summary>
        /// 每秒流量（Mbit/s）阈值
        /// </summary>
        [JsonProperty("traffic_per_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrafficPerSecond { get; set; }

        /// <summary>
        /// 每秒报文数（个/s）阈值
        /// </summary>
        [JsonProperty("packet_per_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? PacketPerSecond { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendDDoSSet {\n");
            sb.Append("  setID: ").Append(SetID).Append("\n");
            sb.Append("  newConnectionLimited: ").Append(NewConnectionLimited).Append("\n");
            sb.Append("  totalConnectionLimited: ").Append(TotalConnectionLimited).Append("\n");
            sb.Append("  httpPacketPerSecond: ").Append(HttpPacketPerSecond).Append("\n");
            sb.Append("  trafficPerSecond: ").Append(TrafficPerSecond).Append("\n");
            sb.Append("  packetPerSecond: ").Append(PacketPerSecond).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtendDDoSSet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtendDDoSSet input)
        {
            if (input == null) return false;
            if (this.SetID != input.SetID || (this.SetID != null && !this.SetID.Equals(input.SetID))) return false;
            if (this.NewConnectionLimited != input.NewConnectionLimited || (this.NewConnectionLimited != null && !this.NewConnectionLimited.Equals(input.NewConnectionLimited))) return false;
            if (this.TotalConnectionLimited != input.TotalConnectionLimited || (this.TotalConnectionLimited != null && !this.TotalConnectionLimited.Equals(input.TotalConnectionLimited))) return false;
            if (this.HttpPacketPerSecond != input.HttpPacketPerSecond || (this.HttpPacketPerSecond != null && !this.HttpPacketPerSecond.Equals(input.HttpPacketPerSecond))) return false;
            if (this.TrafficPerSecond != input.TrafficPerSecond || (this.TrafficPerSecond != null && !this.TrafficPerSecond.Equals(input.TrafficPerSecond))) return false;
            if (this.PacketPerSecond != input.PacketPerSecond || (this.PacketPerSecond != null && !this.PacketPerSecond.Equals(input.PacketPerSecond))) return false;

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
                if (this.SetID != null) hashCode = hashCode * 59 + this.SetID.GetHashCode();
                if (this.NewConnectionLimited != null) hashCode = hashCode * 59 + this.NewConnectionLimited.GetHashCode();
                if (this.TotalConnectionLimited != null) hashCode = hashCode * 59 + this.TotalConnectionLimited.GetHashCode();
                if (this.HttpPacketPerSecond != null) hashCode = hashCode * 59 + this.HttpPacketPerSecond.GetHashCode();
                if (this.TrafficPerSecond != null) hashCode = hashCode * 59 + this.TrafficPerSecond.GetHashCode();
                if (this.PacketPerSecond != null) hashCode = hashCode * 59 + this.PacketPerSecond.GetHashCode();
                return hashCode;
            }
        }
    }
}
