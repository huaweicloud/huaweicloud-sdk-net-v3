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
    /// 
    /// </summary>
    public class ShowInstanceTopicDetailRespPartitions 
    {

        /// <summary>
        /// **参数解释**： 分区ID。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// **参数解释**： leader副本所在节点的id。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("leader", NullValueHandling = NullValueHandling.Ignore)]
        public int? Leader { get; set; }

        /// <summary>
        /// **参数解释**： 分区leader副本的LEO（Log End Offset）。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("leo", NullValueHandling = NullValueHandling.Ignore)]
        public long? Leo { get; set; }

        /// <summary>
        /// **参数解释**： 分区高水位（HW，High Watermark）。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("hw", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hw { get; set; }

        /// <summary>
        /// **参数解释**： 分区leader副本的LSO（Log Start Offset）。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("lso", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lso { get; set; }

        /// <summary>
        /// **参数解释**： 分区上次写入消息的时间。  格式为Unix时间戳。  单位：毫秒。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("last_update_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// **参数解释**： 副本列表。
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowInstanceTopicDetailRespReplicas> Replicas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceTopicDetailRespPartitions {\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  leader: ").Append(Leader).Append("\n");
            sb.Append("  leo: ").Append(Leo).Append("\n");
            sb.Append("  hw: ").Append(Hw).Append("\n");
            sb.Append("  lso: ").Append(Lso).Append("\n");
            sb.Append("  lastUpdateTimestamp: ").Append(LastUpdateTimestamp).Append("\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceTopicDetailRespPartitions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceTopicDetailRespPartitions input)
        {
            if (input == null) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.Leader != input.Leader || (this.Leader != null && !this.Leader.Equals(input.Leader))) return false;
            if (this.Leo != input.Leo || (this.Leo != null && !this.Leo.Equals(input.Leo))) return false;
            if (this.Hw != input.Hw || (this.Hw != null && !this.Hw.Equals(input.Hw))) return false;
            if (this.Lso != input.Lso || (this.Lso != null && !this.Lso.Equals(input.Lso))) return false;
            if (this.LastUpdateTimestamp != input.LastUpdateTimestamp || (this.LastUpdateTimestamp != null && !this.LastUpdateTimestamp.Equals(input.LastUpdateTimestamp))) return false;
            if (this.Replicas != input.Replicas || (this.Replicas != null && input.Replicas != null && !this.Replicas.SequenceEqual(input.Replicas))) return false;

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
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.Leader != null) hashCode = hashCode * 59 + this.Leader.GetHashCode();
                if (this.Leo != null) hashCode = hashCode * 59 + this.Leo.GetHashCode();
                if (this.Hw != null) hashCode = hashCode * 59 + this.Hw.GetHashCode();
                if (this.Lso != null) hashCode = hashCode * 59 + this.Lso.GetHashCode();
                if (this.LastUpdateTimestamp != null) hashCode = hashCode * 59 + this.LastUpdateTimestamp.GetHashCode();
                if (this.Replicas != null) hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                return hashCode;
            }
        }
    }
}
