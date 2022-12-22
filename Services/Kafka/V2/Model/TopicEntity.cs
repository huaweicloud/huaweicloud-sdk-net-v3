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
    public class TopicEntity 
    {

        /// <summary>
        /// 是否为默认策略。
        /// </summary>
        [JsonProperty("policiesOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PoliciesOnly { get; set; }

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 副本数，配置数据的可靠性。
        /// </summary>
        [JsonProperty("replication", NullValueHandling = NullValueHandling.Ignore)]
        public int? Replication { get; set; }

        /// <summary>
        /// topic分区数，设置消费的并发数。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 消息老化时间。
        /// </summary>
        [JsonProperty("retention_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionTime { get; set; }

        /// <summary>
        /// 是否开启同步复制，开启后，客户端生产消息时相应的也要设置acks&#x3D;-1，否则不生效，默认关闭。
        /// </summary>
        [JsonProperty("sync_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncReplication { get; set; }

        /// <summary>
        /// 是否使用同步落盘。默认值为false。同步落盘会导致性能降低。
        /// </summary>
        [JsonProperty("sync_message_flush", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncMessageFlush { get; set; }

        /// <summary>
        /// 扩展配置。
        /// </summary>
        [JsonProperty("external_configs", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExternalConfigs { get; set; }

        /// <summary>
        /// topic类型(0:普通Topic 1:系统(内部)Topic。
        /// </summary>
        [JsonProperty("topic_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopicType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicEntity {\n");
            sb.Append("  policiesOnly: ").Append(PoliciesOnly).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  replication: ").Append(Replication).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  retentionTime: ").Append(RetentionTime).Append("\n");
            sb.Append("  syncReplication: ").Append(SyncReplication).Append("\n");
            sb.Append("  syncMessageFlush: ").Append(SyncMessageFlush).Append("\n");
            sb.Append("  externalConfigs: ").Append(ExternalConfigs).Append("\n");
            sb.Append("  topicType: ").Append(TopicType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TopicEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TopicEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoliciesOnly == input.PoliciesOnly ||
                    (this.PoliciesOnly != null &&
                    this.PoliciesOnly.Equals(input.PoliciesOnly))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Replication == input.Replication ||
                    (this.Replication != null &&
                    this.Replication.Equals(input.Replication))
                ) && 
                (
                    this.Partition == input.Partition ||
                    (this.Partition != null &&
                    this.Partition.Equals(input.Partition))
                ) && 
                (
                    this.RetentionTime == input.RetentionTime ||
                    (this.RetentionTime != null &&
                    this.RetentionTime.Equals(input.RetentionTime))
                ) && 
                (
                    this.SyncReplication == input.SyncReplication ||
                    (this.SyncReplication != null &&
                    this.SyncReplication.Equals(input.SyncReplication))
                ) && 
                (
                    this.SyncMessageFlush == input.SyncMessageFlush ||
                    (this.SyncMessageFlush != null &&
                    this.SyncMessageFlush.Equals(input.SyncMessageFlush))
                ) && 
                (
                    this.ExternalConfigs == input.ExternalConfigs ||
                    (this.ExternalConfigs != null &&
                    this.ExternalConfigs.Equals(input.ExternalConfigs))
                ) && 
                (
                    this.TopicType == input.TopicType ||
                    (this.TopicType != null &&
                    this.TopicType.Equals(input.TopicType))
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
                if (this.PoliciesOnly != null)
                    hashCode = hashCode * 59 + this.PoliciesOnly.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Replication != null)
                    hashCode = hashCode * 59 + this.Replication.GetHashCode();
                if (this.Partition != null)
                    hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.RetentionTime != null)
                    hashCode = hashCode * 59 + this.RetentionTime.GetHashCode();
                if (this.SyncReplication != null)
                    hashCode = hashCode * 59 + this.SyncReplication.GetHashCode();
                if (this.SyncMessageFlush != null)
                    hashCode = hashCode * 59 + this.SyncMessageFlush.GetHashCode();
                if (this.ExternalConfigs != null)
                    hashCode = hashCode * 59 + this.ExternalConfigs.GetHashCode();
                if (this.TopicType != null)
                    hashCode = hashCode * 59 + this.TopicType.GetHashCode();
                return hashCode;
            }
        }
    }
}
