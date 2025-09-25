using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PermissionsDto 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repository_access", NullValueHandling = NullValueHandling.Ignore)]
        public MemberAccess RepositoryAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("group_access", NullValueHandling = NullValueHandling.Ignore)]
        public MemberAccess GroupAccess { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionsDto {\n");
            sb.Append("  repositoryAccess: ").Append(RepositoryAccess).Append("\n");
            sb.Append("  groupAccess: ").Append(GroupAccess).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionsDto input)
        {
            if (input == null) return false;
            if (this.RepositoryAccess != input.RepositoryAccess || (this.RepositoryAccess != null && !this.RepositoryAccess.Equals(input.RepositoryAccess))) return false;
            if (this.GroupAccess != input.GroupAccess || (this.GroupAccess != null && !this.GroupAccess.Equals(input.GroupAccess))) return false;

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
                if (this.RepositoryAccess != null) hashCode = hashCode * 59 + this.RepositoryAccess.GetHashCode();
                if (this.GroupAccess != null) hashCode = hashCode * 59 + this.GroupAccess.GetHashCode();
                return hashCode;
            }
        }
    }
}
