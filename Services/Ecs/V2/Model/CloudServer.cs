using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CloudServer 
    {

        /// <summary>
        /// 云服务器唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云服务器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 云服务器当前状态信息。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 云服务器所属租户ID。即项目id，与project_id表示相同的概念。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 云服务器所属用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("market_info", NullValueHandling = NullValueHandling.Ignore)]
        public MarketModel MarketInfo { get; set; }

        /// <summary>
        /// 可用分区
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 云服务器的状态。
        /// </summary>
        [JsonProperty("vm_state", NullValueHandling = NullValueHandling.Ignore)]
        public string VmState { get; set; }

        /// <summary>
        /// 云服务器任务状态。
        /// </summary>
        [JsonProperty("task_state", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskState { get; set; }

        /// <summary>
        /// 云服务器电源状态。
        /// </summary>
        [JsonProperty("power_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? PowerState { get; set; }

        /// <summary>
        /// 云服务器创建时间。 时间格式例如：2020-05-22T07:48:53Z。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 云服务器是否处于回收站中
        /// </summary>
        [JsonProperty("in_recycle_bin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InRecycleBin { get; set; }

        /// <summary>
        /// 共池裸机按整机柜发放的同一批次的批创ID
        /// </summary>
        [JsonProperty("spod_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpodId { get; set; }

        /// <summary>
        /// 云服务器上一次更新时间。时间格式例如：2020-05-22T07:48:53Z
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 云服务器启动时间。时间格式例如：2020-05-22T07:48:53Z。
        /// </summary>
        [JsonProperty("launched", NullValueHandling = NullValueHandling.Ignore)]
        public string Launched { get; set; }

        /// <summary>
        /// 云服务器的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 云服务器使用的密钥对名称。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 云服务器是否为锁定状态。  true：锁定 false：未锁定
        /// </summary>
        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; }

        /// <summary>
        /// 云服务器系统盘的设备名称，例如当系统盘的磁盘模式是VDB时，为/dev/vda。
        /// </summary>
        [JsonProperty("root_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RootDeviceName { get; set; }

        /// <summary>
        /// 在专属主机或共享池中创建云服务器。默认为在共享池创建。值为： shared或dedicated。  shared：表示共享池。 dedicated:表示专属主机。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenancy { get; set; }

        /// <summary>
        /// 专属主机ID。此属性仅在tenancy值为dedicated时有效，不指定此属性，系统将自动分配租户可自动放置云服务器的专属主机。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// 查询绑定某个企业项目的云服务器。 若需要查询当前用户所有企业项目绑定的云服务，请传参all_granted_eps。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 云服务器元数据。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 云服务器的标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 云服务器对应的网络地址信息。
        /// </summary>
        [JsonProperty("addresses", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<NetworkAddresses>> Addresses { get; set; }

        /// <summary>
        /// 云服务器的安全组信息。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 云服务器挂载磁盘信息。
        /// </summary>
        [JsonProperty("volumes_attached", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeAttach> VolumesAttached { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public Image Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorQuasar Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fault", NullValueHandling = NullValueHandling.Ignore)]
        public Fault Fault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu_options", NullValueHandling = NullValueHandling.Ignore)]
        public CpuOptions CpuOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudServer {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  marketInfo: ").Append(MarketInfo).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  vmState: ").Append(VmState).Append("\n");
            sb.Append("  taskState: ").Append(TaskState).Append("\n");
            sb.Append("  powerState: ").Append(PowerState).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  inRecycleBin: ").Append(InRecycleBin).Append("\n");
            sb.Append("  spodId: ").Append(SpodId).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  launched: ").Append(Launched).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  locked: ").Append(Locked).Append("\n");
            sb.Append("  rootDeviceName: ").Append(RootDeviceName).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  addresses: ").Append(Addresses).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  volumesAttached: ").Append(VolumesAttached).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  fault: ").Append(Fault).Append("\n");
            sb.Append("  cpuOptions: ").Append(CpuOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudServer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudServer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.MarketInfo == input.MarketInfo ||
                    (this.MarketInfo != null &&
                    this.MarketInfo.Equals(input.MarketInfo))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.VmState == input.VmState ||
                    (this.VmState != null &&
                    this.VmState.Equals(input.VmState))
                ) && 
                (
                    this.TaskState == input.TaskState ||
                    (this.TaskState != null &&
                    this.TaskState.Equals(input.TaskState))
                ) && 
                (
                    this.PowerState == input.PowerState ||
                    (this.PowerState != null &&
                    this.PowerState.Equals(input.PowerState))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.InRecycleBin == input.InRecycleBin ||
                    (this.InRecycleBin != null &&
                    this.InRecycleBin.Equals(input.InRecycleBin))
                ) && 
                (
                    this.SpodId == input.SpodId ||
                    (this.SpodId != null &&
                    this.SpodId.Equals(input.SpodId))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.Launched == input.Launched ||
                    (this.Launched != null &&
                    this.Launched.Equals(input.Launched))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.Locked == input.Locked ||
                    (this.Locked != null &&
                    this.Locked.Equals(input.Locked))
                ) && 
                (
                    this.RootDeviceName == input.RootDeviceName ||
                    (this.RootDeviceName != null &&
                    this.RootDeviceName.Equals(input.RootDeviceName))
                ) && 
                (
                    this.Tenancy == input.Tenancy ||
                    (this.Tenancy != null &&
                    this.Tenancy.Equals(input.Tenancy))
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.VolumesAttached == input.VolumesAttached ||
                    this.VolumesAttached != null &&
                    input.VolumesAttached != null &&
                    this.VolumesAttached.SequenceEqual(input.VolumesAttached)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Flavor == input.Flavor ||
                    (this.Flavor != null &&
                    this.Flavor.Equals(input.Flavor))
                ) && 
                (
                    this.Fault == input.Fault ||
                    (this.Fault != null &&
                    this.Fault.Equals(input.Fault))
                ) && 
                (
                    this.CpuOptions == input.CpuOptions ||
                    (this.CpuOptions != null &&
                    this.CpuOptions.Equals(input.CpuOptions))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.MarketInfo != null)
                    hashCode = hashCode * 59 + this.MarketInfo.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.VmState != null)
                    hashCode = hashCode * 59 + this.VmState.GetHashCode();
                if (this.TaskState != null)
                    hashCode = hashCode * 59 + this.TaskState.GetHashCode();
                if (this.PowerState != null)
                    hashCode = hashCode * 59 + this.PowerState.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.InRecycleBin != null)
                    hashCode = hashCode * 59 + this.InRecycleBin.GetHashCode();
                if (this.SpodId != null)
                    hashCode = hashCode * 59 + this.SpodId.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Launched != null)
                    hashCode = hashCode * 59 + this.Launched.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.Locked != null)
                    hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.RootDeviceName != null)
                    hashCode = hashCode * 59 + this.RootDeviceName.GetHashCode();
                if (this.Tenancy != null)
                    hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.VolumesAttached != null)
                    hashCode = hashCode * 59 + this.VolumesAttached.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Flavor != null)
                    hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Fault != null)
                    hashCode = hashCode * 59 + this.Fault.GetHashCode();
                if (this.CpuOptions != null)
                    hashCode = hashCode * 59 + this.CpuOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
