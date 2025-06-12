using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSmartChatRoomsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 智能交互对话总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**： 智能交互对话总并发路数。
        /// </summary>
        [JsonProperty("count_concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? CountConcurrency { get; set; }

        /// <summary>
        /// 智能交互对话列表。
        /// </summary>
        [JsonProperty("smart_chat_rooms", NullValueHandling = NullValueHandling.Ignore)]
        public List<SmartChatRoomBaseInfo> SmartChatRooms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSmartChatRoomsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  countConcurrency: ").Append(CountConcurrency).Append("\n");
            sb.Append("  smartChatRooms: ").Append(SmartChatRooms).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSmartChatRoomsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSmartChatRoomsResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.CountConcurrency != input.CountConcurrency || (this.CountConcurrency != null && !this.CountConcurrency.Equals(input.CountConcurrency))) return false;
            if (this.SmartChatRooms != input.SmartChatRooms || (this.SmartChatRooms != null && input.SmartChatRooms != null && !this.SmartChatRooms.SequenceEqual(input.SmartChatRooms))) return false;
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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.CountConcurrency != null) hashCode = hashCode * 59 + this.CountConcurrency.GetHashCode();
                if (this.SmartChatRooms != null) hashCode = hashCode * 59 + this.SmartChatRooms.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
