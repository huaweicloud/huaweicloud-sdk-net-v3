using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMembersRequest 
    {

        /// <summary>
        /// 后端云服务器组id
        /// </summary>
        [SDKProperty("pool_id", IsPath = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 分页查询中每页的后端服务器个数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页查询的起始的资源id，表示上一页最后一条查询记录的后端服务器的id。不指定时表示查询第一页。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 分页的顺序，true表示从后往前分页，false表示从前往后分页，默认为false。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 后端云服务器的ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 后端云服务器的名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 后端云服务器对应的IP地址。
        /// </summary>
        [SDKProperty("address", IsQuery = true)]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 后端云服务器后端端口的协议号。
        /// </summary>
        [SDKProperty("protocol_port", IsQuery = true)]
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// 后端云服务器所在的子网ID。
        /// </summary>
        [SDKProperty("subnet_id", IsQuery = true)]
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 后端云服务器的管理状态。取值范围：true/false。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端云服务器的权重。
        /// </summary>
        [SDKProperty("weight", IsQuery = true)]
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 企业项目ID。 不传时查询default企业项目（即enterprise_project_id&#x3D;0）下的资源，鉴权按照default企业项目鉴权。 如果传值enterprise_project_id&#x3D;all_granted_eps，则表示查询所有有权限的企业项目下的资源。 其他情况则传已存在的企业项目ID。此时会校验ID，若不存在或格式错误则报错。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMembersRequest {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMembersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMembersRequest input)
        {
            if (input == null) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.ProtocolPort != input.ProtocolPort || (this.ProtocolPort != null && !this.ProtocolPort.Equals(input.ProtocolPort))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ProtocolPort != null) hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
