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
    /// 
    /// </summary>
    public class SubscriptionEntity 
    {

        /// <summary>
        /// **参数解释**： Topic名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// **参数解释**： 消费者标签列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("consumers_in_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConsumersInTagEntity> ConsumersInTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionEntity {\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("  consumersInTags: ").Append(ConsumersInTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscriptionEntity input)
        {
            if (input == null) return false;
            if (this.TopicName != input.TopicName || (this.TopicName != null && !this.TopicName.Equals(input.TopicName))) return false;
            if (this.ConsumersInTags != input.ConsumersInTags || (this.ConsumersInTags != null && input.ConsumersInTags != null && !this.ConsumersInTags.SequenceEqual(input.ConsumersInTags))) return false;

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
                if (this.TopicName != null) hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.ConsumersInTags != null) hashCode = hashCode * 59 + this.ConsumersInTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
