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
    public class ModifyPolicyGroupRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_group", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyGroupForUpdate PolicyGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPolicyGroupRequest {\n");
            sb.Append("  policyGroup: ").Append(PolicyGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyPolicyGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyPolicyGroupRequest input)
        {
            if (input == null) return false;
            if (this.PolicyGroup != input.PolicyGroup || (this.PolicyGroup != null && !this.PolicyGroup.Equals(input.PolicyGroup))) return false;

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
                if (this.PolicyGroup != null) hashCode = hashCode * 59 + this.PolicyGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
