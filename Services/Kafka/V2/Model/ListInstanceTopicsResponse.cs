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
    public class ListInstanceTopicsResponse : SdkResponse
    {

        /// <summary>
        /// topic总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 分页查询的大小。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 剩余分区数。
        /// </summary>
        [JsonProperty("remain_partitions", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainPartitions { get; set; }

        /// <summary>
        /// 分区总数。
        /// </summary>
        [JsonProperty("max_partitions", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxPartitions { get; set; }

        /// <summary>
        /// topic列表。
        /// </summary>
        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopicEntity> Topics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceTopicsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  remainPartitions: ").Append(RemainPartitions).Append("\n");
            sb.Append("  maxPartitions: ").Append(MaxPartitions).Append("\n");
            sb.Append("  topics: ").Append(Topics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceTopicsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceTopicsResponse input)
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
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.RemainPartitions == input.RemainPartitions ||
                    (this.RemainPartitions != null &&
                    this.RemainPartitions.Equals(input.RemainPartitions))
                ) && 
                (
                    this.MaxPartitions == input.MaxPartitions ||
                    (this.MaxPartitions != null &&
                    this.MaxPartitions.Equals(input.MaxPartitions))
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.RemainPartitions != null)
                    hashCode = hashCode * 59 + this.RemainPartitions.GetHashCode();
                if (this.MaxPartitions != null)
                    hashCode = hashCode * 59 + this.MaxPartitions.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                return hashCode;
            }
        }
    }
}
