using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**： 代理个数。 **取值范围**： - 1 - 3 - 5 - 7
        /// </summary>
        /// <value>**参数解释**： 代理个数。 **取值范围**： - 1 - 3 - 5 - 7</value>
        [JsonConverter(typeof(EnumClassConverter<BrokerNumEnum>))]
        public class BrokerNumEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly BrokerNumEnum NUMBER_1 = new BrokerNumEnum(1);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly BrokerNumEnum NUMBER_3 = new BrokerNumEnum(3);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly BrokerNumEnum NUMBER_5 = new BrokerNumEnum(5);

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            public static readonly BrokerNumEnum NUMBER_7 = new BrokerNumEnum(7);

            private static readonly Dictionary<int?, BrokerNumEnum> StaticFields =
            new Dictionary<int?, BrokerNumEnum>()
            {
                { 1, NUMBER_1 },
                { 3, NUMBER_3 },
                { 5, NUMBER_5 },
                { 7, NUMBER_7 },
            };

            private int? _value;

            public BrokerNumEnum()
            {

            }

            public BrokerNumEnum(int? value)
            {
                _value = value;
            }

            public static BrokerNumEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as BrokerNumEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BrokerNumEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BrokerNumEnum a, BrokerNumEnum b)
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

            public static bool operator !=(BrokerNumEnum a, BrokerNumEnum b)
            {
                return !(a == b);
            }
        }

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
        /// **参数解释**： 认证用户名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

        /// <summary>
        /// **参数解释**： 代理个数。 **取值范围**： - 1 - 3 - 5 - 7
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public BrokerNumEnum BrokerNum { get; set; }
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
        /// **参数解释**： 消息引擎版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**： 实例规格。 **取值范围**： - 单机实例：返回vm规格。 - 集群实例：返回vm规格和节点数。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// **参数解释**： 消息存储空间，单位：GB。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 已使用的消息存储空间，单位：GB。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("used_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedStorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 实例是否开启域名访问功能。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("dns_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DnsEnable { get; set; }

        /// <summary>
        /// **参数解释**： 实例内网连接IP地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 实例内网连接域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("connect_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 实例公网连接IP地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 实例公网连接域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_connect_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicConnectDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 实例连接端口。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数解释**： 实例状态。 **取值范围**： [详细状态说明请参考[实例状态说明](rabbitmq-api-180514012.xml)](tag:hws,hws_eu,hws_hk,cmcc,ctc,sbc,hk_sbc,g42,hk_g42,tm,hk_tm)[详细状态说明请参考[实例状态说明](kafka-api-180514012.xml)](tag:hcs)。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 实例描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 资源规格标识。 **取值范围**： [- dms.instance.rabbitmq.single.c3.2u4g：RabbitMQ单机，vm规格2u4g - dms.instance.rabbitmq.single.c3.4u8g：RabbitMQ单机，vm规格4u8g - dms.instance.rabbitmq.single.c3.8u16g：RabbitMQ单机，vm规格8u16g - dms.instance.rabbitmq.single.c3.16u32g：RabbitMQ单机，vm规格16u32g - dms.instance.rabbitmq.cluster.c3.4u8g.3：RabbitMQ集群，vm规格4u8g，3个节点 - dms.instance.rabbitmq.cluster.c3.4u8g.5：RabbitMQ集群，vm规格4u8g，5个节点 - dms.instance.rabbitmq.cluster.c3.4u8g.7：RabbitMQ集群，vm规格4u8g，7个节点 - dms.instance.rabbitmq.cluster.c3.8u16g.3：RabbitMQ集群，vm规格8u16g，3个节点 - dms.instance.rabbitmq.cluster.c3.8u16g.5：RabbitMQ集群，vm规格8u16g，5个节点 - dms.instance.rabbitmq.cluster.c3.8u16g.7：RabbitMQ集群，vm规格8u16g，7个节点 - dms.instance.rabbitmq.cluster.c3.16u32g.3：RabbitMQ集群，vm规格16u32g，3个节点 - dms.instance.rabbitmq.cluster.c3.16u32g.5：RabbitMQ集群，vm规格16u32g，5个节点 - dms.instance.rabbitmq.cluster.c3.16u32g.7：RabbitMQ集群，vm规格16u32g，7个节点](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,sbc)
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： 付费模式。 **取值范围**： - 1：按需计费。 - 0：包年/包月计费。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// **参数解释**： VPC ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**： VPC的名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// **参数解释**： 完成创建时间。格式为时间戳，指从格林威治时间 1970年01月01日00时00分00秒起至指定时间的偏差总毫秒数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

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
        /// **参数解释**： 订单ID，只有在包周期计费时才会有order_id值，其他计费方式order_id值为空。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

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
        /// **参数解释**： RabbitMQ实例是否开启公网访问功能。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ实例绑定的弹性IP地址。  如果未开启公网访问功能，该字段值为null。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("publicip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipAddress { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ实例绑定的弹性IP地址的ID。  如果未开启公网访问功能，该字段值为null。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ实例的管理地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("management_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ实例的管理域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("management_connect_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementConnectDomainName { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ实例的公网管理地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_management_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicManagementConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： RabbitMQ实例的公网管理域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_management_connect_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicManagementConnectDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启安全认证。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 实例扩容时用于区分老实例与新实例。 **取值范围**： - true：新创建的实例，允许磁盘动态扩容不需要重启。 - false：特别老的实例不支持磁盘扩容。
        /// </summary>
        [JsonProperty("is_logical_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLogicalVolume { get; set; }

        /// <summary>
        /// **参数解释**： 实例扩容磁盘次数，如果超过20次则无法扩容磁盘。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("extend_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendTimes { get; set; }

        /// <summary>
        /// **参数解释**： 实例类型。 **取值范围**： - single：单机。 - cluster：集群。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
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
        /// **参数解释**： 租户安全组名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("security_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// **参数解释**： 子网ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 实例节点所在的可用区ID。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 实例节点所在的可用区名称。
        /// </summary>
        [JsonProperty("available_zone_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZoneNames { get; set; }

        /// <summary>
        /// **参数解释**： 总共消息存储空间，单位：GB。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalStorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 存储资源ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageResourceId { get; set; }

        /// <summary>
        /// **参数解释**： IO规格。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启IPv6。 **取值范围**： - true：开启。 - false：不开启。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// **参数解释**： IPv6的连接地址。
        /// </summary>
        [JsonProperty("ipv6_connect_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6ConnectAddresses { get; set; }

        /// <summary>
        /// **参数解释**： 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagEntity> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceResponse {\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  usedStorageSpace: ").Append(UsedStorageSpace).Append("\n");
            sb.Append("  dnsEnable: ").Append(DnsEnable).Append("\n");
            sb.Append("  connectAddress: ").Append(ConnectAddress).Append("\n");
            sb.Append("  connectDomainName: ").Append(ConnectDomainName).Append("\n");
            sb.Append("  publicConnectAddress: ").Append(PublicConnectAddress).Append("\n");
            sb.Append("  publicConnectDomainName: ").Append(PublicConnectDomainName).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
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
            sb.Append("  publicipAddress: ").Append(PublicipAddress).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  managementConnectAddress: ").Append(ManagementConnectAddress).Append("\n");
            sb.Append("  managementConnectDomainName: ").Append(ManagementConnectDomainName).Append("\n");
            sb.Append("  publicManagementConnectAddress: ").Append(PublicManagementConnectAddress).Append("\n");
            sb.Append("  publicManagementConnectDomainName: ").Append(PublicManagementConnectDomainName).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isLogicalVolume: ").Append(IsLogicalVolume).Append("\n");
            sb.Append("  extendTimes: ").Append(ExtendTimes).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  securityGroupName: ").Append(SecurityGroupName).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  availableZoneNames: ").Append(AvailableZoneNames).Append("\n");
            sb.Append("  totalStorageSpace: ").Append(TotalStorageSpace).Append("\n");
            sb.Append("  storageResourceId: ").Append(StorageResourceId).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  ipv6ConnectAddresses: ").Append(Ipv6ConnectAddresses).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceResponse input)
        {
            if (input == null) return false;
            if (this.AccessUser != input.AccessUser || (this.AccessUser != null && !this.AccessUser.Equals(input.AccessUser))) return false;
            if (this.BrokerNum != input.BrokerNum) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.Specification != input.Specification || (this.Specification != null && !this.Specification.Equals(input.Specification))) return false;
            if (this.StorageSpace != input.StorageSpace || (this.StorageSpace != null && !this.StorageSpace.Equals(input.StorageSpace))) return false;
            if (this.UsedStorageSpace != input.UsedStorageSpace || (this.UsedStorageSpace != null && !this.UsedStorageSpace.Equals(input.UsedStorageSpace))) return false;
            if (this.DnsEnable != input.DnsEnable || (this.DnsEnable != null && !this.DnsEnable.Equals(input.DnsEnable))) return false;
            if (this.ConnectAddress != input.ConnectAddress || (this.ConnectAddress != null && !this.ConnectAddress.Equals(input.ConnectAddress))) return false;
            if (this.ConnectDomainName != input.ConnectDomainName || (this.ConnectDomainName != null && !this.ConnectDomainName.Equals(input.ConnectDomainName))) return false;
            if (this.PublicConnectAddress != input.PublicConnectAddress || (this.PublicConnectAddress != null && !this.PublicConnectAddress.Equals(input.PublicConnectAddress))) return false;
            if (this.PublicConnectDomainName != input.PublicConnectDomainName || (this.PublicConnectDomainName != null && !this.PublicConnectDomainName.Equals(input.PublicConnectDomainName))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VpcName != input.VpcName || (this.VpcName != null && !this.VpcName.Equals(input.VpcName))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.MaintainBegin != input.MaintainBegin || (this.MaintainBegin != null && !this.MaintainBegin.Equals(input.MaintainBegin))) return false;
            if (this.MaintainEnd != input.MaintainEnd || (this.MaintainEnd != null && !this.MaintainEnd.Equals(input.MaintainEnd))) return false;
            if (this.EnablePublicip != input.EnablePublicip || (this.EnablePublicip != null && !this.EnablePublicip.Equals(input.EnablePublicip))) return false;
            if (this.PublicipAddress != input.PublicipAddress || (this.PublicipAddress != null && !this.PublicipAddress.Equals(input.PublicipAddress))) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.ManagementConnectAddress != input.ManagementConnectAddress || (this.ManagementConnectAddress != null && !this.ManagementConnectAddress.Equals(input.ManagementConnectAddress))) return false;
            if (this.ManagementConnectDomainName != input.ManagementConnectDomainName || (this.ManagementConnectDomainName != null && !this.ManagementConnectDomainName.Equals(input.ManagementConnectDomainName))) return false;
            if (this.PublicManagementConnectAddress != input.PublicManagementConnectAddress || (this.PublicManagementConnectAddress != null && !this.PublicManagementConnectAddress.Equals(input.PublicManagementConnectAddress))) return false;
            if (this.PublicManagementConnectDomainName != input.PublicManagementConnectDomainName || (this.PublicManagementConnectDomainName != null && !this.PublicManagementConnectDomainName.Equals(input.PublicManagementConnectDomainName))) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IsLogicalVolume != input.IsLogicalVolume || (this.IsLogicalVolume != null && !this.IsLogicalVolume.Equals(input.IsLogicalVolume))) return false;
            if (this.ExtendTimes != input.ExtendTimes || (this.ExtendTimes != null && !this.ExtendTimes.Equals(input.ExtendTimes))) return false;
            if (this.Type != input.Type) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.SecurityGroupName != input.SecurityGroupName || (this.SecurityGroupName != null && !this.SecurityGroupName.Equals(input.SecurityGroupName))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.AvailableZoneNames != input.AvailableZoneNames || (this.AvailableZoneNames != null && input.AvailableZoneNames != null && !this.AvailableZoneNames.SequenceEqual(input.AvailableZoneNames))) return false;
            if (this.TotalStorageSpace != input.TotalStorageSpace || (this.TotalStorageSpace != null && !this.TotalStorageSpace.Equals(input.TotalStorageSpace))) return false;
            if (this.StorageResourceId != input.StorageResourceId || (this.StorageResourceId != null && !this.StorageResourceId.Equals(input.StorageResourceId))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode || (this.StorageSpecCode != null && !this.StorageSpecCode.Equals(input.StorageSpecCode))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.Ipv6ConnectAddresses != input.Ipv6ConnectAddresses || (this.Ipv6ConnectAddresses != null && input.Ipv6ConnectAddresses != null && !this.Ipv6ConnectAddresses.SequenceEqual(input.Ipv6ConnectAddresses))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.AccessUser != null) hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null) hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.StorageSpace != null) hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.UsedStorageSpace != null) hashCode = hashCode * 59 + this.UsedStorageSpace.GetHashCode();
                if (this.DnsEnable != null) hashCode = hashCode * 59 + this.DnsEnable.GetHashCode();
                if (this.ConnectAddress != null) hashCode = hashCode * 59 + this.ConnectAddress.GetHashCode();
                if (this.ConnectDomainName != null) hashCode = hashCode * 59 + this.ConnectDomainName.GetHashCode();
                if (this.PublicConnectAddress != null) hashCode = hashCode * 59 + this.PublicConnectAddress.GetHashCode();
                if (this.PublicConnectDomainName != null) hashCode = hashCode * 59 + this.PublicConnectDomainName.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcName != null) hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.MaintainBegin != null) hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null) hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnablePublicip != null) hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.PublicipAddress != null) hashCode = hashCode * 59 + this.PublicipAddress.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.ManagementConnectAddress != null) hashCode = hashCode * 59 + this.ManagementConnectAddress.GetHashCode();
                if (this.ManagementConnectDomainName != null) hashCode = hashCode * 59 + this.ManagementConnectDomainName.GetHashCode();
                if (this.PublicManagementConnectAddress != null) hashCode = hashCode * 59 + this.PublicManagementConnectAddress.GetHashCode();
                if (this.PublicManagementConnectDomainName != null) hashCode = hashCode * 59 + this.PublicManagementConnectDomainName.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsLogicalVolume != null) hashCode = hashCode * 59 + this.IsLogicalVolume.GetHashCode();
                if (this.ExtendTimes != null) hashCode = hashCode * 59 + this.ExtendTimes.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SecurityGroupName != null) hashCode = hashCode * 59 + this.SecurityGroupName.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.AvailableZoneNames != null) hashCode = hashCode * 59 + this.AvailableZoneNames.GetHashCode();
                if (this.TotalStorageSpace != null) hashCode = hashCode * 59 + this.TotalStorageSpace.GetHashCode();
                if (this.StorageResourceId != null) hashCode = hashCode * 59 + this.StorageResourceId.GetHashCode();
                if (this.StorageSpecCode != null) hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.Ipv6ConnectAddresses != null) hashCode = hashCode * 59 + this.Ipv6ConnectAddresses.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
