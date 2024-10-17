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
    /// RocketMQ元数据迁移，RocketMQ消费组元数据。
    /// </summary>
    public class MigrationRocketMqSubscriptionGroup 
    {

        /// <summary>
        /// 消费组名。
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 是否允许以广播模式消费。
        /// </summary>
        [JsonProperty("consumeBroadcastEnable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeBroadcastEnable { get; set; }

        /// <summary>
        /// 是否允许消费。
        /// </summary>
        [JsonProperty("consumeEnable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeEnable { get; set; }

        /// <summary>
        /// 是否从最小偏移量开始消费。
        /// </summary>
        [JsonProperty("consumeFromMinEnable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConsumeFromMinEnable { get; set; }

        /// <summary>
        /// 消费者ID变化时是否通知。
        /// </summary>
        [JsonProperty("notifyConsumerIdsChangedEnable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyConsumerIdsChangedEnable { get; set; }

        /// <summary>
        /// 消费最大重试次数。
        /// </summary>
        [JsonProperty("retryMaxTimes", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryMaxTimes { get; set; }

        /// <summary>
        /// 重试队列个数。
        /// </summary>
        [JsonProperty("retryQueueNums", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryQueueNums { get; set; }

        /// <summary>
        /// 慢消费时选择的broker节点ID。
        /// </summary>
        [JsonProperty("whichBrokerWhenConsumeSlow", NullValueHandling = NullValueHandling.Ignore)]
        public long? WhichBrokerWhenConsumeSlow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRocketMqSubscriptionGroup {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  consumeBroadcastEnable: ").Append(ConsumeBroadcastEnable).Append("\n");
            sb.Append("  consumeEnable: ").Append(ConsumeEnable).Append("\n");
            sb.Append("  consumeFromMinEnable: ").Append(ConsumeFromMinEnable).Append("\n");
            sb.Append("  notifyConsumerIdsChangedEnable: ").Append(NotifyConsumerIdsChangedEnable).Append("\n");
            sb.Append("  retryMaxTimes: ").Append(RetryMaxTimes).Append("\n");
            sb.Append("  retryQueueNums: ").Append(RetryQueueNums).Append("\n");
            sb.Append("  whichBrokerWhenConsumeSlow: ").Append(WhichBrokerWhenConsumeSlow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationRocketMqSubscriptionGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationRocketMqSubscriptionGroup input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ConsumeBroadcastEnable != input.ConsumeBroadcastEnable || (this.ConsumeBroadcastEnable != null && !this.ConsumeBroadcastEnable.Equals(input.ConsumeBroadcastEnable))) return false;
            if (this.ConsumeEnable != input.ConsumeEnable || (this.ConsumeEnable != null && !this.ConsumeEnable.Equals(input.ConsumeEnable))) return false;
            if (this.ConsumeFromMinEnable != input.ConsumeFromMinEnable || (this.ConsumeFromMinEnable != null && !this.ConsumeFromMinEnable.Equals(input.ConsumeFromMinEnable))) return false;
            if (this.NotifyConsumerIdsChangedEnable != input.NotifyConsumerIdsChangedEnable || (this.NotifyConsumerIdsChangedEnable != null && !this.NotifyConsumerIdsChangedEnable.Equals(input.NotifyConsumerIdsChangedEnable))) return false;
            if (this.RetryMaxTimes != input.RetryMaxTimes || (this.RetryMaxTimes != null && !this.RetryMaxTimes.Equals(input.RetryMaxTimes))) return false;
            if (this.RetryQueueNums != input.RetryQueueNums || (this.RetryQueueNums != null && !this.RetryQueueNums.Equals(input.RetryQueueNums))) return false;
            if (this.WhichBrokerWhenConsumeSlow != input.WhichBrokerWhenConsumeSlow || (this.WhichBrokerWhenConsumeSlow != null && !this.WhichBrokerWhenConsumeSlow.Equals(input.WhichBrokerWhenConsumeSlow))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ConsumeBroadcastEnable != null) hashCode = hashCode * 59 + this.ConsumeBroadcastEnable.GetHashCode();
                if (this.ConsumeEnable != null) hashCode = hashCode * 59 + this.ConsumeEnable.GetHashCode();
                if (this.ConsumeFromMinEnable != null) hashCode = hashCode * 59 + this.ConsumeFromMinEnable.GetHashCode();
                if (this.NotifyConsumerIdsChangedEnable != null) hashCode = hashCode * 59 + this.NotifyConsumerIdsChangedEnable.GetHashCode();
                if (this.RetryMaxTimes != null) hashCode = hashCode * 59 + this.RetryMaxTimes.GetHashCode();
                if (this.RetryQueueNums != null) hashCode = hashCode * 59 + this.RetryQueueNums.GetHashCode();
                if (this.WhichBrokerWhenConsumeSlow != null) hashCode = hashCode * 59 + this.WhichBrokerWhenConsumeSlow.GetHashCode();
                return hashCode;
            }
        }
    }
}
