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
    /// 创建中心网络GDGW附件的请求体。
    /// </summary>
    public class CreateCentralNetworkGdgwAttachment 
    {

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
        /// 企业路由器的ID。
        /// </summary>
        [JsonProperty("enterprise_router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseRouterId { get; set; }

        /// <summary>
        /// Gdgw的ID。
        /// </summary>
        [JsonProperty("global_dc_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalDcGatewayId { get; set; }

        /// <summary>
        /// Gdgw的项目ID。
        /// </summary>
        [JsonProperty("global_dc_gateway_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalDcGatewayProjectId { get; set; }

        /// <summary>
        /// Gdgw的RegionID。
        /// </summary>
        [JsonProperty("global_dc_gateway_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalDcGatewayRegionId { get; set; }

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
        /// 中心网络平面ID。
        /// </summary>
        [JsonProperty("central_network_plane_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CentralNetworkPlaneId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCentralNetworkGdgwAttachment {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseRouterId: ").Append(EnterpriseRouterId).Append("\n");
            sb.Append("  globalDcGatewayId: ").Append(GlobalDcGatewayId).Append("\n");
            sb.Append("  globalDcGatewayProjectId: ").Append(GlobalDcGatewayProjectId).Append("\n");
            sb.Append("  globalDcGatewayRegionId: ").Append(GlobalDcGatewayRegionId).Append("\n");
            sb.Append("  enterpriseRouterProjectId: ").Append(EnterpriseRouterProjectId).Append("\n");
            sb.Append("  enterpriseRouterRegionId: ").Append(EnterpriseRouterRegionId).Append("\n");
            sb.Append("  centralNetworkPlaneId: ").Append(CentralNetworkPlaneId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCentralNetworkGdgwAttachment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCentralNetworkGdgwAttachment input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.EnterpriseRouterId != input.EnterpriseRouterId || (this.EnterpriseRouterId != null && !this.EnterpriseRouterId.Equals(input.EnterpriseRouterId))) return false;
            if (this.GlobalDcGatewayId != input.GlobalDcGatewayId || (this.GlobalDcGatewayId != null && !this.GlobalDcGatewayId.Equals(input.GlobalDcGatewayId))) return false;
            if (this.GlobalDcGatewayProjectId != input.GlobalDcGatewayProjectId || (this.GlobalDcGatewayProjectId != null && !this.GlobalDcGatewayProjectId.Equals(input.GlobalDcGatewayProjectId))) return false;
            if (this.GlobalDcGatewayRegionId != input.GlobalDcGatewayRegionId || (this.GlobalDcGatewayRegionId != null && !this.GlobalDcGatewayRegionId.Equals(input.GlobalDcGatewayRegionId))) return false;
            if (this.EnterpriseRouterProjectId != input.EnterpriseRouterProjectId || (this.EnterpriseRouterProjectId != null && !this.EnterpriseRouterProjectId.Equals(input.EnterpriseRouterProjectId))) return false;
            if (this.EnterpriseRouterRegionId != input.EnterpriseRouterRegionId || (this.EnterpriseRouterRegionId != null && !this.EnterpriseRouterRegionId.Equals(input.EnterpriseRouterRegionId))) return false;
            if (this.CentralNetworkPlaneId != input.CentralNetworkPlaneId || (this.CentralNetworkPlaneId != null && !this.CentralNetworkPlaneId.Equals(input.CentralNetworkPlaneId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseRouterId != null) hashCode = hashCode * 59 + this.EnterpriseRouterId.GetHashCode();
                if (this.GlobalDcGatewayId != null) hashCode = hashCode * 59 + this.GlobalDcGatewayId.GetHashCode();
                if (this.GlobalDcGatewayProjectId != null) hashCode = hashCode * 59 + this.GlobalDcGatewayProjectId.GetHashCode();
                if (this.GlobalDcGatewayRegionId != null) hashCode = hashCode * 59 + this.GlobalDcGatewayRegionId.GetHashCode();
                if (this.EnterpriseRouterProjectId != null) hashCode = hashCode * 59 + this.EnterpriseRouterProjectId.GetHashCode();
                if (this.EnterpriseRouterRegionId != null) hashCode = hashCode * 59 + this.EnterpriseRouterRegionId.GetHashCode();
                if (this.CentralNetworkPlaneId != null) hashCode = hashCode * 59 + this.CentralNetworkPlaneId.GetHashCode();
                return hashCode;
            }
        }
    }
}
