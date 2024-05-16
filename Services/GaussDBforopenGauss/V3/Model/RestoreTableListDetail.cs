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
    /// 
    /// </summary>
    public class RestoreTableListDetail 
    {

        /// <summary>
        /// 库名参数必传
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// schema名  备份恢复到新实例和当前实例：使用DATABASE_TABLE级别恢复参数必传, 使用DATABASE类型恢复参数无效。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 表名  备份恢复到新实例和当前实例：使用DATABASE_TABLE级别恢复参数必传, 使用DATABASE类型恢复参数无效。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 新库名  备份恢复到新实例和当前实例：   使用DATABASE级别恢复：需注意目标实例不存在当前一样的库名，否则无法下发。   使用DATABASE_TABLE级别恢复，不填时与源库名一致。
        /// </summary>
        [JsonProperty("new_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewDbName { get; set; }

        /// <summary>
        /// 新schema_name  备份恢复到新实例和当前实例：    使用DATABASE类型恢复参数无效。   使用DATABASE_TABLE级别恢复，不填时与源schema名一致。
        /// </summary>
        [JsonProperty("new_schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewSchemaName { get; set; }

        /// <summary>
        /// 新表名  备份恢复到新实例和当前实例：   使用DATABASE类型恢复参数无效。   使用DATABASE_TABLE级别恢复，需注意目标实例里不存在当前的表名，否则无法下发。
        /// </summary>
        [JsonProperty("new_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewTableName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreTableListDetail {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  newDbName: ").Append(NewDbName).Append("\n");
            sb.Append("  newSchemaName: ").Append(NewSchemaName).Append("\n");
            sb.Append("  newTableName: ").Append(NewTableName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreTableListDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreTableListDetail input)
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
                    this.NewDbName == input.NewDbName ||
                    (this.NewDbName != null &&
                    this.NewDbName.Equals(input.NewDbName))
                ) && 
                (
                    this.NewSchemaName == input.NewSchemaName ||
                    (this.NewSchemaName != null &&
                    this.NewSchemaName.Equals(input.NewSchemaName))
                ) && 
                (
                    this.NewTableName == input.NewTableName ||
                    (this.NewTableName != null &&
                    this.NewTableName.Equals(input.NewTableName))
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
                if (this.NewDbName != null)
                    hashCode = hashCode * 59 + this.NewDbName.GetHashCode();
                if (this.NewSchemaName != null)
                    hashCode = hashCode * 59 + this.NewSchemaName.GetHashCode();
                if (this.NewTableName != null)
                    hashCode = hashCode * 59 + this.NewTableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
