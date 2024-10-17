using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowFirewallRequest 
    {

        /// <summary>
        /// 网络ACL的唯一标识
        /// </summary>
        [SDKProperty("firewall_id", IsPath = true)]
        [JsonProperty("firewall_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFirewallRequest {\n");
            sb.Append("  firewallId: ").Append(FirewallId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFirewallRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFirewallRequest input)
        {
            if (input == null) return false;
            if (this.FirewallId != input.FirewallId || (this.FirewallId != null && !this.FirewallId.Equals(input.FirewallId))) return false;

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
                if (this.FirewallId != null) hashCode = hashCode * 59 + this.FirewallId.GetHashCode();
                return hashCode;
            }
        }
    }
}
