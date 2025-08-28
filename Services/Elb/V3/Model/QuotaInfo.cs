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
    /// **参数解释**：配额信息，包括总配额和已使用配额。
    /// </summary>
    public class QuotaInfo 
    {

        /// <summary>
        /// **参数解释**：配额类型。  **取值范围**：loadbalancer、listener、ipgroup、pool、member、healthmonitor、l7policy、certificate、security_policy、listeners_per_loadbalancer、listeners_per_pool、members_per_pool、condition_per_policy、ipgroup_bindings、ipgroup_max_length、ipgroups_per_listener、pools_per_l7policy、l7policies_per_listener、free_instance_members_per_pool、free_instance_listeners_per_loadbalancer。
        /// </summary>
        [JsonProperty("quota_key", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaKey { get; set; }

        /// <summary>
        /// **参数解释**：总配额。  **取值范围**： - 大于等于0：表示当前配额数量。 - -1：表示无配额限制。
        /// </summary>
        [JsonProperty("quota_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaLimit { get; set; }

        /// <summary>
        /// **参数解释**：已使用配额。  **取值范围**：大于等于0。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// **参数解释**：配额单位。  **取值范围**：count，表示个数。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaInfo {\n");
            sb.Append("  quotaKey: ").Append(QuotaKey).Append("\n");
            sb.Append("  quotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaInfo input)
        {
            if (input == null) return false;
            if (this.QuotaKey != input.QuotaKey || (this.QuotaKey != null && !this.QuotaKey.Equals(input.QuotaKey))) return false;
            if (this.QuotaLimit != input.QuotaLimit || (this.QuotaLimit != null && !this.QuotaLimit.Equals(input.QuotaLimit))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;

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
                if (this.QuotaLimit != null) hashCode = hashCode * 59 + this.QuotaLimit.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
