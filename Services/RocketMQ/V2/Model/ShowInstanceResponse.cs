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
    /// Response Object
    /// </summary>
    public class ShowInstanceResponse : SdkResponse
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
        /// 状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 消息描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例类型：集群，cluster。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 实例规格。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// 版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// [付费模式，1表示按需计费。](tag:hws_eu,g42,hk_g42,tm,hk_tm)[付费模式，1表示按需计费，0表示包年/包月计费。](tag:hws,hws_hk,ctc) [计费模式，参数暂未使用。](tag:ocb,hws_ocb)
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 私有云名称。
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// 完成创建时间。 格式为时间戳，指从格林威治时间1970年01月01日00时00分00秒起至指定时间的偏差总毫秒数。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

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
        /// 子网名称。
        /// </summary>
        [JsonProperty("subnet_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetName { get; set; }

        /// <summary>
        /// 子网路由。
        /// </summary>
        [JsonProperty("subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// IO未售罄的可用区列表。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

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
        /// 是否开启消息收集功能。
        /// </summary>
        [JsonProperty("enable_log_collection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLogCollection { get; set; }

        /// <summary>
        /// 存储空间，单位：GB。
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// 已用消息存储空间，单位：GB。
        /// </summary>
        [JsonProperty("used_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedStorageSpace { get; set; }

        /// <summary>
        /// 是否开启公网。
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// 实例绑定的弹性IP地址的ID。 以英文逗号隔开多个弹性IP地址的ID。 如果开启了公网访问功能（即enable_publicip为true），该字段为必选。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 公网IP地址。
        /// </summary>
        [JsonProperty("publicip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipAddress { get; set; }

        /// <summary>
        /// 是否开启SSL。
        /// </summary>
        [JsonProperty("ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnable { get; set; }

        /// <summary>
        /// 跨VPC访问信息。
        /// </summary>
        [JsonProperty("cross_vpc_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossVpcInfo { get; set; }

        /// <summary>
        /// 存储资源ID。
        /// </summary>
        [JsonProperty("storage_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageResourceId { get; set; }

        /// <summary>
        /// 存储规格代码。
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
        /// 扩展时间。
        /// </summary>
        [JsonProperty("extend_times", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExtendTimes { get; set; }

        /// <summary>
        /// 是否开启IPv6。
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// 实例支持的特性功能。
        /// </summary>
        [JsonProperty("support_features", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportFeatures { get; set; }

        /// <summary>
        /// 是否开启磁盘加密。
        /// </summary>
        [JsonProperty("disk_encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DiskEncrypted { get; set; }

        /// <summary>
        /// 云监控版本。
        /// </summary>
        [JsonProperty("ces_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CesVersion { get; set; }

        /// <summary>
        /// 节点数。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 是否启用新规格计费。
        /// </summary>
        [JsonProperty("new_spec_billing_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewSpecBillingEnable { get; set; }

        /// <summary>
        /// 是否开启访问控制列表。
        /// </summary>
        [JsonProperty("enable_acl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAcl { get; set; }

        /// <summary>
        /// 节点数。
        /// </summary>
        [JsonProperty("broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BrokerNum { get; set; }

        /// <summary>
        /// 元数据地址。
        /// </summary>
        [JsonProperty("namesrv_address", NullValueHandling = NullValueHandling.Ignore)]
        public string NamesrvAddress { get; set; }

        /// <summary>
        /// 业务数据地址。
        /// </summary>
        [JsonProperty("broker_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BrokerAddress { get; set; }

        /// <summary>
        /// 公网元数据地址。
        /// </summary>
        [JsonProperty("public_namesrv_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicNamesrvAddress { get; set; }

        /// <summary>
        /// 公网业务数据地址。
        /// </summary>
        [JsonProperty("public_broker_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBrokerAddress { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagEntity> Tags { get; set; }

        /// <summary>
        /// 总存储空间。
        /// </summary>
        [JsonProperty("total_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalStorageSpace { get; set; }

        /// <summary>
        /// 资源规格。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceResponse {\n");
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
            sb.Append("  subnetName: ").Append(SubnetName).Append("\n");
            sb.Append("  subnetCidr: ").Append(SubnetCidr).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
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
            sb.Append("  namesrvAddress: ").Append(NamesrvAddress).Append("\n");
            sb.Append("  brokerAddress: ").Append(BrokerAddress).Append("\n");
            sb.Append("  publicNamesrvAddress: ").Append(PublicNamesrvAddress).Append("\n");
            sb.Append("  publicBrokerAddress: ").Append(PublicBrokerAddress).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  totalStorageSpace: ").Append(TotalStorageSpace).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Specification == input.Specification ||
                    (this.Specification != null &&
                    this.Specification.Equals(input.Specification))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
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
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
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
                    this.EnableLogCollection == input.EnableLogCollection ||
                    (this.EnableLogCollection != null &&
                    this.EnableLogCollection.Equals(input.EnableLogCollection))
                ) && 
                (
                    this.StorageSpace == input.StorageSpace ||
                    (this.StorageSpace != null &&
                    this.StorageSpace.Equals(input.StorageSpace))
                ) && 
                (
                    this.UsedStorageSpace == input.UsedStorageSpace ||
                    (this.UsedStorageSpace != null &&
                    this.UsedStorageSpace.Equals(input.UsedStorageSpace))
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
                    this.SslEnable == input.SslEnable ||
                    (this.SslEnable != null &&
                    this.SslEnable.Equals(input.SslEnable))
                ) && 
                (
                    this.CrossVpcInfo == input.CrossVpcInfo ||
                    (this.CrossVpcInfo != null &&
                    this.CrossVpcInfo.Equals(input.CrossVpcInfo))
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
                    this.ExtendTimes == input.ExtendTimes ||
                    (this.ExtendTimes != null &&
                    this.ExtendTimes.Equals(input.ExtendTimes))
                ) && 
                (
                    this.Ipv6Enable == input.Ipv6Enable ||
                    (this.Ipv6Enable != null &&
                    this.Ipv6Enable.Equals(input.Ipv6Enable))
                ) && 
                (
                    this.SupportFeatures == input.SupportFeatures ||
                    (this.SupportFeatures != null &&
                    this.SupportFeatures.Equals(input.SupportFeatures))
                ) && 
                (
                    this.DiskEncrypted == input.DiskEncrypted ||
                    (this.DiskEncrypted != null &&
                    this.DiskEncrypted.Equals(input.DiskEncrypted))
                ) && 
                (
                    this.CesVersion == input.CesVersion ||
                    (this.CesVersion != null &&
                    this.CesVersion.Equals(input.CesVersion))
                ) && 
                (
                    this.NodeNum == input.NodeNum ||
                    (this.NodeNum != null &&
                    this.NodeNum.Equals(input.NodeNum))
                ) && 
                (
                    this.NewSpecBillingEnable == input.NewSpecBillingEnable ||
                    (this.NewSpecBillingEnable != null &&
                    this.NewSpecBillingEnable.Equals(input.NewSpecBillingEnable))
                ) && 
                (
                    this.EnableAcl == input.EnableAcl ||
                    (this.EnableAcl != null &&
                    this.EnableAcl.Equals(input.EnableAcl))
                ) && 
                (
                    this.BrokerNum == input.BrokerNum ||
                    (this.BrokerNum != null &&
                    this.BrokerNum.Equals(input.BrokerNum))
                ) && 
                (
                    this.NamesrvAddress == input.NamesrvAddress ||
                    (this.NamesrvAddress != null &&
                    this.NamesrvAddress.Equals(input.NamesrvAddress))
                ) && 
                (
                    this.BrokerAddress == input.BrokerAddress ||
                    (this.BrokerAddress != null &&
                    this.BrokerAddress.Equals(input.BrokerAddress))
                ) && 
                (
                    this.PublicNamesrvAddress == input.PublicNamesrvAddress ||
                    (this.PublicNamesrvAddress != null &&
                    this.PublicNamesrvAddress.Equals(input.PublicNamesrvAddress))
                ) && 
                (
                    this.PublicBrokerAddress == input.PublicBrokerAddress ||
                    (this.PublicBrokerAddress != null &&
                    this.PublicBrokerAddress.Equals(input.PublicBrokerAddress))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TotalStorageSpace == input.TotalStorageSpace ||
                    (this.TotalStorageSpace != null &&
                    this.TotalStorageSpace.Equals(input.TotalStorageSpace))
                ) && 
                (
                    this.ResourceSpecCode == input.ResourceSpecCode ||
                    (this.ResourceSpecCode != null &&
                    this.ResourceSpecCode.Equals(input.ResourceSpecCode))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Specification != null)
                    hashCode = hashCode * 59 + this.Specification.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcName != null)
                    hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SecurityGroupName != null)
                    hashCode = hashCode * 59 + this.SecurityGroupName.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SubnetName != null)
                    hashCode = hashCode * 59 + this.SubnetName.GetHashCode();
                if (this.SubnetCidr != null)
                    hashCode = hashCode * 59 + this.SubnetCidr.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.MaintainBegin != null)
                    hashCode = hashCode * 59 + this.MaintainBegin.GetHashCode();
                if (this.MaintainEnd != null)
                    hashCode = hashCode * 59 + this.MaintainEnd.GetHashCode();
                if (this.EnableLogCollection != null)
                    hashCode = hashCode * 59 + this.EnableLogCollection.GetHashCode();
                if (this.StorageSpace != null)
                    hashCode = hashCode * 59 + this.StorageSpace.GetHashCode();
                if (this.UsedStorageSpace != null)
                    hashCode = hashCode * 59 + this.UsedStorageSpace.GetHashCode();
                if (this.EnablePublicip != null)
                    hashCode = hashCode * 59 + this.EnablePublicip.GetHashCode();
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.PublicipAddress != null)
                    hashCode = hashCode * 59 + this.PublicipAddress.GetHashCode();
                if (this.SslEnable != null)
                    hashCode = hashCode * 59 + this.SslEnable.GetHashCode();
                if (this.CrossVpcInfo != null)
                    hashCode = hashCode * 59 + this.CrossVpcInfo.GetHashCode();
                if (this.StorageResourceId != null)
                    hashCode = hashCode * 59 + this.StorageResourceId.GetHashCode();
                if (this.StorageSpecCode != null)
                    hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.ExtendTimes != null)
                    hashCode = hashCode * 59 + this.ExtendTimes.GetHashCode();
                if (this.Ipv6Enable != null)
                    hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.SupportFeatures != null)
                    hashCode = hashCode * 59 + this.SupportFeatures.GetHashCode();
                if (this.DiskEncrypted != null)
                    hashCode = hashCode * 59 + this.DiskEncrypted.GetHashCode();
                if (this.CesVersion != null)
                    hashCode = hashCode * 59 + this.CesVersion.GetHashCode();
                if (this.NodeNum != null)
                    hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.NewSpecBillingEnable != null)
                    hashCode = hashCode * 59 + this.NewSpecBillingEnable.GetHashCode();
                if (this.EnableAcl != null)
                    hashCode = hashCode * 59 + this.EnableAcl.GetHashCode();
                if (this.BrokerNum != null)
                    hashCode = hashCode * 59 + this.BrokerNum.GetHashCode();
                if (this.NamesrvAddress != null)
                    hashCode = hashCode * 59 + this.NamesrvAddress.GetHashCode();
                if (this.BrokerAddress != null)
                    hashCode = hashCode * 59 + this.BrokerAddress.GetHashCode();
                if (this.PublicNamesrvAddress != null)
                    hashCode = hashCode * 59 + this.PublicNamesrvAddress.GetHashCode();
                if (this.PublicBrokerAddress != null)
                    hashCode = hashCode * 59 + this.PublicBrokerAddress.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TotalStorageSpace != null)
                    hashCode = hashCode * 59 + this.TotalStorageSpace.GetHashCode();
                if (this.ResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
