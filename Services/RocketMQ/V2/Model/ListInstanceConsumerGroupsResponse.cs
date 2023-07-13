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
        /// 消费组总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// 消费组列表。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConsumerGroup> Groups { get; set; }

        /// <summary>
        /// 最大可创建消费组数量。
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Max { get; set; }

        /// <summary>
        /// 剩余可创建消费组数量。
        /// </summary>
        [JsonProperty("remaining", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Remaining { get; set; }

        /// <summary>
        /// 下个分页的offset。
        /// </summary>
        [JsonProperty("next_offset", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NextOffset { get; set; }

        /// <summary>
        /// 上个分页的offset。
        /// </summary>
        [JsonProperty("previous_offset", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PreviousOffset { get; set; }



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
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Remaining == input.Remaining ||
                    (this.Remaining != null &&
                    this.Remaining.Equals(input.Remaining))
                ) && 
                (
                    this.NextOffset == input.NextOffset ||
                    (this.NextOffset != null &&
                    this.NextOffset.Equals(input.NextOffset))
                ) && 
                (
                    this.PreviousOffset == input.PreviousOffset ||
                    (this.PreviousOffset != null &&
                    this.PreviousOffset.Equals(input.PreviousOffset))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Remaining != null)
                    hashCode = hashCode * 59 + this.Remaining.GetHashCode();
                if (this.NextOffset != null)
                    hashCode = hashCode * 59 + this.NextOffset.GetHashCode();
                if (this.PreviousOffset != null)
                    hashCode = hashCode * 59 + this.PreviousOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
