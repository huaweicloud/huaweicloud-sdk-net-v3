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
    /// 
    /// </summary>
    public class PolicyGroupForBaseList 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyGroupForBaseList {\n");
            sb.Append("  policyGroupId: ").Append(PolicyGroupId).Append("\n");
            sb.Append("  policyGroupName: ").Append(PolicyGroupName).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyGroupForBaseList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyGroupForBaseList input)
        {
            if (input == null) return false;
            if (this.PolicyGroupId != input.PolicyGroupId || (this.PolicyGroupId != null && !this.PolicyGroupId.Equals(input.PolicyGroupId))) return false;
            if (this.PolicyGroupName != input.PolicyGroupName || (this.PolicyGroupName != null && !this.PolicyGroupName.Equals(input.PolicyGroupName))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                return hashCode;
            }
        }
    }
}
