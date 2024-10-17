using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceTopicDetailResponse : SdkResponse
    {

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 分区列表。
        /// </summary>
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowInstanceTopicDetailRespPartitions> Partitions { get; set; }

        /// <summary>
        /// 订阅该topic的消费组名称列表。
        /// </summary>
        [JsonProperty("group_subscribed", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupSubscribed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceTopicDetailResponse {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("  groupSubscribed: ").Append(GroupSubscribed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceTopicDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceTopicDetailResponse input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Partitions != input.Partitions || (this.Partitions != null && input.Partitions != null && !this.Partitions.SequenceEqual(input.Partitions))) return false;
            if (this.GroupSubscribed != input.GroupSubscribed || (this.GroupSubscribed != null && input.GroupSubscribed != null && !this.GroupSubscribed.SequenceEqual(input.GroupSubscribed))) return false;

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
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Partitions != null) hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                if (this.GroupSubscribed != null) hashCode = hashCode * 59 + this.GroupSubscribed.GetHashCode();
                return hashCode;
            }
        }
    }
}
