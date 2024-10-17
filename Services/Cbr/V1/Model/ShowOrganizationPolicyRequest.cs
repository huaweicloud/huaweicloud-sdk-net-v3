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
    /// Request Object
    /// </summary>
    public class ShowOrganizationPolicyRequest 
    {

        /// <summary>
        /// 组织策略ID
        /// </summary>
        [SDKProperty("organization_policy_id", IsPath = true)]
        [JsonProperty("organization_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrganizationPolicyRequest {\n");
            sb.Append("  organizationPolicyId: ").Append(OrganizationPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrganizationPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrganizationPolicyRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationPolicyId != input.OrganizationPolicyId || (this.OrganizationPolicyId != null && !this.OrganizationPolicyId.Equals(input.OrganizationPolicyId))) return false;

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
                if (this.OrganizationPolicyId != null) hashCode = hashCode * 59 + this.OrganizationPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
