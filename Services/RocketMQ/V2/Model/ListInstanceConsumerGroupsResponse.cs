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
    public class ListInstanceConsumerGroupsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 消费组总数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// **参数解释**： 消费组列表。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConsumerGroup> Groups { get; set; }

        /// <summary>
        /// **参数解释**： 最大可创建消费组数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }

        /// <summary>
        /// **参数解释**： 剩余可创建消费组数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("remaining", NullValueHandling = NullValueHandling.Ignore)]
        public int? Remaining { get; set; }

        /// <summary>
        /// **参数解释**： 下个分页的offset。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("next_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// **参数解释**： 上个分页的offset。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("previous_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreviousOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceConsumerGroupsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  max: ").Append(Max).Append("\n");
            sb.Append("  remaining: ").Append(Remaining).Append("\n");
            sb.Append("  nextOffset: ").Append(NextOffset).Append("\n");
            sb.Append("  previousOffset: ").Append(PreviousOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceConsumerGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceConsumerGroupsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;
            if (this.Max != input.Max || (this.Max != null && !this.Max.Equals(input.Max))) return false;
            if (this.Remaining != input.Remaining || (this.Remaining != null && !this.Remaining.Equals(input.Remaining))) return false;
            if (this.NextOffset != input.NextOffset || (this.NextOffset != null && !this.NextOffset.Equals(input.NextOffset))) return false;
            if (this.PreviousOffset != input.PreviousOffset || (this.PreviousOffset != null && !this.PreviousOffset.Equals(input.PreviousOffset))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Max != null) hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Remaining != null) hashCode = hashCode * 59 + this.Remaining.GetHashCode();
                if (this.NextOffset != null) hashCode = hashCode * 59 + this.NextOffset.GetHashCode();
                if (this.PreviousOffset != null) hashCode = hashCode * 59 + this.PreviousOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
