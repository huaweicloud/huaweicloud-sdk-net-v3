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
    /// 数据库信息。
    /// </summary>
    public class ListGaussMysqlDatabaseInfo 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库使用的字符集，如utf8mb4、gbk等。
        /// </summary>
        [JsonProperty("charset", NullValueHandling = NullValueHandling.Ignore)]
        public string Charset { get; set; }

        /// <summary>
        /// 数据库备注。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 已授权数据库用户列表。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<GaussMySqlDatabaseInfo> Users { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGaussMysqlDatabaseInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  charset: ").Append(Charset).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGaussMysqlDatabaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGaussMysqlDatabaseInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Charset != input.Charset || (this.Charset != null && !this.Charset.Equals(input.Charset))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;

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
                if (this.Charset != null) hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }
}
