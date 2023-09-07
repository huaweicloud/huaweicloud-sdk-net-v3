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
    /// 
    /// </summary>
    public class DataProcessInfo 
    {

        /// <summary>
        /// 指定任务数据加工规则请求体
        /// </summary>
        [JsonProperty("filter_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataFilteringCondition> FilterConditions { get; set; }

        /// <summary>
        /// 库级、批量表级处理为true，单表操作为false
        /// </summary>
        [JsonProperty("is_batch_process", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBatchProcess { get; set; }

        /// <summary>
        /// 附加列 当选择附加列时必须填写 约束：使用多对一操作时，需要使用数据加工的附加列操作来避免数据冲突。
        /// </summary>
        [JsonProperty("add_columns", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddColumnInfo> AddColumns { get; set; }

        /// <summary>
        /// 支持DDL的语法 选择增量迁移或同步的DDL操作。取值及意思如下： \&quot;table\&quot;: \&quot;CREATE TABLE, ALTER TABLE,DROP TABLE,RENAME TABLE\&quot; 如该值为空，不迁移或同步DDL操作
        /// </summary>
        [JsonProperty("ddl_operation", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> DdlOperation { get; set; }

        /// <summary>
        /// 支持DML的语法 选择DML操作时，取值如下： i：INSERT。 u：UPDATE。 d：DELETE。 如该值为空，不增量迁移或同步DML操作。
        /// </summary>
        [JsonProperty("dml_operation", NullValueHandling = NullValueHandling.Ignore)]
        public string DmlOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_object_column_info", NullValueHandling = NullValueHandling.Ignore)]
        public DbObjectColumnInfo DbObjectColumnInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_or_table_rename_rule", NullValueHandling = NullValueHandling.Ignore)]
        public DbOrTableRenameRule DbOrTableRenameRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_object", NullValueHandling = NullValueHandling.Ignore)]
        public DbObject DbObject { get; set; }

        /// <summary>
        /// 表示该规则是否已同步至目标库
        /// </summary>
        [JsonProperty("is_synchronized", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSynchronized { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataProcessInfo {\n");
            sb.Append("  filterConditions: ").Append(FilterConditions).Append("\n");
            sb.Append("  isBatchProcess: ").Append(IsBatchProcess).Append("\n");
            sb.Append("  addColumns: ").Append(AddColumns).Append("\n");
            sb.Append("  ddlOperation: ").Append(DdlOperation).Append("\n");
            sb.Append("  dmlOperation: ").Append(DmlOperation).Append("\n");
            sb.Append("  dbObjectColumnInfo: ").Append(DbObjectColumnInfo).Append("\n");
            sb.Append("  dbOrTableRenameRule: ").Append(DbOrTableRenameRule).Append("\n");
            sb.Append("  dbObject: ").Append(DbObject).Append("\n");
            sb.Append("  isSynchronized: ").Append(IsSynchronized).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataProcessInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataProcessInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FilterConditions == input.FilterConditions ||
                    this.FilterConditions != null &&
                    input.FilterConditions != null &&
                    this.FilterConditions.SequenceEqual(input.FilterConditions)
                ) && 
                (
                    this.IsBatchProcess == input.IsBatchProcess ||
                    (this.IsBatchProcess != null &&
                    this.IsBatchProcess.Equals(input.IsBatchProcess))
                ) && 
                (
                    this.AddColumns == input.AddColumns ||
                    this.AddColumns != null &&
                    input.AddColumns != null &&
                    this.AddColumns.SequenceEqual(input.AddColumns)
                ) && 
                (
                    this.DdlOperation == input.DdlOperation ||
                    this.DdlOperation != null &&
                    input.DdlOperation != null &&
                    this.DdlOperation.SequenceEqual(input.DdlOperation)
                ) && 
                (
                    this.DmlOperation == input.DmlOperation ||
                    (this.DmlOperation != null &&
                    this.DmlOperation.Equals(input.DmlOperation))
                ) && 
                (
                    this.DbObjectColumnInfo == input.DbObjectColumnInfo ||
                    (this.DbObjectColumnInfo != null &&
                    this.DbObjectColumnInfo.Equals(input.DbObjectColumnInfo))
                ) && 
                (
                    this.DbOrTableRenameRule == input.DbOrTableRenameRule ||
                    (this.DbOrTableRenameRule != null &&
                    this.DbOrTableRenameRule.Equals(input.DbOrTableRenameRule))
                ) && 
                (
                    this.DbObject == input.DbObject ||
                    (this.DbObject != null &&
                    this.DbObject.Equals(input.DbObject))
                ) && 
                (
                    this.IsSynchronized == input.IsSynchronized ||
                    (this.IsSynchronized != null &&
                    this.IsSynchronized.Equals(input.IsSynchronized))
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
                if (this.FilterConditions != null)
                    hashCode = hashCode * 59 + this.FilterConditions.GetHashCode();
                if (this.IsBatchProcess != null)
                    hashCode = hashCode * 59 + this.IsBatchProcess.GetHashCode();
                if (this.AddColumns != null)
                    hashCode = hashCode * 59 + this.AddColumns.GetHashCode();
                if (this.DdlOperation != null)
                    hashCode = hashCode * 59 + this.DdlOperation.GetHashCode();
                if (this.DmlOperation != null)
                    hashCode = hashCode * 59 + this.DmlOperation.GetHashCode();
                if (this.DbObjectColumnInfo != null)
                    hashCode = hashCode * 59 + this.DbObjectColumnInfo.GetHashCode();
                if (this.DbOrTableRenameRule != null)
                    hashCode = hashCode * 59 + this.DbOrTableRenameRule.GetHashCode();
                if (this.DbObject != null)
                    hashCode = hashCode * 59 + this.DbObject.GetHashCode();
                if (this.IsSynchronized != null)
                    hashCode = hashCode * 59 + this.IsSynchronized.GetHashCode();
                return hashCode;
            }
        }
    }
}
