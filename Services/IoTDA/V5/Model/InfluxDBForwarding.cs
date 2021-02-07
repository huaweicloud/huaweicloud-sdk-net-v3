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
    /// InfluxDB配置信息
    /// </summary>
    public class InfluxDBForwarding 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public NetAddress Address { get; set; }

        /// <summary>
        /// 连接InfluxDB数据库的库名,不存在会自动创建
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 连接InfluxDB数据库的用户名
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 连接InfluxDB数据库的密码
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// InfluxDB数据库的measurement,不存在会自动创建
        /// </summary>
        [JsonProperty("measurement", NullValueHandling = NullValueHandling.Ignore)]
        public string Measurement { get; set; }

        /// <summary>
        /// InfluxDB数据库和流转数据的对应关系列表。
        /// </summary>
        [JsonProperty("column_mappings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnMapping> ColumnMappings { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfluxDBForwarding {\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  measurement: ").Append(Measurement).Append("\n");
            sb.Append("  columnMappings: ").Append(ColumnMappings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InfluxDBForwarding);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InfluxDBForwarding input)
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
                    this.Measurement == input.Measurement ||
                    (this.Measurement != null &&
                    this.Measurement.Equals(input.Measurement))
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
                if (this.Measurement != null)
                    hashCode = hashCode * 59 + this.Measurement.GetHashCode();
                if (this.ColumnMappings != null)
                    hashCode = hashCode * 59 + this.ColumnMappings.GetHashCode();
                return hashCode;
            }
        }
    }
}
