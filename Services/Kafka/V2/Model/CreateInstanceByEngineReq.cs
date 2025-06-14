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
    /// 创建实例请求体。
    /// </summary>
    public class CreateInstanceByEngineReq 
    {
        /// <summary>
        /// 消息引擎。取值填写为：kafka。
        /// </summary>
        /// <value>消息引擎。取值填写为：kafka。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum KAFKA for value: kafka
            /// </summary>
            public static readonly EngineEnum KAFKA = new EngineEnum("kafka");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "kafka", KAFKA },
            };

            private string _value;

            public EngineEnum()
            {

            }

            public EngineEnum(string value)
            {
                _value = value;
            }

            public static EngineEnum FromValue(string value)
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }

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

            public static bool operator !=(SaslEnabledMechanismsEnum a, SaslEnabledMechanismsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 磁盘的容量到达容量阈值后，对于消息的处理策略。  取值如下： - produce_reject：表示拒绝消息写入。 - time_base：表示自动删除最老消息。
        /// </summary>
        /// <value>磁盘的容量到达容量阈值后，对于消息的处理策略。  取值如下： - produce_reject：表示拒绝消息写入。 - time_base：表示自动删除最老消息。</value>
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
        /// 存储IO规格。  取值范围：   - dms.physical.storage.high.v2：使用高IO的磁盘类型。   - dms.physical.storage.ultra.v2：使用超高IO的磁盘类型。  [如何选择磁盘类型请参考《云硬盘 [产品介绍](tag:hws,hws_hk,hws_eu,cmcc)[用户指南](tag:dt,g42,hk_g42,ctc,tm,hk_tm,sbc,ocb,hws_ocb)》的“磁盘类型及性能介绍”。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt)
        /// </summary>
        /// <value>存储IO规格。  取值范围：   - dms.physical.storage.high.v2：使用高IO的磁盘类型。   - dms.physical.storage.ultra.v2：使用超高IO的磁盘类型。  [如何选择磁盘类型请参考《云硬盘 [产品介绍](tag:hws,hws_hk,hws_eu,cmcc)[用户指南](tag:dt,g42,hk_g42,ctc,tm,hk_tm,sbc,ocb,hws_ocb)》的“磁盘类型及性能介绍”。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt)</value>
        [JsonConverter(typeof(EnumClassConverter<StorageSpecCodeEnum>))]
        public class StorageSpecCodeEnum
        {
            /// <summary>
            /// Enum DMS_PHYSICAL_STORAGE_HIGH_V2 for value: dms.physical.storage.high.v2
            /// </summary>
            public static readonly StorageSpecCodeEnum DMS_PHYSICAL_STORAGE_HIGH_V2 = new StorageSpecCodeEnum("dms.physical.storage.high.v2");

            /// <summary>
            /// Enum DMS_PHYSICAL_STORAGE_ULTRA_V2 for value: dms.physical.storage.ultra.v2
            /// </summary>
            public static readonly StorageSpecCodeEnum DMS_PHYSICAL_STORAGE_ULTRA_V2 = new StorageSpecCodeEnum("dms.physical.storage.ultra.v2");

            private static readonly Dictionary<string, StorageSpecCodeEnum> StaticFields =
            new Dictionary<string, StorageSpecCodeEnum>()
            {
                { "dms.physical.storage.high.v2", DMS_PHYSICAL_STORAGE_HIGH_V2 },
                { "dms.physical.storage.ultra.v2", DMS_PHYSICAL_STORAGE_ULTRA_V2 },
            };

            private string _value;

            public StorageSpecCodeEnum()
            {

            }

            public StorageSpecCodeEnum(string value)
            {
                _value = value;
            }

            public static StorageSpecCodeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageSpecCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageSpecCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageSpecCodeEnum a, StorageSpecCodeEnum b)
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

            public static bool operator !=(StorageSpecCodeEnum a, StorageSpecCodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例名称。  由英文字符开头，只能由英文字母、数字、中划线、下划线组成，长度为4~64的字符。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例的描述信息。  长度不超过1024的字符串。[且字符串不能包含\&quot;&gt;\&quot;与\&quot;&lt;\&quot;，字符串首字符不能为\&quot;&#x3D;\&quot;,\&quot;+\&quot;,\&quot;-\&quot;,\&quot;@\&quot;的全角和半角字符。](tag:hcs,fcs)  &gt; \\与\&quot;在json报文中属于特殊字符，如果参数值中需要显示\\或者\&quot;字符，请在字符前增加转义字符\\，比如\\\\或者\\\&quot;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 消息引擎。取值填写为：kafka。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// 消息引擎的版本。取值填写为：   [- 1.1.0](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,sbc,cmcc)   [- 2.3.0](tag:g42,tm,hk_g42,ctc,hk_tm,dt,sbc,cmcc)   - 2.7   [- 3.x](tag:hws,hws_hk,dt,sbc,hcs,fcs,ctc,tm,hk_tm,hws_eu)
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 代理个数。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerNum { get; set; }

        /// <summary>
        /// 消息存储空间，单位GB。   [- Kafka实例规格为c6.2u4g.cluster时，存储空间取值范围300GB ~ 300000GB。   - Kafka实例规格为c6.4u8g.cluster时，存储空间取值范围300GB ~ 600000GB。   - Kafka实例规格为c6.8u16g.cluster时，存储空间取值范围300GB ~ 1500000GB。   - Kafka实例规格为c6.12u24g.cluster时，存储空间取值范围300GB ~ 1500000GB。   - Kafka实例规格为c6.16u32g.cluster时，存储空间取值范围300GB ~ 1500000GB。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt)      [- Kafka实例规格为kafka.2u8g.cluster时，存储空间取值范围300GB~300000GB。](tag:fcs)   [- Kafka实例规格为kafka.4u16g.cluster时，存储空间取值范围300GB~600000GB。   - Kafka实例规格为kafka.8u32g.cluster时，存储空间取值范围300GB~1500000GB。   - Kafka实例规格为kafka.16u64g.cluster时，存储空间取值范围300GB~1500000GB。   - Kafka实例规格为kafka.32u128g.cluster时，存储空间取值范围300GB~1500000GB。](tag:hcs,fcs)
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// 当ssl_enable为true时，该参数必选，ssl_enable为false时，该参数无效。  认证用户名，只能由英文字母开头且由英文字母、数字、中划线、下划线组成，长度为4~64的字符。
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

        /// <summary>
        /// 当ssl_enable为true时，该参数必选，ssl_enable为false时，该参数无效。  实例的认证密码。  复杂度要求： - 输入长度为8到32位的字符串。 - 必须包含如下四种字符中的三种组合：   - 小写字母   - 大写字母   - 数字   - 特殊字符包括（&#x60;~!@#$%^&amp;*()-_&#x3D;+\\|[{}]:&#39;\&quot;,&lt;.&gt;/?）和空格，并且不能以-开头
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 虚拟私有云ID。  获取方法如下：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 指定实例所属的安全组。  获取方法如下：登录虚拟私有云服务的控制台界面，在安全组的详情页面查找安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 子网信息。  获取方法如下：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 创建节点到指定且有资源的可用区ID。请参考[查询可用区信息](ListAvailableZones.xml)获取可用区ID。  该参数不能为空数组或者数组的值为空。  创建Kafka实例，支持节点部署在1个或3个及3个以上的可用区。在为节点指定可用区时，用逗号分隔开。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 产品ID。  产品ID可以从[查询产品规格列表](ListEngineProducts.xml)获取。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 维护时间窗开始时间，格式为HH:mm。
        /// </summary>
        [JsonProperty("maintain_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainBegin { get; set; }

        /// <summary>
        /// 维护时间窗结束时间，格式为HH:mm。
        /// </summary>
        [JsonProperty("maintain_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainEnd { get; set; }

        /// <summary>
        /// 是否开启公网访问功能。默认不开启公网。 - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// 创建实例时可以手动指定实例节点的内网IP地址，仅支持指定IPv4地址。  指定内网IP地址数量必须小于等于创建的节点数量。  如果指定的内网IP地址数量小于创建的节点数量时，系统会自动为剩余的节点随机分配内网IP地址。
        /// </summary>
        [JsonProperty("tenant_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TenantIps { get; set; }

        /// <summary>
        /// 实例绑定的弹性IP地址的ID。  以英文逗号隔开多个弹性IP地址的ID。  如果开启了公网访问功能（即enable_publicip为true），该字段为必选。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 是否开启SASL加密访问。  [实例创建后将不支持动态开启和关闭。](tag:ocb,hws_ocb,hcs)  - true：开启SASL加密访问。 - false：关闭SASL加密访问。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// 开启SASL后使用的安全协议。 - SASL_SSL: 使用SSL证书加密传输，支持账号密码认证，安全性更高。 - SASL_PLAINTEXT: 通过明文传输，支持账号密码认证，性能更好。  若该字段值为空，默认开启SASL_SSL认证机制。实例创建后，此参数不支持动态修改。 若创建实例时，使用了port_protocol参数，则Kafka的内网访问安全协议以及公网访问安全协议会使用port_protocol中的值，则此参数无效。
        /// </summary>
        [JsonProperty("kafka_security_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string KafkaSecurityProtocol { get; set; }

        /// <summary>
        /// 开启SASL后使用的认证机制，如果开启了SASL认证功能（即ssl_enable&#x3D;true），该字段为必选。  若该字段值为空，默认开启PLAIN认证机制。  选择其一进行SASL认证即可，支持同时开启两种认证机制。 取值如下： - PLAIN: 简单的用户名密码校验。 - SCRAM-SHA-512: 用户凭证校验，安全性比PLAIN机制更高。
        /// </summary>
        [JsonProperty("sasl_enabled_mechanisms", NullValueHandling = NullValueHandling.Ignore)]
        public List<SaslEnabledMechanismsEnum> SaslEnabledMechanisms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("port_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public PortProtocol PortProtocol { get; set; }

        /// <summary>
        /// 磁盘的容量到达容量阈值后，对于消息的处理策略。  取值如下： - produce_reject：表示拒绝消息写入。 - time_base：表示自动删除最老消息。
        /// </summary>
        [JsonProperty("retention_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RetentionPolicyEnum RetentionPolicy { get; set; }
        /// <summary>
        /// 是否开启ipv6。仅在虚拟私有云支持ipv6时生效。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 是否开启磁盘加密。
        /// </summary>
        [JsonProperty("disk_encrypted_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiskEncryptedEnable { get; set; }

        /// <summary>
        /// 磁盘加密key，未开启磁盘加密时为空
        /// </summary>
        [JsonProperty("disk_encrypted_key", NullValueHandling = NullValueHandling.Ignore)]
        public string DiskEncryptedKey { get; set; }

        /// <summary>
        /// 是否开启消息转储功能。  默认不开启消息转储。
        /// </summary>
        [JsonProperty("connector_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectorEnable { get; set; }

        /// <summary>
        /// 是否打开kafka自动创建Topic功能。 - true：开启 - false：关闭  当您选择开启，表示生产或消费一个未创建的Topic时，会自动创建一个包含3个分区和3个副本的Topic。  默认是false关闭。
        /// </summary>
        [JsonProperty("enable_auto_topic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoTopic { get; set; }

        /// <summary>
        /// 存储IO规格。  取值范围：   - dms.physical.storage.high.v2：使用高IO的磁盘类型。   - dms.physical.storage.ultra.v2：使用超高IO的磁盘类型。  [如何选择磁盘类型请参考《云硬盘 [产品介绍](tag:hws,hws_hk,hws_eu,cmcc)[用户指南](tag:dt,g42,hk_g42,ctc,tm,hk_tm,sbc,ocb,hws_ocb)》的“磁盘类型及性能介绍”。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt)
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public StorageSpecCodeEnum StorageSpecCode { get; set; }
        /// <summary>
        /// 企业项目ID。若为企业项目账号，该参数必填。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagEntity> Tags { get; set; }

        /// <summary>
        /// CPU架构。当前只支持X86架构[以及arm架构](tag:hcs,fcs,ctc)。  取值范围：   - X86   [- arm](tag:hcs,fcs,ctc)
        /// </summary>
        [JsonProperty("arch_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchType { get; set; }

        /// <summary>
        /// VPC内网明文访问。
        /// </summary>
        [JsonProperty("vpc_client_plain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VpcClientPlain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bss_param", NullValueHandling = NullValueHandling.Ignore)]
        public BssParam BssParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInstanceByEngineReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  tenantIps: ").Append(TenantIps).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  kafkaSecurityProtocol: ").Append(KafkaSecurityProtocol).Append("\n");
            sb.Append("  saslEnabledMechanisms: ").Append(SaslEnabledMechanisms).Append("\n");
            sb.Append("  portProtocol: ").Append(PortProtocol).Append("\n");
            sb.Append("  retentionPolicy: ").Append(RetentionPolicy).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  diskEncryptedEnable: ").Append(DiskEncryptedEnable).Append("\n");
            sb.Append("  diskEncryptedKey: ").Append(DiskEncryptedKey).Append("\n");
            sb.Append("  connectorEnable: ").Append(ConnectorEnable).Append("\n");
            sb.Append("  enableAutoTopic: ").Append(EnableAutoTopic).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  archType: ").Append(ArchType).Append("\n");
            sb.Append("  vpcClientPlain: ").Append(VpcClientPlain).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceByEngineReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceByEngineReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Engine != input.Engine) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.BrokerNum != input.BrokerNum || (this.BrokerNum != null && !this.BrokerNum.Equals(input.BrokerNum))) return false;
            if (this.StorageSpace != input.StorageSpace || (this.StorageSpace != null && !this.StorageSpace.Equals(input.StorageSpace))) return false;
            if (this.AccessUser != input.AccessUser || (this.AccessUser != null && !this.AccessUser.Equals(input.AccessUser))) return false;
            if (this.Password != input.Password || (this.Password != null && !this.Password.Equals(input.Password))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.MaintainBegin != input.MaintainBegin || (this.MaintainBegin != null && !this.MaintainBegin.Equals(input.MaintainBegin))) return false;
            if (this.MaintainEnd != input.MaintainEnd || (this.MaintainEnd != null && !this.MaintainEnd.Equals(input.MaintainEnd))) return false;
            if (this.EnablePublicip != input.EnablePublicip || (this.EnablePublicip != null && !this.EnablePublicip.Equals(input.EnablePublicip))) return false;
            if (this.TenantIps != input.TenantIps || (this.TenantIps != null && input.TenantIps != null && !this.TenantIps.SequenceEqual(input.TenantIps))) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.SslEnable != input.SslEnable || (this.SslEnable != null && !this.SslEnable.Equals(input.SslEnable))) return false;
            if (this.KafkaSecurityProtocol != input.KafkaSecurityProtocol || (this.KafkaSecurityProtocol != null && !this.KafkaSecurityProtocol.Equals(input.KafkaSecurityProtocol))) return false;
            if (this.SaslEnabledMechanisms != input.SaslEnabledMechanisms || (this.SaslEnabledMechanisms != null && input.SaslEnabledMechanisms != null && !this.SaslEnabledMechanisms.SequenceEqual(input.SaslEnabledMechanisms))) return false;
            if (this.PortProtocol != input.PortProtocol || (this.PortProtocol != null && !this.PortProtocol.Equals(input.PortProtocol))) return false;
            if (this.RetentionPolicy != input.RetentionPolicy) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;
            if (this.DiskEncryptedEnable != input.DiskEncryptedEnable || (this.DiskEncryptedEnable != null && !this.DiskEncryptedEnable.Equals(input.DiskEncryptedEnable))) return false;
            if (this.DiskEncryptedKey != input.DiskEncryptedKey || (this.DiskEncryptedKey != null && !this.DiskEncryptedKey.Equals(input.DiskEncryptedKey))) return false;
            if (this.ConnectorEnable != input.ConnectorEnable || (this.ConnectorEnable != null && !this.ConnectorEnable.Equals(input.ConnectorEnable))) return false;
            if (this.EnableAutoTopic != input.EnableAutoTopic || (this.EnableAutoTopic != null && !this.EnableAutoTopic.Equals(input.EnableAutoTopic))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ArchType != input.ArchType || (this.ArchType != null && !this.ArchType.Equals(input.ArchType))) return false;
            if (this.VpcClientPlain != input.VpcClientPlain || (this.VpcClientPlain != null && !this.VpcClientPlain.Equals(input.VpcClientPlain))) return false;
            if (this.BssParam != input.BssParam || (this.BssParam != null && !this.BssParam.Equals(input.BssParam))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.BrokerNum != null) hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.StorageSpace != null) hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.AccessUser != null) hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                if (this.Password != null) hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.MaintainBegin != null) hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null) hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnablePublicip != null) hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.TenantIps != null) hashCode = hashCode * 59 + this.TenantIps.GetHashCode();
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.SslEnable != null) hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.KafkaSecurityProtocol != null) hashCode = hashCode * 59 + this.KafkaSecurityProtocol.GetHashCode();
                hashCode = hashCode * 59 + this.SaslEnabledMechanisms.GetHashCode();
                if (this.PortProtocol != null) hashCode = hashCode * 59 + this.PortProtocol.GetHashCode();
                hashCode = hashCode * 59 + this.RetentionPolicy.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.DiskEncryptedEnable != null) hashCode = hashCode * 59 + this.DiskEncryptedEnable.GetHashCode();
                if (this.DiskEncryptedKey != null) hashCode = hashCode * 59 + this.DiskEncryptedKey.GetHashCode();
                if (this.ConnectorEnable != null) hashCode = hashCode * 59 + this.ConnectorEnable.GetHashCode();
                if (this.EnableAutoTopic != null) hashCode = hashCode * 59 + this.EnableAutoTopic.GetHashCode();
                hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ArchType != null) hashCode = hashCode * 59 + this.ArchType.GetHashCode();
                if (this.VpcClientPlain != null) hashCode = hashCode * 59 + this.VpcClientPlain.GetHashCode();
                if (this.BssParam != null) hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
