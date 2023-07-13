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
    public class RoleAssignmentScope 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public RoleProjectAssignmentId Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public RoleDomainAssignmentId Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enterprise_project", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnterpriseProjectAssignmentId EnterpriseProject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleAssignmentScope {\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  enterpriseProject: ").Append(EnterpriseProject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleAssignmentScope);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleAssignmentScope input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.EnterpriseProject == input.EnterpriseProject ||
                    (this.EnterpriseProject != null &&
                    this.EnterpriseProject.Equals(input.EnterpriseProject))
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
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EnterpriseProject != null)
                    hashCode = hashCode * 59 + this.EnterpriseProject.GetHashCode();
                return hashCode;
            }
        }
    }
}
