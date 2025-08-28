using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 企业路由器的路由表附件详情。
    /// </summary>
    public class CentralNetworkErRouteTableAttachment 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public CentralNetworkConnectionStateEnum State { get; set; }
        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 中心网络ID。
        /// </summary>
        [JsonProperty("central_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkId { get; set; }

        /// <summary>
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("central_network_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkPlaneId { get; set; }

        /// <summary>
        /// 全域互联带宽ID。
        /// </summary>
        [JsonProperty("global_connection_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalConnectionBandwidthId { get; set; }

        /// <summary>
        /// 是否冻结。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthTypeEnum BandwidthType { get; set; }
        /// <summary>
        /// 带宽值，单位Mbps。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? BandwidthSize { get; set; }

        /// <summary>
        /// 企业路由器的ID。
        /// </summary>
        [JsonProperty("enterprise_router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterId { get; set; }

        /// <summary>
        /// 企业路由器的项目ID。
        /// </summary>
        [JsonProperty("enterprise_router_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterProjectId { get; set; }

        /// <summary>
        /// ER路由器的regionID。
        /// </summary>
        [JsonProperty("enterprise_router_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterRegionId { get; set; }

        /// <summary>
        /// 企业路由器的连接ID。
        /// </summary>
        [JsonProperty("enterprise_router_attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterAttachmentId { get; set; }

        /// <summary>
        /// 企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("enterprise_router_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterTableId { get; set; }

        /// <summary>
        /// 中心网络企业路由器的站点编码。
        /// </summary>
        [JsonProperty("enterprise_router_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterSiteCode { get; set; }

        /// <summary>
        /// 被挂载的企业路由器的项目ID。
        /// </summary>
        [JsonProperty("attached_er_table_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableProjectId { get; set; }

        /// <summary>
        /// ER路由器的regionID。
        /// </summary>
        [JsonProperty("attached_er_table_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableRegionId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器ID。
        /// </summary>
        [JsonProperty("attached_er_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("attached_er_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器的连接ID。
        /// </summary>
        [JsonProperty("attached_er_attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErAttachmentId { get; set; }

        /// <summary>
        /// 被挂载的企业路由器的站点编码。
        /// </summary>
        [JsonProperty("attached_er_table_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableSiteCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hosted_cloud", NullValueHandling = NullValueHandling.Ignore)]
        public HostedCloudEnum HostedCloud { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("approved_state", NullValueHandling = NullValueHandling.Ignore)]
        public ApprovedStateEnum ApprovedState { get; set; }
        /// <summary>
        /// 审批拒绝创建企业路由表附件的原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkErRouteTableAttachment {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  centralNetworkId: ").Append(CentralNetworkId).Append("\n");
            sb.Append("  centralNetworkPlaneId: ").Append(CentralNetworkPlaneId).Append("\n");
            sb.Append("  globalConnectionBandwidthId: ").Append(GlobalConnectionBandwidthId).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  enterpriseRouterId: ").Append(EnterpriseRouterId).Append("\n");
            sb.Append("  enterpriseRouterProjectId: ").Append(EnterpriseRouterProjectId).Append("\n");
            sb.Append("  enterpriseRouterRegionId: ").Append(EnterpriseRouterRegionId).Append("\n");
            sb.Append("  enterpriseRouterAttachmentId: ").Append(EnterpriseRouterAttachmentId).Append("\n");
            sb.Append("  enterpriseRouterTableId: ").Append(EnterpriseRouterTableId).Append("\n");
            sb.Append("  enterpriseRouterSiteCode: ").Append(EnterpriseRouterSiteCode).Append("\n");
            sb.Append("  attachedErTableProjectId: ").Append(AttachedErTableProjectId).Append("\n");
            sb.Append("  attachedErTableRegionId: ").Append(AttachedErTableRegionId).Append("\n");
            sb.Append("  attachedErId: ").Append(AttachedErId).Append("\n");
            sb.Append("  attachedErTableId: ").Append(AttachedErTableId).Append("\n");
            sb.Append("  attachedErAttachmentId: ").Append(AttachedErAttachmentId).Append("\n");
            sb.Append("  attachedErTableSiteCode: ").Append(AttachedErTableSiteCode).Append("\n");
            sb.Append("  hostedCloud: ").Append(HostedCloud).Append("\n");
            sb.Append("  approvedState: ").Append(ApprovedState).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkErRouteTableAttachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkErRouteTableAttachment input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.State != input.State) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.CentralNetworkId != input.CentralNetworkId || (this.CentralNetworkId != null && !this.CentralNetworkId.Equals(input.CentralNetworkId))) return false;
            if (this.CentralNetworkPlaneId != input.CentralNetworkPlaneId || (this.CentralNetworkPlaneId != null && !this.CentralNetworkPlaneId.Equals(input.CentralNetworkPlaneId))) return false;
            if (this.GlobalConnectionBandwidthId != input.GlobalConnectionBandwidthId || (this.GlobalConnectionBandwidthId != null && !this.GlobalConnectionBandwidthId.Equals(input.GlobalConnectionBandwidthId))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.BandwidthType != input.BandwidthType) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.EnterpriseRouterId != input.EnterpriseRouterId || (this.EnterpriseRouterId != null && !this.EnterpriseRouterId.Equals(input.EnterpriseRouterId))) return false;
            if (this.EnterpriseRouterProjectId != input.EnterpriseRouterProjectId || (this.EnterpriseRouterProjectId != null && !this.EnterpriseRouterProjectId.Equals(input.EnterpriseRouterProjectId))) return false;
            if (this.EnterpriseRouterRegionId != input.EnterpriseRouterRegionId || (this.EnterpriseRouterRegionId != null && !this.EnterpriseRouterRegionId.Equals(input.EnterpriseRouterRegionId))) return false;
            if (this.EnterpriseRouterAttachmentId != input.EnterpriseRouterAttachmentId || (this.EnterpriseRouterAttachmentId != null && !this.EnterpriseRouterAttachmentId.Equals(input.EnterpriseRouterAttachmentId))) return false;
            if (this.EnterpriseRouterTableId != input.EnterpriseRouterTableId || (this.EnterpriseRouterTableId != null && !this.EnterpriseRouterTableId.Equals(input.EnterpriseRouterTableId))) return false;
            if (this.EnterpriseRouterSiteCode != input.EnterpriseRouterSiteCode || (this.EnterpriseRouterSiteCode != null && !this.EnterpriseRouterSiteCode.Equals(input.EnterpriseRouterSiteCode))) return false;
            if (this.AttachedErTableProjectId != input.AttachedErTableProjectId || (this.AttachedErTableProjectId != null && !this.AttachedErTableProjectId.Equals(input.AttachedErTableProjectId))) return false;
            if (this.AttachedErTableRegionId != input.AttachedErTableRegionId || (this.AttachedErTableRegionId != null && !this.AttachedErTableRegionId.Equals(input.AttachedErTableRegionId))) return false;
            if (this.AttachedErId != input.AttachedErId || (this.AttachedErId != null && !this.AttachedErId.Equals(input.AttachedErId))) return false;
            if (this.AttachedErTableId != input.AttachedErTableId || (this.AttachedErTableId != null && !this.AttachedErTableId.Equals(input.AttachedErTableId))) return false;
            if (this.AttachedErAttachmentId != input.AttachedErAttachmentId || (this.AttachedErAttachmentId != null && !this.AttachedErAttachmentId.Equals(input.AttachedErAttachmentId))) return false;
            if (this.AttachedErTableSiteCode != input.AttachedErTableSiteCode || (this.AttachedErTableSiteCode != null && !this.AttachedErTableSiteCode.Equals(input.AttachedErTableSiteCode))) return false;
            if (this.HostedCloud != input.HostedCloud) return false;
            if (this.ApprovedState != input.ApprovedState) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.CentralNetworkId != null) hashCode = hashCode * 59 + this.CentralNetworkId.GetHashCode();
                if (this.CentralNetworkPlaneId != null) hashCode = hashCode * 59 + this.CentralNetworkPlaneId.GetHashCode();
                if (this.GlobalConnectionBandwidthId != null) hashCode = hashCode * 59 + this.GlobalConnectionBandwidthId.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.EnterpriseRouterId != null) hashCode = hashCode * 59 + this.EnterpriseRouterId.GetHashCode();
                if (this.EnterpriseRouterProjectId != null) hashCode = hashCode * 59 + this.EnterpriseRouterProjectId.GetHashCode();
                if (this.EnterpriseRouterRegionId != null) hashCode = hashCode * 59 + this.EnterpriseRouterRegionId.GetHashCode();
                if (this.EnterpriseRouterAttachmentId != null) hashCode = hashCode * 59 + this.EnterpriseRouterAttachmentId.GetHashCode();
                if (this.EnterpriseRouterTableId != null) hashCode = hashCode * 59 + this.EnterpriseRouterTableId.GetHashCode();
                if (this.EnterpriseRouterSiteCode != null) hashCode = hashCode * 59 + this.EnterpriseRouterSiteCode.GetHashCode();
                if (this.AttachedErTableProjectId != null) hashCode = hashCode * 59 + this.AttachedErTableProjectId.GetHashCode();
                if (this.AttachedErTableRegionId != null) hashCode = hashCode * 59 + this.AttachedErTableRegionId.GetHashCode();
                if (this.AttachedErId != null) hashCode = hashCode * 59 + this.AttachedErId.GetHashCode();
                if (this.AttachedErTableId != null) hashCode = hashCode * 59 + this.AttachedErTableId.GetHashCode();
                if (this.AttachedErAttachmentId != null) hashCode = hashCode * 59 + this.AttachedErAttachmentId.GetHashCode();
                if (this.AttachedErTableSiteCode != null) hashCode = hashCode * 59 + this.AttachedErTableSiteCode.GetHashCode();
                hashCode = hashCode * 59 + this.HostedCloud.GetHashCode();
                hashCode = hashCode * 59 + this.ApprovedState.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }
    }
}
