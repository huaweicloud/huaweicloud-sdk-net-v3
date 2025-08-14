using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssignmentConfigDto 
    {

        /// <summary>
        /// 应用程序是否需要分配
        /// </summary>
        [JsonProperty("assignment_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssignmentRequired { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssignmentConfigDto {\n");
            sb.Append("  assignmentRequired: ").Append(AssignmentRequired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssignmentConfigDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssignmentConfigDto input)
        {
            if (input == null) return false;
            if (this.AssignmentRequired != input.AssignmentRequired || (this.AssignmentRequired != null && !this.AssignmentRequired.Equals(input.AssignmentRequired))) return false;

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
                if (this.AssignmentRequired != null) hashCode = hashCode * 59 + this.AssignmentRequired.GetHashCode();
                return hashCode;
            }
        }
    }
}
