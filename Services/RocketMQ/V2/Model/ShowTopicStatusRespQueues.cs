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
    /// 
    /// </summary>
    public class ShowTopicStatusRespQueues 
    {

        /// <summary>
        /// 队列ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 最小偏移量。
        /// </summary>
        [JsonProperty("min_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinOffset { get; set; }

        /// <summary>
        /// 最大偏移量。
        /// </summary>
        [JsonProperty("max_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxOffset { get; set; }

        /// <summary>
        /// 最后一条消息的时间。
        /// </summary>
        [JsonProperty("last_message_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastMessageTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTopicStatusRespQueues {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  minOffset: ").Append(MinOffset).Append("\n");
            sb.Append("  maxOffset: ").Append(MaxOffset).Append("\n");
            sb.Append("  lastMessageTime: ").Append(LastMessageTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTopicStatusRespQueues);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTopicStatusRespQueues input)
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
                    this.MinOffset == input.MinOffset ||
                    (this.MinOffset != null &&
                    this.MinOffset.Equals(input.MinOffset))
                ) && 
                (
                    this.MaxOffset == input.MaxOffset ||
                    (this.MaxOffset != null &&
                    this.MaxOffset.Equals(input.MaxOffset))
                ) && 
                (
                    this.LastMessageTime == input.LastMessageTime ||
                    (this.LastMessageTime != null &&
                    this.LastMessageTime.Equals(input.LastMessageTime))
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
                if (this.MinOffset != null)
                    hashCode = hashCode * 59 + this.MinOffset.GetHashCode();
                if (this.MaxOffset != null)
                    hashCode = hashCode * 59 + this.MaxOffset.GetHashCode();
                if (this.LastMessageTime != null)
                    hashCode = hashCode * 59 + this.LastMessageTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
