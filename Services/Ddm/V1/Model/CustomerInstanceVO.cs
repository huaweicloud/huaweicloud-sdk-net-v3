using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerInstanceVO 
    {

        /// <summary>
        /// **参数解释**：  实例ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  实例状态。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  实例名称。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：  更新时间。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// **参数解释**：  描述。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：  可用区。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("available_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableZone { get; set; }

        /// <summary>
        /// **参数解释**：  虚拟私有云ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**：  子网ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// **参数解释**：  安全组ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// **参数解释**：  节点数量。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// **参数解释**：  访问IP。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("access_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessIp { get; set; }

        /// <summary>
        /// **参数解释**：  访问端口。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("access_port", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPort { get; set; }

        /// <summary>
        /// **参数解释**：  核数。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("core_count", NullValueHandling = NullValueHandling.Ignore)]
        public string CoreCount { get; set; }

        /// <summary>
        /// **参数解释**：  内存大小。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("ram_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string RamCapacity { get; set; }

        /// <summary>
        /// **参数解释**：  错误信息。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// **参数解释**：  节点状态。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("node_status", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeStatus { get; set; }

        /// <summary>
        /// **参数解释**：  维护时间。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("maintenance_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MaintenanceTime { get; set; }

        /// <summary>
        /// **参数解释**：  企业项目ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**：  项目ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：  引擎版本。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// **参数解释**：  订单ID。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// **参数解释**：  管理员账号。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("admin_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminUserName { get; set; }

        /// <summary>
        /// **参数解释**：  是否支持ssl。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// **参数解释**：  规格码。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// **参数解释**：  标签的集合。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tags> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerInstanceVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  availableZone: ").Append(AvailableZone).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  nodeCount: ").Append(NodeCount).Append("\n");
            sb.Append("  accessIp: ").Append(AccessIp).Append("\n");
            sb.Append("  accessPort: ").Append(AccessPort).Append("\n");
            sb.Append("  coreCount: ").Append(CoreCount).Append("\n");
            sb.Append("  ramCapacity: ").Append(RamCapacity).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  nodeStatus: ").Append(NodeStatus).Append("\n");
            sb.Append("  maintenanceTime: ").Append(MaintenanceTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  adminUserName: ").Append(AdminUserName).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerInstanceVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerInstanceVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AvailableZone != input.AvailableZone || (this.AvailableZone != null && !this.AvailableZone.Equals(input.AvailableZone))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecurityGroupId != input.SecurityGroupId || (this.SecurityGroupId != null && !this.SecurityGroupId.Equals(input.SecurityGroupId))) return false;
            if (this.NodeCount != input.NodeCount || (this.NodeCount != null && !this.NodeCount.Equals(input.NodeCount))) return false;
            if (this.AccessIp != input.AccessIp || (this.AccessIp != null && !this.AccessIp.Equals(input.AccessIp))) return false;
            if (this.AccessPort != input.AccessPort || (this.AccessPort != null && !this.AccessPort.Equals(input.AccessPort))) return false;
            if (this.CoreCount != input.CoreCount || (this.CoreCount != null && !this.CoreCount.Equals(input.CoreCount))) return false;
            if (this.RamCapacity != input.RamCapacity || (this.RamCapacity != null && !this.RamCapacity.Equals(input.RamCapacity))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.NodeStatus != input.NodeStatus || (this.NodeStatus != null && !this.NodeStatus.Equals(input.NodeStatus))) return false;
            if (this.MaintenanceTime != input.MaintenanceTime || (this.MaintenanceTime != null && !this.MaintenanceTime.Equals(input.MaintenanceTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.AdminUserName != input.AdminUserName || (this.AdminUserName != null && !this.AdminUserName.Equals(input.AdminUserName))) return false;
            if (this.EnableSsl != input.EnableSsl || (this.EnableSsl != null && !this.EnableSsl.Equals(input.EnableSsl))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AvailableZone != null) hashCode = hashCode * 59 + this.AvailableZone.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SecurityGroupId != null) hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.NodeCount != null) hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.AccessIp != null) hashCode = hashCode * 59 + this.AccessIp.GetHashCode();
                if (this.AccessPort != null) hashCode = hashCode * 59 + this.AccessPort.GetHashCode();
                if (this.CoreCount != null) hashCode = hashCode * 59 + this.CoreCount.GetHashCode();
                if (this.RamCapacity != null) hashCode = hashCode * 59 + this.RamCapacity.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.NodeStatus != null) hashCode = hashCode * 59 + this.NodeStatus.GetHashCode();
                if (this.MaintenanceTime != null) hashCode = hashCode * 59 + this.MaintenanceTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.AdminUserName != null) hashCode = hashCode * 59 + this.AdminUserName.GetHashCode();
                if (this.EnableSsl != null) hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
