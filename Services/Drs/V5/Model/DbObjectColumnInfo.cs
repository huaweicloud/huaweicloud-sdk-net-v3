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
    /// 列加工对象 约束： 列加工提供列级的查询、映射和过滤能力。 编辑列名后，目标数据库的列名为修改后的名称。 列映射名不能和原列名或已存在的映射名相同。 不支持库名、表名带有换行符的列进行映射。 任务再编辑时，已经同步的表不支持修改列信息。 只有勾选的列才会被同步。 MySQL-&gt;MySQL、MySQL-&gt;GaussDB(for MySQL)不支持分区表的分区字段进行列映射。 GaussDB分区键不可以被过滤。
    /// </summary>
    public class DbObjectColumnInfo 
    {

        /// <summary>
        /// 数据库库名称。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 数据库schema名称。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 数据库表名称。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 数据库列信息。
        /// </summary>
        [JsonProperty("column_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryColumnInfo> ColumnInfos { get; set; }

        /// <summary>
        /// 数据库列信息总数，与分页无关，仅作为返回体参数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbObjectColumnInfo {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  columnInfos: ").Append(ColumnInfos).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbObjectColumnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbObjectColumnInfo input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.ColumnInfos != input.ColumnInfos || (this.ColumnInfos != null && input.ColumnInfos != null && !this.ColumnInfos.SequenceEqual(input.ColumnInfos))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.ColumnInfos != null) hashCode = hashCode * 59 + this.ColumnInfos.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
