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
    public class ShowPartitionEndMessageResponse : SdkResponse
    {

        /// <summary>
        /// Topic名称。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 分区编号。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 最新消息位置。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 生产消息的时间。 格式为Unix时间戳。单位为毫秒。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPartitionEndMessageResponse {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPartitionEndMessageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPartitionEndMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Topic == input.Topic ||
                    (this.Topic != null &&
                    this.Topic.Equals(input.Topic))
                ) && 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.Topic != null)
                    hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
