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
    /// Response Object
    /// </summary>
    public class ShowTraceEventsResponse : SdkResponse
    {

        /// <summary>
        /// span event信息列表。
        /// </summary>
        [JsonProperty("span_event_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpanEventInfo> SpanEventList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTraceEventsResponse {\n");
            sb.Append("  spanEventList: ").Append(SpanEventList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTraceEventsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTraceEventsResponse input)
        {
            if (input == null) return false;
            if (this.SpanEventList != input.SpanEventList || (this.SpanEventList != null && input.SpanEventList != null && !this.SpanEventList.SequenceEqual(input.SpanEventList))) return false;

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
                if (this.SpanEventList != null) hashCode = hashCode * 59 + this.SpanEventList.GetHashCode();
                return hashCode;
            }
        }
    }
}
