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
    /// 流量限制列表
    /// </summary>
    public class TriggerBpsDict 
    {

        /// <summary>
        /// 流量分段ID，取值范围：1：10M;2：30M;3：50M;4：70M;5：100M;6：150M;7：200M;8：250M;9：300M;10：500M;11：800M;88：1000M;99：默认防护。
        /// </summary>
        [JsonProperty("traffic_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrafficPosId { get; set; }

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
            sb.Append("class TriggerBpsDict {\n");
            sb.Append("  trafficPosId: ").Append(TrafficPosId).Append("\n");
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
            return this.Equals(input as TriggerBpsDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerBpsDict input)
        {
            if (input == null) return false;
            if (this.TrafficPosId != input.TrafficPosId || (this.TrafficPosId != null && !this.TrafficPosId.Equals(input.TrafficPosId))) return false;
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
                if (this.TrafficPosId != null) hashCode = hashCode * 59 + this.TrafficPosId.GetHashCode();
                if (this.TrafficPerSecond != null) hashCode = hashCode * 59 + this.TrafficPerSecond.GetHashCode();
                if (this.PacketPerSecond != null) hashCode = hashCode * 59 + this.PacketPerSecond.GetHashCode();
                return hashCode;
            }
        }
    }
}
