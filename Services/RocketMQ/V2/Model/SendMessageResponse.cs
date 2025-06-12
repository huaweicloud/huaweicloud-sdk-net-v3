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
    public class SendMessageResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 主题名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释**： 消息内容。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// **参数解释**： 特性列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("property_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SendMessageProperties> PropertyList { get; set; }

        /// <summary>
        /// **参数解释**： 消息ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("msg_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MsgId { get; set; }

        /// <summary>
        /// **参数解释**： 队列ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QueueId { get; set; }

        /// <summary>
        /// **参数解释**： 队列offset。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("queue_offset", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? QueueOffset { get; set; }

        /// <summary>
        /// **参数解释**： Broker名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendMessageResponse {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  propertyList: ").Append(PropertyList).Append("\n");
            sb.Append("  msgId: ").Append(MsgId).Append("\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  queueOffset: ").Append(QueueOffset).Append("\n");
            sb.Append("  brokerName: ").Append(BrokerName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendMessageResponse input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;
            if (this.PropertyList != input.PropertyList || (this.PropertyList != null && input.PropertyList != null && !this.PropertyList.SequenceEqual(input.PropertyList))) return false;
            if (this.MsgId != input.MsgId || (this.MsgId != null && !this.MsgId.Equals(input.MsgId))) return false;
            if (this.QueueId != input.QueueId || (this.QueueId != null && !this.QueueId.Equals(input.QueueId))) return false;
            if (this.QueueOffset != input.QueueOffset || (this.QueueOffset != null && !this.QueueOffset.Equals(input.QueueOffset))) return false;
            if (this.BrokerName != input.BrokerName || (this.BrokerName != null && !this.BrokerName.Equals(input.BrokerName))) return false;

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
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.PropertyList != null) hashCode = hashCode * 59 + this.PropertyList.GetHashCode();
                if (this.MsgId != null) hashCode = hashCode * 59 + this.MsgId.GetHashCode();
                if (this.QueueId != null) hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.QueueOffset != null) hashCode = hashCode * 59 + this.QueueOffset.GetHashCode();
                if (this.BrokerName != null) hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                return hashCode;
            }
        }
    }
}
