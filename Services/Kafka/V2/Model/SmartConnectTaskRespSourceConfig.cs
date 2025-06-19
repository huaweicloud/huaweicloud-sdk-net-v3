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
    public class SmartConnectTaskRespSourceConfig 
    {

        /// <summary>
        /// **参数解释**： 当前Kafka实例别名。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("current_cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentClusterName { get; set; }

        /// <summary>
        /// **参数解释**： 对端Kafka实例别名。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// **参数解释**： 对端Kafka用户名。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**： 对端Kafka认证机制。（仅源端类型为Kafka时会显示） **取值范围**： - PLAIN - SCRAM-SHA-512
        /// </summary>
        [JsonProperty("sasl_mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string SaslMechanism { get; set; }

        /// <summary>
        /// **参数解释**： 对端Kafka实例ID。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 对端Kafka实例地址。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("bootstrap_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string BootstrapServers { get; set; }

        /// <summary>
        /// **参数解释**： 对端Kafka认证方式。（仅源端类型为Kafka时会显示） **取值范围**： - PLAINTEXT：不开启SSL，明文传输。 - SASL_SSL：采用SASL方式进行认证，数据通过SSL证书进行加密传输，安全性更高。 - SASL_PLAINTEXT：采用SASL方式进行认证，数据通过明文传输，性能更好。
        /// </summary>
        [JsonProperty("security_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityProtocol { get; set; }

        /// <summary>
        /// **参数解释**： 同步方向。（仅源端类型为Kafka时会显示） **取值范围**： - pull：拉取。 - push：推送。 - two-way：双向。
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// **参数解释**： 是否同步消费进度。（仅源端类型为Kafka时会显示） **取值范围**： - true：同步消费进度 - false：不同步消费进度
        /// </summary>
        [JsonProperty("sync_consumer_offsets_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncConsumerOffsetsEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 副本数。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("replication_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// **参数解释**： 任务数。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("task_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskNum { get; set; }

        /// <summary>
        /// **参数解释**： 是否重命名Topic。（仅源端类型为Kafka时会显示） **取值范围**： - true：重命名Topic。 - false：不进行重命名Topic。
        /// </summary>
        [JsonProperty("rename_topic_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenameTopicEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 是否添加来源header。（仅源端类型为Kafka时会显示） **取值范围**： - true：添加来源header。 - false：不添加来源header。
        /// </summary>
        [JsonProperty("provenance_header_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProvenanceHeaderEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 启动偏移量。（仅源端类型为Kafka时会显示） **取值范围**： - latest：获取最新的数据。 - earliest：获取最早的数据。
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// **参数解释**： 压缩算法。（仅源端类型为Kafka时会显示） **取值范围**： - none - gzip - snappy - lz4 - zstd
        /// </summary>
        [JsonProperty("compression_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressionType { get; set; }

        /// <summary>
        /// **参数解释**： Topic映射。（仅源端类型为Kafka时会显示） **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("topics_mapping", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicsMapping { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartConnectTaskRespSourceConfig {\n");
            sb.Append("  currentClusterName: ").Append(CurrentClusterName).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  saslMechanism: ").Append(SaslMechanism).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  bootstrapServers: ").Append(BootstrapServers).Append("\n");
            sb.Append("  securityProtocol: ").Append(SecurityProtocol).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  syncConsumerOffsetsEnabled: ").Append(SyncConsumerOffsetsEnabled).Append("\n");
            sb.Append("  replicationFactor: ").Append(ReplicationFactor).Append("\n");
            sb.Append("  taskNum: ").Append(TaskNum).Append("\n");
            sb.Append("  renameTopicEnabled: ").Append(RenameTopicEnabled).Append("\n");
            sb.Append("  provenanceHeaderEnabled: ").Append(ProvenanceHeaderEnabled).Append("\n");
            sb.Append("  consumerStrategy: ").Append(ConsumerStrategy).Append("\n");
            sb.Append("  compressionType: ").Append(CompressionType).Append("\n");
            sb.Append("  topicsMapping: ").Append(TopicsMapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartConnectTaskRespSourceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartConnectTaskRespSourceConfig input)
        {
            if (input == null) return false;
            if (this.CurrentClusterName != input.CurrentClusterName || (this.CurrentClusterName != null && !this.CurrentClusterName.Equals(input.CurrentClusterName))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.SaslMechanism != input.SaslMechanism || (this.SaslMechanism != null && !this.SaslMechanism.Equals(input.SaslMechanism))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.BootstrapServers != input.BootstrapServers || (this.BootstrapServers != null && !this.BootstrapServers.Equals(input.BootstrapServers))) return false;
            if (this.SecurityProtocol != input.SecurityProtocol || (this.SecurityProtocol != null && !this.SecurityProtocol.Equals(input.SecurityProtocol))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.SyncConsumerOffsetsEnabled != input.SyncConsumerOffsetsEnabled || (this.SyncConsumerOffsetsEnabled != null && !this.SyncConsumerOffsetsEnabled.Equals(input.SyncConsumerOffsetsEnabled))) return false;
            if (this.ReplicationFactor != input.ReplicationFactor || (this.ReplicationFactor != null && !this.ReplicationFactor.Equals(input.ReplicationFactor))) return false;
            if (this.TaskNum != input.TaskNum || (this.TaskNum != null && !this.TaskNum.Equals(input.TaskNum))) return false;
            if (this.RenameTopicEnabled != input.RenameTopicEnabled || (this.RenameTopicEnabled != null && !this.RenameTopicEnabled.Equals(input.RenameTopicEnabled))) return false;
            if (this.ProvenanceHeaderEnabled != input.ProvenanceHeaderEnabled || (this.ProvenanceHeaderEnabled != null && !this.ProvenanceHeaderEnabled.Equals(input.ProvenanceHeaderEnabled))) return false;
            if (this.ConsumerStrategy != input.ConsumerStrategy || (this.ConsumerStrategy != null && !this.ConsumerStrategy.Equals(input.ConsumerStrategy))) return false;
            if (this.CompressionType != input.CompressionType || (this.CompressionType != null && !this.CompressionType.Equals(input.CompressionType))) return false;
            if (this.TopicsMapping != input.TopicsMapping || (this.TopicsMapping != null && !this.TopicsMapping.Equals(input.TopicsMapping))) return false;

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
                if (this.CurrentClusterName != null) hashCode = hashCode * 59 + this.CurrentClusterName.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SaslMechanism != null) hashCode = hashCode * 59 + this.SaslMechanism.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BootstrapServers != null) hashCode = hashCode * 59 + this.BootstrapServers.GetHashCode();
                if (this.SecurityProtocol != null) hashCode = hashCode * 59 + this.SecurityProtocol.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.SyncConsumerOffsetsEnabled != null) hashCode = hashCode * 59 + this.SyncConsumerOffsetsEnabled.GetHashCode();
                if (this.ReplicationFactor != null) hashCode = hashCode * 59 + this.ReplicationFactor.GetHashCode();
                if (this.TaskNum != null) hashCode = hashCode * 59 + this.TaskNum.GetHashCode();
                if (this.RenameTopicEnabled != null) hashCode = hashCode * 59 + this.RenameTopicEnabled.GetHashCode();
                if (this.ProvenanceHeaderEnabled != null) hashCode = hashCode * 59 + this.ProvenanceHeaderEnabled.GetHashCode();
                if (this.ConsumerStrategy != null) hashCode = hashCode * 59 + this.ConsumerStrategy.GetHashCode();
                if (this.CompressionType != null) hashCode = hashCode * 59 + this.CompressionType.GetHashCode();
                if (this.TopicsMapping != null) hashCode = hashCode * 59 + this.TopicsMapping.GetHashCode();
                return hashCode;
            }
        }
    }
}
