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
    /// 数据过滤高级设置信息体
    /// </summary>
    public class DataFilteringAdvancedSetting 
    {

        /// <summary>
        /// 库名
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        [JsonProperty("col_names", NullValueHandling = NullValueHandling.Ignore)]
        public string ColNames { get; set; }

        /// <summary>
        /// 主键或唯一索引
        /// </summary>
        [JsonProperty("prim_key_or_indexes", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimKeyOrIndexes { get; set; }

        /// <summary>
        /// 优化查询所需的索引
        /// </summary>
        [JsonProperty("indexes", NullValueHandling = NullValueHandling.Ignore)]
        public string Indexes { get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public string Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFilteringAdvancedSetting {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  colNames: ").Append(ColNames).Append("\n");
            sb.Append("  primKeyOrIndexes: ").Append(PrimKeyOrIndexes).Append("\n");
            sb.Append("  indexes: ").Append(Indexes).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataFilteringAdvancedSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataFilteringAdvancedSetting input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.ColNames != input.ColNames || (this.ColNames != null && !this.ColNames.Equals(input.ColNames))) return false;
            if (this.PrimKeyOrIndexes != input.PrimKeyOrIndexes || (this.PrimKeyOrIndexes != null && !this.PrimKeyOrIndexes.Equals(input.PrimKeyOrIndexes))) return false;
            if (this.Indexes != input.Indexes || (this.Indexes != null && !this.Indexes.Equals(input.Indexes))) return false;
            if (this.Values != input.Values || (this.Values != null && !this.Values.Equals(input.Values))) return false;

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
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.ColNames != null) hashCode = hashCode * 59 + this.ColNames.GetHashCode();
                if (this.PrimKeyOrIndexes != null) hashCode = hashCode * 59 + this.PrimKeyOrIndexes.GetHashCode();
                if (this.Indexes != null) hashCode = hashCode * 59 + this.Indexes.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
