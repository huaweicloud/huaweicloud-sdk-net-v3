using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RolesOption 
    {

        /// <summary>
        /// 被继承角色所在数据库名称。 - 长度为1~64位，可以包含大写字母（A~Z）、小写字母（a~z）、数字（0~9）、下划线。
        /// </summary>
        [JsonProperty("role_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleDbName { get; set; }

        /// <summary>
        /// 被继承角色的名称。 - 长度为1~64位，可以包含大写字母（A~Z）、小写字母（a~z）、数字（0~9）、中划线、下划线和点。
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolesOption {\n");
            sb.Append("  roleDbName: ").Append(RoleDbName).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RolesOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RolesOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RoleDbName == input.RoleDbName ||
                    (this.RoleDbName != null &&
                    this.RoleDbName.Equals(input.RoleDbName))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
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
                if (this.RoleDbName != null)
                    hashCode = hashCode * 59 + this.RoleDbName.GetHashCode();
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
