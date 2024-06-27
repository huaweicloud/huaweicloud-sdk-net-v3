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
    /// 
    /// </summary>
    public class ShowClickHouseDatabaseUsersUserDetails 
    {

        /// <summary>
        /// 数据库账户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 已授权数据库。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// DML权限。 取值范围： - 1：只读权限 - 2：读取和设置权限
        /// </summary>
        [JsonProperty("dml", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dml { get; set; }

        /// <summary>
        /// DDL授权。 取值范围： - 0：无DDL权限 - 1：有DDL权限
        /// </summary>
        [JsonProperty("ddl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ddl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClickHouseDatabaseUsersUserDetails {\n");
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
            return this.Equals(input as ShowClickHouseDatabaseUsersUserDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClickHouseDatabaseUsersUserDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Databases == input.Databases ||
                    this.Databases != null &&
                    input.Databases != null &&
                    this.Databases.SequenceEqual(input.Databases)
                ) && 
                (
                    this.Dml == input.Dml ||
                    (this.Dml != null &&
                    this.Dml.Equals(input.Dml))
                ) && 
                (
                    this.Ddl == input.Ddl ||
                    (this.Ddl != null &&
                    this.Ddl.Equals(input.Ddl))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Databases != null)
                    hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.Dml != null)
                    hashCode = hashCode * 59 + this.Dml.GetHashCode();
                if (this.Ddl != null)
                    hashCode = hashCode * 59 + this.Ddl.GetHashCode();
                return hashCode;
            }
        }
    }
}
