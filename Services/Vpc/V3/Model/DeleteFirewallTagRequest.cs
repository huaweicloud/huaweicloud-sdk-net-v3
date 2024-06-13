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
    public class DeleteFirewallTagRequest 
    {

        /// <summary>
        /// 功能说明：ACL唯一标识 取值范围：合法UUID 约束：ID对应的ACL必须存在
        /// </summary>
        [SDKProperty("firewall_id", IsPath = true)]
        [JsonProperty("firewall_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FirewallId { get; set; }

        /// <summary>
        /// 功能说明：标签键
        /// </summary>
        [SDKProperty("tag_key", IsPath = true)]
        [JsonProperty("tag_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TagKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFirewallTagRequest {\n");
            sb.Append("  firewallId: ").Append(FirewallId).Append("\n");
            sb.Append("  tagKey: ").Append(TagKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFirewallTagRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFirewallTagRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirewallId == input.FirewallId ||
                    (this.FirewallId != null &&
                    this.FirewallId.Equals(input.FirewallId))
                ) && 
                (
                    this.TagKey == input.TagKey ||
                    (this.TagKey != null &&
                    this.TagKey.Equals(input.TagKey))
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
                if (this.FirewallId != null)
                    hashCode = hashCode * 59 + this.FirewallId.GetHashCode();
                if (this.TagKey != null)
                    hashCode = hashCode * 59 + this.TagKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
