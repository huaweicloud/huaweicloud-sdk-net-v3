using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPrivateSnatsRequest 
    {

        /// <summary>
        /// 功能说明：每页返回的个数。 取值范围：1~2000。 默认值：2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 功能说明：分页查询起始的资源ID，为空时查询第一页。 值从上一次查询的PageInfo中的next_marker或者previous_marker中获取。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 是否查询前一页。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// SNAT规则的ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// SNAT规则的描述。长度范围小于等于255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 私网NAT网关实例的ID。
        /// </summary>
        [SDKProperty("gateway_id", IsQuery = true)]
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GatewayId { get; set; }

        /// <summary>
        /// 规则匹配的CIDR。
        /// </summary>
        [SDKProperty("cidr", IsQuery = true)]
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Cidr { get; set; }

        /// <summary>
        /// 规则匹配的子网的ID。
        /// </summary>
        [SDKProperty("virsubnet_id", IsQuery = true)]
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VirsubnetId { get; set; }

        /// <summary>
        /// 中转IP的ID。
        /// </summary>
        [SDKProperty("transit_ip_id", IsQuery = true)]
        [JsonProperty("transit_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitIpId { get; set; }

        /// <summary>
        /// 中转IP地址。
        /// </summary>
        [SDKProperty("transit_ip_address", IsQuery = true)]
        [JsonProperty("transit_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitIpAddress { get; set; }

        /// <summary>
        /// 企业项目ID。创建SNAT规则时，关联的企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateSnatsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  gatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  transitIpId: ").Append(TransitIpId).Append("\n");
            sb.Append("  transitIpAddress: ").Append(TransitIpAddress).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateSnatsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateSnatsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.GatewayId != input.GatewayId || (this.GatewayId != null && input.GatewayId != null && !this.GatewayId.SequenceEqual(input.GatewayId))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && input.Cidr != null && !this.Cidr.SequenceEqual(input.Cidr))) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && input.VirsubnetId != null && !this.VirsubnetId.SequenceEqual(input.VirsubnetId))) return false;
            if (this.TransitIpId != input.TransitIpId || (this.TransitIpId != null && input.TransitIpId != null && !this.TransitIpId.SequenceEqual(input.TransitIpId))) return false;
            if (this.TransitIpAddress != input.TransitIpAddress || (this.TransitIpAddress != null && input.TransitIpAddress != null && !this.TransitIpAddress.SequenceEqual(input.TransitIpAddress))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GatewayId != null) hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.TransitIpId != null) hashCode = hashCode * 59 + this.TransitIpId.GetHashCode();
                if (this.TransitIpAddress != null) hashCode = hashCode * 59 + this.TransitIpAddress.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
