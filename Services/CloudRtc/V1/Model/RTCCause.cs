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
    public class RTCCause 
    {

        /// <summary>
        /// 异常事件的时间戳 
        /// </summary>
        [JsonProperty("ts", NullValueHandling = NullValueHandling.Ignore)]
        public string Ts { get; set; }

        /// <summary>
        /// 异常事件ID 
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 对端的用户ID 
        /// </summary>
        [JsonProperty("peer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RTCCause {\n");
            sb.Append("  ts: ").Append(Ts).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  peerId: ").Append(PeerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RTCCause);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RTCCause input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ts == input.Ts ||
                    (this.Ts != null &&
                    this.Ts.Equals(input.Ts))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.PeerId == input.PeerId ||
                    (this.PeerId != null &&
                    this.PeerId.Equals(input.PeerId))
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
                if (this.Ts != null)
                    hashCode = hashCode * 59 + this.Ts.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.PeerId != null)
                    hashCode = hashCode * 59 + this.PeerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
