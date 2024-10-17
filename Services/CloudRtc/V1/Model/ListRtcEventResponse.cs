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
    /// Response Object
    /// </summary>
    public class ListRtcEventResponse : SdkResponse
    {

        /// <summary>
        /// 时间 
        /// </summary>
        [JsonProperty("ctime", NullValueHandling = NullValueHandling.Ignore)]
        public string Ctime { get; set; }

        /// <summary>
        /// 异常事件ID 
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 异常事件信息 
        /// </summary>
        [JsonProperty("event_info", NullValueHandling = NullValueHandling.Ignore)]
        public string EventInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-id", IsHeader = true)]
        [JsonProperty("X-request-id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcEventResponse {\n");
            sb.Append("  ctime: ").Append(Ctime).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  eventInfo: ").Append(EventInfo).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcEventResponse input)
        {
            if (input == null) return false;
            if (this.Ctime != input.Ctime || (this.Ctime != null && !this.Ctime.Equals(input.Ctime))) return false;
            if (this.EventId != input.EventId || (this.EventId != null && !this.EventId.Equals(input.EventId))) return false;
            if (this.EventInfo != input.EventInfo || (this.EventInfo != null && !this.EventInfo.Equals(input.EventInfo))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Ctime != null) hashCode = hashCode * 59 + this.Ctime.GetHashCode();
                if (this.EventId != null) hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.EventInfo != null) hashCode = hashCode * 59 + this.EventInfo.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
