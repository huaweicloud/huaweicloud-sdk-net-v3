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
    public class UpdateOrganizationPolicyRequest 
    {

        /// <summary>
        /// 组织策略ID
        /// </summary>
        [SDKProperty("organization_policy_id", IsPath = true)]
        [JsonProperty("organization_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationPolicyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationPolicyUpdateReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOrganizationPolicyRequest {\n");
            sb.Append("  organizationPolicyId: ").Append(OrganizationPolicyId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOrganizationPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateOrganizationPolicyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganizationPolicyId == input.OrganizationPolicyId ||
                    (this.OrganizationPolicyId != null &&
                    this.OrganizationPolicyId.Equals(input.OrganizationPolicyId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.OrganizationPolicyId != null)
                    hashCode = hashCode * 59 + this.OrganizationPolicyId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
