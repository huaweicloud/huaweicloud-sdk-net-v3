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
    public class ConsumeMessagesRequest 
    {

        /// <summary>
        /// 指定的队列ID。
        /// </summary>
        [SDKProperty("queue_id", IsPath = true)]
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 消费组的ID。
        /// </summary>
        [SDKProperty("consumer_group_id", IsPath = true)]
        [JsonProperty("consumer_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// 获取可消费的消息的条数。  取值范围：1~10。  默认值：10
        /// </summary>
        [SDKProperty("max_msgs", IsQuery = true)]
        [JsonProperty("max_msgs", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxMsgs { get; set; }

        /// <summary>
        /// 设定队列可消费的消息为0时的读取消息等待时间。  如果在等待时间内有新的消息，则立即返回消费结果，如果等待时间内没有新的消息，则到等待时间后返回消费结果。  取值范围：1~60s  默认值：3s  说明：不带该参数或者配置为空，都默认为3s。
        /// </summary>
        [SDKProperty("time_wait", IsQuery = true)]
        [JsonProperty("time_wait", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeWait { get; set; }

        /// <summary>
        /// 提交确认消费的超时时间，客户端需要在该时间内提交消费确认，如果超过指定时间，没有确认消费，系统会报消息确认超时或handler无效，则默认为消费失败。  取值范围：15~300s  默认值：30s  说明：不带该参数或者配置为空，都默认为30s。
        /// </summary>
        [SDKProperty("ack_wait", IsQuery = true)]
        [JsonProperty("ack_wait", NullValueHandling = NullValueHandling.Ignore)]
        public int? AckWait { get; set; }

        /// <summary>
        /// 添加标签后可以按照Tag进行过滤，只消费匹配上标签的消息。  Tag的数量不超过3个。  每个Tag长度不超过64。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 多个消息标签的过滤类型。  取值范围： - and：必须所有标签匹配上，才能消费消息。 - or：只要有一条标签匹配上，就可以消费消息。  默认值为：or。
        /// </summary>
        [SDKProperty("tag_type", IsQuery = true)]
        [JsonProperty("tag_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TagType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumeMessagesRequest {\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  consumerGroupId: ").Append(ConsumerGroupId).Append("\n");
            sb.Append("  maxMsgs: ").Append(MaxMsgs).Append("\n");
            sb.Append("  timeWait: ").Append(TimeWait).Append("\n");
            sb.Append("  ackWait: ").Append(AckWait).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  tagType: ").Append(TagType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumeMessagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumeMessagesRequest input)
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
                    this.MaxMsgs == input.MaxMsgs ||
                    (this.MaxMsgs != null &&
                    this.MaxMsgs.Equals(input.MaxMsgs))
                ) && 
                (
                    this.TimeWait == input.TimeWait ||
                    (this.TimeWait != null &&
                    this.TimeWait.Equals(input.TimeWait))
                ) && 
                (
                    this.AckWait == input.AckWait ||
                    (this.AckWait != null &&
                    this.AckWait.Equals(input.AckWait))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.TagType == input.TagType ||
                    (this.TagType != null &&
                    this.TagType.Equals(input.TagType))
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
                if (this.MaxMsgs != null)
                    hashCode = hashCode * 59 + this.MaxMsgs.GetHashCode();
                if (this.TimeWait != null)
                    hashCode = hashCode * 59 + this.TimeWait.GetHashCode();
                if (this.AckWait != null)
                    hashCode = hashCode * 59 + this.AckWait.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.TagType != null)
                    hashCode = hashCode * 59 + this.TagType.GetHashCode();
                return hashCode;
            }
        }
    }
}
