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
    /// Response Object
    /// </summary>
    public class ShowDomainRoleAssignmentsResponse : SdkResponse
    {

        /// <summary>
        /// 返回授权记录的总条数。
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("role_assignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleAssignmentBody> RoleAssignments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainRoleAssignmentsResponse {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  roleAssignments: ").Append(RoleAssignments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainRoleAssignmentsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainRoleAssignmentsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalNum == input.TotalNum ||
                    (this.TotalNum != null &&
                    this.TotalNum.Equals(input.TotalNum))
                ) && 
                (
                    this.RoleAssignments == input.RoleAssignments ||
                    this.RoleAssignments != null &&
                    input.RoleAssignments != null &&
                    this.RoleAssignments.SequenceEqual(input.RoleAssignments)
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
                if (this.TotalNum != null)
                    hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.RoleAssignments != null)
                    hashCode = hashCode * 59 + this.RoleAssignments.GetHashCode();
                return hashCode;
            }
        }
    }
}
