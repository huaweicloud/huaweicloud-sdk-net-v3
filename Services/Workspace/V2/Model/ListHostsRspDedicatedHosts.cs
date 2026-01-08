using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListHostsRspDedicatedHosts 
    {

        /// <summary>
        /// 云办公主机ID。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// 云办公主机的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 在创建云服务器时（未指定专属主机ID），是否允许云服务器自动分配在一台可用的云办公主机上。取值范围：“on”或“off”。
        /// </summary>
        [JsonProperty("auto_placement", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoPlacement { get; set; }

        /// <summary>
        /// 云办公主机的区域。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("host_properties", NullValueHandling = NullValueHandling.Ignore)]
        public ListHostsRspHostProperties HostProperties { get; set; }

        /// <summary>
        /// 云办公主机的产品id。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 云办公主机的订单id。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 云服务资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云办公主机状态，该参数取值可以为：“available”、“fault”或“released”。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 云办公主机可用的vCPU核数。
        /// </summary>
        [JsonProperty("available_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailableVcpus { get; set; }

        /// <summary>
        /// 云办公主机可用的内存大小。
        /// </summary>
        [JsonProperty("available_memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? AvailableMemory { get; set; }

        /// <summary>
        /// 云办公主机上的实例总数。
        /// </summary>
        [JsonProperty("instance_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceTotal { get; set; }

        /// <summary>
        /// 云办公主机的分配时间。
        /// </summary>
        [JsonProperty("allocated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string AllocatedAt { get; set; }

        /// <summary>
        /// 云办公主机的释放时间。
        /// </summary>
        [JsonProperty("released_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleasedAt { get; set; }

        /// <summary>
        /// 专属主机上的实例UUID。
        /// </summary>
        [JsonProperty("instance_uuids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceUuids { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHostsRspDedicatedHosts {\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  autoPlacement: ").Append(AutoPlacement).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  hostProperties: ").Append(HostProperties).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  availableVcpus: ").Append(AvailableVcpus).Append("\n");
            sb.Append("  availableMemory: ").Append(AvailableMemory).Append("\n");
            sb.Append("  instanceTotal: ").Append(InstanceTotal).Append("\n");
            sb.Append("  allocatedAt: ").Append(AllocatedAt).Append("\n");
            sb.Append("  releasedAt: ").Append(ReleasedAt).Append("\n");
            sb.Append("  instanceUuids: ").Append(InstanceUuids).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHostsRspDedicatedHosts);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHostsRspDedicatedHosts input)
        {
            if (input == null) return false;
            if (this.DedicatedHostId != input.DedicatedHostId || (this.DedicatedHostId != null && !this.DedicatedHostId.Equals(input.DedicatedHostId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AutoPlacement != input.AutoPlacement || (this.AutoPlacement != null && !this.AutoPlacement.Equals(input.AutoPlacement))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.HostProperties != input.HostProperties || (this.HostProperties != null && !this.HostProperties.Equals(input.HostProperties))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.AvailableVcpus != input.AvailableVcpus || (this.AvailableVcpus != null && !this.AvailableVcpus.Equals(input.AvailableVcpus))) return false;
            if (this.AvailableMemory != input.AvailableMemory || (this.AvailableMemory != null && !this.AvailableMemory.Equals(input.AvailableMemory))) return false;
            if (this.InstanceTotal != input.InstanceTotal || (this.InstanceTotal != null && !this.InstanceTotal.Equals(input.InstanceTotal))) return false;
            if (this.AllocatedAt != input.AllocatedAt || (this.AllocatedAt != null && !this.AllocatedAt.Equals(input.AllocatedAt))) return false;
            if (this.ReleasedAt != input.ReleasedAt || (this.ReleasedAt != null && !this.ReleasedAt.Equals(input.ReleasedAt))) return false;
            if (this.InstanceUuids != input.InstanceUuids || (this.InstanceUuids != null && input.InstanceUuids != null && !this.InstanceUuids.SequenceEqual(input.InstanceUuids))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.DedicatedHostId != null) hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AutoPlacement != null) hashCode = hashCode * 59 + this.AutoPlacement.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.HostProperties != null) hashCode = hashCode * 59 + this.HostProperties.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.AvailableVcpus != null) hashCode = hashCode * 59 + this.AvailableVcpus.GetHashCode();
                if (this.AvailableMemory != null) hashCode = hashCode * 59 + this.AvailableMemory.GetHashCode();
                if (this.InstanceTotal != null) hashCode = hashCode * 59 + this.InstanceTotal.GetHashCode();
                if (this.AllocatedAt != null) hashCode = hashCode * 59 + this.AllocatedAt.GetHashCode();
                if (this.ReleasedAt != null) hashCode = hashCode * 59 + this.ReleasedAt.GetHashCode();
                if (this.InstanceUuids != null) hashCode = hashCode * 59 + this.InstanceUuids.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
