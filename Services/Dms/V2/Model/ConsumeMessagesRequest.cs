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
        /// 
        /// </summary>
        [SDKProperty("queue_id", IsPath = true)]
        [JsonProperty("queue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("consumer_group_id", IsPath = true)]
        [JsonProperty("consumer_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("max_msgs", IsQuery = true)]
        [JsonProperty("max_msgs", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxMsgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("time_wait", IsQuery = true)]
        [JsonProperty("time_wait", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeWait { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ack_wait", IsQuery = true)]
        [JsonProperty("ack_wait", NullValueHandling = NullValueHandling.Ignore)]
        public int? AckWait { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 
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
