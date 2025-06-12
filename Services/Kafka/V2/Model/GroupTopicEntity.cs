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
    /// 消费组Topic详情
    /// </summary>
    public class GroupTopicEntity 
    {

        /// <summary>
        /// Topic名称
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("partitions", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partitions { get; set; }

        /// <summary>
        /// 消息堆积数量
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupTopicEntity {\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  partitions: ").Append(Partitions).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupTopicEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupTopicEntity input)
        {
            if (input == null) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Partitions != input.Partitions || (this.Partitions != null && !this.Partitions.Equals(input.Partitions))) return false;
            if (this.Lag != input.Lag || (this.Lag != null && !this.Lag.Equals(input.Lag))) return false;

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
                if (this.Lag != null) hashCode = hashCode * 59 + this.Lag.GetHashCode();
                return hashCode;
            }
        }
    }
}
