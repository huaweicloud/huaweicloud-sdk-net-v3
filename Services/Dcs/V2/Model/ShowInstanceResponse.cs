using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceResponse : SdkResponse
    {
        /// <summary>
        /// 版本类型：社区版、企业版
        /// </summary>
        /// <value>版本类型：社区版、企业版</value>
        [JsonConverter(typeof(EnumClassConverter<ProductTypeEnum>))]
        public class ProductTypeEnum
        {
            /// <summary>
            /// Enum GENERIC for value: generic
            /// </summary>
            public static readonly ProductTypeEnum GENERIC = new ProductTypeEnum("generic");

            /// <summary>
            /// Enum ENTERPRISE for value: enterprise
            /// </summary>
            public static readonly ProductTypeEnum ENTERPRISE = new ProductTypeEnum("enterprise");

            private static readonly Dictionary<string, ProductTypeEnum> StaticFields =
            new Dictionary<string, ProductTypeEnum>()
            {
                { "generic", GENERIC },
                { "enterprise", ENTERPRISE },
            };

            private string _value;

            public ProductTypeEnum()
            {

            }

            public ProductTypeEnum(string value)
            {
                _value = value;
            }

            public static ProductTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProductTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProductTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProductTypeEnum a, ProductTypeEnum b)
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

            public static bool operator !=(ProductTypeEnum a, ProductTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 存储类型：内存存储
        /// </summary>
        /// <value>存储类型：内存存储</value>
        [JsonConverter(typeof(EnumClassConverter<StorageTypeEnum>))]
        public class StorageTypeEnum
        {
            /// <summary>
            /// Enum DRAM for value: DRAM
            /// </summary>
            public static readonly StorageTypeEnum DRAM = new StorageTypeEnum("DRAM");

            private static readonly Dictionary<string, StorageTypeEnum> StaticFields =
            new Dictionary<string, StorageTypeEnum>()
            {
                { "DRAM", DRAM },
            };

            private string _value;

            public StorageTypeEnum()
            {

            }

            public StorageTypeEnum(string value)
            {
                _value = value;
            }

            public static StorageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as StorageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StorageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StorageTypeEnum a, StorageTypeEnum b)
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

            public static bool operator !=(StorageTypeEnum a, StorageTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 缓存类型：单机类型，主备类型，主备读写分离，Proxy集群类型，原生集群类型
        /// </summary>
        /// <value>缓存类型：单机类型，主备类型，主备读写分离，Proxy集群类型，原生集群类型</value>
        [JsonConverter(typeof(EnumClassConverter<CacheModeEnum>))]
        public class CacheModeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly CacheModeEnum SINGLE = new CacheModeEnum("single");

            /// <summary>
            /// Enum HA for value: ha
            /// </summary>
            public static readonly CacheModeEnum HA = new CacheModeEnum("ha");

            /// <summary>
            /// Enum HA_RW_SPLIT for value: ha_rw_split
            /// </summary>
            public static readonly CacheModeEnum HA_RW_SPLIT = new CacheModeEnum("ha_rw_split");

            /// <summary>
            /// Enum PROXY for value: proxy
            /// </summary>
            public static readonly CacheModeEnum PROXY = new CacheModeEnum("proxy");

            /// <summary>
            /// Enum CLUSTER for value: cluster
            /// </summary>
            public static readonly CacheModeEnum CLUSTER = new CacheModeEnum("cluster");

            private static readonly Dictionary<string, CacheModeEnum> StaticFields =
            new Dictionary<string, CacheModeEnum>()
            {
                { "single", SINGLE },
                { "ha", HA },
                { "ha_rw_split", HA_RW_SPLIT },
                { "proxy", PROXY },
                { "cluster", CLUSTER },
            };

            private string _value;

            public CacheModeEnum()
            {

            }

            public CacheModeEnum(string value)
            {
                _value = value;
            }

            public static CacheModeEnum FromValue(string value)
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

                if (this.Equals(obj as CacheModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CacheModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CacheModeEnum a, CacheModeEnum b)
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

            public static bool operator !=(CacheModeEnum a, CacheModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// VPC的名称。
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// 付费模式，0表示按需计费，1表示包年/包月计费。
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 完成创建时间。格式为：2017-03-31T12:24:46.297Z
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 实例描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

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
        /// 总内存，单位：MB。
        /// </summary>
        [JsonProperty("max_memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxMemory { get; set; }

        /// <summary>
        /// 已使用的内存，单位：MB。
        /// </summary>
        [JsonProperty("used_memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedMemory { get; set; }

        /// <summary>
        /// 缓存实例的容量（G Byte）。
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Capacity { get; set; }

        /// <summary>
        /// 单机小规格的缓存容量。
        /// </summary>
        [JsonProperty("capacity_minor", NullValueHandling = NullValueHandling.Ignore)]
        public string CapacityMinor { get; set; }

        /// <summary>
        /// 维护时间窗开始时间，为UTC时间，格式为HH:mm:ss
        /// </summary>
        [JsonProperty("maintain_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainBegin { get; set; }

        /// <summary>
        /// 维护时间窗结束时间，为UTC时间，格式为HH:mm:ss
        /// </summary>
        [JsonProperty("maintain_end", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintainEnd { get; set; }

        /// <summary>
        /// 缓存实例的引擎类型。
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 是否允许免密码访问缓存实例。 - true：该实例无需密码即可访问。 - false：该实例必须通过密码认证才能访问。 
        /// </summary>
        [JsonProperty("no_password_access", NullValueHandling = NullValueHandling.Ignore)]
        public string NoPasswordAccess { get; set; }

        /// <summary>
        /// 连接缓存实例的IP地址。如果是集群实例，返回多个IP地址，使用逗号分隔。如：192.168.0.1，192.168.0.2。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_backup_policy", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceBackupPolicy InstanceBackupPolicy { get; set; }

        /// <summary>
        /// 实例所在的可用区。返回“可用区Code”
        /// </summary>
        [JsonProperty("az_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AzCodes { get; set; }

        /// <summary>
        /// 通过密码认证访问缓存实例的认证用户名。
        /// </summary>
        [JsonProperty("access_user", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessUser { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 缓存的端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 用户id。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 产品规格编码
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 子网名称。
        /// </summary>
        [JsonProperty("subnet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetName { get; set; }

        /// <summary>
        /// 子网网段。
        /// </summary>
        [JsonProperty("subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// 缓存版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 缓存实例的状态。详细状态说明见[缓存实例状态说明](https://support.huaweicloud.com/api-dcs/dcs-api-0312047.html)
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例的域名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 实例的只读域名，只有主备实例有该字段。
        /// </summary>
        [JsonProperty("readonly_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadonlyDomainName { get; set; }

        /// <summary>
        /// Redis缓存实例是否开启公网访问功能。 - true：开启 - false：不开启 
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// Redis缓存实例绑定的弹性IP地址的id。 如果未开启公网访问功能，该字段值为null。 
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// Redis缓存实例绑定的弹性IP地址。 如果未开启公网访问功能，该字段值为null。 
        /// </summary>
        [JsonProperty("publicip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipAddress { get; set; }

        /// <summary>
        /// Redis缓存实例开启公网访问功能时，是否选择支持ssl。 - true：开启 - false：不开启 
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 实例是否存在升级任务。 - true：存在 - false：不存在 
        /// </summary>
        [JsonProperty("service_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServiceUpgrade { get; set; }

        /// <summary>
        /// 升级任务的ID。 - 当service_upgrade为true时，为升级任务的ID。 - 当service_upgrade为false时，该参数为空。 
        /// </summary>
        [JsonProperty("service_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 集群实例的后端服务地址。
        /// </summary>
        [JsonProperty("backend_addrs", NullValueHandling = NullValueHandling.Ignore)]
        public string BackendAddrs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("features", NullValueHandling = NullValueHandling.Ignore)]
        public Features Features { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain_name_info", NullValueHandling = NullValueHandling.Ignore)]
        public DomainNameInfo DomainNameInfo { get; set; }

        /// <summary>
        /// 是否开启客户端ip透传。
        /// </summary>
        [JsonProperty("transparent_client_ip_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TransparentClientIpEnable { get; set; }

        /// <summary>
        /// 实例子状态。
        /// </summary>
        [JsonProperty("sub_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SubStatus { get; set; }

        /// <summary>
        /// 实例标签键值。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// 实例CPU类型，通常为x86_64或aarch64
        /// </summary>
        [JsonProperty("cpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuType { get; set; }

        /// <summary>
        /// 企业项目名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 更新时间，形如2022-07-06T09:32:16.502Z
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// 版本类型：社区版、企业版
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProductTypeEnum ProductType { get; set; }
        /// <summary>
        /// 存储类型：内存存储
        /// </summary>
        [JsonProperty("storage_type", NullValueHandling = NullValueHandling.Ignore)]
        public StorageTypeEnum StorageType { get; set; }
        /// <summary>
        /// 启动时间，形如2022-07-06T09:32:16.502Z
        /// </summary>
        [JsonProperty("launched_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LaunchedAt { get; set; }

        /// <summary>
        /// 缓存类型：单机类型，主备类型，主备读写分离，Proxy集群类型，原生集群类型
        /// </summary>
        [JsonProperty("cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public CacheModeEnum CacheMode { get; set; }
        /// <summary>
        /// 是否支持慢日志
        /// </summary>
        [JsonProperty("support_slow_log_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportSlowLogFlag { get; set; }

        /// <summary>
        /// 数据库数量
        /// </summary>
        [JsonProperty("db_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbNumber { get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("replica_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// 集群实例分片个数
        /// </summary>
        [JsonProperty("sharding_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardingCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_info", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthInfo BandwidthInfo { get; set; }

        /// <summary>
        /// 云服务类型编码。
        /// </summary>
        [JsonProperty("cloud_service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeCode { get; set; }

        /// <summary>
        /// 云资源类型编码。
        /// </summary>
        [JsonProperty("cloud_resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudResourceTypeCode { get; set; }

        /// <summary>
        /// 运营系统中的规格编码
        /// </summary>
        [JsonProperty("inquery_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string InquerySpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceResponse {\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  securityGroupName: ").Append(SecurityGroupName).Append("\n");
            sb.Append("  maxMemory: ").Append(MaxMemory).Append("\n");
            sb.Append("  usedMemory: ").Append(UsedMemory).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  capacityMinor: ").Append(CapacityMinor).Append("\n");
            sb.Append("  maintainBegin: ").Append(MaintainBegin).Append("\n");
            sb.Append("  maintainEnd: ").Append(MaintainEnd).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  noPasswordAccess: ").Append(NoPasswordAccess).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  instanceBackupPolicy: ").Append(InstanceBackupPolicy).Append("\n");
            sb.Append("  azCodes: ").Append(AzCodes).Append("\n");
            sb.Append("  accessUser: ").Append(AccessUser).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  subnetName: ").Append(SubnetName).Append("\n");
            sb.Append("  subnetCidr: ").Append(SubnetCidr).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  readonlyDomainName: ").Append(ReadonlyDomainName).Append("\n");
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  publicipAddress: ").Append(PublicipAddress).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  serviceUpgrade: ").Append(ServiceUpgrade).Append("\n");
            sb.Append("  serviceTaskId: ").Append(ServiceTaskId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  backendAddrs: ").Append(BackendAddrs).Append("\n");
            sb.Append("  features: ").Append(Features).Append("\n");
            sb.Append("  domainNameInfo: ").Append(DomainNameInfo).Append("\n");
            sb.Append("  transparentClientIpEnable: ").Append(TransparentClientIpEnable).Append("\n");
            sb.Append("  subStatus: ").Append(SubStatus).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  cpuType: ").Append(CpuType).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  productType: ").Append(ProductType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  launchedAt: ").Append(LaunchedAt).Append("\n");
            sb.Append("  cacheMode: ").Append(CacheMode).Append("\n");
            sb.Append("  supportSlowLogFlag: ").Append(SupportSlowLogFlag).Append("\n");
            sb.Append("  dbNumber: ").Append(DbNumber).Append("\n");
            sb.Append("  replicaCount: ").Append(ReplicaCount).Append("\n");
            sb.Append("  shardingCount: ").Append(ShardingCount).Append("\n");
            sb.Append("  bandwidthInfo: ").Append(BandwidthInfo).Append("\n");
            sb.Append("  cloudServiceTypeCode: ").Append(CloudServiceTypeCode).Append("\n");
            sb.Append("  cloudResourceTypeCode: ").Append(CloudResourceTypeCode).Append("\n");
            sb.Append("  inquerySpecCode: ").Append(InquerySpecCode).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.VpcName == input.VpcName ||
                    (this.VpcName != null &&
                    this.VpcName.Equals(input.VpcName))
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
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.MaxMemory == input.MaxMemory ||
                    (this.MaxMemory != null &&
                    this.MaxMemory.Equals(input.MaxMemory))
                ) && 
                (
                    this.UsedMemory == input.UsedMemory ||
                    (this.UsedMemory != null &&
                    this.UsedMemory.Equals(input.UsedMemory))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.CapacityMinor == input.CapacityMinor ||
                    (this.CapacityMinor != null &&
                    this.CapacityMinor.Equals(input.CapacityMinor))
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
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.NoPasswordAccess == input.NoPasswordAccess ||
                    (this.NoPasswordAccess != null &&
                    this.NoPasswordAccess.Equals(input.NoPasswordAccess))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.InstanceBackupPolicy == input.InstanceBackupPolicy ||
                    (this.InstanceBackupPolicy != null &&
                    this.InstanceBackupPolicy.Equals(input.InstanceBackupPolicy))
                ) && 
                (
                    this.AzCodes == input.AzCodes ||
                    this.AzCodes != null &&
                    input.AzCodes != null &&
                    this.AzCodes.SequenceEqual(input.AzCodes)
                ) && 
                (
                    this.AccessUser == input.AccessUser ||
                    (this.AccessUser != null &&
                    this.AccessUser.Equals(input.AccessUser))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.SubnetName == input.SubnetName ||
                    (this.SubnetName != null &&
                    this.SubnetName.Equals(input.SubnetName))
                ) && 
                (
                    this.SubnetCidr == input.SubnetCidr ||
                    (this.SubnetCidr != null &&
                    this.SubnetCidr.Equals(input.SubnetCidr))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.ReadonlyDomainName == input.ReadonlyDomainName ||
                    (this.ReadonlyDomainName != null &&
                    this.ReadonlyDomainName.Equals(input.ReadonlyDomainName))
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
                    this.PublicipAddress == input.PublicipAddress ||
                    (this.PublicipAddress != null &&
                    this.PublicipAddress.Equals(input.PublicipAddress))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.ServiceUpgrade == input.ServiceUpgrade ||
                    (this.ServiceUpgrade != null &&
                    this.ServiceUpgrade.Equals(input.ServiceUpgrade))
                ) && 
                (
                    this.ServiceTaskId == input.ServiceTaskId ||
                    (this.ServiceTaskId != null &&
                    this.ServiceTaskId.Equals(input.ServiceTaskId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.BackendAddrs == input.BackendAddrs ||
                    (this.BackendAddrs != null &&
                    this.BackendAddrs.Equals(input.BackendAddrs))
                ) && 
                (
                    this.Features == input.Features ||
                    (this.Features != null &&
                    this.Features.Equals(input.Features))
                ) && 
                (
                    this.DomainNameInfo == input.DomainNameInfo ||
                    (this.DomainNameInfo != null &&
                    this.DomainNameInfo.Equals(input.DomainNameInfo))
                ) && 
                (
                    this.TransparentClientIpEnable == input.TransparentClientIpEnable ||
                    (this.TransparentClientIpEnable != null &&
                    this.TransparentClientIpEnable.Equals(input.TransparentClientIpEnable))
                ) && 
                (
                    this.SubStatus == input.SubStatus ||
                    (this.SubStatus != null &&
                    this.SubStatus.Equals(input.SubStatus))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.CpuType == input.CpuType ||
                    (this.CpuType != null &&
                    this.CpuType.Equals(input.CpuType))
                ) && 
                (
                    this.EnterpriseProjectName == input.EnterpriseProjectName ||
                    (this.EnterpriseProjectName != null &&
                    this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))
                ) && 
                (
                    this.UpdateAt == input.UpdateAt ||
                    (this.UpdateAt != null &&
                    this.UpdateAt.Equals(input.UpdateAt))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.LaunchedAt == input.LaunchedAt ||
                    (this.LaunchedAt != null &&
                    this.LaunchedAt.Equals(input.LaunchedAt))
                ) && 
                (
                    this.CacheMode == input.CacheMode ||
                    (this.CacheMode != null &&
                    this.CacheMode.Equals(input.CacheMode))
                ) && 
                (
                    this.SupportSlowLogFlag == input.SupportSlowLogFlag ||
                    (this.SupportSlowLogFlag != null &&
                    this.SupportSlowLogFlag.Equals(input.SupportSlowLogFlag))
                ) && 
                (
                    this.DbNumber == input.DbNumber ||
                    (this.DbNumber != null &&
                    this.DbNumber.Equals(input.DbNumber))
                ) && 
                (
                    this.ReplicaCount == input.ReplicaCount ||
                    (this.ReplicaCount != null &&
                    this.ReplicaCount.Equals(input.ReplicaCount))
                ) && 
                (
                    this.ShardingCount == input.ShardingCount ||
                    (this.ShardingCount != null &&
                    this.ShardingCount.Equals(input.ShardingCount))
                ) && 
                (
                    this.BandwidthInfo == input.BandwidthInfo ||
                    (this.BandwidthInfo != null &&
                    this.BandwidthInfo.Equals(input.BandwidthInfo))
                ) && 
                (
                    this.CloudServiceTypeCode == input.CloudServiceTypeCode ||
                    (this.CloudServiceTypeCode != null &&
                    this.CloudServiceTypeCode.Equals(input.CloudServiceTypeCode))
                ) && 
                (
                    this.CloudResourceTypeCode == input.CloudResourceTypeCode ||
                    (this.CloudResourceTypeCode != null &&
                    this.CloudResourceTypeCode.Equals(input.CloudResourceTypeCode))
                ) && 
                (
                    this.InquerySpecCode == input.InquerySpecCode ||
                    (this.InquerySpecCode != null &&
                    this.InquerySpecCode.Equals(input.InquerySpecCode))
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
                if (this.VpcName != null)
                    hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SecurityGroupName != null)
                    hashCode = hashCode * 59 + this.SecurityGroupName.GetHashCode();
                if (this.MaxMemory != null)
                    hashCode = hashCode * 59 + this.MaxMemory.GetHashCode();
                if (this.UsedMemory != null)
                    hashCode = hashCode * 59 + this.UsedMemory.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.CapacityMinor != null)
                    hashCode = hashCode * 59 + this.CapacityMinor.GetHashCode();
                if (this.MaintainBegin != null)
                    hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null)
                    hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.NoPasswordAccess != null)
                    hashCode = hashCode * 59 + this.NoPasswordAccess.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.InstanceBackupPolicy != null)
                    hashCode = hashCode * 59 + this.InstanceBackupPolicy.GetHashCode();
                if (this.AzCodes != null)
                    hashCode = hashCode * 59 + this.AzCodes.GetHashCode();
                if (this.AccessUser != null)
                    hashCode = hashCode * 59 + this.AccessUser.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SubnetName != null)
                    hashCode = hashCode * 59 + this.SubnetName.GetHashCode();
                if (this.SubnetCidr != null)
                    hashCode = hashCode * 59 + this.SubnetCidr.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.ReadonlyDomainName != null)
                    hashCode = hashCode * 59 + this.ReadonlyDomainName.GetHashCode();
                if (this.EnablePublicip != null)
                    hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.PublicipAddress != null)
                    hashCode = hashCode * 59 + this.PublicipAddress.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.ServiceUpgrade != null)
                    hashCode = hashCode * 59 + this.ServiceUpgrade.GetHashCode();
                if (this.ServiceTaskId != null)
                    hashCode = hashCode * 59 + this.ServiceTaskId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.BackendAddrs != null)
                    hashCode = hashCode * 59 + this.BackendAddrs.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.DomainNameInfo != null)
                    hashCode = hashCode * 59 + this.DomainNameInfo.GetHashCode();
                if (this.TransparentClientIpEnable != null)
                    hashCode = hashCode * 59 + this.TransparentClientIpEnable.GetHashCode();
                if (this.SubStatus != null)
                    hashCode = hashCode * 59 + this.SubStatus.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CpuType != null)
                    hashCode = hashCode * 59 + this.CpuType.GetHashCode();
                if (this.EnterpriseProjectName != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.UpdateAt != null)
                    hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.LaunchedAt != null)
                    hashCode = hashCode * 59 + this.LaunchedAt.GetHashCode();
                if (this.CacheMode != null)
                    hashCode = hashCode * 59 + this.CacheMode.GetHashCode();
                if (this.SupportSlowLogFlag != null)
                    hashCode = hashCode * 59 + this.SupportSlowLogFlag.GetHashCode();
                if (this.DbNumber != null)
                    hashCode = hashCode * 59 + this.DbNumber.GetHashCode();
                if (this.ReplicaCount != null)
                    hashCode = hashCode * 59 + this.ReplicaCount.GetHashCode();
                if (this.ShardingCount != null)
                    hashCode = hashCode * 59 + this.ShardingCount.GetHashCode();
                if (this.BandwidthInfo != null)
                    hashCode = hashCode * 59 + this.BandwidthInfo.GetHashCode();
                if (this.CloudServiceTypeCode != null)
                    hashCode = hashCode * 59 + this.CloudServiceTypeCode.GetHashCode();
                if (this.CloudResourceTypeCode != null)
                    hashCode = hashCode * 59 + this.CloudResourceTypeCode.GetHashCode();
                if (this.InquerySpecCode != null)
                    hashCode = hashCode * 59 + this.InquerySpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
