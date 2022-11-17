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
    public class DiskusageTopicEntity 
    {

        /// <summary>
        /// 磁盘使用量。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("topic_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// 分区。
        /// </summary>
        [JsonProperty("topic_partition", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicPartition { get; set; }

        /// <summary>
        /// 磁盘使用量的占比。
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskusageTopicEntity {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("  topicPartition: ").Append(TopicPartition).Append("\n");
            sb.Append("  percentage: ").Append(Percentage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskusageTopicEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskusageTopicEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && 
                (
                    this.TopicPartition == input.TopicPartition ||
                    (this.TopicPartition != null &&
                    this.TopicPartition.Equals(input.TopicPartition))
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    (this.Percentage != null &&
                    this.Percentage.Equals(input.Percentage))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.TopicPartition != null)
                    hashCode = hashCode * 59 + this.TopicPartition.GetHashCode();
                if (this.Percentage != null)
                    hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                return hashCode;
            }
        }
    }
}
