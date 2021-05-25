using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dms.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ConfirmDeadLettersMessagesRequest 
    {

        /// <summary>
        /// 队列ID。
        /// </summary>
        [SDKProperty("queue_id", IsPath = true)]
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 消费组ID。
        /// </summary>
        [SDKProperty("consumer_group_id", IsPath = true)]
        [JsonProperty("consumer_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ConfirmDeadLettersMessagesReq Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmDeadLettersMessagesRequest {\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  consumerGroupId: ").Append(ConsumerGroupId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfirmDeadLettersMessagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfirmDeadLettersMessagesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.ConsumerGroupId == input.ConsumerGroupId ||
                    (this.ConsumerGroupId != null &&
                    this.ConsumerGroupId.Equals(input.ConsumerGroupId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.ConsumerGroupId != null)
                    hashCode = hashCode * 59 + this.ConsumerGroupId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
