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
    /// 
    /// </summary>
    public class ListQueuesRespQueues 
    {

        /// <summary>
        /// 队列ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 队列的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 创建队列的时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; set; }

        /// <summary>
        /// 队列的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 队列类型。
        /// </summary>
        [JsonProperty("queue_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueMode { get; set; }

        /// <summary>
        /// 消息在队列中允许保留的时长（单位分钟）。
        /// </summary>
        [JsonProperty("reservation", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reservation { get; set; }

        /// <summary>
        /// 队列中允许的最大消息大小（单位Byte）。
        /// </summary>
        [JsonProperty("max_msg_size_byte", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxMsgSizeByte { get; set; }

        /// <summary>
        /// 队列的消息总数。
        /// </summary>
        [JsonProperty("produced_messages", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProducedMessages { get; set; }

        /// <summary>
        /// 该队列是否开启死信消息。仅当include_deadletter为true时，才有该响应参数。 - enable：表示开启。 - disable：表示不开启。
        /// </summary>
        [JsonProperty("redrive_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string RedrivePolicy { get; set; }

        /// <summary>
        /// 最大确认消费失败的次数，当达到最大确认失败次数后，DMS会将该条消息转存到死信队列中。  仅当include_deadletter为true时，才有该响应参数。
        /// </summary>
        [JsonProperty("max_consume_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxConsumeCount { get; set; }

        /// <summary>
        /// 该队列下的消费组数量。
        /// </summary>
        [JsonProperty("group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupCount { get; set; }

        /// <summary>
        /// 创建队列的时间。
        /// </summary>
        [JsonProperty("eff_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? EffDate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQueuesRespQueues {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  queueMode: ").Append(QueueMode).Append("\n");
            sb.Append("  reservation: ").Append(Reservation).Append("\n");
            sb.Append("  maxMsgSizeByte: ").Append(MaxMsgSizeByte).Append("\n");
            sb.Append("  producedMessages: ").Append(ProducedMessages).Append("\n");
            sb.Append("  redrivePolicy: ").Append(RedrivePolicy).Append("\n");
            sb.Append("  maxConsumeCount: ").Append(MaxConsumeCount).Append("\n");
            sb.Append("  groupCount: ").Append(GroupCount).Append("\n");
            sb.Append("  effDate: ").Append(EffDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQueuesRespQueues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQueuesRespQueues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.QueueMode == input.QueueMode ||
                    (this.QueueMode != null &&
                    this.QueueMode.Equals(input.QueueMode))
                ) && 
                (
                    this.Reservation == input.Reservation ||
                    (this.Reservation != null &&
                    this.Reservation.Equals(input.Reservation))
                ) && 
                (
                    this.MaxMsgSizeByte == input.MaxMsgSizeByte ||
                    (this.MaxMsgSizeByte != null &&
                    this.MaxMsgSizeByte.Equals(input.MaxMsgSizeByte))
                ) && 
                (
                    this.ProducedMessages == input.ProducedMessages ||
                    (this.ProducedMessages != null &&
                    this.ProducedMessages.Equals(input.ProducedMessages))
                ) && 
                (
                    this.RedrivePolicy == input.RedrivePolicy ||
                    (this.RedrivePolicy != null &&
                    this.RedrivePolicy.Equals(input.RedrivePolicy))
                ) && 
                (
                    this.MaxConsumeCount == input.MaxConsumeCount ||
                    (this.MaxConsumeCount != null &&
                    this.MaxConsumeCount.Equals(input.MaxConsumeCount))
                ) && 
                (
                    this.GroupCount == input.GroupCount ||
                    (this.GroupCount != null &&
                    this.GroupCount.Equals(input.GroupCount))
                ) && 
                (
                    this.EffDate == input.EffDate ||
                    (this.EffDate != null &&
                    this.EffDate.Equals(input.EffDate))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.QueueMode != null)
                    hashCode = hashCode * 59 + this.QueueMode.GetHashCode();
                if (this.Reservation != null)
                    hashCode = hashCode * 59 + this.Reservation.GetHashCode();
                if (this.MaxMsgSizeByte != null)
                    hashCode = hashCode * 59 + this.MaxMsgSizeByte.GetHashCode();
                if (this.ProducedMessages != null)
                    hashCode = hashCode * 59 + this.ProducedMessages.GetHashCode();
                if (this.RedrivePolicy != null)
                    hashCode = hashCode * 59 + this.RedrivePolicy.GetHashCode();
                if (this.MaxConsumeCount != null)
                    hashCode = hashCode * 59 + this.MaxConsumeCount.GetHashCode();
                if (this.GroupCount != null)
                    hashCode = hashCode * 59 + this.GroupCount.GetHashCode();
                if (this.EffDate != null)
                    hashCode = hashCode * 59 + this.EffDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
