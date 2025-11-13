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
    public class ErrorTable 
    {

        /// <summary>
        /// **参数解释**：  Excel导入失败的对象信息。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入失败的数据库名。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入失败的表名。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入失败的行。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("row_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowNumber { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入失败的错误信息描述。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("full_description", NullValueHandling = NullValueHandling.Ignore)]
        public string FullDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorTable {\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  rowNumber: ").Append(RowNumber).Append("\n");
            sb.Append("  fullDescription: ").Append(FullDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorTable);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorTable input)
        {
            if (input == null) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.RowNumber != input.RowNumber || (this.RowNumber != null && !this.RowNumber.Equals(input.RowNumber))) return false;
            if (this.FullDescription != input.FullDescription || (this.FullDescription != null && !this.FullDescription.Equals(input.FullDescription))) return false;

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
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.RowNumber != null) hashCode = hashCode * 59 + this.RowNumber.GetHashCode();
                if (this.FullDescription != null) hashCode = hashCode * 59 + this.FullDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
