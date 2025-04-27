using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListResolverRuleParam 
    {

        /// <summary>
        /// 转发规则的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 规则名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 当前规则所属的终端节点ID。
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// 资源状态。 取值范围：PENDING_CREATE, ACTIVE, PENDING_DELETE, ERROR。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 规则类型。 预留字段，当前默认为FORWARD。
        /// </summary>
        [JsonProperty("rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleType { get; set; }

        /// <summary>
        /// 当前规则下的IP地址数量。
        /// </summary>
        [JsonProperty("ipaddress_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpaddressCount { get; set; }

        /// <summary>
        /// 关联的VPC信息。
        /// </summary>
        [JsonProperty("routers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Router> Routers { get; set; }

        /// <summary>
        /// 创建时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResolverRuleParam {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ruleType: ").Append(RuleType).Append("\n");
            sb.Append("  ipaddressCount: ").Append(IpaddressCount).Append("\n");
            sb.Append("  routers: ").Append(Routers).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResolverRuleParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResolverRuleParam input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RuleType != input.RuleType || (this.RuleType != null && !this.RuleType.Equals(input.RuleType))) return false;
            if (this.IpaddressCount != input.IpaddressCount || (this.IpaddressCount != null && !this.IpaddressCount.Equals(input.IpaddressCount))) return false;
            if (this.Routers != input.Routers || (this.Routers != null && input.Routers != null && !this.Routers.SequenceEqual(input.Routers))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RuleType != null) hashCode = hashCode * 59 + this.RuleType.GetHashCode();
                if (this.IpaddressCount != null) hashCode = hashCode * 59 + this.IpaddressCount.GetHashCode();
                if (this.Routers != null) hashCode = hashCode * 59 + this.Routers.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
