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
    /// 修改的Topic。
    /// </summary>
    public class UpdateInstanceTopicReqTopics 
    {

        /// <summary>
        /// Topic名称，不支持修改。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 老化时间，单位小时。
        /// </summary>
        [JsonProperty("retention_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionTime { get; set; }

        /// <summary>
        /// 是否同步复制。
        /// </summary>
        [JsonProperty("sync_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncReplication { get; set; }

        /// <summary>
        /// 是否同步落盘。
        /// </summary>
        [JsonProperty("sync_message_flush", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncMessageFlush { get; set; }

        /// <summary>
        /// 分区数。
        /// </summary>
        [JsonProperty("new_partition_numbers", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPartitionNumbers { get; set; }

        /// <summary>
        /// 增加分区时指定broker列表
        /// </summary>
        [JsonProperty("new_partition_brokers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> NewPartitionBrokers { get; set; }

        /// <summary>
        /// Topic配置
        /// </summary>
        [JsonProperty("topic_other_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateInstanceTopicReqTopicOtherConfigs> TopicOtherConfigs { get; set; }

        /// <summary>
        /// Topic描述
        /// </summary>
        [JsonProperty("topic_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceTopicReqTopics {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  retentionTime: ").Append(RetentionTime).Append("\n");
            sb.Append("  syncReplication: ").Append(SyncReplication).Append("\n");
            sb.Append("  syncMessageFlush: ").Append(SyncMessageFlush).Append("\n");
            sb.Append("  newPartitionNumbers: ").Append(NewPartitionNumbers).Append("\n");
            sb.Append("  newPartitionBrokers: ").Append(NewPartitionBrokers).Append("\n");
            sb.Append("  topicOtherConfigs: ").Append(TopicOtherConfigs).Append("\n");
            sb.Append("  topicDesc: ").Append(TopicDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceTopicReqTopics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceTopicReqTopics input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RetentionTime != input.RetentionTime || (this.RetentionTime != null && !this.RetentionTime.Equals(input.RetentionTime))) return false;
            if (this.SyncReplication != input.SyncReplication || (this.SyncReplication != null && !this.SyncReplication.Equals(input.SyncReplication))) return false;
            if (this.SyncMessageFlush != input.SyncMessageFlush || (this.SyncMessageFlush != null && !this.SyncMessageFlush.Equals(input.SyncMessageFlush))) return false;
            if (this.NewPartitionNumbers != input.NewPartitionNumbers || (this.NewPartitionNumbers != null && !this.NewPartitionNumbers.Equals(input.NewPartitionNumbers))) return false;
            if (this.NewPartitionBrokers != input.NewPartitionBrokers || (this.NewPartitionBrokers != null && input.NewPartitionBrokers != null && !this.NewPartitionBrokers.SequenceEqual(input.NewPartitionBrokers))) return false;
            if (this.TopicOtherConfigs != input.TopicOtherConfigs || (this.TopicOtherConfigs != null && input.TopicOtherConfigs != null && !this.TopicOtherConfigs.SequenceEqual(input.TopicOtherConfigs))) return false;
            if (this.TopicDesc != input.TopicDesc || (this.TopicDesc != null && !this.TopicDesc.Equals(input.TopicDesc))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RetentionTime != null) hashCode = hashCode * 59 + this.RetentionTime.GetHashCode();
                if (this.SyncReplication != null) hashCode = hashCode * 59 + this.SyncReplication.GetHashCode();
                if (this.SyncMessageFlush != null) hashCode = hashCode * 59 + this.SyncMessageFlush.GetHashCode();
                if (this.NewPartitionNumbers != null) hashCode = hashCode * 59 + this.NewPartitionNumbers.GetHashCode();
                if (this.NewPartitionBrokers != null) hashCode = hashCode * 59 + this.NewPartitionBrokers.GetHashCode();
                if (this.TopicOtherConfigs != null) hashCode = hashCode * 59 + this.TopicOtherConfigs.GetHashCode();
                if (this.TopicDesc != null) hashCode = hashCode * 59 + this.TopicDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
