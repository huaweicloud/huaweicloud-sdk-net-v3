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
    /// Response Object
    /// </summary>
    public class UploadImportExcelTemplateResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  Excel导入返回状态。  **取值范围**：  - true: 导入成功。 - false： 导入失败。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// **参数解释**：  已处理的行数。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("processed_rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProcessedRows { get; set; }

        /// <summary>
        /// **参数解释**：  导入失败返回的错误列表。 
        /// </summary>
        [JsonProperty("error_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorTable> ErrorTables { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入验证成功的列表。 
        /// </summary>
        [JsonProperty("success_tables", NullValueHandling = NullValueHandling.Ignore)]
        public List<SuccessTable> SuccessTables { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入验证失败的行数。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("error_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// **参数解释**：  Excel导入验证成功的行数。   **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadImportExcelTemplateResponse {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  processedRows: ").Append(ProcessedRows).Append("\n");
            sb.Append("  errorTables: ").Append(ErrorTables).Append("\n");
            sb.Append("  successTables: ").Append(SuccessTables).Append("\n");
            sb.Append("  errorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadImportExcelTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadImportExcelTemplateResponse input)
        {
            if (input == null) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;
            if (this.ProcessedRows != input.ProcessedRows || (this.ProcessedRows != null && !this.ProcessedRows.Equals(input.ProcessedRows))) return false;
            if (this.ErrorTables != input.ErrorTables || (this.ErrorTables != null && input.ErrorTables != null && !this.ErrorTables.SequenceEqual(input.ErrorTables))) return false;
            if (this.SuccessTables != input.SuccessTables || (this.SuccessTables != null && input.SuccessTables != null && !this.SuccessTables.SequenceEqual(input.SuccessTables))) return false;
            if (this.ErrorCount != input.ErrorCount || (this.ErrorCount != null && !this.ErrorCount.Equals(input.ErrorCount))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;

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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.ProcessedRows != null) hashCode = hashCode * 59 + this.ProcessedRows.GetHashCode();
                if (this.ErrorTables != null) hashCode = hashCode * 59 + this.ErrorTables.GetHashCode();
                if (this.SuccessTables != null) hashCode = hashCode * 59 + this.SuccessTables.GetHashCode();
                if (this.ErrorCount != null) hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
