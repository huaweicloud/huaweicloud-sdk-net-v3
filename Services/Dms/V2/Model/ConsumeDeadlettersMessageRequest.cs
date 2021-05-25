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
    public class ConsumeDeadlettersMessageRequest 
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
        /// 获取可消费的死信消息的条数。  &gt;单次消费返回的消息数量可能会少于指定条数，但多次消费最终可获取全部消息。  取值范围：1~10。  默认值：10
        /// </summary>
        [SDKProperty("max_msgs", IsQuery = true)]
        [JsonProperty("max_msgs", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxMsgs { get; set; }

        /// <summary>
        /// 设定消费组中可消费的死信为0时的读取消息等待时间。  如果在等待时间内有新的死信消息，则立即返回消费结果，如果等待时间内没有新的死信消息，则到等待时间后返回消费结果。  取值范围：1~60s  默认值：3s  说明：不带该参数或者配置为空，都默认为3s。
        /// </summary>
        [SDKProperty("time_wait", IsQuery = true)]
        [JsonProperty("time_wait", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeWait { get; set; }

        /// <summary>
        /// commit提交超时时间，在该时间内提交确认，确认有效，如果超过指定时间，系统会报消息确认超时，或handler无效。  取值范围：15~300s  默认值：30s  说明：不带该参数或者配置为空，都默认为30s。
        /// </summary>
        [SDKProperty("ack_wait", IsQuery = true)]
        [JsonProperty("ack_wait", NullValueHandling = NullValueHandling.Ignore)]
        public int? AckWait { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumeDeadlettersMessageRequest {\n");
            sb.Append("  queueId: ").Append(QueueId).Append("\n");
            sb.Append("  consumerGroupId: ").Append(ConsumerGroupId).Append("\n");
            sb.Append("  maxMsgs: ").Append(MaxMsgs).Append("\n");
            sb.Append("  timeWait: ").Append(TimeWait).Append("\n");
            sb.Append("  ackWait: ").Append(AckWait).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumeDeadlettersMessageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumeDeadlettersMessageRequest input)
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
                return hashCode;
            }
        }
    }
}
