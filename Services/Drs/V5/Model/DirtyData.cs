using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 异常数据。
    /// </summary>
    public class DirtyData 
    {

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 模式名称。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 表名称。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 异常SQL。
        /// </summary>
        [JsonProperty("error_sql", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorSql { get; set; }

        /// <summary>
        /// 发生异常时间，UTC时间，例如：2023-06-10T03:01:52Z
        /// </summary>
        [JsonProperty("error_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorTime { get; set; }

        /// <summary>
        /// 异常信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirtyData {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  errorSql: ").Append(ErrorSql).Append("\n");
            sb.Append("  errorTime: ").Append(ErrorTime).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DirtyData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DirtyData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbName == input.DbName ||
                    (this.DbName != null &&
                    this.DbName.Equals(input.DbName))
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
                ) && 
                (
                    this.TableName == input.TableName ||
                    (this.TableName != null &&
                    this.TableName.Equals(input.TableName))
                ) && 
                (
                    this.ErrorSql == input.ErrorSql ||
                    (this.ErrorSql != null &&
                    this.ErrorSql.Equals(input.ErrorSql))
                ) && 
                (
                    this.ErrorTime == input.ErrorTime ||
                    (this.ErrorTime != null &&
                    this.ErrorTime.Equals(input.ErrorTime))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.DbName != null)
                    hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null)
                    hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TableName != null)
                    hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.ErrorSql != null)
                    hashCode = hashCode * 59 + this.ErrorSql.GetHashCode();
                if (this.ErrorTime != null)
                    hashCode = hashCode * 59 + this.ErrorTime.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
