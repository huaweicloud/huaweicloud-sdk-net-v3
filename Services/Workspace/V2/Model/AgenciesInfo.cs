using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 委托信息。
    /// </summary>
    public class AgenciesInfo 
    {

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 委托权限信息
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgenciesPermissionInfo> Permissions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgenciesInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgenciesInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgenciesInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && input.Permissions != null && !this.Permissions.SequenceEqual(input.Permissions))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                return hashCode;
            }
        }
    }
}
