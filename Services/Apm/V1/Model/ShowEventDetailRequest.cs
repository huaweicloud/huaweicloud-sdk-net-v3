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
    /// Request Object
    /// </summary>
    public class ShowEventDetailRequest 
    {

        /// <summary>
        /// trace id。
        /// </summary>
        [SDKProperty("trace_id", IsQuery = true)]
        [JsonProperty("trace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TraceId { get; set; }

        /// <summary>
        /// span id。
        /// </summary>
        [SDKProperty("span_id", IsQuery = true)]
        [JsonProperty("span_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpanId { get; set; }

        /// <summary>
        /// event id。
        /// </summary>
        [SDKProperty("event_id", IsQuery = true)]
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [SDKProperty("env_id", IsQuery = true)]
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEventDetailRequest {\n");
            sb.Append("  traceId: ").Append(TraceId).Append("\n");
            sb.Append("  spanId: ").Append(SpanId).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEventDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEventDetailRequest input)
        {
            if (input == null) return false;
            if (this.TraceId != input.TraceId || (this.TraceId != null && !this.TraceId.Equals(input.TraceId))) return false;
            if (this.SpanId != input.SpanId || (this.SpanId != null && !this.SpanId.Equals(input.SpanId))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;

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
                if (this.TraceId != null) hashCode = hashCode * 59 + this.TraceId.GetHashCode();
                if (this.SpanId != null) hashCode = hashCode * 59 + this.SpanId.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                return hashCode;
            }
        }
    }
}
