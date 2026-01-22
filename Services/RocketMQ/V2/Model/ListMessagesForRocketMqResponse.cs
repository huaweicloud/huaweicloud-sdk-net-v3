using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMessagesForRocketMqResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 消息列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Message> Messages { get; set; }

        /// <summary>
        /// **参数解释**： 消息总数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMessagesForRocketMqResponse {\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMessagesForRocketMqResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMessagesForRocketMqResponse input)
        {
            if (input == null) return false;
            if (this.Messages != input.Messages || (this.Messages != null && input.Messages != null && !this.Messages.SequenceEqual(input.Messages))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
