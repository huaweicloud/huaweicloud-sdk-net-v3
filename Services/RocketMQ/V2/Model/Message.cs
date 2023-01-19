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
    /// 消息。
    /// </summary>
    public class Message 
    {

        /// <summary>
        /// 消息ID。
        /// </summary>
        [JsonProperty("msg_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MsgId { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 主题名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 存储消息的时间。
        /// </summary>
        [JsonProperty("store_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoreTimestamp { get; set; }

        /// <summary>
        /// 产生消息的时间。
        /// </summary>
        [JsonProperty("born_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BornTimestamp { get; set; }

        /// <summary>
        /// 重试次数。
        /// </summary>
        [JsonProperty("reconsume_times", NullValueHandling = NullValueHandling.Ignore)]
        public string ReconsumeTimes { get; set; }

        /// <summary>
        /// 消息体。
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 消息体校验和。
        /// </summary>
        [JsonProperty("body_crc", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BodyCrc { get; set; }

        /// <summary>
        /// 存储大小。
        /// </summary>
        [JsonProperty("store_size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoreSize { get; set; }

        /// <summary>
        /// 消息属性列表。
        /// </summary>
        [JsonProperty("property_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MessagePropertyList> PropertyList { get; set; }

        /// <summary>
        /// 产生消息的主机IP。
        /// </summary>
        [JsonProperty("born_host", NullValueHandling = NullValueHandling.Ignore)]
        public string BornHost { get; set; }

        /// <summary>
        /// 存储消息的主机IP。
        /// </summary>
        [JsonProperty("store_host", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreHost { get; set; }

        /// <summary>
        /// 队列ID。
        /// </summary>
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 在队列中的偏移量。
        /// </summary>
        [JsonProperty("queue_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  msgId: ").Append(MsgId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  storeTimestamp: ").Append(StoreTimestamp).Append("\n");
            sb.Append("  bornTimestamp: ").Append(BornTimestamp).Append("\n");
            sb.Append("  reconsumeTimes: ").Append(ReconsumeTimes).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  bodyCrc: ").Append(BodyCrc).Append("\n");
            sb.Append("  storeSize: ").Append(StoreSize).Append("\n");
            sb.Append("  propertyList: ").Append(PropertyList).Append("\n");
            sb.Append("  bornHost: ").Append(BornHost).Append("\n");
            sb.Append("  storeHost: ").Append(StoreHost).Append("\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  queueOffset: ").Append(QueueOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Message input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MsgId == input.MsgId ||
                    (this.MsgId != null &&
                    this.MsgId.Equals(input.MsgId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.StoreTimestamp == input.StoreTimestamp ||
                    (this.StoreTimestamp != null &&
                    this.StoreTimestamp.Equals(input.StoreTimestamp))
                ) && 
                (
                    this.BornTimestamp == input.BornTimestamp ||
                    (this.BornTimestamp != null &&
                    this.BornTimestamp.Equals(input.BornTimestamp))
                ) && 
                (
                    this.ReconsumeTimes == input.ReconsumeTimes ||
                    (this.ReconsumeTimes != null &&
                    this.ReconsumeTimes.Equals(input.ReconsumeTimes))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BodyCrc == input.BodyCrc ||
                    (this.BodyCrc != null &&
                    this.BodyCrc.Equals(input.BodyCrc))
                ) && 
                (
                    this.StoreSize == input.StoreSize ||
                    (this.StoreSize != null &&
                    this.StoreSize.Equals(input.StoreSize))
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    input.PropertyList != null &&
                    this.PropertyList.SequenceEqual(input.PropertyList)
                ) && 
                (
                    this.BornHost == input.BornHost ||
                    (this.BornHost != null &&
                    this.BornHost.Equals(input.BornHost))
                ) && 
                (
                    this.StoreHost == input.StoreHost ||
                    (this.StoreHost != null &&
                    this.StoreHost.Equals(input.StoreHost))
                ) && 
                (
                    this.QueueId == input.QueueId ||
                    (this.QueueId != null &&
                    this.QueueId.Equals(input.QueueId))
                ) && 
                (
                    this.QueueOffset == input.QueueOffset ||
                    (this.QueueOffset != null &&
                    this.QueueOffset.Equals(input.QueueOffset))
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
                if (this.MsgId != null)
                    hashCode = hashCode * 59 + this.MsgId.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.StoreTimestamp != null)
                    hashCode = hashCode * 59 + this.StoreTimestamp.GetHashCode();
                if (this.BornTimestamp != null)
                    hashCode = hashCode * 59 + this.BornTimestamp.GetHashCode();
                if (this.ReconsumeTimes != null)
                    hashCode = hashCode * 59 + this.ReconsumeTimes.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.BodyCrc != null)
                    hashCode = hashCode * 59 + this.BodyCrc.GetHashCode();
                if (this.StoreSize != null)
                    hashCode = hashCode * 59 + this.StoreSize.GetHashCode();
                if (this.PropertyList != null)
                    hashCode = hashCode * 59 + this.PropertyList.GetHashCode();
                if (this.BornHost != null)
                    hashCode = hashCode * 59 + this.BornHost.GetHashCode();
                if (this.StoreHost != null)
                    hashCode = hashCode * 59 + this.StoreHost.GetHashCode();
                if (this.QueueId != null)
                    hashCode = hashCode * 59 + this.QueueId.GetHashCode();
                if (this.QueueOffset != null)
                    hashCode = hashCode * 59 + this.QueueOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
