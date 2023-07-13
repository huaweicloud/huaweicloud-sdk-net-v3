using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class NeutronListFloatingIpsRequest 
    {

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 取值为上一页数据的最后一条记录的id，当marker参数为无效id时，response将响应错误码400
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// False/True，是否设置分页的顺序。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 浮动IP的id。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 浮动IP地址。
        /// </summary>
        [SDKProperty("floating_ip_address", IsQuery = true)]
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// 所属路由器id。
        /// </summary>
        [SDKProperty("router_id", IsQuery = true)]
        [JsonProperty("router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterId { get; set; }

        /// <summary>
        /// 端口id。
        /// </summary>
        [SDKProperty("port_id", IsQuery = true)]
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 关联端口的私有IP地址。
        /// </summary>
        [SDKProperty("fixed_ip_address", IsQuery = true)]
        [JsonProperty("fixed_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedIpAddress { get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [SDKProperty("tenant_id", IsQuery = true)]
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 外部网络的id。只能使用固定的外网，外部网络的信息请通过GET /v2.0/networks?router:external&#x3D;True或GET /v2.0/networks?name&#x3D;{floating_network}或neutron net-external-list方式查询
        /// </summary>
        [SDKProperty("floating_network_id", IsQuery = true)]
        [JsonProperty("floating_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingNetworkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListFloatingIpsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  routerId: ").Append(RouterId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  fixedIpAddress: ").Append(FixedIpAddress).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  floatingNetworkId: ").Append(FloatingNetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListFloatingIpsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListFloatingIpsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FloatingIpAddress == input.FloatingIpAddress ||
                    (this.FloatingIpAddress != null &&
                    this.FloatingIpAddress.Equals(input.FloatingIpAddress))
                ) && 
                (
                    this.RouterId == input.RouterId ||
                    (this.RouterId != null &&
                    this.RouterId.Equals(input.RouterId))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.FixedIpAddress == input.FixedIpAddress ||
                    (this.FixedIpAddress != null &&
                    this.FixedIpAddress.Equals(input.FixedIpAddress))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.FloatingNetworkId == input.FloatingNetworkId ||
                    (this.FloatingNetworkId != null &&
                    this.FloatingNetworkId.Equals(input.FloatingNetworkId))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FloatingIpAddress != null)
                    hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.RouterId != null)
                    hashCode = hashCode * 59 + this.RouterId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.FixedIpAddress != null)
                    hashCode = hashCode * 59 + this.FixedIpAddress.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.FloatingNetworkId != null)
                    hashCode = hashCode * 59 + this.FloatingNetworkId.GetHashCode();
                return hashCode;
            }
        }
    }
}
