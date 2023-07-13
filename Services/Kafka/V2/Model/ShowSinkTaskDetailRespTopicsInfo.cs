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
    public class ShowSinkTaskDetailRespTopicsInfo 
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
        public List<ShowSinkTaskDetailRespPartitions> Partitions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSinkTaskDetailRespTopicsInfo {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSinkTaskDetailRespTopicsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSinkTaskDetailRespTopicsInfo input)
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
                    this.Partitions == input.Partitions ||
                    this.Partitions != null &&
                    input.Partitions != null &&
                    this.Partitions.SequenceEqual(input.Partitions)
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
                if (this.Partitions != null)
                    hashCode = hashCode * 59 + this.Partitions.GetHashCode();
                return hashCode;
            }
        }
    }
}
