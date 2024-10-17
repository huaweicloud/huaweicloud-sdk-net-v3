using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class NeutronListFirewallGroupsRequest 
    {

        /// <summary>
        /// 分页查询起始的资源ID，为空时查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 每页返回的个数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 使用id过滤网络ACL组
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 使用name过滤ACL组
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 使用description过滤ACL组
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 使用入方向的网络ACL策略ID过滤网络ACL组
        /// </summary>
        [SDKProperty("ingress_firewall_policy_id", IsQuery = true)]
        [JsonProperty("ingress_firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IngressFirewallPolicyId { get; set; }

        /// <summary>
        /// 使用出方向的网络ACL策略过滤查询网络ACL组
        /// </summary>
        [SDKProperty("egress_firewall_policy_id", IsQuery = true)]
        [JsonProperty("egress_firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EgressFirewallPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListFirewallGroupsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ingressFirewallPolicyId: ").Append(IngressFirewallPolicyId).Append("\n");
            sb.Append("  egressFirewallPolicyId: ").Append(EgressFirewallPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListFirewallGroupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListFirewallGroupsRequest input)
        {
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.IngressFirewallPolicyId != input.IngressFirewallPolicyId || (this.IngressFirewallPolicyId != null && !this.IngressFirewallPolicyId.Equals(input.IngressFirewallPolicyId))) return false;
            if (this.EgressFirewallPolicyId != input.EgressFirewallPolicyId || (this.EgressFirewallPolicyId != null && !this.EgressFirewallPolicyId.Equals(input.EgressFirewallPolicyId))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IngressFirewallPolicyId != null) hashCode = hashCode * 59 + this.IngressFirewallPolicyId.GetHashCode();
                if (this.EgressFirewallPolicyId != null) hashCode = hashCode * 59 + this.EgressFirewallPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
