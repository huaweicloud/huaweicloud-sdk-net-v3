using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAgencyPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 委托是否存在。
        /// </summary>
        [JsonProperty("is_existed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExisted { get; set; }

        /// <summary>
        /// 委托名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 委托角色列表。
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgencyRole> Roles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAgencyPolicyResponse {\n");
            sb.Append("  isExisted: ").Append(IsExisted).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  roles: ").Append(Roles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAgencyPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAgencyPolicyResponse input)
        {
            if (input == null) return false;
            if (this.IsExisted != input.IsExisted || (this.IsExisted != null && !this.IsExisted.Equals(input.IsExisted))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
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
                if (this.IsExisted != null) hashCode = hashCode * 59 + this.IsExisted.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Roles != null) hashCode = hashCode * 59 + this.Roles.GetHashCode();
                return hashCode;
            }
        }
    }
}
