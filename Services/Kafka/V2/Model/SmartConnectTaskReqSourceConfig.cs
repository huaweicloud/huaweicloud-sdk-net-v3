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
    public class SmartConnectTaskReqSourceConfig 
    {

        /// <summary>
        /// Redis实例地址。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("redis_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisAddress { get; set; }

        /// <summary>
        /// Redis实例类型。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("redis_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisType { get; set; }

        /// <summary>
        /// DCS实例ID。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("dcs_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DcsInstanceId { get; set; }

        /// <summary>
        /// Redis密码。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("redis_password", NullValueHandling = NullValueHandling.Ignore)]
        public string RedisPassword { get; set; }

        /// <summary>
        /// 同步类型，“RDB_ONLY”为全量同步，“CUSTOM_OFFSET”为全量同步+增量同步。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("sync_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string SyncMode { get; set; }

        /// <summary>
        /// 全量同步重试间隔时间，单位：毫秒。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("full_sync_wait_ms", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullSyncWaitMs { get; set; }

        /// <summary>
        /// 全量同步最大重试次数。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("full_sync_max_retry", NullValueHandling = NullValueHandling.Ignore)]
        public int? FullSyncMaxRetry { get; set; }

        /// <summary>
        /// 限速，单位为KB/s。-1表示不限速。（仅源端类型为Redis时需要填写）
        /// </summary>
        [JsonProperty("ratelimit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ratelimit { get; set; }

        /// <summary>
        /// 当前Kafka实例别名。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("current_cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentClusterName { get; set; }

        /// <summary>
        /// 对端Kafka实例别名。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 对端Kafka开启SASL_SSL时设置的用户名，或者创建SASL_SSL用户时设置的用户名。（仅源端类型为Kafka且对端Kafka认证方式为“SASL_SSL”时需要填写）
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 对端Kafka开启SASL_SSL时设置的密码，或者创建SASL_SSL用户时设置的密码。（仅源端类型为Kafka且对端Kafka认证方式为“SASL_SSL”时需要填写）
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 对端Kafka认证机制。（仅源端类型为Kafka且“认证方式”为“SASL_SSL”时需要填写）
        /// </summary>
        [JsonProperty("sasl_mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string SaslMechanism { get; set; }

        /// <summary>
        /// 对端Kafka实例ID。（仅源端类型为Kafka时需要填写，instance_id和bootstrap_servers仅需要填写其中一个）
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 对端Kafka实例地址。（仅源端类型为Kafka时需要填写，instance_id和bootstrap_servers仅需要填写其中一个）
        /// </summary>
        [JsonProperty("bootstrap_servers", NullValueHandling = NullValueHandling.Ignore)]
        public string BootstrapServers { get; set; }

        /// <summary>
        /// 对端Kafka认证方式。（仅源端类型为Kafka需要填写） 支持以下两种认证方式：   - SASL_SSL：表示实例已开启SASL_SSL。   - PLAINTEXT：表示实例未开启SASL_SSL。 
        /// </summary>
        [JsonProperty("security_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityProtocol { get; set; }

        /// <summary>
        /// 同步方向；pull为把对端Kafka实例数据复制到当前Kafka实例中，push为把当前Kafka实例数据复制到对端Kafka实例中，two-way为对两端Kafka实例数据进行双向复制。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 是否同步消费进度。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("sync_consumer_offsets_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncConsumerOffsetsEnabled { get; set; }

        /// <summary>
        /// 在对端实例中自动创建Topic时，指定Topic的副本数，此参数值不能超过对端实例的代理数。如果对端实例中设置了“default.replication.factor”，此参数的优先级高于“default.replication.factor”。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("replication_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicationFactor { get; set; }

        /// <summary>
        /// 数据复制的任务数。默认值为2，建议保持默认值。如果“同步方式”为“双向”，实际任务数&#x3D;设置的任务数*2。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("task_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskNum { get; set; }

        /// <summary>
        /// 是否重命名Topic，在目标Topic名称前添加源端Kafka实例的别名，形成目标Topic新的名称。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("rename_topic_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenameTopicEnabled { get; set; }

        /// <summary>
        /// 目标Topic接收复制的消息，此消息header中包含消息来源。两端实例数据双向复制时，请开启“添加来源header”，防止循环复制。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("provenance_header_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProvenanceHeaderEnabled { get; set; }

        /// <summary>
        /// 启动偏移量，latest为获取最新的数据，earliest为获取最早的数据。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("consumer_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerStrategy { get; set; }

        /// <summary>
        /// 复制消息所使用的压缩算法。（仅源端类型为Kafka时需要填写） - none - gzip - snappy - lz4 - zstd 
        /// </summary>
        [JsonProperty("compression_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressionType { get; set; }

        /// <summary>
        /// topic映射，用于自定义目标端Topic名称。不能同时设置“重命名Topic”和“topic映射”。topic映射请按照“源端topic:目的端topic”的格式填写，如涉及多个topic映射，请用“,”分隔开，例如：topic-sc-1:topic-sc-2,topic-sc-3:topic-sc-4。（仅源端类型为Kafka时需要填写）
        /// </summary>
        [JsonProperty("topics_mapping", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicsMapping { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartConnectTaskReqSourceConfig {\n");
            sb.Append("  redisAddress: ").Append(RedisAddress).Append("\n");
            sb.Append("  redisType: ").Append(RedisType).Append("\n");
            sb.Append("  dcsInstanceId: ").Append(DcsInstanceId).Append("\n");
            sb.Append("  redisPassword: ").Append(RedisPassword).Append("\n");
            sb.Append("  syncMode: ").Append(SyncMode).Append("\n");
            sb.Append("  fullSyncWaitMs: ").Append(FullSyncWaitMs).Append("\n");
            sb.Append("  fullSyncMaxRetry: ").Append(FullSyncMaxRetry).Append("\n");
            sb.Append("  ratelimit: ").Append(Ratelimit).Append("\n");
            sb.Append("  currentClusterName: ").Append(CurrentClusterName).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
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
            return this.Equals(input as SmartConnectTaskReqSourceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartConnectTaskReqSourceConfig input)
        {
            if (input == null) return false;
            if (this.RedisAddress != input.RedisAddress || (this.RedisAddress != null && !this.RedisAddress.Equals(input.RedisAddress))) return false;
            if (this.RedisType != input.RedisType || (this.RedisType != null && !this.RedisType.Equals(input.RedisType))) return false;
            if (this.DcsInstanceId != input.DcsInstanceId || (this.DcsInstanceId != null && !this.DcsInstanceId.Equals(input.DcsInstanceId))) return false;
            if (this.RedisPassword != input.RedisPassword || (this.RedisPassword != null && !this.RedisPassword.Equals(input.RedisPassword))) return false;
            if (this.SyncMode != input.SyncMode || (this.SyncMode != null && !this.SyncMode.Equals(input.SyncMode))) return false;
            if (this.FullSyncWaitMs != input.FullSyncWaitMs || (this.FullSyncWaitMs != null && !this.FullSyncWaitMs.Equals(input.FullSyncWaitMs))) return false;
            if (this.FullSyncMaxRetry != input.FullSyncMaxRetry || (this.FullSyncMaxRetry != null && !this.FullSyncMaxRetry.Equals(input.FullSyncMaxRetry))) return false;
            if (this.Ratelimit != input.Ratelimit || (this.Ratelimit != null && !this.Ratelimit.Equals(input.Ratelimit))) return false;
            if (this.CurrentClusterName != input.CurrentClusterName || (this.CurrentClusterName != null && !this.CurrentClusterName.Equals(input.CurrentClusterName))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
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
                if (this.RedisAddress != null) hashCode = hashCode * 59 + this.RedisAddress.GetHashCode();
                if (this.RedisType != null) hashCode = hashCode * 59 + this.RedisType.GetHashCode();
                if (this.DcsInstanceId != null) hashCode = hashCode * 59 + this.DcsInstanceId.GetHashCode();
                if (this.RedisPassword != null) hashCode = hashCode * 59 + this.RedisPassword.GetHashCode();
                if (this.SyncMode != null) hashCode = hashCode * 59 + this.SyncMode.GetHashCode();
                if (this.FullSyncWaitMs != null) hashCode = hashCode * 59 + this.FullSyncWaitMs.GetHashCode();
                if (this.FullSyncMaxRetry != null) hashCode = hashCode * 59 + this.FullSyncMaxRetry.GetHashCode();
                if (this.Ratelimit != null) hashCode = hashCode * 59 + this.Ratelimit.GetHashCode();
                if (this.CurrentClusterName != null) hashCode = hashCode * 59 + this.CurrentClusterName.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
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
