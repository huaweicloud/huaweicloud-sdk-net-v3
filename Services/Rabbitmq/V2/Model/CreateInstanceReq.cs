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
    /// 创建实例请求体。
    /// </summary>
    public class CreateInstanceReq 
    {
        /// <summary>
        /// 消息引擎：rabbitmq。
        /// </summary>
        /// <value>消息引擎：rabbitmq。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum RABBITMQ for value: rabbitmq
            /// </summary>
            public static readonly EngineEnum RABBITMQ = new EngineEnum("rabbitmq");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "rabbitmq", RABBITMQ },
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
        /// 消息引擎的版本。   - RabbitMQ版本有：3.8.35[和3.7.17](tag:tm,hk_tm,hk_sbc,sbc)。 
        /// </summary>
        /// <value>消息引擎的版本。   - RabbitMQ版本有：3.8.35[和3.7.17](tag:tm,hk_tm,hk_sbc,sbc)。 </value>
        [JsonConverter(typeof(EnumClassConverter<EngineVersionEnum>))]
        public class EngineVersionEnum
        {
            /// <summary>
            /// Enum _3_8_35 for value: 3.8.35
            /// </summary>
            public static readonly EngineVersionEnum _3_8_35 = new EngineVersionEnum("3.8.35");

            private static readonly Dictionary<string, EngineVersionEnum> StaticFields =
            new Dictionary<string, EngineVersionEnum>()
            {
                { "3.8.35", _3_8_35 },
            };

            private string _value;

            public EngineVersionEnum()
            {

            }

            public EngineVersionEnum(string value)
            {
                _value = value;
            }

            public static EngineVersionEnum FromValue(string value)
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

                if (this.Equals(obj as EngineVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineVersionEnum a, EngineVersionEnum b)
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

            public static bool operator !=(EngineVersionEnum a, EngineVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 代理个数。  当产品为单机类型，代理个数只能为1；当产品为集群类型，可选3、5、7个代理个数。  产品类型为single时:   - 1  产品类型为cluster时:   - 3   - 5   - 7
        /// </summary>
        /// <value>代理个数。  当产品为单机类型，代理个数只能为1；当产品为集群类型，可选3、5、7个代理个数。  产品类型为single时:   - 1  产品类型为cluster时:   - 3   - 5   - 7</value>
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
        /// 存储IO规格。  取值范围：   - dms.physical.storage.high.v2   - dms.physical.storage.ultra.v2   - dms.physical.storage.high.dss.v2(专属云)   - dms.physical.storage.ultra.dss.v2(专属云)
        /// </summary>
        /// <value>存储IO规格。  取值范围：   - dms.physical.storage.high.v2   - dms.physical.storage.ultra.v2   - dms.physical.storage.high.dss.v2(专属云)   - dms.physical.storage.ultra.dss.v2(专属云)</value>
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

            /// <summary>
            /// Enum DMS_PHYSICAL_STORAGE_HIGH_DSS_V2 for value: dms.physical.storage.high.dss.v2
            /// </summary>
            public static readonly StorageSpecCodeEnum DMS_PHYSICAL_STORAGE_HIGH_DSS_V2 = new StorageSpecCodeEnum("dms.physical.storage.high.dss.v2");

            /// <summary>
            /// Enum DMS_PHYSICAL_STORAGE_ULTRA_DSS_V2 for value: dms.physical.storage.ultra.dss.v2
            /// </summary>
            public static readonly StorageSpecCodeEnum DMS_PHYSICAL_STORAGE_ULTRA_DSS_V2 = new StorageSpecCodeEnum("dms.physical.storage.ultra.dss.v2");

            private static readonly Dictionary<string, StorageSpecCodeEnum> StaticFields =
            new Dictionary<string, StorageSpecCodeEnum>()
            {
                { "dms.physical.storage.high.v2", DMS_PHYSICAL_STORAGE_HIGH_V2 },
                { "dms.physical.storage.ultra.v2", DMS_PHYSICAL_STORAGE_ULTRA_V2 },
                { "dms.physical.storage.high.dss.v2", DMS_PHYSICAL_STORAGE_HIGH_DSS_V2 },
                { "dms.physical.storage.ultra.dss.v2", DMS_PHYSICAL_STORAGE_ULTRA_DSS_V2 },
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
        /// 实例的描述信息。  长度不超过1024的字符串。  &gt; \\与\&quot;在json报文中属于特殊字符，如果参数值中需要显示\\或者\&quot;字符，请在字符前增加转义字符\\，比如\\\\或者\\\&quot;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 消息引擎：rabbitmq。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// 消息引擎的版本。   - RabbitMQ版本有：3.8.35[和3.7.17](tag:tm,hk_tm,hk_sbc,sbc)。 
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public EngineVersionEnum EngineVersion { get; set; }
        /// <summary>
        /// 消息存储空间，单位GB。   - 单机RabbitMQ实例的存储空间的取值范围100GB~90000GB。   - 集群RabbitMQ实例的存储空间的取值范围为100GB\\*节点数~90000GB、200GB\\*节点数~90000GB、300GB\\*节点数~90000GB。 
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// 认证用户名，只能由英文字母开头且由英文字母、数字、中划线、下划线组成，长度为4~64的字符。
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

        /// <summary>
        /// 实例的认证密码。  复杂度要求： - 输入长度为8到32位的字符串。 - 必须包含如下四种字符中的两种组合：   - 小写字母   - 大写字母   - 数字   - 特殊字符包括（&#x60;~!@#$%^&amp;*()-_&#x3D;+\\|[{}]:&#39;\&quot;,&lt;.&gt;/?）
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 租户VPC ID。  获取方法如下：登录虚拟私有云服务的控制台界面，在虚拟私有云的详情页面查找VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 租户安全组ID。  获取方法如下：登录虚拟私有云服务的控制台界面，在安全组的详情页面查找安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 子网ID。  获取方法如下：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找网络ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 创建节点到指定且有资源的可用区ID。请参考[查询可用区信息](ListAvailableZones.xml)获取可用区ID。  该参数不能为空数组或者数组的值为空。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 产品标识。  [产品ID可以从[查询产品规格列表](ListEngineProducts.xml)获取。](tag:hws,hws_hk,ctc,cmcc,hws_eu,g42,hk_g42,tm,hk_tm,ocb,hws_ocb,hcs) [产品ID可以从[查询产品规格列表](ListProducts.xml)获取。](tag:hk_sbc,sbc)  如果产品ID为集群类型（即对应的type为cluster），broker_num字段为必选。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 代理个数。  当产品为单机类型，代理个数只能为1；当产品为集群类型，可选3、5、7个代理个数。  产品类型为single时:   - 1  产品类型为cluster时:   - 3   - 5   - 7
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public BrokerNumEnum BrokerNum { get; set; }
        /// <summary>
        /// 维护时间窗开始时间，格式为HH:mm。 - 维护时间窗开始和结束时间必须为指定的时间段。 - 开始时间必须为22:00、02:00、06:00、10:00、14:00和18:00。 - 该参数不能单独为空，若该值为空，则结束时间也为空。系统分配一个默认开始时间02:00。
        /// </summary>
        [JsonProperty("maintain_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainBegin { get; set; }

        /// <summary>
        /// 维护时间窗结束时间，格式为HH:mm。 - 维护时间窗开始和结束时间必须为指定的时间段。 - 结束时间在开始时间基础上加四个小时，即当开始时间为22:00时，结束时间为02:00。 - 该参数不能单独为空，若该值为空，则开始时间也为空，系统分配一个默认结束时间06:00。
        /// </summary>
        [JsonProperty("maintain_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainEnd { get; set; }

        /// <summary>
        /// RabbitMQ实例是否开启公网访问功能。 - true：开启 - false：不开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// RabbitMQ实例绑定的弹性IP地址的ID。 如果开启了公网访问功能（即enable_publicip为true），该字段为必选。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 是否打开SSL加密访问。 - true：打开SSL加密访问。 - false：不打开SSL加密访问。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// 存储IO规格。  取值范围：   - dms.physical.storage.high.v2   - dms.physical.storage.ultra.v2   - dms.physical.storage.high.dss.v2(专属云)   - dms.physical.storage.ultra.dss.v2(专属云)
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
            sb.Append("class CreateInstanceReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  brokerNum: ").Append(BrokerNum).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  sslEnable: ").Append(SslEnable).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInstanceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInstanceReq input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.StorageSpace == input.StorageSpace ||
                    (this.StorageSpace != null &&
                    this.StorageSpace.Equals(input.StorageSpace))
                ) && 
                (
                    this.AccessUser == input.AccessUser ||
                    (this.AccessUser != null &&
                    this.AccessUser.Equals(input.AccessUser))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
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
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.BrokerNum == input.BrokerNum ||
                    (this.BrokerNum != null &&
                    this.BrokerNum.Equals(input.BrokerNum))
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
                    this.PublicipId == input.PublicipId ||
                    (this.PublicipId != null &&
                    this.PublicipId.Equals(input.PublicipId))
                ) && 
                (
                    this.SslEnable == input.SslEnable ||
                    (this.SslEnable != null &&
                    this.SslEnable.Equals(input.SslEnable))
                ) && 
                (
                    this.StorageSpecCode == input.StorageSpecCode ||
                    (this.StorageSpecCode != null &&
                    this.StorageSpecCode.Equals(input.StorageSpecCode))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.BssParam == input.BssParam ||
                    (this.BssParam != null &&
                    this.BssParam.Equals(input.BssParam))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.StorageSpace != null)
                    hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.AccessUser != null)
                    hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.BrokerNum != null)
                    hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.MaintainBegin != null)
                    hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null)
                    hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnablePublicip != null)
                    hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.SslEnable != null)
                    hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.StorageSpecCode != null)
                    hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.BssParam != null)
                    hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
