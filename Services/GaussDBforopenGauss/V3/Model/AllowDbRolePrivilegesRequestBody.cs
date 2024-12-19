using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 授权数据库角色。
    /// </summary>
    public class AllowDbRolePrivilegesRequestBody 
    {

        /// <summary>
        /// 数据库名称。 不能使用模板库，且是已存在的数据库名称。 模板库包括postgres， template0 ，template1，templatea，template_pdb，templatem。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 角色权限信息。
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public Object User { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowDbRolePrivilegesRequestBody {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowDbRolePrivilegesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllowDbRolePrivilegesRequestBody input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                return hashCode;
            }
        }
    }
}
