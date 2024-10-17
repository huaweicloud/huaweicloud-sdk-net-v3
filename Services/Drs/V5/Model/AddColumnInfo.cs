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
    public class AddColumnInfo 
    {

        /// <summary>
        /// 列类型
        /// </summary>
        [JsonProperty("column_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnType { get; set; }

        /// <summary>
        /// 列名称
        /// </summary>
        [JsonProperty("column_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnName { get; set; }

        /// <summary>
        /// 列填充值
        /// </summary>
        [JsonProperty("column_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnValue { get; set; }

        /// <summary>
        /// 填充列的数据类型
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddColumnInfo {\n");
            sb.Append("  columnType: ").Append(ColumnType).Append("\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("  columnValue: ").Append(ColumnValue).Append("\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddColumnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddColumnInfo input)
        {
            if (input == null) return false;
            if (this.ColumnType != input.ColumnType || (this.ColumnType != null && !this.ColumnType.Equals(input.ColumnType))) return false;
            if (this.ColumnName != input.ColumnName || (this.ColumnName != null && !this.ColumnName.Equals(input.ColumnName))) return false;
            if (this.ColumnValue != input.ColumnValue || (this.ColumnValue != null && !this.ColumnValue.Equals(input.ColumnValue))) return false;
            if (this.DataType != input.DataType || (this.DataType != null && !this.DataType.Equals(input.DataType))) return false;

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
                if (this.ColumnName != null) hashCode = hashCode * 59 + this.ColumnName.GetHashCode();
                if (this.ColumnValue != null) hashCode = hashCode * 59 + this.ColumnValue.GetHashCode();
                if (this.DataType != null) hashCode = hashCode * 59 + this.DataType.GetHashCode();
                return hashCode;
            }
        }
    }
}
