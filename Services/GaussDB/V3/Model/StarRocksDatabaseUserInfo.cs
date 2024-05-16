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
    /// 账户信息
    /// </summary>
    public class StarRocksDatabaseUserInfo 
    {

        /// <summary>
        /// 数据库账户名。 长度为2-32个字符，必须以小写字母开头，小写字母或数字结尾，可以包含小写字母、数字以及下划线，不能包含其它特殊字符。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 账户密码。 - 8-32个字符 - 不能与用户名或倒序的用户名相同 - 至少包含以下字符中的三种：大写字母、小写字母、数字和特殊字符~！@#%^*-_&#x3D;+?,
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 数据库列表。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// DML权限，默认2。 取值范围： - 0：读写权限 - 1：只读权限 - 2：只读和设置权限 - 3：读写和设置权限
        /// </summary>
        [JsonProperty("dml", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dml { get; set; }

        /// <summary>
        /// DDL权限，默认0。 取值范围： - 0：无DDL权限 - 1：有DDL权限
        /// </summary>
        [JsonProperty("ddl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ddl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksDatabaseUserInfo {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
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
            return this.Equals(input as StarRocksDatabaseUserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksDatabaseUserInfo input)
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
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
