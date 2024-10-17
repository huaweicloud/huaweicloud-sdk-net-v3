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
    public class BatchDeleteFirewallTagsRequest 
    {

        /// <summary>
        /// 功能说明：ACL唯一标识 取值范围：合法UUID 约束：ID对应的ACL必须存在
        /// </summary>
        [SDKProperty("firewall_id", IsPath = true)]
        [JsonProperty("firewall_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public BatchDeleteFirewallTagsRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteFirewallTagsRequest {\n");
            sb.Append("  firewallId: ").Append(FirewallId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteFirewallTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteFirewallTagsRequest input)
        {
            if (input == null) return false;
            if (this.FirewallId != input.FirewallId || (this.FirewallId != null && !this.FirewallId.Equals(input.FirewallId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
