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
    public class DeleteKafkaTopicMessagesResponse : SdkResponse
    {

        /// <summary>
        /// 分区响应信息
        /// </summary>
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PartitionResp> Partitions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteKafkaTopicMessagesResponse {\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteKafkaTopicMessagesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteKafkaTopicMessagesResponse input)
        {
            if (input == null) return false;
            if (this.Partitions != input.Partitions || (this.Partitions != null && input.Partitions != null && !this.Partitions.SequenceEqual(input.Partitions))) return false;

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
                if (this.Partitions != null) hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                return hashCode;
            }
        }
    }
}
