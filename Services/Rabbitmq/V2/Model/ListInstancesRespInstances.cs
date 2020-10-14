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
    /// 
    /// </summary>
    public class ListInstancesRespInstances 
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
        /// 实例规格。   - RabbitMQ实例单机返回vm规格。   - RabbitMQ实例集群返回vm规格和节点数。
        /// </summary>
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public string Specification { get; set; }

        /// <summary>
        /// 消息存储空间，单位：GB。
        /// </summary>
        [JsonProperty("storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageSpace { get; set; }

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
        /// 实例的状态。详细状态说明见[实例状态说明](https://support.huaweicloud.com/api-rabbitmq/rabbitmq-api-180514012.html)。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 资源规格标识。   - dms.instance.rabbitmq.single.c3.2u4g：RabbitMQ单机，vm规格2u4g   - dms.instance.rabbitmq.single.c3.4u8g：RabbitMQ单机，vm规格4u8g   - dms.instance.rabbitmq.single.c3.8u16g：RabbitMQ单机，vm规格8u16g   - dms.instance.rabbitmq.single.c3.16u32g：RabbitMQ单机，vm规格16u32g   - dms.instance.rabbitmq.cluster.c3.4u8g.3：RabbitMQ集群，vm规格4u8g，3个节点   - dms.instance.rabbitmq.cluster.c3.4u8g.5：RabbitMQ集群，vm规格4u8g，5个节点   - dms.instance.rabbitmq.cluster.c3.4u8g.7：RabbitMQ集群，vm规格4u8g，7个节点   - dms.instance.rabbitmq.cluster.c3.8u16g.3：RabbitMQ集群，vm规格8u16g，3个节点   - dms.instance.rabbitmq.cluster.c3.8u16g.5：RabbitMQ集群，vm规格8u16g，5个节点   - dms.instance.rabbitmq.cluster.c3.8u16g.7：RabbitMQ集群，vm规格8u16g，7个节点   - dms.instance.rabbitmq.cluster.c3.16u32g.3：RabbitMQ集群，vm规格16u32g，3个节点   - dms.instance.rabbitmq.cluster.c3.16u32g.5：RabbitMQ集群，vm规格16u32g，5个节点   - dms.instance.rabbitmq.cluster.c3.16u32g.7：RabbitMQ集群，vm规格16u32g，7个节点
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
        /// RabbitMQ实例是否开启公网访问功能。 - true：开启 - false：未开启
        /// </summary>
        [JsonProperty("enable_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePublicip { get; set; }

        /// <summary>
        /// RabbitMQ实例绑定的弹性IP地址。  如果未开启公网访问功能，该字段值为null。
        /// </summary>
        [JsonProperty("publicip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipAddress { get; set; }

        /// <summary>
        /// RabbitMQ实例绑定的弹性IP地址的ID。  如果未开启公网访问功能，该字段值为null。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// RabbitMQ实例的管理地址。
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesRespInstances {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
            sb.Append("  storageSpace: ").Append(StorageSpace).Append("\n");
            sb.Append("  usedStorageSpace: ").Append(UsedStorageSpace).Append("\n");
            sb.Append("  connectAddress: ").Append(ConnectAddress).Append("\n");
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
            sb.Append("  totalStorageSpace: ").Append(TotalStorageSpace).Append("\n");
            sb.Append("  storageResourceId: ").Append(StorageResourceId).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  storageType: ").Append(StorageType).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  ipv6ConnectAddresses: ").Append(Ipv6ConnectAddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesRespInstances);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesRespInstances input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.PublicipAddress == input.PublicipAddress ||
                    (this.PublicipAddress != null &&
                    this.PublicipAddress.Equals(input.PublicipAddress))
                ) && 
                (
                    this.PublicipId == input.PublicipId ||
                    (this.PublicipId != null &&
                    this.PublicipId.Equals(input.PublicipId))
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
                    this.Ipv6Enable == input.Ipv6Enable ||
                    (this.Ipv6Enable != null &&
                    this.Ipv6Enable.Equals(input.Ipv6Enable))
                ) && 
                (
                    this.Ipv6ConnectAddresses == input.Ipv6ConnectAddresses ||
                    this.Ipv6ConnectAddresses != null &&
                    input.Ipv6ConnectAddresses != null &&
                    this.Ipv6ConnectAddresses.SequenceEqual(input.Ipv6ConnectAddresses)
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
                if (this.UsedStorageSpace != null)
                    hashCode = hashCode * 59 + this.UsedStorageSpace.GetHashCode();
                if (this.ConnectAddress != null)
                    hashCode = hashCode * 59 + this.ConnectAddress.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
                if (this.PublicipAddress != null)
                    hashCode = hashCode * 59 + this.PublicipAddress.GetHashCode();
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
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
                if (this.StorageResourceId != null)
                    hashCode = hashCode * 59 + this.StorageResourceId.GetHashCode();
                if (this.StorageSpecCode != null)
                    hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.StorageType != null)
                    hashCode = hashCode * 59 + this.StorageType.GetHashCode();
                if (this.Ipv6Enable != null)
                    hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.Ipv6ConnectAddresses != null)
                    hashCode = hashCode * 59 + this.Ipv6ConnectAddresses.GetHashCode();
                return hashCode;
            }
        }
    }
}
