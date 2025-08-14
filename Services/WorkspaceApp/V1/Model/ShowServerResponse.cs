using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowServerResponse : SdkResponse
    {

        /// <summary>
        /// aps实例的唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 服务器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 计算机名称。
        /// </summary>
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 服务器组ID。
        /// </summary>
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public Flavor Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ServerStatus Status { get; set; }
        /// <summary>
        /// 服务器创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 服务器可用分区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 域。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组织名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 实例的SID。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// 实例的ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 服务器系统版本。
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 操作系统类型，当前仅支持Windows： - Linux - Windows - Other
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 包周期产品的订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否维护状态。
        /// </summary>
        [JsonProperty("maintain_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MaintainStatus { get; set; }

        /// <summary>
        /// 配置弹性伸缩策略时，服务自动创建的实例。 - true : 通过弹性伸缩创建。 - false: 不是通过弹性伸缩创建。
        /// </summary>
        [JsonProperty("scaling_auto_create", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScalingAutoCreate { get; set; }

        /// <summary>
        /// 上一次执行job的id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobType JobType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public JobStatus JobStatus { get; set; }
        /// <summary>
        /// 上一次执行job的执行时间。
        /// </summary>
        [JsonProperty("job_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JobTime { get; set; }

        /// <summary>
        /// 资源池ID。
        /// </summary>
        [JsonProperty("resource_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolId { get; set; }

        /// <summary>
        /// 资源池类型： - private：私有资源池。 - public: 工作资源池。
        /// </summary>
        [JsonProperty("resource_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolType { get; set; }

        /// <summary>
        /// 云专属主机id。
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 服务器组名称。
        /// </summary>
        [JsonProperty("server_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProductInfo ProductInfo { get; set; }

        /// <summary>
        /// 弹性云服务器元数据。  &gt;   1. charging_mode 云服务器的计费类型。  - “0”：按需计费（即postPaid-后付费方式）。 - “1”：按包年包月计费（即prePaid-预付费方式）。\&quot;2\&quot;：竞价实例计费  2. metering.order_id 按“包年/包月”计费的云服务器对应的订单ID。  3. metering.product_id 按“包年/包月”计费的云服务器对应的产品ID。  4. vpc_id 云服务器所属的虚拟私有云ID。  5. EcmResStatus 云服务器的冻结状态。  - normal：云服务器正常状态（未被冻结）。 - freeze：云服务器被冻结。  &gt; 当云服务器被冻结或者解冻后，系统默认添加该字段，且该字段必选。  6. metering.image_id 云服务器操作系统对应的镜像ID  7.  metering.imagetype 镜像类型，目前支持：  - 公共镜像（gold） - 私有镜像（private） - 共享镜像（shared）  8. metering.resourcespeccode 云服务器对应的资源规格。  9. image_name 云服务器操作系统对应的镜像名称。  10. os_bit 操作系统位数，一般取值为“32”或者“64”。  11. lockCheckEndpoint 回调URL，用于检查弹性云服务器的加锁是否有效。  - 如果有效，则云服务器保持锁定状态。 - 如果无效，解除锁定状态，删除失效的锁。  12. lockSource 弹性云服务器来自哪个服务。订单加锁（ORDER）  13. lockSourceId 弹性云服务器的加锁来自哪个ID。lockSource为“ORDER”时，lockSourceId为订单ID。  14. lockScene 弹性云服务器的加锁类型。  - 按需转包周期（TO_PERIOD_LOCK）  15. virtual_env_type  - IOS镜像创建虚拟机，\&quot;virtual_env_type\&quot;: \&quot;IsoImage\&quot; 属性； - 非IOS镜像创建虚拟机，在19.5.0版本以后创建的虚拟机将不会添加virtual_env_type 属性，而在此之前的版本创建的虚拟机可能会返回\&quot;virtual_env_type\&quot;: \&quot;FusionCompute\&quot;属性 。  &gt; virtual_env_type属性不允许用户增加、删除和修改。  16. metering.resourcetype 云服务器对应的资源类型。  17. os_type 操作系统类型，取值为：Linux、Windows。  18. cascaded.instance_extrainfo 系统内部虚拟机扩展信息。  19. __support_agent_list 云服务器是否支持企业主机安全、主机监控。  - “hss”：企业主机安全 -  “ces”：主机监控  20. agency_name 委托的名称。  委托是由租户管理员在统一身份认证服务（Identity and Access Management，IAM）上创建的，可以为弹性云服务器提供访问云服务的临时凭证。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 会话数量。
        /// </summary>
        [JsonProperty("session_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vm_status", NullValueHandling = NullValueHandling.Ignore)]
        public AppServerStatus VmStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public AppServerTaskStatus TaskStatus { get; set; }
        /// <summary>
        /// 冻结信息。
        /// </summary>
        [JsonProperty("freeze", NullValueHandling = NullValueHandling.Ignore)]
        public List<CbcFreezeInfo> Freeze { get; set; }

        /// <summary>
        /// vpc和子网信息。
        /// </summary>
        [JsonProperty("host_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<EcsNetWork> HostAddress { get; set; }

        /// <summary>
        /// 企业项目ID,仅企业项目会返回。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 标签信息。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TmsTag> Tags { get; set; }

        /// <summary>
        /// 服务器IP地址列表。
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<ServerAddress>> Addresses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeDetail RootVolume { get; set; }

        /// <summary>
        /// 数据卷信息。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeDetail> DataVolumes { get; set; }

        /// <summary>
        /// 服务器安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerSecurityGroup> SecurityGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  maintainStatus: ").Append(MaintainStatus).Append("\n");
            sb.Append("  scalingAutoCreate: ").Append(ScalingAutoCreate).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  jobTime: ").Append(JobTime).Append("\n");
            sb.Append("  resourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("  resourcePoolType: ").Append(ResourcePoolType).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  serverGroupName: ").Append(ServerGroupName).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  sessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  vmStatus: ").Append(VmStatus).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  freeze: ").Append(Freeze).Append("\n");
            sb.Append("  hostAddress: ").Append(HostAddress).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Status != input.Status) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.MaintainStatus != input.MaintainStatus || (this.MaintainStatus != null && !this.MaintainStatus.Equals(input.MaintainStatus))) return false;
            if (this.ScalingAutoCreate != input.ScalingAutoCreate || (this.ScalingAutoCreate != null && !this.ScalingAutoCreate.Equals(input.ScalingAutoCreate))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobType != input.JobType) return false;
            if (this.JobStatus != input.JobStatus) return false;
            if (this.JobTime != input.JobTime || (this.JobTime != null && !this.JobTime.Equals(input.JobTime))) return false;
            if (this.ResourcePoolId != input.ResourcePoolId || (this.ResourcePoolId != null && !this.ResourcePoolId.Equals(input.ResourcePoolId))) return false;
            if (this.ResourcePoolType != input.ResourcePoolType || (this.ResourcePoolType != null && !this.ResourcePoolType.Equals(input.ResourcePoolType))) return false;
            if (this.HostId != input.HostId || (this.HostId != null && !this.HostId.Equals(input.HostId))) return false;
            if (this.ServerGroupName != input.ServerGroupName || (this.ServerGroupName != null && !this.ServerGroupName.Equals(input.ServerGroupName))) return false;
            if (this.ProductInfo != input.ProductInfo || (this.ProductInfo != null && !this.ProductInfo.Equals(input.ProductInfo))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.SessionCount != input.SessionCount || (this.SessionCount != null && !this.SessionCount.Equals(input.SessionCount))) return false;
            if (this.VmStatus != input.VmStatus) return false;
            if (this.TaskStatus != input.TaskStatus) return false;
            if (this.Freeze != input.Freeze || (this.Freeze != null && input.Freeze != null && !this.Freeze.SequenceEqual(input.Freeze))) return false;
            if (this.HostAddress != input.HostAddress || (this.HostAddress != null && input.HostAddress != null && !this.HostAddress.SequenceEqual(input.HostAddress))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Addresses != input.Addresses || (this.Addresses != null && input.Addresses != null && !this.Addresses.SequenceEqual(input.Addresses))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.MaintainStatus != null) hashCode = hashCode * 59 + this.MaintainStatus.GetHashCode();
                if (this.ScalingAutoCreate != null) hashCode = hashCode * 59 + this.ScalingAutoCreate.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.JobTime != null) hashCode = hashCode * 59 + this.JobTime.GetHashCode();
                if (this.ResourcePoolId != null) hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.ResourcePoolType != null) hashCode = hashCode * 59 + this.ResourcePoolType.GetHashCode();
                if (this.HostId != null) hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.ServerGroupName != null) hashCode = hashCode * 59 + this.ServerGroupName.GetHashCode();
                if (this.ProductInfo != null) hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.SessionCount != null) hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
                hashCode = hashCode * 59 + this.VmStatus.GetHashCode();
                hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.Freeze != null) hashCode = hashCode * 59 + this.Freeze.GetHashCode();
                if (this.HostAddress != null) hashCode = hashCode * 59 + this.HostAddress.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Addresses != null) hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
