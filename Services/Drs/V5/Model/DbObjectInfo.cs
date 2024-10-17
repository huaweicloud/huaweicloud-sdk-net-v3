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
    /// 对象信息。
    /// </summary>
    public class DbObjectInfo 
    {

        /// <summary>
        /// 源数据库库名。
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 源数据库模式名。
        /// </summary>
        [JsonProperty("source_schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSchemaName { get; set; }

        /// <summary>
        /// 源数据库表名。
        /// </summary>
        [JsonProperty("source_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// 目标数据库库名。
        /// </summary>
        [JsonProperty("target_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbName { get; set; }

        /// <summary>
        /// 目标数据库模式名。
        /// </summary>
        [JsonProperty("target_schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSchemaName { get; set; }

        /// <summary>
        /// 目标数据库表名。
        /// </summary>
        [JsonProperty("target_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// 是否有列映射。
        /// </summary>
        [JsonProperty("has_column_info", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasColumnInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbObjectInfo {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  sourceSchemaName: ").Append(SourceSchemaName).Append("\n");
            sb.Append("  sourceTableName: ").Append(SourceTableName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  targetSchemaName: ").Append(TargetSchemaName).Append("\n");
            sb.Append("  targetTableName: ").Append(TargetTableName).Append("\n");
            sb.Append("  hasColumnInfo: ").Append(HasColumnInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbObjectInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbObjectInfo input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.SourceSchemaName != input.SourceSchemaName || (this.SourceSchemaName != null && !this.SourceSchemaName.Equals(input.SourceSchemaName))) return false;
            if (this.SourceTableName != input.SourceTableName || (this.SourceTableName != null && !this.SourceTableName.Equals(input.SourceTableName))) return false;
            if (this.TargetDbName != input.TargetDbName || (this.TargetDbName != null && !this.TargetDbName.Equals(input.TargetDbName))) return false;
            if (this.TargetSchemaName != input.TargetSchemaName || (this.TargetSchemaName != null && !this.TargetSchemaName.Equals(input.TargetSchemaName))) return false;
            if (this.TargetTableName != input.TargetTableName || (this.TargetTableName != null && !this.TargetTableName.Equals(input.TargetTableName))) return false;
            if (this.HasColumnInfo != input.HasColumnInfo || (this.HasColumnInfo != null && !this.HasColumnInfo.Equals(input.HasColumnInfo))) return false;

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
                if (this.SourceDbName != null) hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.SourceSchemaName != null) hashCode = hashCode * 59 + this.SourceSchemaName.GetHashCode();
                if (this.SourceTableName != null) hashCode = hashCode * 59 + this.SourceTableName.GetHashCode();
                if (this.TargetDbName != null) hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                if (this.TargetSchemaName != null) hashCode = hashCode * 59 + this.TargetSchemaName.GetHashCode();
                if (this.TargetTableName != null) hashCode = hashCode * 59 + this.TargetTableName.GetHashCode();
                if (this.HasColumnInfo != null) hashCode = hashCode * 59 + this.HasColumnInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
