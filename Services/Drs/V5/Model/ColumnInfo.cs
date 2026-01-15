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
    /// 列信息
    /// </summary>
    public class ColumnInfo 
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
        /// 列的键类型。
        /// </summary>
        [JsonProperty("key_type", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyType { get; set; }

        /// <summary>
        /// 列映射后的名称
        /// </summary>
        [JsonProperty("column_mapped_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnMappedName { get; set; }

        /// <summary>
        /// 该列是否过滤
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status { get; set; }

        /// <summary>
        /// 该列是否partitionKey
        /// </summary>
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partition { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnInfo {\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("  columnType: ").Append(ColumnType).Append("\n");
            sb.Append("  keyType: ").Append(KeyType).Append("\n");
            sb.Append("  columnMappedName: ").Append(ColumnMappedName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColumnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColumnInfo input)
        {
            if (input == null) return false;
            if (this.ColumnName != input.ColumnName || (this.ColumnName != null && !this.ColumnName.Equals(input.ColumnName))) return false;
            if (this.ColumnType != input.ColumnType || (this.ColumnType != null && !this.ColumnType.Equals(input.ColumnType))) return false;
            if (this.KeyType != input.KeyType || (this.KeyType != null && !this.KeyType.Equals(input.KeyType))) return false;
            if (this.ColumnMappedName != input.ColumnMappedName || (this.ColumnMappedName != null && !this.ColumnMappedName.Equals(input.ColumnMappedName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;

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
                if (this.ColumnType != null) hashCode = hashCode * 59 + this.ColumnType.GetHashCode();
                if (this.KeyType != null) hashCode = hashCode * 59 + this.KeyType.GetHashCode();
                if (this.ColumnMappedName != null) hashCode = hashCode * 59 + this.ColumnMappedName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                return hashCode;
            }
        }
    }
}
