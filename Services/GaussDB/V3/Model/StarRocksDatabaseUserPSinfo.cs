using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 修改数据库账号权限
    /// </summary>
    public class StarRocksDatabaseUserPSinfo 
    {

        /// <summary>
        /// 数据库账号名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 数据库列表。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// DML权限。 取值范围： - 0：读写权限 - 1：只读权限 - 2：只读和设置权限 - 3：读写和设置权限
        /// </summary>
        [JsonProperty("dml", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dml { get; set; }

        /// <summary>
        /// DDL权限。 取值范围： - 0：无DDL权限 - 1：有DDL权限
        /// </summary>
        [JsonProperty("ddl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ddl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksDatabaseUserPSinfo {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  dml: ").Append(Dml).Append("\n");
            sb.Append("  ddl: ").Append(Ddl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StarRocksDatabaseUserPSinfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksDatabaseUserPSinfo input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && input.Databases != null && !this.Databases.SequenceEqual(input.Databases))) return false;
            if (this.Dml != input.Dml || (this.Dml != null && !this.Dml.Equals(input.Dml))) return false;
            if (this.Ddl != input.Ddl || (this.Ddl != null && !this.Ddl.Equals(input.Ddl))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.Dml != null) hashCode = hashCode * 59 + this.Dml.GetHashCode();
                if (this.Ddl != null) hashCode = hashCode * 59 + this.Ddl.GetHashCode();
                return hashCode;
            }
        }
    }
}
