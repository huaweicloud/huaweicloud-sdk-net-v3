using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RolePrivilegeV5 
    {

        /// <summary>
        /// **参数解释**: 权限信息。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 无。 
        /// </summary>
        [JsonProperty("privileges", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivilegeParam> Privileges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolePrivilegeV5 {\n");
            sb.Append("  privileges: ").Append(Privileges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RolePrivilegeV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RolePrivilegeV5 input)
        {
            if (input == null) return false;
            if (this.Privileges != input.Privileges || (this.Privileges != null && input.Privileges != null && !this.Privileges.SequenceEqual(input.Privileges))) return false;

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
                if (this.Privileges != null) hashCode = hashCode * 59 + this.Privileges.GetHashCode();
                return hashCode;
            }
        }
    }
}
