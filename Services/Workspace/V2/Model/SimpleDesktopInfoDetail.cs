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
    public class SimpleDesktopInfoDetail 
    {

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面名。
        /// </summary>
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 系统计算机名。
        /// </summary>
        [JsonProperty("os_host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OsHostName { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 桌面ip地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 桌面已分配的用户信息列表。
        /// </summary>
        [JsonProperty("attach_user_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInstancesUserInfo> AttachUserInfos { get; set; }

        /// <summary>
        /// 权限组。
        /// </summary>
        [JsonProperty("user_group", NullValueHandling = NullValueHandling.Ignore)]
        public string UserGroup { get; set; }

        /// <summary>
        /// 桌面的SID信息。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// ou名称。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 是否处于管理员维护模式
        /// </summary>
        [JsonProperty("in_maintenance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InMaintenanceMode { get; set; }

        /// <summary>
        /// 桌面协同资源SKU码
        /// </summary>
        [JsonProperty("share_resource_sku", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareResourceSku { get; set; }

        /// <summary>
        /// 桌面类型
        /// </summary>
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopType { get; set; }

        /// <summary>
        /// 桌面的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 桌面计费资源ID。
        /// </summary>
        [JsonProperty("bill_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BillResourceId { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 桌面的任务状态。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 系統状态
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// 连接状态
        /// </summary>
        [JsonProperty("connect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectStatus { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// AccessAgent版本号
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 租户名称
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// 资源池ID
        /// </summary>
        [JsonProperty("resource_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourcePoolId { get; set; }

        /// <summary>
        /// 操作系统类型：Linux、Windows或Others。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 智能休眠策略数。
        /// </summary>
        [JsonProperty("hibernate_policy_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? HibernatePolicyNum { get; set; }

        /// <summary>
        /// 是否处于智能休眠中
        /// </summary>
        [JsonProperty("is_auto_hibernate", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoHibernate { get; set; }

        /// <summary>
        /// 所属的可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 专享主机ID。
        /// </summary>
        [JsonProperty("exclusive_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExclusiveHostId { get; set; }

        /// <summary>
        /// 云办公主机ID。
        /// </summary>
        [JsonProperty("deh_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DehId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleDesktopInfoDetail {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  osHostName: ").Append(OsHostName).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  attachUserInfos: ").Append(AttachUserInfos).Append("\n");
            sb.Append("  userGroup: ").Append(UserGroup).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  inMaintenanceMode: ").Append(InMaintenanceMode).Append("\n");
            sb.Append("  shareResourceSku: ").Append(ShareResourceSku).Append("\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  billResourceId: ").Append(BillResourceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  connectStatus: ").Append(ConnectStatus).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  resourcePoolId: ").Append(ResourcePoolId).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  hibernatePolicyNum: ").Append(HibernatePolicyNum).Append("\n");
            sb.Append("  isAutoHibernate: ").Append(IsAutoHibernate).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  exclusiveHostId: ").Append(ExclusiveHostId).Append("\n");
            sb.Append("  dehId: ").Append(DehId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleDesktopInfoDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleDesktopInfoDetail input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.OsHostName != input.OsHostName || (this.OsHostName != null && !this.OsHostName.Equals(input.OsHostName))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.AttachUserInfos != input.AttachUserInfos || (this.AttachUserInfos != null && input.AttachUserInfos != null && !this.AttachUserInfos.SequenceEqual(input.AttachUserInfos))) return false;
            if (this.UserGroup != input.UserGroup || (this.UserGroup != null && !this.UserGroup.Equals(input.UserGroup))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.InMaintenanceMode != input.InMaintenanceMode || (this.InMaintenanceMode != null && !this.InMaintenanceMode.Equals(input.InMaintenanceMode))) return false;
            if (this.ShareResourceSku != input.ShareResourceSku || (this.ShareResourceSku != null && !this.ShareResourceSku.Equals(input.ShareResourceSku))) return false;
            if (this.DesktopType != input.DesktopType || (this.DesktopType != null && !this.DesktopType.Equals(input.DesktopType))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.BillResourceId != input.BillResourceId || (this.BillResourceId != null && !this.BillResourceId.Equals(input.BillResourceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.ConnectStatus != input.ConnectStatus || (this.ConnectStatus != null && !this.ConnectStatus.Equals(input.ConnectStatus))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.ResourcePoolId != input.ResourcePoolId || (this.ResourcePoolId != null && !this.ResourcePoolId.Equals(input.ResourcePoolId))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.HibernatePolicyNum != input.HibernatePolicyNum || (this.HibernatePolicyNum != null && !this.HibernatePolicyNum.Equals(input.HibernatePolicyNum))) return false;
            if (this.IsAutoHibernate != input.IsAutoHibernate || (this.IsAutoHibernate != null && !this.IsAutoHibernate.Equals(input.IsAutoHibernate))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ExclusiveHostId != input.ExclusiveHostId || (this.ExclusiveHostId != null && !this.ExclusiveHostId.Equals(input.ExclusiveHostId))) return false;
            if (this.DehId != input.DehId || (this.DehId != null && !this.DehId.Equals(input.DehId))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.OsHostName != null) hashCode = hashCode * 59 + this.OsHostName.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AttachUserInfos != null) hashCode = hashCode * 59 + this.AttachUserInfos.GetHashCode();
                if (this.UserGroup != null) hashCode = hashCode * 59 + this.UserGroup.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.InMaintenanceMode != null) hashCode = hashCode * 59 + this.InMaintenanceMode.GetHashCode();
                if (this.ShareResourceSku != null) hashCode = hashCode * 59 + this.ShareResourceSku.GetHashCode();
                if (this.DesktopType != null) hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.BillResourceId != null) hashCode = hashCode * 59 + this.BillResourceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.ConnectStatus != null) hashCode = hashCode * 59 + this.ConnectStatus.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.ResourcePoolId != null) hashCode = hashCode * 59 + this.ResourcePoolId.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.HibernatePolicyNum != null) hashCode = hashCode * 59 + this.HibernatePolicyNum.GetHashCode();
                if (this.IsAutoHibernate != null) hashCode = hashCode * 59 + this.IsAutoHibernate.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ExclusiveHostId != null) hashCode = hashCode * 59 + this.ExclusiveHostId.GetHashCode();
                if (this.DehId != null) hashCode = hashCode * 59 + this.DehId.GetHashCode();
                return hashCode;
            }
        }
    }
}
