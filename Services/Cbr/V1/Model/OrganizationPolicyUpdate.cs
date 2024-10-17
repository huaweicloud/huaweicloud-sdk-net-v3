using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 更新组织策略body体
    /// </summary>
    public class OrganizationPolicyUpdate 
    {

        /// <summary>
        /// 组织策略名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 组织策略描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// 策略是否开启
        /// </summary>
        [JsonProperty("policy_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PolicyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_operation_definition", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyoODCreate PolicyOperationDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyTriggerReq PolicyTrigger { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationPolicyUpdate {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  policyEnabled: ").Append(PolicyEnabled).Append("\n");
            sb.Append("  policyOperationDefinition: ").Append(PolicyOperationDefinition).Append("\n");
            sb.Append("  policyTrigger: ").Append(PolicyTrigger).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationPolicyUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationPolicyUpdate input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PolicyName != input.PolicyName || (this.PolicyName != null && !this.PolicyName.Equals(input.PolicyName))) return false;
            if (this.PolicyEnabled != input.PolicyEnabled || (this.PolicyEnabled != null && !this.PolicyEnabled.Equals(input.PolicyEnabled))) return false;
            if (this.PolicyOperationDefinition != input.PolicyOperationDefinition || (this.PolicyOperationDefinition != null && !this.PolicyOperationDefinition.Equals(input.PolicyOperationDefinition))) return false;
            if (this.PolicyTrigger != input.PolicyTrigger || (this.PolicyTrigger != null && !this.PolicyTrigger.Equals(input.PolicyTrigger))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PolicyName != null) hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PolicyEnabled != null) hashCode = hashCode * 59 + this.PolicyEnabled.GetHashCode();
                if (this.PolicyOperationDefinition != null) hashCode = hashCode * 59 + this.PolicyOperationDefinition.GetHashCode();
                if (this.PolicyTrigger != null) hashCode = hashCode * 59 + this.PolicyTrigger.GetHashCode();
                return hashCode;
            }
        }
    }
}
