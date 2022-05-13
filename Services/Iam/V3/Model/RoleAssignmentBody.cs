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
    public class RoleAssignmentBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public RoleUserAssignmentId User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleAssignmentId Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public RoleGroupAssignmentId Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("agency", NullValueHandling = NullValueHandling.Ignore)]
        public RoleAgencyAssignmentId Agency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public RoleAssignmentScope Scope { get; set; }

        /// <summary>
        /// 是否基于所有项目授权。
        /// </summary>
        [JsonProperty("is_inherited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInherited { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoleAssignmentBody {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  agency: ").Append(Agency).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  isInherited: ").Append(IsInherited).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoleAssignmentBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RoleAssignmentBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Agency == input.Agency ||
                    (this.Agency != null &&
                    this.Agency.Equals(input.Agency))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.IsInherited == input.IsInherited ||
                    (this.IsInherited != null &&
                    this.IsInherited.Equals(input.IsInherited))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Agency != null)
                    hashCode = hashCode * 59 + this.Agency.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.IsInherited != null)
                    hashCode = hashCode * 59 + this.IsInherited.GetHashCode();
                return hashCode;
            }
        }
    }
}
