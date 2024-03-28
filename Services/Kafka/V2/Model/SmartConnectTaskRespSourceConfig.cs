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
        /// Redis实例地址。（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("redis_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisAddress { get; set; }

        /// <summary>
        /// Redis实例类型。（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("redis_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisType { get; set; }

        /// <summary>
        /// DCS实例ID。（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("dcs_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DcsInstanceId { get; set; }

        /// <summary>
        /// 同步类型，“RDB_ONLY”为全量同步，“CUSTOM_OFFSET”为全量同步+增量同步。（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("sync_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncMode { get; set; }

        /// <summary>
        /// 全量同步重试间隔时间，单位：毫秒。（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("full_sync_wait_ms", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullSyncWaitMs { get; set; }

        /// <summary>
        /// 全量同步最大重试次数。（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("full_sync_max_retry", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullSyncMaxRetry { get; set; }

        /// <summary>
        /// 限速，单位为KB/s。-1表示不限速（仅源端类型为Redis时会显示）
        /// </summary>
        [JsonProperty("ratelimit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ratelimit { get; set; }

        /// <summary>
        /// 当前Kafka实例别名。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("current_cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentClusterName { get; set; }

        /// <summary>
        /// 对端Kafka实例别名。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 对端Kafka用户名。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 对端Kafka认证机制。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("sasl_mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string SaslMechanism { get; set; }

        /// <summary>
        /// 对端Kafka实例ID。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 对端Kafka实例地址。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("bootstrap_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string BootstrapServers { get; set; }

        /// <summary>
        /// 对端Kafka认证方式。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("security_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityProtocol { get; set; }

        /// <summary>
        /// 同步方向。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 是否同步消费进度。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("sync_consumer_offsets_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncConsumerOffsetsEnabled { get; set; }

        /// <summary>
        /// 副本数。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("replication_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// 任务数。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("task_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskNum { get; set; }

        /// <summary>
        /// 是否重命名Topic。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("rename_topic_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenameTopicEnabled { get; set; }

        /// <summary>
        /// 是否添加来源header。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("provenance_header_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProvenanceHeaderEnabled { get; set; }

        /// <summary>
        /// 启动偏移量，latest为获取最新的数据，earliest为获取最早的数据。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// 压缩算法。（仅源端类型为Kafka时会显示）
        /// </summary>
        [JsonProperty("compression_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressionType { get; set; }

        /// <summary>
        /// topic映射。（仅源端类型为Kafka时会显示）
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
            sb.Append("  redisAddress: ").Append(RedisAddress).Append("\n");
            sb.Append("  redisType: ").Append(RedisType).Append("\n");
            sb.Append("  dcsInstanceId: ").Append(DcsInstanceId).Append("\n");
            sb.Append("  syncMode: ").Append(SyncMode).Append("\n");
            sb.Append("  fullSyncWaitMs: ").Append(FullSyncWaitMs).Append("\n");
            sb.Append("  fullSyncMaxRetry: ").Append(FullSyncMaxRetry).Append("\n");
            sb.Append("  ratelimit: ").Append(Ratelimit).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.RedisAddress == input.RedisAddress ||
                    (this.RedisAddress != null &&
                    this.RedisAddress.Equals(input.RedisAddress))
                ) && 
                (
                    this.RedisType == input.RedisType ||
                    (this.RedisType != null &&
                    this.RedisType.Equals(input.RedisType))
                ) && 
                (
                    this.DcsInstanceId == input.DcsInstanceId ||
                    (this.DcsInstanceId != null &&
                    this.DcsInstanceId.Equals(input.DcsInstanceId))
                ) && 
                (
                    this.SyncMode == input.SyncMode ||
                    (this.SyncMode != null &&
                    this.SyncMode.Equals(input.SyncMode))
                ) && 
                (
                    this.FullSyncWaitMs == input.FullSyncWaitMs ||
                    (this.FullSyncWaitMs != null &&
                    this.FullSyncWaitMs.Equals(input.FullSyncWaitMs))
                ) && 
                (
                    this.FullSyncMaxRetry == input.FullSyncMaxRetry ||
                    (this.FullSyncMaxRetry != null &&
                    this.FullSyncMaxRetry.Equals(input.FullSyncMaxRetry))
                ) && 
                (
                    this.Ratelimit == input.Ratelimit ||
                    (this.Ratelimit != null &&
                    this.Ratelimit.Equals(input.Ratelimit))
                ) && 
                (
                    this.CurrentClusterName == input.CurrentClusterName ||
                    (this.CurrentClusterName != null &&
                    this.CurrentClusterName.Equals(input.CurrentClusterName))
                ) && 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.SaslMechanism == input.SaslMechanism ||
                    (this.SaslMechanism != null &&
                    this.SaslMechanism.Equals(input.SaslMechanism))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.BootstrapServers == input.BootstrapServers ||
                    (this.BootstrapServers != null &&
                    this.BootstrapServers.Equals(input.BootstrapServers))
                ) && 
                (
                    this.SecurityProtocol == input.SecurityProtocol ||
                    (this.SecurityProtocol != null &&
                    this.SecurityProtocol.Equals(input.SecurityProtocol))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.SyncConsumerOffsetsEnabled == input.SyncConsumerOffsetsEnabled ||
                    (this.SyncConsumerOffsetsEnabled != null &&
                    this.SyncConsumerOffsetsEnabled.Equals(input.SyncConsumerOffsetsEnabled))
                ) && 
                (
                    this.ReplicationFactor == input.ReplicationFactor ||
                    (this.ReplicationFactor != null &&
                    this.ReplicationFactor.Equals(input.ReplicationFactor))
                ) && 
                (
                    this.TaskNum == input.TaskNum ||
                    (this.TaskNum != null &&
                    this.TaskNum.Equals(input.TaskNum))
                ) && 
                (
                    this.RenameTopicEnabled == input.RenameTopicEnabled ||
                    (this.RenameTopicEnabled != null &&
                    this.RenameTopicEnabled.Equals(input.RenameTopicEnabled))
                ) && 
                (
                    this.ProvenanceHeaderEnabled == input.ProvenanceHeaderEnabled ||
                    (this.ProvenanceHeaderEnabled != null &&
                    this.ProvenanceHeaderEnabled.Equals(input.ProvenanceHeaderEnabled))
                ) && 
                (
                    this.ConsumerStrategy == input.ConsumerStrategy ||
                    (this.ConsumerStrategy != null &&
                    this.ConsumerStrategy.Equals(input.ConsumerStrategy))
                ) && 
                (
                    this.CompressionType == input.CompressionType ||
                    (this.CompressionType != null &&
                    this.CompressionType.Equals(input.CompressionType))
                ) && 
                (
                    this.TopicsMapping == input.TopicsMapping ||
                    (this.TopicsMapping != null &&
                    this.TopicsMapping.Equals(input.TopicsMapping))
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
                if (this.RedisAddress != null)
                    hashCode = hashCode * 59 + this.RedisAddress.GetHashCode();
                if (this.RedisType != null)
                    hashCode = hashCode * 59 + this.RedisType.GetHashCode();
                if (this.DcsInstanceId != null)
                    hashCode = hashCode * 59 + this.DcsInstanceId.GetHashCode();
                if (this.SyncMode != null)
                    hashCode = hashCode * 59 + this.SyncMode.GetHashCode();
                if (this.FullSyncWaitMs != null)
                    hashCode = hashCode * 59 + this.FullSyncWaitMs.GetHashCode();
                if (this.FullSyncMaxRetry != null)
                    hashCode = hashCode * 59 + this.FullSyncMaxRetry.GetHashCode();
                if (this.Ratelimit != null)
                    hashCode = hashCode * 59 + this.Ratelimit.GetHashCode();
                if (this.CurrentClusterName != null)
                    hashCode = hashCode * 59 + this.CurrentClusterName.GetHashCode();
                if (this.ClusterName != null)
                    hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.SaslMechanism != null)
                    hashCode = hashCode * 59 + this.SaslMechanism.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BootstrapServers != null)
                    hashCode = hashCode * 59 + this.BootstrapServers.GetHashCode();
                if (this.SecurityProtocol != null)
                    hashCode = hashCode * 59 + this.SecurityProtocol.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.SyncConsumerOffsetsEnabled != null)
                    hashCode = hashCode * 59 + this.SyncConsumerOffsetsEnabled.GetHashCode();
                if (this.ReplicationFactor != null)
                    hashCode = hashCode * 59 + this.ReplicationFactor.GetHashCode();
                if (this.TaskNum != null)
                    hashCode = hashCode * 59 + this.TaskNum.GetHashCode();
                if (this.RenameTopicEnabled != null)
                    hashCode = hashCode * 59 + this.RenameTopicEnabled.GetHashCode();
                if (this.ProvenanceHeaderEnabled != null)
                    hashCode = hashCode * 59 + this.ProvenanceHeaderEnabled.GetHashCode();
                if (this.ConsumerStrategy != null)
                    hashCode = hashCode * 59 + this.ConsumerStrategy.GetHashCode();
                if (this.CompressionType != null)
                    hashCode = hashCode * 59 + this.CompressionType.GetHashCode();
                if (this.TopicsMapping != null)
                    hashCode = hashCode * 59 + this.TopicsMapping.GetHashCode();
                return hashCode;
            }
        }
    }
}
