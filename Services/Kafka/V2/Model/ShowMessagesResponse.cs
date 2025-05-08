using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMessagesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 消息列表。
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowMessagesRespMessages> Messages { get; set; }

        /// <summary>
        /// **参数解释**： 消息总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("messages_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MessagesCount { get; set; }

        /// <summary>
        /// **参数解释**： 总页数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("offsets_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OffsetsCount { get; set; }

        /// <summary>
        /// **参数解释**： 当前页数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMessagesResponse {\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("  messagesCount: ").Append(MessagesCount).Append("\n");
            sb.Append("  offsetsCount: ").Append(OffsetsCount).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMessagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMessagesResponse input)
        {
            if (input == null) return false;
            if (this.Messages != input.Messages || (this.Messages != null && input.Messages != null && !this.Messages.SequenceEqual(input.Messages))) return false;
            if (this.MessagesCount != input.MessagesCount || (this.MessagesCount != null && !this.MessagesCount.Equals(input.MessagesCount))) return false;
            if (this.OffsetsCount != input.OffsetsCount || (this.OffsetsCount != null && !this.OffsetsCount.Equals(input.OffsetsCount))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.Messages != null) hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.MessagesCount != null) hashCode = hashCode * 59 + this.MessagesCount.GetHashCode();
                if (this.OffsetsCount != null) hashCode = hashCode * 59 + this.OffsetsCount.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
