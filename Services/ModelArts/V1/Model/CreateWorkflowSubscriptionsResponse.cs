using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateWorkflowSubscriptionsResponse : SdkResponse
    {

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 订阅ID，唯一性标识。创建订阅时，后台自动生成。
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// 订阅的主题。
        /// </summary>
        [JsonProperty("topic_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TopicUrns { get; set; }

        /// <summary>
        /// 订阅的主体。
        /// </summary>
        [JsonProperty("entity", NullValueHandling = NullValueHandling.Ignore)]
        public string Entity { get; set; }

        /// <summary>
        /// 订阅的事件。
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Events { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWorkflowSubscriptionsResponse {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  subscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  topicUrns: ").Append(TopicUrns).Append("\n");
            sb.Append("  entity: ").Append(Entity).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWorkflowSubscriptionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWorkflowSubscriptionsResponse input)
        {
            if (input == null) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.SubscriptionId != input.SubscriptionId || (this.SubscriptionId != null && !this.SubscriptionId.Equals(input.SubscriptionId))) return false;
            if (this.TopicUrns != input.TopicUrns || (this.TopicUrns != null && input.TopicUrns != null && !this.TopicUrns.SequenceEqual(input.TopicUrns))) return false;
            if (this.Entity != input.Entity || (this.Entity != null && !this.Entity.Equals(input.Entity))) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;

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
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.SubscriptionId != null) hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.TopicUrns != null) hashCode = hashCode * 59 + this.TopicUrns.GetHashCode();
                if (this.Entity != null) hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                return hashCode;
            }
        }
    }
}
