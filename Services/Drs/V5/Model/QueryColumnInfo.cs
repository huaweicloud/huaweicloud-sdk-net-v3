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
    /// 数据库列信息
    /// </summary>
    public class QueryColumnInfo 
    {

        /// <summary>
        /// 列名
        /// </summary>
        [JsonProperty("column_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnName { get; set; }

        /// <summary>
        /// 列类型
        /// </summary>
        [JsonProperty("column_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnType { get; set; }

        /// <summary>
        /// 主键或者唯一索引
        /// </summary>
        [JsonProperty("primary_key_or_unique_index", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryKeyOrUniqueIndex { get; set; }

        /// <summary>
        /// 列映射后的名称
        /// </summary>
        [JsonProperty("column_mapped_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnMappedName { get; set; }

        /// <summary>
        /// 该列是否过滤
        /// </summary>
        [JsonProperty("is_filtered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// 该列是否partitionKey
        /// </summary>
        [JsonProperty("is_partition_key", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPartitionKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryColumnInfo {\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("  columnType: ").Append(ColumnType).Append("\n");
            sb.Append("  primaryKeyOrUniqueIndex: ").Append(PrimaryKeyOrUniqueIndex).Append("\n");
            sb.Append("  columnMappedName: ").Append(ColumnMappedName).Append("\n");
            sb.Append("  isFiltered: ").Append(IsFiltered).Append("\n");
            sb.Append("  isPartitionKey: ").Append(IsPartitionKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryColumnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryColumnInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnName == input.ColumnName ||
                    (this.ColumnName != null &&
                    this.ColumnName.Equals(input.ColumnName))
                ) && 
                (
                    this.ColumnType == input.ColumnType ||
                    (this.ColumnType != null &&
                    this.ColumnType.Equals(input.ColumnType))
                ) && 
                (
                    this.PrimaryKeyOrUniqueIndex == input.PrimaryKeyOrUniqueIndex ||
                    (this.PrimaryKeyOrUniqueIndex != null &&
                    this.PrimaryKeyOrUniqueIndex.Equals(input.PrimaryKeyOrUniqueIndex))
                ) && 
                (
                    this.ColumnMappedName == input.ColumnMappedName ||
                    (this.ColumnMappedName != null &&
                    this.ColumnMappedName.Equals(input.ColumnMappedName))
                ) && 
                (
                    this.IsFiltered == input.IsFiltered ||
                    (this.IsFiltered != null &&
                    this.IsFiltered.Equals(input.IsFiltered))
                ) && 
                (
                    this.IsPartitionKey == input.IsPartitionKey ||
                    (this.IsPartitionKey != null &&
                    this.IsPartitionKey.Equals(input.IsPartitionKey))
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
                if (this.ColumnName != null)
                    hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                if (this.ColumnType != null)
                    hashCode = hashCode * 59 + this.ColumnType.GetHashCode();
                if (this.PrimaryKeyOrUniqueIndex != null)
                    hashCode = hashCode * 59 + this.PrimaryKeyOrUniqueIndex.GetHashCode();
                if (this.ColumnMappedName != null)
                    hashCode = hashCode * 59 + this.ColumnMappedName.GetHashCode();
                if (this.IsFiltered != null)
                    hashCode = hashCode * 59 + this.IsFiltered.GetHashCode();
                if (this.IsPartitionKey != null)
                    hashCode = hashCode * 59 + this.IsPartitionKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
