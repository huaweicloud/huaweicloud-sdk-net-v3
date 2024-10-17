using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateOrDelAgencyEpPolicyAssignmentReqBody 
    {

        /// <summary>
        /// 委托在企业项目上的绑定关系，最多支持250条。
        /// </summary>
        [JsonProperty("role_assignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateAgencyEpPolicyAssignmentReqBodyRoleAssignments> RoleAssignments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrDelAgencyEpPolicyAssignmentReqBody {\n");
            sb.Append("  roleAssignments: ").Append(RoleAssignments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOrDelAgencyEpPolicyAssignmentReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOrDelAgencyEpPolicyAssignmentReqBody input)
        {
            if (input == null) return false;
            if (this.RoleAssignments != input.RoleAssignments || (this.RoleAssignments != null && input.RoleAssignments != null && !this.RoleAssignments.SequenceEqual(input.RoleAssignments))) return false;

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
                if (this.RoleAssignments != null) hashCode = hashCode * 59 + this.RoleAssignments.GetHashCode();
                return hashCode;
            }
        }
    }
}
