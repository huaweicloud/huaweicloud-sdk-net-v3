using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConsumerDetails 
    {

        /// <summary>
        /// 消费者标识
        /// </summary>
        [JsonProperty("consumer_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel_details", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelDetails ChannelDetails { get; set; }

        /// <summary>
        /// 消费者客户端是否设置手动ack
        /// </summary>
        [JsonProperty("ack_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AckRequired { get; set; }

        /// <summary>
        /// 消费者客户端预取值
        /// </summary>
        [JsonProperty("prefetch_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrefetchCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerDetails {\n");
            sb.Append("  consumerTag: ").Append(ConsumerTag).Append("\n");
            sb.Append("  channelDetails: ").Append(ChannelDetails).Append("\n");
            sb.Append("  ackRequired: ").Append(AckRequired).Append("\n");
            sb.Append("  prefetchCount: ").Append(PrefetchCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerTag == input.ConsumerTag ||
                    (this.ConsumerTag != null &&
                    this.ConsumerTag.Equals(input.ConsumerTag))
                ) && 
                (
                    this.ChannelDetails == input.ChannelDetails ||
                    (this.ChannelDetails != null &&
                    this.ChannelDetails.Equals(input.ChannelDetails))
                ) && 
                (
                    this.AckRequired == input.AckRequired ||
                    (this.AckRequired != null &&
                    this.AckRequired.Equals(input.AckRequired))
                ) && 
                (
                    this.PrefetchCount == input.PrefetchCount ||
                    (this.PrefetchCount != null &&
                    this.PrefetchCount.Equals(input.PrefetchCount))
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
                if (this.ConsumerTag != null)
                    hashCode = hashCode * 59 + this.ConsumerTag.GetHashCode();
                if (this.ChannelDetails != null)
                    hashCode = hashCode * 59 + this.ChannelDetails.GetHashCode();
                if (this.AckRequired != null)
                    hashCode = hashCode * 59 + this.AckRequired.GetHashCode();
                if (this.PrefetchCount != null)
                    hashCode = hashCode * 59 + this.PrefetchCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
