using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AuditSqlResponseSqlOperatedObjInfo 
    {

        /// <summary>
        /// 列名
        /// </summary>
        [JsonProperty("column_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnName { get; set; }

        /// <summary>
        /// 操作对象类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// schema名称
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// sql类型
        /// </summary>
        [JsonProperty("sql_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlType { get; set; }

        /// <summary>
        /// 系统名称
        /// </summary>
        [JsonProperty("sys_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SysName { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSqlResponseSqlOperatedObjInfo {\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  sqlType: ").Append(SqlType).Append("\n");
            sb.Append("  sysName: ").Append(SysName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditSqlResponseSqlOperatedObjInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditSqlResponseSqlOperatedObjInfo input)
        {
            if (input == null) return false;
            if (this.ColumnName != input.ColumnName || (this.ColumnName != null && !this.ColumnName.Equals(input.ColumnName))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.SqlType != input.SqlType || (this.SqlType != null && !this.SqlType.Equals(input.SqlType))) return false;
            if (this.SysName != input.SysName || (this.SysName != null && !this.SysName.Equals(input.SysName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;

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
                if (this.ColumnName != null) hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.SqlType != null) hashCode = hashCode * 59 + this.SqlType.GetHashCode();
                if (this.SysName != null) hashCode = hashCode * 59 + this.SysName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
