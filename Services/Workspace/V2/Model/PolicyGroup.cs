using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 策略组
    /// </summary>
    public class PolicyGroup 
    {

        /// <summary>
        /// 策略组ID。
        /// </summary>
        [JsonProperty("policy_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// 策略组名称。
        /// </summary>
        [JsonProperty("policy_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupName { get; set; }

        /// <summary>
        /// 优先级。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 更新日期。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 策略组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 策略来源。
        /// </summary>
        [JsonProperty("scope_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScopeFlag { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 应用对象列表。
        /// </summary>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Target> Targets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public Policies Policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyGroup {\n");
            sb.Append("  policyGroupId: ").Append(PolicyGroupId).Append("\n");
            sb.Append("  policyGroupName: ").Append(PolicyGroupName).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  scopeFlag: ").Append(ScopeFlag).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  targets: ").Append(Targets).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyGroup input)
        {
            if (input == null) return false;
            if (this.PolicyGroupId != input.PolicyGroupId || (this.PolicyGroupId != null && !this.PolicyGroupId.Equals(input.PolicyGroupId))) return false;
            if (this.PolicyGroupName != input.PolicyGroupName || (this.PolicyGroupName != null && !this.PolicyGroupName.Equals(input.PolicyGroupName))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ScopeFlag != input.ScopeFlag || (this.ScopeFlag != null && !this.ScopeFlag.Equals(input.ScopeFlag))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Targets != input.Targets || (this.Targets != null && input.Targets != null && !this.Targets.SequenceEqual(input.Targets))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && !this.Policies.Equals(input.Policies))) return false;

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
                if (this.PolicyGroupId != null) hashCode = hashCode * 59 + this.PolicyGroupId.GetHashCode();
                if (this.PolicyGroupName != null) hashCode = hashCode * 59 + this.PolicyGroupName.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ScopeFlag != null) hashCode = hashCode * 59 + this.ScopeFlag.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Targets != null) hashCode = hashCode * 59 + this.Targets.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
