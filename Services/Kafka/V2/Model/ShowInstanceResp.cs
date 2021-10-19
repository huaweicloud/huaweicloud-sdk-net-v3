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
    public class ShowInstanceResp 
    {
        /// <summary>
        /// 实例类型：集群，cluster。
        /// </summary>
        /// <value>实例类型：集群，cluster。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly TypeEnum SINGLE = new TypeEnum("single");

            /// <summary>
            /// Enum CLUSTER for value: cluster
            /// </summary>
            public static readonly TypeEnum CLUSTER = new TypeEnum("cluster");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "single", SINGLE },
                { "cluster", CLUSTER },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
            }

            public static TypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 消息老化策略。
        /// </summary>
        /// <value>消息老化策略。</value>
        [JsonConverter(typeof(EnumClassConverter<RetentionPolicyEnum>))]
        public class RetentionPolicyEnum
        {
            /// <summary>
            /// Enum TIME_BASE for value: time_base
            /// </summary>
            public static readonly RetentionPolicyEnum TIME_BASE = new RetentionPolicyEnum("time_base");

            /// <summary>
            /// Enum PRODUCE_REJECT for value: produce_reject
            /// </summary>
            public static readonly RetentionPolicyEnum PRODUCE_REJECT = new RetentionPolicyEnum("produce_reject");

            private static readonly Dictionary<string, RetentionPolicyEnum> StaticFields =
            new Dictionary<string, RetentionPolicyEnum>()
            {
                { "time_base", TIME_BASE },
                { "produce_reject", PRODUCE_REJECT },
            };

            private string Value;

            public RetentionPolicyEnum(string value)
            {
                Value = value;
            }

            public static RetentionPolicyEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as RetentionPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RetentionPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(RetentionPolicyEnum a, RetentionPolicyEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(RetentionPolicyEnum a, RetentionPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 引擎。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 实例规格。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// 消息存储空间，单位：GB。
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// Kafka实例的分区数量。
        /// </summary>
        [JsonProperty("partition_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionNum { get; set; }

        /// <summary>
        /// 已使用的消息存储空间，单位：GB。
        /// </summary>
        [JsonProperty("used_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedStorageSpace { get; set; }

        /// <summary>
        /// 实例连接IP地址。
        /// </summary>
        [JsonProperty("connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectAddress { get; set; }

        /// <summary>
        /// 实例连接端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 实例的状态。详细状态说明见[实例状态说明](https://support.huaweicloud.com/api-kafka/kafka-api-180514012.html)。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 资源规格标识。   - dms.instance.kafka.cluster.c3.mini：Kafka实例的基准带宽为100MByte/秒。   - dms.instance.kafka.cluster.c3.small.2：Kafka实例的基准带宽为300MByte/秒。   - dms.instance.kafka.cluster.c3.middle.2：Kafka实例的基准带宽为600MByte/秒。   - dms.instance.kafka.cluster.c3.high.2：Kafka实例的基准带宽为1200MByte/秒。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 付费模式，1表示按需计费，0表示包年/包月计费。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// VPC的名称。
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// 完成创建时间。  格式为时间戳，指从格林威治时间 1970年01月01日00时00分00秒起至指定时间的偏差总毫秒数。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 订单ID，只有在包周期计费时才会有order_id值，其他计费方式order_id值为空。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 维护时间窗开始时间，格式为HH:mm:ss。
        /// </summary>
        [JsonProperty("maintain_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainBegin { get; set; }

        /// <summary>
        /// 维护时间窗结束时间，格式为HH:mm:ss。
        /// </summary>
        [JsonProperty("maintain_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainEnd { get; set; }

        /// <summary>
        /// 实例是否开启公网访问功能。 - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// Kafka实例的KafkaManager连接地址。
        /// </summary>
        [JsonProperty("management_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementConnectAddress { get; set; }

        /// <summary>
        /// 是否开启安全认证。 - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 实例扩容时用于区分老实例与新实例。 - true：新创建的实例，允许磁盘动态扩容不需要重启。 - false：老实例
        /// </summary>
        [JsonProperty("is_logical_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLogicalVolume { get; set; }

        /// <summary>
        /// 实例扩容磁盘次数，如果超过20次则无法扩容磁盘。
        /// </summary>
        [JsonProperty("extend_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendTimes { get; set; }

        /// <summary>
        /// 是否打开kafka自动创建topic功能。   - true：开启   - false：关闭
        /// </summary>
        [JsonProperty("enable_auto_topic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoTopic { get; set; }

        /// <summary>
        /// 实例类型：集群，cluster。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 产品标识。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 租户安全组名称。
        /// </summary>
        [JsonProperty("security_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 实例节点所在的可用区，返回“可用区ID”。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 总共消息存储空间，单位：GB。
        /// </summary>
        [JsonProperty("total_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalStorageSpace { get; set; }

        /// <summary>
        /// 实例公网连接IP地址。当实例开启了公网访问，实例才包含该参数。
        /// </summary>
        [JsonProperty("public_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicConnectAddress { get; set; }

        /// <summary>
        /// 存储资源ID。
        /// </summary>
        [JsonProperty("storage_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageResourceId { get; set; }

        /// <summary>
        /// IO规格。
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSpecCode { get; set; }

        /// <summary>
        /// 服务类型。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 存储类型。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// 消息老化策略。
        /// </summary>
        [JsonProperty("retention_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RetentionPolicyEnum RetentionPolicy { get; set; }
        /// <summary>
        /// Kafka公网开启状态。
        /// </summary>
        [JsonProperty("kafka_public_status", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPublicStatus { get; set; }

        /// <summary>
        /// 公网带宽。
        /// </summary>
        [JsonProperty("public_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicBandwidth { get; set; }

        /// <summary>
        /// 登录Kafka Manager的用户名。
        /// </summary>
        [JsonProperty("kafka_manager_user", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaManagerUser { get; set; }

        /// <summary>
        /// 是否开启消息收集功能。
        /// </summary>
        [JsonProperty("enable_log_collection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLogCollection { get; set; }

        /// <summary>
        /// 跨VPC访问信息。
        /// </summary>
        [JsonProperty("cross_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossVpcInfo { get; set; }

        /// <summary>
        /// 是否开启ipv6。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// IPv6的连接地址。
        /// </summary>
        [JsonProperty("ipv6_connect_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6ConnectAddresses { get; set; }

        /// <summary>
        /// 是否开启转储。
        /// </summary>
        [JsonProperty("connector_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectorEnable { get; set; }

        /// <summary>
        /// 转储任务ID。
        /// </summary>
        [JsonProperty("connector_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// 是否开启Kafka rest功能。
        /// </summary>
        [JsonProperty("rest_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestEnable { get; set; }

        /// <summary>
        /// Kafka rest连接地址。
        /// </summary>
        [JsonProperty("rest_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RestConnectAddress { get; set; }

        /// <summary>
        /// 是否开启消息查询功能。
        /// </summary>
        [JsonProperty("message_query_inst_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MessageQueryInstEnable { get; set; }

        /// <summary>
        /// 是否开启VPC明文访问。
        /// </summary>
        [JsonProperty("vpc_client_plain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VpcClientPlain { get; set; }

        /// <summary>
        /// Kafka实例支持的特性功能。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportFeatures { get; set; }

        /// <summary>
        /// 是否开启消息轨迹功能。
        /// </summary>
        [JsonProperty("trace_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TraceEnable { get; set; }

        /// <summary>
        /// 租户侧连接地址。
        /// </summary>
        [JsonProperty("pod_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PodConnectAddress { get; set; }

        /// <summary>
        /// 是否开启磁盘加密。
        /// </summary>
        [JsonProperty("disk_encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiskEncrypted { get; set; }

        /// <summary>
        /// Kafka实例私有连接地址。
        /// </summary>
        [JsonProperty("kafka_private_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPrivateConnectAddress { get; set; }

        /// <summary>
        /// 云监控版本。
        /// </summary>
        [JsonProperty("ces_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CesVersion { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagEntity> Tags { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  partitionNum: ").Append(PartitionNum).Append("\n");
            sb.Append("  usedStorageSpace: ").Append(UsedStorageSpace).Append("\n");
            sb.Append("  connectAddress: ").Append(ConnectAddress).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  managementConnectAddress: ").Append(ManagementConnectAddress).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isLogicalVolume: ").Append(IsLogicalVolume).Append("\n");
            sb.Append("  extendTimes: ").Append(ExtendTimes).Append("\n");
            sb.Append("  enableAutoTopic: ").Append(EnableAutoTopic).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  securityGroupName: ").Append(SecurityGroupName).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  totalStorageSpace: ").Append(TotalStorageSpace).Append("\n");
            sb.Append("  publicConnectAddress: ").Append(PublicConnectAddress).Append("\n");
            sb.Append("  storageResourceId: ").Append(StorageResourceId).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  retentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  kafkaPublicStatus: ").Append(KafkaPublicStatus).Append("\n");
            sb.Append("  publicBandwidth: ").Append(PublicBandwidth).Append("\n");
            sb.Append("  kafkaManagerUser: ").Append(KafkaManagerUser).Append("\n");
            sb.Append("  enableLogCollection: ").Append(EnableLogCollection).Append("\n");
            sb.Append("  crossVpcInfo: ").Append(CrossVpcInfo).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  ipv6ConnectAddresses: ").Append(Ipv6ConnectAddresses).Append("\n");
            sb.Append("  connectorEnable: ").Append(ConnectorEnable).Append("\n");
            sb.Append("  connectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  restEnable: ").Append(RestEnable).Append("\n");
            sb.Append("  restConnectAddress: ").Append(RestConnectAddress).Append("\n");
            sb.Append("  messageQueryInstEnable: ").Append(MessageQueryInstEnable).Append("\n");
            sb.Append("  vpcClientPlain: ").Append(VpcClientPlain).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  traceEnable: ").Append(TraceEnable).Append("\n");
            sb.Append("  podConnectAddress: ").Append(PodConnectAddress).Append("\n");
            sb.Append("  diskEncrypted: ").Append(DiskEncrypted).Append("\n");
            sb.Append("  kafkaPrivateConnectAddress: ").Append(KafkaPrivateConnectAddress).Append("\n");
            sb.Append("  cesVersion: ").Append(CesVersion).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.StorageSpace == input.StorageSpace ||
                    (this.StorageSpace != null &&
                    this.StorageSpace.Equals(input.StorageSpace))
                ) && 
                (
                    this.PartitionNum == input.PartitionNum ||
                    (this.PartitionNum != null &&
                    this.PartitionNum.Equals(input.PartitionNum))
                ) && 
                (
                    this.UsedStorageSpace == input.UsedStorageSpace ||
                    (this.UsedStorageSpace != null &&
                    this.UsedStorageSpace.Equals(input.UsedStorageSpace))
                ) && 
                (
                    this.ConnectAddress == input.ConnectAddress ||
                    (this.ConnectAddress != null &&
                    this.ConnectAddress.Equals(input.ConnectAddress))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.ResourceSpecCode == input.ResourceSpecCode ||
                    (this.ResourceSpecCode != null &&
                    this.ResourceSpecCode.Equals(input.ResourceSpecCode))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.VpcName == input.VpcName ||
                    (this.VpcName != null &&
                    this.VpcName.Equals(input.VpcName))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.MaintainBegin == input.MaintainBegin ||
                    (this.MaintainBegin != null &&
                    this.MaintainBegin.Equals(input.MaintainBegin))
                ) && 
                (
                    this.MaintainEnd == input.MaintainEnd ||
                    (this.MaintainEnd != null &&
                    this.MaintainEnd.Equals(input.MaintainEnd))
                ) && 
                (
                    this.EnablePublicip == input.EnablePublicip ||
                    (this.EnablePublicip != null &&
                    this.EnablePublicip.Equals(input.EnablePublicip))
                ) && 
                (
                    this.ManagementConnectAddress == input.ManagementConnectAddress ||
                    (this.ManagementConnectAddress != null &&
                    this.ManagementConnectAddress.Equals(input.ManagementConnectAddress))
                ) && 
                (
                    this.SslEnable == input.SslEnable ||
                    (this.SslEnable != null &&
                    this.SslEnable.Equals(input.SslEnable))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.IsLogicalVolume == input.IsLogicalVolume ||
                    (this.IsLogicalVolume != null &&
                    this.IsLogicalVolume.Equals(input.IsLogicalVolume))
                ) && 
                (
                    this.ExtendTimes == input.ExtendTimes ||
                    (this.ExtendTimes != null &&
                    this.ExtendTimes.Equals(input.ExtendTimes))
                ) && 
                (
                    this.EnableAutoTopic == input.EnableAutoTopic ||
                    (this.EnableAutoTopic != null &&
                    this.EnableAutoTopic.Equals(input.EnableAutoTopic))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.SecurityGroupName == input.SecurityGroupName ||
                    (this.SecurityGroupName != null &&
                    this.SecurityGroupName.Equals(input.SecurityGroupName))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
                ) && 
                (
                    this.TotalStorageSpace == input.TotalStorageSpace ||
                    (this.TotalStorageSpace != null &&
                    this.TotalStorageSpace.Equals(input.TotalStorageSpace))
                ) && 
                (
                    this.PublicConnectAddress == input.PublicConnectAddress ||
                    (this.PublicConnectAddress != null &&
                    this.PublicConnectAddress.Equals(input.PublicConnectAddress))
                ) && 
                (
                    this.StorageResourceId == input.StorageResourceId ||
                    (this.StorageResourceId != null &&
                    this.StorageResourceId.Equals(input.StorageResourceId))
                ) && 
                (
                    this.StorageSpecCode == input.StorageSpecCode ||
                    (this.StorageSpecCode != null &&
                    this.StorageSpecCode.Equals(input.StorageSpecCode))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.RetentionPolicy == input.RetentionPolicy ||
                    (this.RetentionPolicy != null &&
                    this.RetentionPolicy.Equals(input.RetentionPolicy))
                ) && 
                (
                    this.KafkaPublicStatus == input.KafkaPublicStatus ||
                    (this.KafkaPublicStatus != null &&
                    this.KafkaPublicStatus.Equals(input.KafkaPublicStatus))
                ) && 
                (
                    this.PublicBandwidth == input.PublicBandwidth ||
                    (this.PublicBandwidth != null &&
                    this.PublicBandwidth.Equals(input.PublicBandwidth))
                ) && 
                (
                    this.KafkaManagerUser == input.KafkaManagerUser ||
                    (this.KafkaManagerUser != null &&
                    this.KafkaManagerUser.Equals(input.KafkaManagerUser))
                ) && 
                (
                    this.EnableLogCollection == input.EnableLogCollection ||
                    (this.EnableLogCollection != null &&
                    this.EnableLogCollection.Equals(input.EnableLogCollection))
                ) && 
                (
                    this.CrossVpcInfo == input.CrossVpcInfo ||
                    (this.CrossVpcInfo != null &&
                    this.CrossVpcInfo.Equals(input.CrossVpcInfo))
                ) && 
                (
                    this.Ipv6Enable == input.Ipv6Enable ||
                    (this.Ipv6Enable != null &&
                    this.Ipv6Enable.Equals(input.Ipv6Enable))
                ) && 
                (
                    this.Ipv6ConnectAddresses == input.Ipv6ConnectAddresses ||
                    this.Ipv6ConnectAddresses != null &&
                    input.Ipv6ConnectAddresses != null &&
                    this.Ipv6ConnectAddresses.SequenceEqual(input.Ipv6ConnectAddresses)
                ) && 
                (
                    this.ConnectorEnable == input.ConnectorEnable ||
                    (this.ConnectorEnable != null &&
                    this.ConnectorEnable.Equals(input.ConnectorEnable))
                ) && 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
                ) && 
                (
                    this.RestEnable == input.RestEnable ||
                    (this.RestEnable != null &&
                    this.RestEnable.Equals(input.RestEnable))
                ) && 
                (
                    this.RestConnectAddress == input.RestConnectAddress ||
                    (this.RestConnectAddress != null &&
                    this.RestConnectAddress.Equals(input.RestConnectAddress))
                ) && 
                (
                    this.MessageQueryInstEnable == input.MessageQueryInstEnable ||
                    (this.MessageQueryInstEnable != null &&
                    this.MessageQueryInstEnable.Equals(input.MessageQueryInstEnable))
                ) && 
                (
                    this.VpcClientPlain == input.VpcClientPlain ||
                    (this.VpcClientPlain != null &&
                    this.VpcClientPlain.Equals(input.VpcClientPlain))
                ) && 
                (
                    this.SupportFeatures == input.SupportFeatures ||
                    (this.SupportFeatures != null &&
                    this.SupportFeatures.Equals(input.SupportFeatures))
                ) && 
                (
                    this.TraceEnable == input.TraceEnable ||
                    (this.TraceEnable != null &&
                    this.TraceEnable.Equals(input.TraceEnable))
                ) && 
                (
                    this.PodConnectAddress == input.PodConnectAddress ||
                    (this.PodConnectAddress != null &&
                    this.PodConnectAddress.Equals(input.PodConnectAddress))
                ) && 
                (
                    this.DiskEncrypted == input.DiskEncrypted ||
                    (this.DiskEncrypted != null &&
                    this.DiskEncrypted.Equals(input.DiskEncrypted))
                ) && 
                (
                    this.KafkaPrivateConnectAddress == input.KafkaPrivateConnectAddress ||
                    (this.KafkaPrivateConnectAddress != null &&
                    this.KafkaPrivateConnectAddress.Equals(input.KafkaPrivateConnectAddress))
                ) && 
                (
                    this.CesVersion == input.CesVersion ||
                    (this.CesVersion != null &&
                    this.CesVersion.Equals(input.CesVersion))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.StorageSpace != null)
                    hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.PartitionNum != null)
                    hashCode = hashCode * 59 + this.PartitionNum.GetHashCode();
                if (this.UsedStorageSpace != null)
                    hashCode = hashCode * 59 + this.UsedStorageSpace.GetHashCode();
                if (this.ConnectAddress != null)
                    hashCode = hashCode * 59 + this.ConnectAddress.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcName != null)
                    hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.MaintainBegin != null)
                    hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null)
                    hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnablePublicip != null)
                    hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.ManagementConnectAddress != null)
                    hashCode = hashCode * 59 + this.ManagementConnectAddress.GetHashCode();
                if (this.SslEnable != null)
                    hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsLogicalVolume != null)
                    hashCode = hashCode * 59 + this.IsLogicalVolume.GetHashCode();
                if (this.ExtendTimes != null)
                    hashCode = hashCode * 59 + this.ExtendTimes.GetHashCode();
                if (this.EnableAutoTopic != null)
                    hashCode = hashCode * 59 + this.EnableAutoTopic.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SecurityGroupName != null)
                    hashCode = hashCode * 59 + this.SecurityGroupName.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.TotalStorageSpace != null)
                    hashCode = hashCode * 59 + this.TotalStorageSpace.GetHashCode();
                if (this.PublicConnectAddress != null)
                    hashCode = hashCode * 59 + this.PublicConnectAddress.GetHashCode();
                if (this.StorageResourceId != null)
                    hashCode = hashCode * 59 + this.StorageResourceId.GetHashCode();
                if (this.StorageSpecCode != null)
                    hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.RetentionPolicy != null)
                    hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.KafkaPublicStatus != null)
                    hashCode = hashCode * 59 + this.KafkaPublicStatus.GetHashCode();
                if (this.PublicBandwidth != null)
                    hashCode = hashCode * 59 + this.PublicBandwidth.GetHashCode();
                if (this.KafkaManagerUser != null)
                    hashCode = hashCode * 59 + this.KafkaManagerUser.GetHashCode();
                if (this.EnableLogCollection != null)
                    hashCode = hashCode * 59 + this.EnableLogCollection.GetHashCode();
                if (this.CrossVpcInfo != null)
                    hashCode = hashCode * 59 + this.CrossVpcInfo.GetHashCode();
                if (this.Ipv6Enable != null)
                    hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.Ipv6ConnectAddresses != null)
                    hashCode = hashCode * 59 + this.Ipv6ConnectAddresses.GetHashCode();
                if (this.ConnectorEnable != null)
                    hashCode = hashCode * 59 + this.ConnectorEnable.GetHashCode();
                if (this.ConnectorId != null)
                    hashCode = hashCode * 59 + this.ConnectorId.GetHashCode();
                if (this.RestEnable != null)
                    hashCode = hashCode * 59 + this.RestEnable.GetHashCode();
                if (this.RestConnectAddress != null)
                    hashCode = hashCode * 59 + this.RestConnectAddress.GetHashCode();
                if (this.MessageQueryInstEnable != null)
                    hashCode = hashCode * 59 + this.MessageQueryInstEnable.GetHashCode();
                if (this.VpcClientPlain != null)
                    hashCode = hashCode * 59 + this.VpcClientPlain.GetHashCode();
                if (this.SupportFeatures != null)
                    hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.TraceEnable != null)
                    hashCode = hashCode * 59 + this.TraceEnable.GetHashCode();
                if (this.PodConnectAddress != null)
                    hashCode = hashCode * 59 + this.PodConnectAddress.GetHashCode();
                if (this.DiskEncrypted != null)
                    hashCode = hashCode * 59 + this.DiskEncrypted.GetHashCode();
                if (this.KafkaPrivateConnectAddress != null)
                    hashCode = hashCode * 59 + this.KafkaPrivateConnectAddress.GetHashCode();
                if (this.CesVersion != null)
                    hashCode = hashCode * 59 + this.CesVersion.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
