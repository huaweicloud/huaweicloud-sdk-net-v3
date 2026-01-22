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
        /// **参数解释**：配额类型。  **取值范围**： - loadbalancer：负载均衡器配额。 - listener：监听器配额。 - ipgroup：IP地址组配额。 - pool：后端服务器组配额。 - member：后端服务器配额。 - healthmonitor：健康检查配额。 - l7policy：转发策略配额。 - certificate：证书配额。 - security_policy：自定义安全策略配额。 - listeners_per_loadbalancer：单个LB实例下的监听器配额。 - listeners_per_pool：单个pool关联的监听器配额。 - members_per_pool：单个pool下的member的配额。 - condition_per_policy：单个转发策略下所有转发规则的condition总数配额。 - ipgroup_bindings：单个IP地址组可以关联的监听器数量配额。 - ipgroup_max_length：单个监听器下关联的所有IP地址组的ip列表中的IP总数不能超过ipgroup_max_length。 - ipgroups_per_listener：单个监听器下的IP地址组配额。 - pools_per_l7policy：单个转发策略下的后端服务器组配额。 - l7policies_per_listener：单个监听器下的转发策略配额。 - free_instance_members_per_pool：单个pool实例下的免费member配额。 - free_instance_listeners_per_loadbalancer：单个LB实例下的免费监听器配额。
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
