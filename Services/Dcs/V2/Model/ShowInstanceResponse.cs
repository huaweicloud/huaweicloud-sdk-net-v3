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
        public BackupPolicy InstanceBackupPolicy { get; set; }

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
            sb.Append("  enablePublicip: ").Append(EnablePublicip).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  publicipAddress: ").Append(PublicipAddress).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  serviceUpgrade: ").Append(ServiceUpgrade).Append("\n");
            sb.Append("  serviceTaskId: ").Append(ServiceTaskId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  backendAddrs: ").Append(BackendAddrs).Append("\n");
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
                return hashCode;
            }
        }
    }
}
