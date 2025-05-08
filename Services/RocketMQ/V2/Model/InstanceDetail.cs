using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceDetail 
    {
        /// <summary>
        /// **参数解释**： 实例类型。 **取值范围**： - single：单机。 - cluster：集群。
        /// </summary>
        /// <value>**参数解释**： 实例类型。 **取值范围**： - single：单机。 - cluster：集群。</value>
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

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// **参数解释**： 实例名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 消息引擎。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// **参数解释**： 状态。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 消息描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 实例类型。 **取值范围**： - single：单机。 - cluster：集群。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： 实例规格。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// **参数解释**： 实例版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**： 实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 付费模式。 **取值范围**： [1表示按需计费。](tag:hws_eu,g42,hk_g42,tm,sbc,hk_sbc,hk_tm)[1表示按需计费，0表示包年/包月计费。](tag:hws,hws_eu,hws_hk,ctc) [计费模式，参数暂未使用。](tag:ocb,hws_ocb,hcs,fcs)
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// **参数解释**： 私有云ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**： 私有云名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// **参数解释**： 完成创建时间。  格式为时间戳，指从格林威治时间1970年01月01日00时00分00秒起至指定时间的偏差总毫秒数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 产品标识。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// **参数解释**： 安全组ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// **参数解释**： 安全组名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("security_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// **参数解释**： 子网ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 子网路由（仅RocketMQ 5.x版本会显示此字段）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// **参数解释**： 可用区ID列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 可用区名称列表。
        /// </summary>
        [JsonProperty("available_zone_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZoneNames { get; set; }

        /// <summary>
        /// **参数解释**： 用户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**： 用户名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// **参数解释**： 维护时间窗开始时间，格式为HH:mm:ss。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("maintain_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainBegin { get; set; }

        /// <summary>
        /// **参数解释**： 维护时间窗结束时间，格式为HH:mm:ss。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("maintain_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainEnd { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启消息收集功能。 **取值范围**： - true：开启。 - false：不开启。
        /// </summary>
        [JsonProperty("enable_log_collection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLogCollection { get; set; }

        /// <summary>
        /// **参数解释**： 存储空间，单位：GB。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 已用消息存储空间，单位：GB。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("used_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedStorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启公网。 **取值范围**： - true：开启。 - false：不开启。
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// **参数解释**： 实例绑定的弹性IP地址的ID。  以英文逗号隔开多个弹性IP地址的ID。  如果开启了公网访问功能（即enable_publicip为true），该字段为必选。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// **参数解释**： 公网IP地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("publicip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipAddress { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启SSL。 **取值范围**： - true：开启。 - false：未开启。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// **参数解释**： 跨VPC访问信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("cross_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossVpcInfo { get; set; }

        /// <summary>
        /// **参数解释**： 存储资源ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 存储规格代码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： 服务类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// **参数解释**： 存储类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// **参数解释**： 扩展时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("extend_times", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExtendTimes { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启IPv6。 **取值范围**： - true：开启。 - false：未开启。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// **参数解释**： 实例支持的特性功能。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportFeatures { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启磁盘加密。 **取值范围**： - true：开启。 - false：不开启。
        /// </summary>
        [JsonProperty("disk_encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiskEncrypted { get; set; }

        /// <summary>
        /// **参数解释**： 云监控版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ces_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CesVersion { get; set; }

        /// <summary>
        /// **参数解释**： 节点数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// **参数解释**： 是否启用新规格计费。 **取值范围**： - true：开启。 - false：未开启。
        /// </summary>
        [JsonProperty("new_spec_billing_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewSpecBillingEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启访问控制列表。 **取值范围**： - true：开启。 - false：未开启。
        /// </summary>
        [JsonProperty("enable_acl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcl { get; set; }

        /// <summary>
        /// **参数解释**： Broker节点数（仅RocketMQ 4.8.0版本会显示此字段）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerNum { get; set; }

        /// <summary>
        /// **参数解释**： 实例是否开启域名访问功能。 **取值范围**： - true：开启。 - false：未开启。
        /// </summary>
        [JsonProperty("dns_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DnsEnable { get; set; }

        /// <summary>
        /// **参数解释**： 元数据地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("namesrv_address", NullValueHandling = NullValueHandling.Ignore)]
        public string NamesrvAddress { get; set; }

        /// <summary>
        /// **参数解释**： 元数据域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("namesrv_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NamesrvDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 业务数据地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerAddress { get; set; }

        /// <summary>
        /// **参数解释**： 公网元数据地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_namesrv_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicNamesrvAddress { get; set; }

        /// <summary>
        /// **参数解释**： 公网元数据域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_namesrv_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicNamesrvDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 公网业务数据地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_broker_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBrokerAddress { get; set; }

        /// <summary>
        /// **参数解释**： grpc连接地址（仅RocketMQ 5.x版本会显示此字段）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("grpc_address", NullValueHandling = NullValueHandling.Ignore)]
        public string GrpcAddress { get; set; }

        /// <summary>
        /// **参数解释**： grpc连接域名（仅RocketMQ 5.x版本会显示此字段）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("grpc_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GrpcDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 公网grpc连接地址（仅RocketMQ 5.x版本会显示此字段）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_grpc_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicGrpcAddress { get; set; }

        /// <summary>
        /// **参数解释**： 公网grpc连接域名（仅RocketMQ 5.x版本会显示此字段）。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_grpc_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicGrpcDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 标签列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagEntity> Tags { get; set; }

        /// <summary>
        /// **参数解释**： 总存储空间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalStorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 资源规格。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： 生产TPS占比。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("produce_portion", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProducePortion { get; set; }

        /// <summary>
        /// **参数解释**： 消费TPS占比。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("consume_portion", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsumePortion { get; set; }

        /// <summary>
        /// **参数解释**： 是否为容灾实例。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("dr_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DrEnable { get; set; }

        /// <summary>
        /// **参数解释**： 配置ssl是否需要重启。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("config_ssl_need_restart_process", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConfigSslNeedRestartProcess { get; set; }

        /// <summary>
        /// **参数解释**： 实例使用的安全协议。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tls_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDetail {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  securityGroupName: ").Append(SecurityGroupName).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  subnetCidr: ").Append(SubnetCidr).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  availableZoneNames: ").Append(AvailableZoneNames).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  enableLogCollection: ").Append(EnableLogCollection).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  usedStorageSpace: ").Append(UsedStorageSpace).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  publicipAddress: ").Append(PublicipAddress).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  crossVpcInfo: ").Append(CrossVpcInfo).Append("\n");
            sb.Append("  storageResourceId: ").Append(StorageResourceId).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  extendTimes: ").Append(ExtendTimes).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  diskEncrypted: ").Append(DiskEncrypted).Append("\n");
            sb.Append("  cesVersion: ").Append(CesVersion).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  newSpecBillingEnable: ").Append(NewSpecBillingEnable).Append("\n");
            sb.Append("  enableAcl: ").Append(EnableAcl).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  dnsEnable: ").Append(DnsEnable).Append("\n");
            sb.Append("  namesrvAddress: ").Append(NamesrvAddress).Append("\n");
            sb.Append("  namesrvDomainName: ").Append(NamesrvDomainName).Append("\n");
            sb.Append("  brokerAddress: ").Append(BrokerAddress).Append("\n");
            sb.Append("  publicNamesrvAddress: ").Append(PublicNamesrvAddress).Append("\n");
            sb.Append("  publicNamesrvDomainName: ").Append(PublicNamesrvDomainName).Append("\n");
            sb.Append("  publicBrokerAddress: ").Append(PublicBrokerAddress).Append("\n");
            sb.Append("  grpcAddress: ").Append(GrpcAddress).Append("\n");
            sb.Append("  grpcDomainName: ").Append(GrpcDomainName).Append("\n");
            sb.Append("  publicGrpcAddress: ").Append(PublicGrpcAddress).Append("\n");
            sb.Append("  publicGrpcDomainName: ").Append(PublicGrpcDomainName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  totalStorageSpace: ").Append(TotalStorageSpace).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  producePortion: ").Append(ProducePortion).Append("\n");
            sb.Append("  consumePortion: ").Append(ConsumePortion).Append("\n");
            sb.Append("  drEnable: ").Append(DrEnable).Append("\n");
            sb.Append("  configSslNeedRestartProcess: ").Append(ConfigSslNeedRestartProcess).Append("\n");
            sb.Append("  tlsMode: ").Append(TlsMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDetail input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type) return false;
            if (this.Specification != input.Specification || (this.Specification != null && !this.Specification.Equals(input.Specification))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VpcName != input.VpcName || (this.VpcName != null && !this.VpcName.Equals(input.VpcName))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.SecurityGroupName != input.SecurityGroupName || (this.SecurityGroupName != null && !this.SecurityGroupName.Equals(input.SecurityGroupName))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SubnetCidr != input.SubnetCidr || (this.SubnetCidr != null && !this.SubnetCidr.Equals(input.SubnetCidr))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.AvailableZoneNames != input.AvailableZoneNames || (this.AvailableZoneNames != null && input.AvailableZoneNames != null && !this.AvailableZoneNames.SequenceEqual(input.AvailableZoneNames))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.MaintainBegin != input.MaintainBegin || (this.MaintainBegin != null && !this.MaintainBegin.Equals(input.MaintainBegin))) return false;
            if (this.MaintainEnd != input.MaintainEnd || (this.MaintainEnd != null && !this.MaintainEnd.Equals(input.MaintainEnd))) return false;
            if (this.EnableLogCollection != input.EnableLogCollection || (this.EnableLogCollection != null && !this.EnableLogCollection.Equals(input.EnableLogCollection))) return false;
            if (this.StorageSpace != input.StorageSpace || (this.StorageSpace != null && !this.StorageSpace.Equals(input.StorageSpace))) return false;
            if (this.UsedStorageSpace != input.UsedStorageSpace || (this.UsedStorageSpace != null && !this.UsedStorageSpace.Equals(input.UsedStorageSpace))) return false;
            if (this.EnablePublicip != input.EnablePublicip || (this.EnablePublicip != null && !this.EnablePublicip.Equals(input.EnablePublicip))) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.PublicipAddress != input.PublicipAddress || (this.PublicipAddress != null && !this.PublicipAddress.Equals(input.PublicipAddress))) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.CrossVpcInfo != input.CrossVpcInfo || (this.CrossVpcInfo != null && !this.CrossVpcInfo.Equals(input.CrossVpcInfo))) return false;
            if (this.StorageResourceId != input.StorageResourceId || (this.StorageResourceId != null && !this.StorageResourceId.Equals(input.StorageResourceId))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode || (this.StorageSpecCode != null && !this.StorageSpecCode.Equals(input.StorageSpecCode))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.StorageType != input.StorageType || (this.StorageType != null && !this.StorageType.Equals(input.StorageType))) return false;
            if (this.ExtendTimes != input.ExtendTimes || (this.ExtendTimes != null && !this.ExtendTimes.Equals(input.ExtendTimes))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.SupportFeatures != input.SupportFeatures || (this.SupportFeatures != null && !this.SupportFeatures.Equals(input.SupportFeatures))) return false;
            if (this.DiskEncrypted != input.DiskEncrypted || (this.DiskEncrypted != null && !this.DiskEncrypted.Equals(input.DiskEncrypted))) return false;
            if (this.CesVersion != input.CesVersion || (this.CesVersion != null && !this.CesVersion.Equals(input.CesVersion))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.NewSpecBillingEnable != input.NewSpecBillingEnable || (this.NewSpecBillingEnable != null && !this.NewSpecBillingEnable.Equals(input.NewSpecBillingEnable))) return false;
            if (this.EnableAcl != input.EnableAcl || (this.EnableAcl != null && !this.EnableAcl.Equals(input.EnableAcl))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;
            if (this.DnsEnable != input.DnsEnable || (this.DnsEnable != null && !this.DnsEnable.Equals(input.DnsEnable))) return false;
            if (this.NamesrvAddress != input.NamesrvAddress || (this.NamesrvAddress != null && !this.NamesrvAddress.Equals(input.NamesrvAddress))) return false;
            if (this.NamesrvDomainName != input.NamesrvDomainName || (this.NamesrvDomainName != null && !this.NamesrvDomainName.Equals(input.NamesrvDomainName))) return false;
            if (this.BrokerAddress != input.BrokerAddress || (this.BrokerAddress != null && !this.BrokerAddress.Equals(input.BrokerAddress))) return false;
            if (this.PublicNamesrvAddress != input.PublicNamesrvAddress || (this.PublicNamesrvAddress != null && !this.PublicNamesrvAddress.Equals(input.PublicNamesrvAddress))) return false;
            if (this.PublicNamesrvDomainName != input.PublicNamesrvDomainName || (this.PublicNamesrvDomainName != null && !this.PublicNamesrvDomainName.Equals(input.PublicNamesrvDomainName))) return false;
            if (this.PublicBrokerAddress != input.PublicBrokerAddress || (this.PublicBrokerAddress != null && !this.PublicBrokerAddress.Equals(input.PublicBrokerAddress))) return false;
            if (this.GrpcAddress != input.GrpcAddress || (this.GrpcAddress != null && !this.GrpcAddress.Equals(input.GrpcAddress))) return false;
            if (this.GrpcDomainName != input.GrpcDomainName || (this.GrpcDomainName != null && !this.GrpcDomainName.Equals(input.GrpcDomainName))) return false;
            if (this.PublicGrpcAddress != input.PublicGrpcAddress || (this.PublicGrpcAddress != null && !this.PublicGrpcAddress.Equals(input.PublicGrpcAddress))) return false;
            if (this.PublicGrpcDomainName != input.PublicGrpcDomainName || (this.PublicGrpcDomainName != null && !this.PublicGrpcDomainName.Equals(input.PublicGrpcDomainName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TotalStorageSpace != input.TotalStorageSpace || (this.TotalStorageSpace != null && !this.TotalStorageSpace.Equals(input.TotalStorageSpace))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ProducePortion != input.ProducePortion || (this.ProducePortion != null && !this.ProducePortion.Equals(input.ProducePortion))) return false;
            if (this.ConsumePortion != input.ConsumePortion || (this.ConsumePortion != null && !this.ConsumePortion.Equals(input.ConsumePortion))) return false;
            if (this.DrEnable != input.DrEnable || (this.DrEnable != null && !this.DrEnable.Equals(input.DrEnable))) return false;
            if (this.ConfigSslNeedRestartProcess != input.ConfigSslNeedRestartProcess || (this.ConfigSslNeedRestartProcess != null && !this.ConfigSslNeedRestartProcess.Equals(input.ConfigSslNeedRestartProcess))) return false;
            if (this.TlsMode != input.TlsMode || (this.TlsMode != null && !this.TlsMode.Equals(input.TlsMode))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcName != null) hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SecurityGroupName != null) hashCode = hashCode * 59 + this.SecurityGroupName.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SubnetCidr != null) hashCode = hashCode * 59 + this.SubnetCidr.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.AvailableZoneNames != null) hashCode = hashCode * 59 + this.AvailableZoneNames.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.MaintainBegin != null) hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null) hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnableLogCollection != null) hashCode = hashCode * 59 + this.EnableLogCollection.GetHashCode();
                if (this.StorageSpace != null) hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.UsedStorageSpace != null) hashCode = hashCode * 59 + this.UsedStorageSpace.GetHashCode();
                if (this.EnablePublicip != null) hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.PublicipAddress != null) hashCode = hashCode * 59 + this.PublicipAddress.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.CrossVpcInfo != null) hashCode = hashCode * 59 + this.CrossVpcInfo.GetHashCode();
                if (this.StorageResourceId != null) hashCode = hashCode * 59 + this.StorageResourceId.GetHashCode();
                if (this.StorageSpecCode != null) hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StorageType != null) hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.ExtendTimes != null) hashCode = hashCode * 59 + this.ExtendTimes.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.SupportFeatures != null) hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.DiskEncrypted != null) hashCode = hashCode * 59 + this.DiskEncrypted.GetHashCode();
                if (this.CesVersion != null) hashCode = hashCode * 59 + this.CesVersion.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.NewSpecBillingEnable != null) hashCode = hashCode * 59 + this.NewSpecBillingEnable.GetHashCode();
                if (this.EnableAcl != null) hashCode = hashCode * 59 + this.EnableAcl.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.DnsEnable != null) hashCode = hashCode * 59 + this.DnsEnable.GetHashCode();
                if (this.NamesrvAddress != null) hashCode = hashCode * 59 + this.NamesrvAddress.GetHashCode();
                if (this.NamesrvDomainName != null) hashCode = hashCode * 59 + this.NamesrvDomainName.GetHashCode();
                if (this.BrokerAddress != null) hashCode = hashCode * 59 + this.BrokerAddress.GetHashCode();
                if (this.PublicNamesrvAddress != null) hashCode = hashCode * 59 + this.PublicNamesrvAddress.GetHashCode();
                if (this.PublicNamesrvDomainName != null) hashCode = hashCode * 59 + this.PublicNamesrvDomainName.GetHashCode();
                if (this.PublicBrokerAddress != null) hashCode = hashCode * 59 + this.PublicBrokerAddress.GetHashCode();
                if (this.GrpcAddress != null) hashCode = hashCode * 59 + this.GrpcAddress.GetHashCode();
                if (this.GrpcDomainName != null) hashCode = hashCode * 59 + this.GrpcDomainName.GetHashCode();
                if (this.PublicGrpcAddress != null) hashCode = hashCode * 59 + this.PublicGrpcAddress.GetHashCode();
                if (this.PublicGrpcDomainName != null) hashCode = hashCode * 59 + this.PublicGrpcDomainName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TotalStorageSpace != null) hashCode = hashCode * 59 + this.TotalStorageSpace.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ProducePortion != null) hashCode = hashCode * 59 + this.ProducePortion.GetHashCode();
                if (this.ConsumePortion != null) hashCode = hashCode * 59 + this.ConsumePortion.GetHashCode();
                if (this.DrEnable != null) hashCode = hashCode * 59 + this.DrEnable.GetHashCode();
                if (this.ConfigSslNeedRestartProcess != null) hashCode = hashCode * 59 + this.ConfigSslNeedRestartProcess.GetHashCode();
                if (this.TlsMode != null) hashCode = hashCode * 59 + this.TlsMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
