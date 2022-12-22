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
    public class DeleteDatabaseRoleRequestBody 
    {

        /// <summary>
        /// 角色名称。 - 长度为1~64位，可以包含大写字母（A~Z）、小写字母（a~z）、数字（0~9）、中划线、下划线和点。
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// 角色所在的数据库名称。 - 长度为1~64位，可以包含大写字母（A~Z）、小写字母（a~z）、数字（0~9）、下划线。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDatabaseRoleRequestBody {\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDatabaseRoleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDatabaseRoleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
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
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                return hashCode;
            }
        }
    }
}
