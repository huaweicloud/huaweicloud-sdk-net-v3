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
    public class SuccessTable 
    {

        /// <summary>
        /// **参数解释**：  Excel导入成功的数据库名。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入成功的表名。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入成功的表配置。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigName { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入成功的行数。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("row_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowNumber { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入成功的表全名。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("full_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullTableName { get; set; }

        /// <summary>
        /// **参数解释**：  Excel信息是否合规。   **取值范围**：  - true：校验结果合规。 - false：校验结果不合规。
        /// </summary>
        [JsonProperty("valid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Valid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuccessTable {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("  rowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  fullTableName: ").Append(FullTableName).Append("\n");
            sb.Append("  valid: ").Append(Valid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SuccessTable);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SuccessTable input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.ConfigName != input.ConfigName || (this.ConfigName != null && !this.ConfigName.Equals(input.ConfigName))) return false;
            if (this.RowNumber != input.RowNumber || (this.RowNumber != null && !this.RowNumber.Equals(input.RowNumber))) return false;
            if (this.FullTableName != input.FullTableName || (this.FullTableName != null && !this.FullTableName.Equals(input.FullTableName))) return false;
            if (this.Valid != input.Valid || (this.Valid != null && !this.Valid.Equals(input.Valid))) return false;

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
                if (this.ConfigName != null) hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.RowNumber != null) hashCode = hashCode * 59 + this.RowNumber.GetHashCode();
                if (this.FullTableName != null) hashCode = hashCode * 59 + this.FullTableName.GetHashCode();
                if (this.Valid != null) hashCode = hashCode * 59 + this.Valid.GetHashCode();
                return hashCode;
            }
        }
    }
}
