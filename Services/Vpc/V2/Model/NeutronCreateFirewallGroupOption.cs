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
    /// 
    /// </summary>
    public class NeutronCreateFirewallGroupOption 
    {

        /// <summary>
        /// 功能说明：网络ACL组名称 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：网络ACL防火墙组描述 取值范围：最长255个字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：入方向网络ACL策略
        /// </summary>
        [JsonProperty("ingress_firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IngressFirewallPolicyId { get; set; }

        /// <summary>
        /// 功能说明：出方向网络ACL策略
        /// </summary>
        [JsonProperty("egress_firewall_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EgressFirewallPolicyId { get; set; }

        /// <summary>
        /// 功能说明：网络ACL防火墙组绑定的端口列表 约束：必须为分布式router的端口id
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ports { get; set; }

        /// <summary>
        /// 功能说明：网络ACL是否受管理员控制
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateFirewallGroupOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  ingressFirewallPolicyId: ").Append(IngressFirewallPolicyId).Append("\n");
            sb.Append("  egressFirewallPolicyId: ").Append(EgressFirewallPolicyId).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateFirewallGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateFirewallGroupOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IngressFirewallPolicyId == input.IngressFirewallPolicyId ||
                    (this.IngressFirewallPolicyId != null &&
                    this.IngressFirewallPolicyId.Equals(input.IngressFirewallPolicyId))
                ) && 
                (
                    this.EgressFirewallPolicyId == input.EgressFirewallPolicyId ||
                    (this.EgressFirewallPolicyId != null &&
                    this.EgressFirewallPolicyId.Equals(input.EgressFirewallPolicyId))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IngressFirewallPolicyId != null)
                    hashCode = hashCode * 59 + this.IngressFirewallPolicyId.GetHashCode();
                if (this.EgressFirewallPolicyId != null)
                    hashCode = hashCode * 59 + this.EgressFirewallPolicyId.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                return hashCode;
            }
        }
    }
}
