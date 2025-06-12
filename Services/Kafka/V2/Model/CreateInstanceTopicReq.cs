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
    public class CreateInstanceTopicReq 
    {

        /// <summary>
        /// Topic名称，长度为3-200，以字母开头且只支持大小写字母、中横线、下划线、点以及数字。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 副本数，配置数据的可靠性。 取值范围：1-3。
        /// </summary>
        [JsonProperty("replication", NullValueHandling = NullValueHandling.Ignore)]
        public int? Replication { get; set; }

        /// <summary>
        /// 是否使用同步落盘。默认值为false。同步落盘会导致性能降低。
        /// </summary>
        [JsonProperty("sync_message_flush", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncMessageFlush { get; set; }

        /// <summary>
        /// Topic分区数，设置消费的并发数。 取值范围：1-200。
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public int? Partition { get; set; }

        /// <summary>
        /// 是否开启同步复制，开启后，客户端生产消息时相应的也要设置acks&#x3D;-1，否则不生效，默认关闭。
        /// </summary>
        [JsonProperty("sync_replication", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncReplication { get; set; }

        /// <summary>
        /// 消息老化时间。默认值为72。 取值范围1-720，单位小时。
        /// </summary>
        [JsonProperty("retention_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionTime { get; set; }

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
            sb.Append("class CreateInstanceTopicReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  replication: ").Append(Replication).Append("\n");
            sb.Append("  syncMessageFlush: ").Append(SyncMessageFlush).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  syncReplication: ").Append(SyncReplication).Append("\n");
            sb.Append("  retentionTime: ").Append(RetentionTime).Append("\n");
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
            return this.Equals(input as CreateInstanceTopicReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceTopicReq input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Replication != input.Replication || (this.Replication != null && !this.Replication.Equals(input.Replication))) return false;
            if (this.SyncMessageFlush != input.SyncMessageFlush || (this.SyncMessageFlush != null && !this.SyncMessageFlush.Equals(input.SyncMessageFlush))) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.SyncReplication != input.SyncReplication || (this.SyncReplication != null && !this.SyncReplication.Equals(input.SyncReplication))) return false;
            if (this.RetentionTime != input.RetentionTime || (this.RetentionTime != null && !this.RetentionTime.Equals(input.RetentionTime))) return false;
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
                if (this.Replication != null) hashCode = hashCode * 59 + this.Replication.GetHashCode();
                if (this.SyncMessageFlush != null) hashCode = hashCode * 59 + this.SyncMessageFlush.GetHashCode();
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.SyncReplication != null) hashCode = hashCode * 59 + this.SyncReplication.GetHashCode();
                if (this.RetentionTime != null) hashCode = hashCode * 59 + this.RetentionTime.GetHashCode();
                if (this.TopicOtherConfigs != null) hashCode = hashCode * 59 + this.TopicOtherConfigs.GetHashCode();
                if (this.TopicDesc != null) hashCode = hashCode * 59 + this.TopicDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
