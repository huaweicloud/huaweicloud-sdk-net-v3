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
    public class ShowConsumerListOrDetailsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： Topic列表（当查询Topic消费“列表”时才显示此参数）。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// **参数解释**： Topic总数（当查询Topic消费“列表”时才显示此参数）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 消费堆积总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lag { get; set; }

        /// <summary>
        /// **参数解释**： 消息总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("max_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxOffset { get; set; }

        /// <summary>
        /// **参数解释**： 已消费消息数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("consumer_offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConsumerOffset { get; set; }

        /// <summary>
        /// **参数解释**： Topic关联代理（当查询Topic消费“详情”才显示此参数）。
        /// </summary>
        [JsonProperty("brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Brokers> Brokers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConsumerListOrDetailsResponse {\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("  maxOffset: ").Append(MaxOffset).Append("\n");
            sb.Append("  consumerOffset: ").Append(ConsumerOffset).Append("\n");
            sb.Append("  brokers: ").Append(Brokers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConsumerListOrDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConsumerListOrDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Topics != input.Topics || (this.Topics != null && input.Topics != null && !this.Topics.SequenceEqual(input.Topics))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Lag != input.Lag || (this.Lag != null && !this.Lag.Equals(input.Lag))) return false;
            if (this.MaxOffset != input.MaxOffset || (this.MaxOffset != null && !this.MaxOffset.Equals(input.MaxOffset))) return false;
            if (this.ConsumerOffset != input.ConsumerOffset || (this.ConsumerOffset != null && !this.ConsumerOffset.Equals(input.ConsumerOffset))) return false;
            if (this.Brokers != input.Brokers || (this.Brokers != null && input.Brokers != null && !this.Brokers.SequenceEqual(input.Brokers))) return false;

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
                if (this.Topics != null) hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Lag != null) hashCode = hashCode * 59 + this.Lag.GetHashCode();
                if (this.MaxOffset != null) hashCode = hashCode * 59 + this.MaxOffset.GetHashCode();
                if (this.ConsumerOffset != null) hashCode = hashCode * 59 + this.ConsumerOffset.GetHashCode();
                if (this.Brokers != null) hashCode = hashCode * 59 + this.Brokers.GetHashCode();
                return hashCode;
            }
        }
    }
}
