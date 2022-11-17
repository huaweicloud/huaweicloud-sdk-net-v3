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
    public class ListInstanceConsumerGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 所有的消费组ID
        /// </summary>
        [JsonProperty("group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 所有的消费组总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 下一个消费组序号
        /// </summary>
        [JsonProperty("next_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 上一个消费组序号
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
            sb.Append("  groupIds: ").Append(GroupIds).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
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
                    this.GroupIds == input.GroupIds ||
                    this.GroupIds != null &&
                    input.GroupIds != null &&
                    this.GroupIds.SequenceEqual(input.GroupIds)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.GroupIds != null)
                    hashCode = hashCode * 59 + this.GroupIds.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.NextOffset != null)
                    hashCode = hashCode * 59 + this.NextOffset.GetHashCode();
                if (this.PreviousOffset != null)
                    hashCode = hashCode * 59 + this.PreviousOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
