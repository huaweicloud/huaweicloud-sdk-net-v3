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
    public class ShowInstanceTopicDetailRespReplicas 
    {

        /// <summary>
        /// 副本所在的节点ID。
        /// </summary>
        [JsonProperty("broker", NullValueHandling = NullValueHandling.Ignore)]
        public int? Broker { get; set; }

        /// <summary>
        /// 该副本是否为leader。
        /// </summary>
        [JsonProperty("leader", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Leader { get; set; }

        /// <summary>
        /// 该副本是否在ISR副本中。
        /// </summary>
        [JsonProperty("in_sync", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InSync { get; set; }

        /// <summary>
        /// 该副本当前日志大小。单位：Byte。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 该副本当前落后hw的消息数。
        /// </summary>
        [JsonProperty("lag", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceTopicDetailRespReplicas {\n");
            sb.Append("  broker: ").Append(Broker).Append("\n");
            sb.Append("  leader: ").Append(Leader).Append("\n");
            sb.Append("  inSync: ").Append(InSync).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  lag: ").Append(Lag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceTopicDetailRespReplicas);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceTopicDetailRespReplicas input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Broker == input.Broker ||
                    (this.Broker != null &&
                    this.Broker.Equals(input.Broker))
                ) && 
                (
                    this.Leader == input.Leader ||
                    (this.Leader != null &&
                    this.Leader.Equals(input.Leader))
                ) && 
                (
                    this.InSync == input.InSync ||
                    (this.InSync != null &&
                    this.InSync.Equals(input.InSync))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Lag == input.Lag ||
                    (this.Lag != null &&
                    this.Lag.Equals(input.Lag))
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
                if (this.Broker != null)
                    hashCode = hashCode * 59 + this.Broker.GetHashCode();
                if (this.Leader != null)
                    hashCode = hashCode * 59 + this.Leader.GetHashCode();
                if (this.InSync != null)
                    hashCode = hashCode * 59 + this.InSync.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Lag != null)
                    hashCode = hashCode * 59 + this.Lag.GetHashCode();
                return hashCode;
            }
        }
    }
}
