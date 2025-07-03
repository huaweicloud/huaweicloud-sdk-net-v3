using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 拓扑图上线条的的信息。
    /// </summary>
    public class TraceTopologyLineInfo 
    {

        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 耗时。
        /// </summary>
        [JsonProperty("time_used", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeUsed { get; set; }

        /// <summary>
        /// 参数信息，比如调用的url信息等。
        /// </summary>
        [JsonProperty("argument", NullValueHandling = NullValueHandling.Ignore)]
        public string Argument { get; set; }

        /// <summary>
        /// event的id。
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TraceTopologyLineInfo {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  timeUsed: ").Append(TimeUsed).Append("\n");
            sb.Append("  argument: ").Append(Argument).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TraceTopologyLineInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TraceTopologyLineInfo input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TimeUsed != input.TimeUsed || (this.TimeUsed != null && !this.TimeUsed.Equals(input.TimeUsed))) return false;
            if (this.Argument != input.Argument || (this.Argument != null && !this.Argument.Equals(input.Argument))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TimeUsed != null) hashCode = hashCode * 59 + this.TimeUsed.GetHashCode();
                if (this.Argument != null) hashCode = hashCode * 59 + this.Argument.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                return hashCode;
            }
        }
    }
}
