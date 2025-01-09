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
    /// Request Object
    /// </summary>
    public class DeletePolicyGroupRequest 
    {

        /// <summary>
        /// 策略组id。
        /// </summary>
        [SDKProperty("policy_group_id", IsPath = true)]
        [JsonProperty("policy_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePolicyGroupRequest {\n");
            sb.Append("  policyGroupId: ").Append(PolicyGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletePolicyGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletePolicyGroupRequest input)
        {
            if (input == null) return false;
            if (this.PolicyGroupId != input.PolicyGroupId || (this.PolicyGroupId != null && !this.PolicyGroupId.Equals(input.PolicyGroupId))) return false;

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
                return hashCode;
            }
        }
    }
}