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
    public class ListRolesForGroupOnEnterpriseProjectResponse : SdkResponse
    {

        /// <summary>
        /// 角色列表。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<RolesItem> Roles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRolesForGroupOnEnterpriseProjectResponse {\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRolesForGroupOnEnterpriseProjectResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRolesForGroupOnEnterpriseProjectResponse input)
        {
            if (input == null) return false;
            if (this.Roles != input.Roles || (this.Roles != null && input.Roles != null && !this.Roles.SequenceEqual(input.Roles))) return false;

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
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }
    }
}
