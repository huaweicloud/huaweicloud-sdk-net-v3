using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 数据库的列和流转数据的对应关系。
    /// </summary>
    public class ColumnMapping 
    {

        /// <summary>
        /// **参数说明**：数据库的列名
        /// </summary>
        [JsonProperty("column_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnName { get; set; }

        /// <summary>
        /// **参数说明**：流转数据的属性名
        /// </summary>
        [JsonProperty("json_key", NullValueHandling = NullValueHandling.Ignore)]
        public string JsonKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ColumnMapping {\n");
            sb.Append("  columnName: ").Append(ColumnName).Append("\n");
            sb.Append("  jsonKey: ").Append(JsonKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ColumnMapping);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ColumnMapping input)
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
                    this.JsonKey == input.JsonKey ||
                    (this.JsonKey != null &&
                    this.JsonKey.Equals(input.JsonKey))
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
                if (this.JsonKey != null)
                    hashCode = hashCode * 59 + this.JsonKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
