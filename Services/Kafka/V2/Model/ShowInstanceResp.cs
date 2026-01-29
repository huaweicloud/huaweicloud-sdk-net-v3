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
        /// Defines saslEnabledMechanisms
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SaslEnabledMechanismsEnum>))]
        public class SaslEnabledMechanismsEnum
        {
            /// <summary>
            /// Enum PLAIN for value: PLAIN
            /// </summary>
            public static readonly SaslEnabledMechanismsEnum PLAIN = new SaslEnabledMechanismsEnum("PLAIN");

            /// <summary>
            /// Enum SCRAM_SHA_512 for value: SCRAM-SHA-512
            /// </summary>
            public static readonly SaslEnabledMechanismsEnum SCRAM_SHA_512 = new SaslEnabledMechanismsEnum("SCRAM-SHA-512");

            private static readonly Dictionary<string, SaslEnabledMechanismsEnum> StaticFields =
            new Dictionary<string, SaslEnabledMechanismsEnum>()
            {
                { "PLAIN", PLAIN },
                { "SCRAM-SHA-512", SCRAM_SHA_512 },
            };

            private string _value;

            public SaslEnabledMechanismsEnum()
            {

            }

            public SaslEnabledMechanismsEnum(string value)
            {
                _value = value;
            }

            public static SaslEnabledMechanismsEnum FromValue(string value)
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

                if (this.Equals(obj as SaslEnabledMechanismsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SaslEnabledMechanismsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SaslEnabledMechanismsEnum a, SaslEnabledMechanismsEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SaslEnabledMechanismsEnum a, SaslEnabledMechanismsEnum b)
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
                if (ReferenceEquals(a, b))
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
        /// **参数解释**： 消息老化策略。 **取值范围**： - time_base：表示自动删除最老消息。 - produce_reject：表示拒绝消息写入。
        /// </summary>
        /// <value>**参数解释**： 消息老化策略。 **取值范围**： - time_base：表示自动删除最老消息。 - produce_reject：表示拒绝消息写入。</value>
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

            private string _value;

            public RetentionPolicyEnum()
            {

            }

            public RetentionPolicyEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RetentionPolicyEnum a, RetentionPolicyEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// **参数解释**： 实例名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 引擎。 **取值范围**： kafka
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// **参数解释**： Kafka的版本。 **取值范围**： [- 1.1.0](tag:hws,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,sbc,hk_sbc,cmcc,ax,srg) [- 2.3.0](tag:g42,tm,hk_g42,ctc,hk_tm,dt,cmcc,ocb,hws_ocb) - 2.7 [- 3.x](tag:hws,hws_hk,dt,sbc,hk_sbc,hcs,fcs,ctc,tm,hk_tm,hws_eu,ax,cmcc,srg)
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**： 实例描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 实例规格。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// **参数解释**： 消息存储空间，单位：GB。 **取值范围**： [- Kafka实例规格为c6.2u4g.cluster时，存储空间取值范围300GB ~ 300000GB。 - Kafka实例规格为c6.4u8g.cluster时，存储空间取值范围300GB ~ 600000GB。 - Kafka实例规格为c6.8u16g.cluster时，存储空间取值范围300GB ~ 1500000GB。 - Kafka实例规格为c6.12u24g.cluster时，存储空间取值范围300GB ~ 1500000GB。 - Kafka实例规格为c6.16u32g.cluster时，存储空间取值范围300GB ~ 1500000GB。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,ax,cmcc,sbc,hk_sbc,srg) [- Kafka实例规格为kafka.2u4g.cluster.small时，存储空间取值范围300GB~300000GB。](tag:hws,hws_hk,hws_eu,dt,ax) [- Kafka实例规格为kafka.2u8g.cluster时，存储空间取值范围300GB~300000GB。](tag:fcs) [- Kafka实例规格为kafka.4u16g.cluster时，存储空间取值范围300GB~600000GB。 - Kafka实例规格为kafka.8u32g.cluster时，存储空间取值范围300GB~1500000GB。 - Kafka实例规格为kafka.16u64g.cluster时，存储空间取值范围300GB~1500000GB。 - Kafka实例规格为kafka.32u128g.cluster时，存储空间取值范围300GB~1500000GB。](tag:hcs,fcs)
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： Kafka实例的分区数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("partition_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PartitionNum { get; set; }

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
        /// **参数解释**： 实例连接IP地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 实例连接端口。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数解释**： 实例的状态。详细状态说明请参考[实例状态说明](kafka-api-180514012.xml)。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 实例ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 资源规格标识。 **取值范围**： [- dms.instance.kafka.cluster.c3.mini：Kafka实例的基准带宽为100MByte/秒。 - dms.instance.kafka.cluster.c3.small.2：Kafka实例的基准带宽为300MByte/秒。 - dms.instance.kafka.cluster.c3.middle.2：Kafka实例的基准带宽为600MByte/秒。 - dms.instance.kafka.cluster.c3.high.2：Kafka实例的基准带宽为1200MByte/秒。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,ax) [不涉及。](tag:hcs)
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： 付费模式。 **取值范围**： [- 1表示按需计费。 - 0表示包年/包月计费。](tag:hws,hws_hk,ctc,cmcc,ax,hws_eu)[付费模式，暂未使用。](tag:hws_ocb,ocb) [- 1表示按需计费。](tag:dt,g42,tm,hk_g42,hk_tm,hcs,fcs,sbc,hk_sbc)
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
        /// **参数解释**： 完成创建时间。  格式为时间戳，指从格林威治时间 1970年01月01日00时00分00秒起至指定时间的偏差总毫秒数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： 子网名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("subnet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetName { get; set; }

        /// <summary>
        /// **参数解释**： 子网网段。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidr { get; set; }

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
        /// **参数解释**： 实例访问用户名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

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
        /// **参数解释**： 实例是否开启公网访问功能。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// **参数解释**： Kafka实例的Kafka Manager连接地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("management_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启安全认证。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启broker间副本加密传输。 **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("broker_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BrokerSslEnable { get; set; }

        /// <summary>
        /// **参数解释**： Kafka使用的安全协议。 若实例详情中不存在port_protocols返回参数，则kafka_security_protocol同时代表内网访问、公网访问以及跨VPC访问的安全协议。 若实例详情中存在port_protocols返回参数，则kafka_security_protocol仅代表跨VPC访问的安全协议。内网访问公网访问的安全协议请参考port_protocols参数。 **取值范围**： - PLAINTEXT：既未采用SSL证书进行加密传输，也不支持账号密码认证。性能更好，安全性较低，建议在生产环境下公网访问不使用此方式。 - SASL_SSL：采用SSL证书进行加密传输，支持账号密码认证，安全性更高。 [- SASL_PLAINTEXT：明文传输，支持账号密码认证，性能更好，建议使用SCRAM-SHA-512机制。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,ax)
        /// </summary>
        [JsonProperty("kafka_security_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaSecurityProtocol { get; set; }

        /// <summary>
        /// **参数解释**： 开启SASL后使用的认证机制。
        /// </summary>
        [JsonProperty("sasl_enabled_mechanisms", NullValueHandling = NullValueHandling.Ignore)]
        public List<SaslEnabledMechanismsEnum> SaslEnabledMechanisms { get; set; }
        /// <summary>
        /// **参数解释**： 是否开启双向认证。[华为云Stack不支持此参数。](tag:hcs) **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("ssl_two_way_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslTwoWayEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启证书替换。[华为云Stack不支持此参数。](tag:hcs) **取值范围**： - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("cert_replaced", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CertReplaced { get; set; }

        /// <summary>
        /// **参数解释**： 公网访问Kafka Manager连接地址。[华为云Stack不支持此参数。](tag:hcs) **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_management_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicManagementConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 实例扩容时用于区分老实例与新实例。 **取值范围**： - true：新创建的实例，允许磁盘动态扩容不需要重启。 - false：老实例。
        /// </summary>
        [JsonProperty("is_logical_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLogicalVolume { get; set; }

        /// <summary>
        /// **参数解释**： 实例扩容磁盘次数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("extend_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendTimes { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启自动创建Topic。 **取值范围**： - true：开启 - false：关闭
        /// </summary>
        [JsonProperty("enable_auto_topic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoTopic { get; set; }

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
        /// **参数解释**： 实例节点所在的可用区，返回“可用区ID”。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 实例节点所在的可用区名称，返回“可用区名称”。
        /// </summary>
        [JsonProperty("available_zone_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZoneNames { get; set; }

        /// <summary>
        /// **参数解释**： 总共消息存储空间，单位：GB。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalStorageSpace { get; set; }

        /// <summary>
        /// **参数解释**： 实例公网连接IP地址。当实例开启了公网访问，实例才包含该参数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 实例公网连接域名。当实例开启了公网访问，实例才包含该参数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_connect_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicConnectDomainName { get; set; }

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
        /// **参数解释**： 服务类型。 **取值范围**： advanced：服务类型。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// **参数解释**： 存储类型。 **取值范围**： hec：存储类型。
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageType { get; set; }

        /// <summary>
        /// **参数解释**： 消息老化策略。 **取值范围**： - time_base：表示自动删除最老消息。 - produce_reject：表示拒绝消息写入。
        /// </summary>
        [JsonProperty("retention_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RetentionPolicyEnum RetentionPolicy { get; set; }
        /// <summary>
        /// **参数解释**： Kafka公网开启状态。 **取值范围**： - true：开启公网。 - closed：关闭公网。 - false：未使用公网。 - freezed：公网冻结。 - actived：公网解冻。
        /// </summary>
        [JsonProperty("kafka_public_status", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPublicStatus { get; set; }

        /// <summary>
        /// **参数解释**： kafka公网访问带宽。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicBandwidth { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启消息收集功能。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("enable_log_collection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLogCollection { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启新证书。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("new_auth_cert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewAuthCert { get; set; }

        /// <summary>
        /// **参数解释**： 跨VPC访问信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("cross_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossVpcInfo { get; set; }

        /// <summary>
        /// **参数解释**： 公网跨VPC访问信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_cross_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicCrossVpcInfo { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启IPv6。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// **参数解释**： IPv6的连接地址。
        /// </summary>
        [JsonProperty("ipv6_connect_addresses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ipv6ConnectAddresses { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启转储。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("connector_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectorEnable { get; set; }

        /// <summary>
        /// **参数解释**： connector节点数量。 **取值范围**： 2-16。
        /// </summary>
        [JsonProperty("connector_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectorNodeNum { get; set; }

        /// <summary>
        /// **参数解释**： 转储任务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("connector_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启Kafka rest功能。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("rest_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestEnable { get; set; }

        /// <summary>
        /// **参数解释**：  Kafka rest连接地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("rest_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string RestConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： Kafka公网访问带宽。待删除版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("public_boundwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? PublicBoundwidth { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启消息查询功能。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("message_query_inst_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MessageQueryInstEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启VPC明文访问。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("vpc_client_plain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VpcClientPlain { get; set; }

        /// <summary>
        /// **参数解释**： Kafka实例支持的特性功能。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportFeatures { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启消息轨迹功能。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("trace_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TraceEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启代理。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("agent_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AgentEnable { get; set; }

        /// <summary>
        /// **参数解释**： 租户侧连接地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("pod_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PodConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启磁盘加密。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("disk_encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiskEncrypted { get; set; }

        /// <summary>
        /// **参数解释**： 磁盘加密key，未开启磁盘加密时为空。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("disk_encrypted_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptedKey { get; set; }

        /// <summary>
        /// **参数解释**： Kafka实例内网连接地址。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("kafka_private_connect_address", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPrivateConnectAddress { get; set; }

        /// <summary>
        /// **参数解释**： Kafka实例内网连接域名。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("kafka_private_connect_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaPrivateConnectDomainName { get; set; }

        /// <summary>
        /// **参数解释**： 云监控版本。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ces_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CesVersion { get; set; }

        /// <summary>
        /// **参数解释**： 区分实例什么时候开启的公网访问 **取值范围**： - true：已开启公网访问 - actived：已开启公网访问 - closed：已关闭公网访问 - false：已关闭公网访问
        /// </summary>
        [JsonProperty("public_access_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicAccessEnabled { get; set; }

        /// <summary>
        /// **参数解释**： 节点数。 **取值范围**： [- 1：Kafka单机实例的节点数。](tag:hws,hws_hk,hws_eu,dt,hcs,ax) - 3~50：Kafka集群实例的节点数。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("port_protocols", NullValueHandling = NullValueHandling.Ignore)]
        public PortProtocolsEntity PortProtocols { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启访问控制。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("enable_acl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcl { get; set; }

        /// <summary>
        /// **参数解释**： 是否启用新规格计费。 **取值范围**： - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("new_spec_billing_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewSpecBillingEnable { get; set; }

        /// <summary>
        /// **参数解释**： 节点数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerNum { get; set; }

        /// <summary>
        /// **参数解释**： 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagEntity> Tags { get; set; }

        /// <summary>
        /// **参数解释**：  是否为容灾实例。 **取值范围**： - true：是容灾实例。 - false：不是容灾实例。
        /// </summary>
        [JsonProperty("dr_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DrEnable { get; set; }



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
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  partitionNum: ").Append(PartitionNum).Append("\n");
            sb.Append("  usedStorageSpace: ").Append(UsedStorageSpace).Append("\n");
            sb.Append("  dnsEnable: ").Append(DnsEnable).Append("\n");
            sb.Append("  connectAddress: ").Append(ConnectAddress).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  subnetName: ").Append(SubnetName).Append("\n");
            sb.Append("  subnetCidr: ").Append(SubnetCidr).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  managementConnectAddress: ").Append(ManagementConnectAddress).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  brokerSslEnable: ").Append(BrokerSslEnable).Append("\n");
            sb.Append("  kafkaSecurityProtocol: ").Append(KafkaSecurityProtocol).Append("\n");
            sb.Append("  saslEnabledMechanisms: ").Append(SaslEnabledMechanisms).Append("\n");
            sb.Append("  sslTwoWayEnable: ").Append(SslTwoWayEnable).Append("\n");
            sb.Append("  certReplaced: ").Append(CertReplaced).Append("\n");
            sb.Append("  publicManagementConnectAddress: ").Append(PublicManagementConnectAddress).Append("\n");
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
            sb.Append("  availableZoneNames: ").Append(AvailableZoneNames).Append("\n");
            sb.Append("  totalStorageSpace: ").Append(TotalStorageSpace).Append("\n");
            sb.Append("  publicConnectAddress: ").Append(PublicConnectAddress).Append("\n");
            sb.Append("  publicConnectDomainName: ").Append(PublicConnectDomainName).Append("\n");
            sb.Append("  storageResourceId: ").Append(StorageResourceId).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  retentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  kafkaPublicStatus: ").Append(KafkaPublicStatus).Append("\n");
            sb.Append("  publicBandwidth: ").Append(PublicBandwidth).Append("\n");
            sb.Append("  enableLogCollection: ").Append(EnableLogCollection).Append("\n");
            sb.Append("  newAuthCert: ").Append(NewAuthCert).Append("\n");
            sb.Append("  crossVpcInfo: ").Append(CrossVpcInfo).Append("\n");
            sb.Append("  publicCrossVpcInfo: ").Append(PublicCrossVpcInfo).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  ipv6ConnectAddresses: ").Append(Ipv6ConnectAddresses).Append("\n");
            sb.Append("  connectorEnable: ").Append(ConnectorEnable).Append("\n");
            sb.Append("  connectorNodeNum: ").Append(ConnectorNodeNum).Append("\n");
            sb.Append("  connectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  restEnable: ").Append(RestEnable).Append("\n");
            sb.Append("  restConnectAddress: ").Append(RestConnectAddress).Append("\n");
            sb.Append("  publicBoundwidth: ").Append(PublicBoundwidth).Append("\n");
            sb.Append("  messageQueryInstEnable: ").Append(MessageQueryInstEnable).Append("\n");
            sb.Append("  vpcClientPlain: ").Append(VpcClientPlain).Append("\n");
            sb.Append("  supportFeatures: ").Append(SupportFeatures).Append("\n");
            sb.Append("  traceEnable: ").Append(TraceEnable).Append("\n");
            sb.Append("  agentEnable: ").Append(AgentEnable).Append("\n");
            sb.Append("  podConnectAddress: ").Append(PodConnectAddress).Append("\n");
            sb.Append("  diskEncrypted: ").Append(DiskEncrypted).Append("\n");
            sb.Append("  diskEncryptedKey: ").Append(DiskEncryptedKey).Append("\n");
            sb.Append("  kafkaPrivateConnectAddress: ").Append(KafkaPrivateConnectAddress).Append("\n");
            sb.Append("  kafkaPrivateConnectDomainName: ").Append(KafkaPrivateConnectDomainName).Append("\n");
            sb.Append("  cesVersion: ").Append(CesVersion).Append("\n");
            sb.Append("  publicAccessEnabled: ").Append(PublicAccessEnabled).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  portProtocols: ").Append(PortProtocols).Append("\n");
            sb.Append("  enableAcl: ").Append(EnableAcl).Append("\n");
            sb.Append("  newSpecBillingEnable: ").Append(NewSpecBillingEnable).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  drEnable: ").Append(DrEnable).Append("\n");
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
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Engine != input.Engine || (this.Engine != null && !this.Engine.Equals(input.Engine))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Specification != input.Specification || (this.Specification != null && !this.Specification.Equals(input.Specification))) return false;
            if (this.StorageSpace != input.StorageSpace || (this.StorageSpace != null && !this.StorageSpace.Equals(input.StorageSpace))) return false;
            if (this.PartitionNum != input.PartitionNum || (this.PartitionNum != null && !this.PartitionNum.Equals(input.PartitionNum))) return false;
            if (this.UsedStorageSpace != input.UsedStorageSpace || (this.UsedStorageSpace != null && !this.UsedStorageSpace.Equals(input.UsedStorageSpace))) return false;
            if (this.DnsEnable != input.DnsEnable || (this.DnsEnable != null && !this.DnsEnable.Equals(input.DnsEnable))) return false;
            if (this.ConnectAddress != input.ConnectAddress || (this.ConnectAddress != null && !this.ConnectAddress.Equals(input.ConnectAddress))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VpcName != input.VpcName || (this.VpcName != null && !this.VpcName.Equals(input.VpcName))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.SubnetName != input.SubnetName || (this.SubnetName != null && !this.SubnetName.Equals(input.SubnetName))) return false;
            if (this.SubnetCidr != input.SubnetCidr || (this.SubnetCidr != null && !this.SubnetCidr.Equals(input.SubnetCidr))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.AccessUser != input.AccessUser || (this.AccessUser != null && !this.AccessUser.Equals(input.AccessUser))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.MaintainBegin != input.MaintainBegin || (this.MaintainBegin != null && !this.MaintainBegin.Equals(input.MaintainBegin))) return false;
            if (this.MaintainEnd != input.MaintainEnd || (this.MaintainEnd != null && !this.MaintainEnd.Equals(input.MaintainEnd))) return false;
            if (this.EnablePublicip != input.EnablePublicip || (this.EnablePublicip != null && !this.EnablePublicip.Equals(input.EnablePublicip))) return false;
            if (this.ManagementConnectAddress != input.ManagementConnectAddress || (this.ManagementConnectAddress != null && !this.ManagementConnectAddress.Equals(input.ManagementConnectAddress))) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.BrokerSslEnable != input.BrokerSslEnable || (this.BrokerSslEnable != null && !this.BrokerSslEnable.Equals(input.BrokerSslEnable))) return false;
            if (this.KafkaSecurityProtocol != input.KafkaSecurityProtocol || (this.KafkaSecurityProtocol != null && !this.KafkaSecurityProtocol.Equals(input.KafkaSecurityProtocol))) return false;
            if (this.SaslEnabledMechanisms != input.SaslEnabledMechanisms || (this.SaslEnabledMechanisms != null && input.SaslEnabledMechanisms != null && !this.SaslEnabledMechanisms.SequenceEqual(input.SaslEnabledMechanisms))) return false;
            if (this.SslTwoWayEnable != input.SslTwoWayEnable || (this.SslTwoWayEnable != null && !this.SslTwoWayEnable.Equals(input.SslTwoWayEnable))) return false;
            if (this.CertReplaced != input.CertReplaced || (this.CertReplaced != null && !this.CertReplaced.Equals(input.CertReplaced))) return false;
            if (this.PublicManagementConnectAddress != input.PublicManagementConnectAddress || (this.PublicManagementConnectAddress != null && !this.PublicManagementConnectAddress.Equals(input.PublicManagementConnectAddress))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IsLogicalVolume != input.IsLogicalVolume || (this.IsLogicalVolume != null && !this.IsLogicalVolume.Equals(input.IsLogicalVolume))) return false;
            if (this.ExtendTimes != input.ExtendTimes || (this.ExtendTimes != null && !this.ExtendTimes.Equals(input.ExtendTimes))) return false;
            if (this.EnableAutoTopic != input.EnableAutoTopic || (this.EnableAutoTopic != null && !this.EnableAutoTopic.Equals(input.EnableAutoTopic))) return false;
            if (this.Type != input.Type) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.SecurityGroupName != input.SecurityGroupName || (this.SecurityGroupName != null && !this.SecurityGroupName.Equals(input.SecurityGroupName))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.AvailableZoneNames != input.AvailableZoneNames || (this.AvailableZoneNames != null && input.AvailableZoneNames != null && !this.AvailableZoneNames.SequenceEqual(input.AvailableZoneNames))) return false;
            if (this.TotalStorageSpace != input.TotalStorageSpace || (this.TotalStorageSpace != null && !this.TotalStorageSpace.Equals(input.TotalStorageSpace))) return false;
            if (this.PublicConnectAddress != input.PublicConnectAddress || (this.PublicConnectAddress != null && !this.PublicConnectAddress.Equals(input.PublicConnectAddress))) return false;
            if (this.PublicConnectDomainName != input.PublicConnectDomainName || (this.PublicConnectDomainName != null && !this.PublicConnectDomainName.Equals(input.PublicConnectDomainName))) return false;
            if (this.StorageResourceId != input.StorageResourceId || (this.StorageResourceId != null && !this.StorageResourceId.Equals(input.StorageResourceId))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode || (this.StorageSpecCode != null && !this.StorageSpecCode.Equals(input.StorageSpecCode))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.StorageType != input.StorageType || (this.StorageType != null && !this.StorageType.Equals(input.StorageType))) return false;
            if (this.RetentionPolicy != input.RetentionPolicy) return false;
            if (this.KafkaPublicStatus != input.KafkaPublicStatus || (this.KafkaPublicStatus != null && !this.KafkaPublicStatus.Equals(input.KafkaPublicStatus))) return false;
            if (this.PublicBandwidth != input.PublicBandwidth || (this.PublicBandwidth != null && !this.PublicBandwidth.Equals(input.PublicBandwidth))) return false;
            if (this.EnableLogCollection != input.EnableLogCollection || (this.EnableLogCollection != null && !this.EnableLogCollection.Equals(input.EnableLogCollection))) return false;
            if (this.NewAuthCert != input.NewAuthCert || (this.NewAuthCert != null && !this.NewAuthCert.Equals(input.NewAuthCert))) return false;
            if (this.CrossVpcInfo != input.CrossVpcInfo || (this.CrossVpcInfo != null && !this.CrossVpcInfo.Equals(input.CrossVpcInfo))) return false;
            if (this.PublicCrossVpcInfo != input.PublicCrossVpcInfo || (this.PublicCrossVpcInfo != null && !this.PublicCrossVpcInfo.Equals(input.PublicCrossVpcInfo))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.Ipv6ConnectAddresses != input.Ipv6ConnectAddresses || (this.Ipv6ConnectAddresses != null && input.Ipv6ConnectAddresses != null && !this.Ipv6ConnectAddresses.SequenceEqual(input.Ipv6ConnectAddresses))) return false;
            if (this.ConnectorEnable != input.ConnectorEnable || (this.ConnectorEnable != null && !this.ConnectorEnable.Equals(input.ConnectorEnable))) return false;
            if (this.ConnectorNodeNum != input.ConnectorNodeNum || (this.ConnectorNodeNum != null && !this.ConnectorNodeNum.Equals(input.ConnectorNodeNum))) return false;
            if (this.ConnectorId != input.ConnectorId || (this.ConnectorId != null && !this.ConnectorId.Equals(input.ConnectorId))) return false;
            if (this.RestEnable != input.RestEnable || (this.RestEnable != null && !this.RestEnable.Equals(input.RestEnable))) return false;
            if (this.RestConnectAddress != input.RestConnectAddress || (this.RestConnectAddress != null && !this.RestConnectAddress.Equals(input.RestConnectAddress))) return false;
            if (this.PublicBoundwidth != input.PublicBoundwidth || (this.PublicBoundwidth != null && !this.PublicBoundwidth.Equals(input.PublicBoundwidth))) return false;
            if (this.MessageQueryInstEnable != input.MessageQueryInstEnable || (this.MessageQueryInstEnable != null && !this.MessageQueryInstEnable.Equals(input.MessageQueryInstEnable))) return false;
            if (this.VpcClientPlain != input.VpcClientPlain || (this.VpcClientPlain != null && !this.VpcClientPlain.Equals(input.VpcClientPlain))) return false;
            if (this.SupportFeatures != input.SupportFeatures || (this.SupportFeatures != null && !this.SupportFeatures.Equals(input.SupportFeatures))) return false;
            if (this.TraceEnable != input.TraceEnable || (this.TraceEnable != null && !this.TraceEnable.Equals(input.TraceEnable))) return false;
            if (this.AgentEnable != input.AgentEnable || (this.AgentEnable != null && !this.AgentEnable.Equals(input.AgentEnable))) return false;
            if (this.PodConnectAddress != input.PodConnectAddress || (this.PodConnectAddress != null && !this.PodConnectAddress.Equals(input.PodConnectAddress))) return false;
            if (this.DiskEncrypted != input.DiskEncrypted || (this.DiskEncrypted != null && !this.DiskEncrypted.Equals(input.DiskEncrypted))) return false;
            if (this.DiskEncryptedKey != input.DiskEncryptedKey || (this.DiskEncryptedKey != null && !this.DiskEncryptedKey.Equals(input.DiskEncryptedKey))) return false;
            if (this.KafkaPrivateConnectAddress != input.KafkaPrivateConnectAddress || (this.KafkaPrivateConnectAddress != null && !this.KafkaPrivateConnectAddress.Equals(input.KafkaPrivateConnectAddress))) return false;
            if (this.KafkaPrivateConnectDomainName != input.KafkaPrivateConnectDomainName || (this.KafkaPrivateConnectDomainName != null && !this.KafkaPrivateConnectDomainName.Equals(input.KafkaPrivateConnectDomainName))) return false;
            if (this.CesVersion != input.CesVersion || (this.CesVersion != null && !this.CesVersion.Equals(input.CesVersion))) return false;
            if (this.PublicAccessEnabled != input.PublicAccessEnabled || (this.PublicAccessEnabled != null && !this.PublicAccessEnabled.Equals(input.PublicAccessEnabled))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.PortProtocols != input.PortProtocols || (this.PortProtocols != null && !this.PortProtocols.Equals(input.PortProtocols))) return false;
            if (this.EnableAcl != input.EnableAcl || (this.EnableAcl != null && !this.EnableAcl.Equals(input.EnableAcl))) return false;
            if (this.NewSpecBillingEnable != input.NewSpecBillingEnable || (this.NewSpecBillingEnable != null && !this.NewSpecBillingEnable.Equals(input.NewSpecBillingEnable))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.DrEnable != input.DrEnable || (this.DrEnable != null && !this.DrEnable.Equals(input.DrEnable))) return false;

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
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.StorageSpace != null) hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.PartitionNum != null) hashCode = hashCode * 59 + this.PartitionNum.GetHashCode();
                if (this.UsedStorageSpace != null) hashCode = hashCode * 59 + this.UsedStorageSpace.GetHashCode();
                if (this.DnsEnable != null) hashCode = hashCode * 59 + this.DnsEnable.GetHashCode();
                if (this.ConnectAddress != null) hashCode = hashCode * 59 + this.ConnectAddress.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcName != null) hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.SubnetName != null) hashCode = hashCode * 59 + this.SubnetName.GetHashCode();
                if (this.SubnetCidr != null) hashCode = hashCode * 59 + this.SubnetCidr.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AccessUser != null) hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.MaintainBegin != null) hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null) hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnablePublicip != null) hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.ManagementConnectAddress != null) hashCode = hashCode * 59 + this.ManagementConnectAddress.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.BrokerSslEnable != null) hashCode = hashCode * 59 + this.BrokerSslEnable.GetHashCode();
                if (this.KafkaSecurityProtocol != null) hashCode = hashCode * 59 + this.KafkaSecurityProtocol.GetHashCode();
                hashCode = hashCode * 59 + this.SaslEnabledMechanisms.GetHashCode();
                if (this.SslTwoWayEnable != null) hashCode = hashCode * 59 + this.SslTwoWayEnable.GetHashCode();
                if (this.CertReplaced != null) hashCode = hashCode * 59 + this.CertReplaced.GetHashCode();
                if (this.PublicManagementConnectAddress != null) hashCode = hashCode * 59 + this.PublicManagementConnectAddress.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsLogicalVolume != null) hashCode = hashCode * 59 + this.IsLogicalVolume.GetHashCode();
                if (this.ExtendTimes != null) hashCode = hashCode * 59 + this.ExtendTimes.GetHashCode();
                if (this.EnableAutoTopic != null) hashCode = hashCode * 59 + this.EnableAutoTopic.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SecurityGroupName != null) hashCode = hashCode * 59 + this.SecurityGroupName.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.AvailableZoneNames != null) hashCode = hashCode * 59 + this.AvailableZoneNames.GetHashCode();
                if (this.TotalStorageSpace != null) hashCode = hashCode * 59 + this.TotalStorageSpace.GetHashCode();
                if (this.PublicConnectAddress != null) hashCode = hashCode * 59 + this.PublicConnectAddress.GetHashCode();
                if (this.PublicConnectDomainName != null) hashCode = hashCode * 59 + this.PublicConnectDomainName.GetHashCode();
                if (this.StorageResourceId != null) hashCode = hashCode * 59 + this.StorageResourceId.GetHashCode();
                if (this.StorageSpecCode != null) hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StorageType != null) hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.KafkaPublicStatus != null) hashCode = hashCode * 59 + this.KafkaPublicStatus.GetHashCode();
                if (this.PublicBandwidth != null) hashCode = hashCode * 59 + this.PublicBandwidth.GetHashCode();
                if (this.EnableLogCollection != null) hashCode = hashCode * 59 + this.EnableLogCollection.GetHashCode();
                if (this.NewAuthCert != null) hashCode = hashCode * 59 + this.NewAuthCert.GetHashCode();
                if (this.CrossVpcInfo != null) hashCode = hashCode * 59 + this.CrossVpcInfo.GetHashCode();
                if (this.PublicCrossVpcInfo != null) hashCode = hashCode * 59 + this.PublicCrossVpcInfo.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.Ipv6ConnectAddresses != null) hashCode = hashCode * 59 + this.Ipv6ConnectAddresses.GetHashCode();
                if (this.ConnectorEnable != null) hashCode = hashCode * 59 + this.ConnectorEnable.GetHashCode();
                if (this.ConnectorNodeNum != null) hashCode = hashCode * 59 + this.ConnectorNodeNum.GetHashCode();
                if (this.ConnectorId != null) hashCode = hashCode * 59 + this.ConnectorId.GetHashCode();
                if (this.RestEnable != null) hashCode = hashCode * 59 + this.RestEnable.GetHashCode();
                if (this.RestConnectAddress != null) hashCode = hashCode * 59 + this.RestConnectAddress.GetHashCode();
                if (this.PublicBoundwidth != null) hashCode = hashCode * 59 + this.PublicBoundwidth.GetHashCode();
                if (this.MessageQueryInstEnable != null) hashCode = hashCode * 59 + this.MessageQueryInstEnable.GetHashCode();
                if (this.VpcClientPlain != null) hashCode = hashCode * 59 + this.VpcClientPlain.GetHashCode();
                if (this.SupportFeatures != null) hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.TraceEnable != null) hashCode = hashCode * 59 + this.TraceEnable.GetHashCode();
                if (this.AgentEnable != null) hashCode = hashCode * 59 + this.AgentEnable.GetHashCode();
                if (this.PodConnectAddress != null) hashCode = hashCode * 59 + this.PodConnectAddress.GetHashCode();
                if (this.DiskEncrypted != null) hashCode = hashCode * 59 + this.DiskEncrypted.GetHashCode();
                if (this.DiskEncryptedKey != null) hashCode = hashCode * 59 + this.DiskEncryptedKey.GetHashCode();
                if (this.KafkaPrivateConnectAddress != null) hashCode = hashCode * 59 + this.KafkaPrivateConnectAddress.GetHashCode();
                if (this.KafkaPrivateConnectDomainName != null) hashCode = hashCode * 59 + this.KafkaPrivateConnectDomainName.GetHashCode();
                if (this.CesVersion != null) hashCode = hashCode * 59 + this.CesVersion.GetHashCode();
                if (this.PublicAccessEnabled != null) hashCode = hashCode * 59 + this.PublicAccessEnabled.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.PortProtocols != null) hashCode = hashCode * 59 + this.PortProtocols.GetHashCode();
                if (this.EnableAcl != null) hashCode = hashCode * 59 + this.EnableAcl.GetHashCode();
                if (this.NewSpecBillingEnable != null) hashCode = hashCode * 59 + this.NewSpecBillingEnable.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DrEnable != null) hashCode = hashCode * 59 + this.DrEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
