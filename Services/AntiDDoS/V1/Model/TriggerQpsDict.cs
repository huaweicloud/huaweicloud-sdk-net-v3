using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// HTTP限制列表
    /// </summary>
    public class TriggerQpsDict 
    {

        /// <summary>
        /// HTTP请求数分段ID
        /// </summary>
        [JsonProperty("http_request_pos_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpRequestPosId { get; set; }

        /// <summary>
        /// 每秒HTTP请求数（个/s）阈值
        /// </summary>
        [JsonProperty("http_packet_per_second", NullValueHandling = NullValueHandling.Ignore)]
        public long? HttpPacketPerSecond { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerQpsDict {\n");
            sb.Append("  httpRequestPosId: ").Append(HttpRequestPosId).Append("\n");
            sb.Append("  httpPacketPerSecond: ").Append(HttpPacketPerSecond).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriggerQpsDict);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerQpsDict input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HttpRequestPosId == input.HttpRequestPosId ||
                    (this.HttpRequestPosId != null &&
                    this.HttpRequestPosId.Equals(input.HttpRequestPosId))
                ) && 
                (
                    this.HttpPacketPerSecond == input.HttpPacketPerSecond ||
                    (this.HttpPacketPerSecond != null &&
                    this.HttpPacketPerSecond.Equals(input.HttpPacketPerSecond))
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
                if (this.HttpRequestPosId != null)
                    hashCode = hashCode * 59 + this.HttpRequestPosId.GetHashCode();
                if (this.HttpPacketPerSecond != null)
                    hashCode = hashCode * 59 + this.HttpPacketPerSecond.GetHashCode();
                return hashCode;
            }
        }
    }
}
