using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TableMetaInfo 
    {

        /// <summary>
        /// 列的数据类型
        /// </summary>
        [JsonProperty("column_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnType { get; set; }

        /// <summary>
        /// 额外的信息，例如是否是自动递增列
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public string Extra { get; set; }

        /// <summary>
        /// 是否允许为NULL
        /// </summary>
        [JsonProperty("is_nullable", NullValueHandling = NullValueHandling.Ignore)]
        public string IsNullable { get; set; }

        /// <summary>
        /// 列的默认值
        /// </summary>
        [JsonProperty("column_default", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnDefault { get; set; }

        /// <summary>
        /// 是否是索引列
        /// </summary>
        [JsonProperty("column_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnKey { get; set; }

        /// <summary>
        /// 列名
        /// </summary>
        [JsonProperty("column_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableMetaInfo {\n");
            sb.Append("  columnType: ").Append(ColumnType).Append("\n");
            sb.Append("  extra: ").Append(Extra).Append("\n");
            sb.Append("  isNullable: ").Append(IsNullable).Append("\n");
            sb.Append("  columnDefault: ").Append(ColumnDefault).Append("\n");
            sb.Append("  columnKey: ").Append(ColumnKey).Append("\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TableMetaInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TableMetaInfo input)
        {
            if (input == null) return false;
            if (this.ColumnType != input.ColumnType || (this.ColumnType != null && !this.ColumnType.Equals(input.ColumnType))) return false;
            if (this.Extra != input.Extra || (this.Extra != null && !this.Extra.Equals(input.Extra))) return false;
            if (this.IsNullable != input.IsNullable || (this.IsNullable != null && !this.IsNullable.Equals(input.IsNullable))) return false;
            if (this.ColumnDefault != input.ColumnDefault || (this.ColumnDefault != null && !this.ColumnDefault.Equals(input.ColumnDefault))) return false;
            if (this.ColumnKey != input.ColumnKey || (this.ColumnKey != null && !this.ColumnKey.Equals(input.ColumnKey))) return false;
            if (this.ColumnName != input.ColumnName || (this.ColumnName != null && !this.ColumnName.Equals(input.ColumnName))) return false;

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
                if (this.ColumnType != null) hashCode = hashCode * 59 + this.ColumnType.GetHashCode();
                if (this.Extra != null) hashCode = hashCode * 59 + this.Extra.GetHashCode();
                if (this.IsNullable != null) hashCode = hashCode * 59 + this.IsNullable.GetHashCode();
                if (this.ColumnDefault != null) hashCode = hashCode * 59 + this.ColumnDefault.GetHashCode();
                if (this.ColumnKey != null) hashCode = hashCode * 59 + this.ColumnKey.GetHashCode();
                if (this.ColumnName != null) hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                return hashCode;
            }
        }
    }
}
