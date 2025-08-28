using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListQuotaDetailsRequest 
    {

        /// <summary>
        /// **参数解释**：配额类型。支持多值查询，查询条件格式：quota_key&#x3D;xxx&amp;quota_key&#x3D;xxx。  **约束限制**：不涉及  **取值范围**： loadbalancer、listener、ipgroup、pool、member、healthmonitor、l7policy、certificate、security_policy、listeners_per_loadbalancer、listeners_per_pool、members_per_pool、condition_per_policy、ipgroup_bindings、ipgroup_max_length、ipgroups_per_listener、pools_per_l7policy、l7policies_per_listener、free_instance_members_per_pool、free_instance_listeners_per_loadbalancer。  **默认取值**：不涉及
        /// </summary>
        [SDKProperty("quota_key", IsQuery = true)]
        [JsonProperty("quota_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuotaKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListQuotaDetailsRequest {\n");
            sb.Append("  quotaKey: ").Append(QuotaKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListQuotaDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListQuotaDetailsRequest input)
        {
            if (input == null) return false;
            if (this.QuotaKey != input.QuotaKey || (this.QuotaKey != null && input.QuotaKey != null && !this.QuotaKey.SequenceEqual(input.QuotaKey))) return false;

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
                if (this.QuotaKey != null) hashCode = hashCode * 59 + this.QuotaKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
