using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// MySql配置信息
    /// </summary>
    public class MysqlForwarding 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public NetAddress Address { get; set; }

        /// <summary>
        /// **参数说明**：连接MYSQL数据库的库名。 **取值范围**：长度不超过64，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数说明**：连接MYSQL数据库的用户名
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数说明**：连接MYSQL数据库的密码
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// **参数说明**：客户端是否使用SSL连接服务端，默认为true
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// **参数说明**：MYSQL数据库的表名
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数说明**：MYSQL数据库的列和流转数据的对应关系列表。
        /// </summary>
        [JsonProperty("column_mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnMapping> ColumnMappings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlForwarding {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  columnMappings: ").Append(ColumnMappings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlForwarding input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.ColumnMappings == input.ColumnMappings ||
                    this.ColumnMappings != null &&
                    input.ColumnMappings != null &&
                    this.ColumnMappings.SequenceEqual(input.ColumnMappings)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.ColumnMappings != null)
                    hashCode = hashCode * 59 + this.ColumnMappings.GetHashCode();
                return hashCode;
            }
        }
    }
}
