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
    /// 需要修改的协议策略组。
    /// </summary>
    public class PolicyGroupForUpdate 
    {

        /// <summary>
        /// 策略组名称，长度不能超过255个字符。
        /// </summary>
        [JsonProperty("policy_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupName { get; set; }

        /// <summary>
        /// 策略组描述，长度不能超过255个字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 优先级。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

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
            sb.Append("class PolicyGroupForUpdate {\n");
            sb.Append("  policyGroupName: ").Append(PolicyGroupName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as PolicyGroupForUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyGroupForUpdate input)
        {
            if (input == null) return false;
            if (this.PolicyGroupName != input.PolicyGroupName || (this.PolicyGroupName != null && !this.PolicyGroupName.Equals(input.PolicyGroupName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
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
                if (this.PolicyGroupName != null) hashCode = hashCode * 59 + this.PolicyGroupName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Targets != null) hashCode = hashCode * 59 + this.Targets.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
