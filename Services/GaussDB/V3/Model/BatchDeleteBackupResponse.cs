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
    public class BatchDeleteBackupResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  备份删除异常信息。  **取值范围**：  当所有备份删除成功，该值是空。
        /// </summary>
        [JsonProperty("failed_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<DeleteBackupResult> FailedResults { get; set; }

        /// <summary>
        /// **参数解释**：  删除成功的数量。  **取值范围**：  0-50。
        /// </summary>
        [JsonProperty("success_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// **参数解释**：  删除失败的数量。  **取值范围**：  0-50。
        /// </summary>
        [JsonProperty("failed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteBackupResponse {\n");
            sb.Append("  failedResults: ").Append(FailedResults).Append("\n");
            sb.Append("  successCount: ").Append(SuccessCount).Append("\n");
            sb.Append("  failedCount: ").Append(FailedCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteBackupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteBackupResponse input)
        {
            if (input == null) return false;
            if (this.FailedResults != input.FailedResults || (this.FailedResults != null && input.FailedResults != null && !this.FailedResults.SequenceEqual(input.FailedResults))) return false;
            if (this.SuccessCount != input.SuccessCount || (this.SuccessCount != null && !this.SuccessCount.Equals(input.SuccessCount))) return false;
            if (this.FailedCount != input.FailedCount || (this.FailedCount != null && !this.FailedCount.Equals(input.FailedCount))) return false;

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
                if (this.FailedResults != null) hashCode = hashCode * 59 + this.FailedResults.GetHashCode();
                if (this.SuccessCount != null) hashCode = hashCode * 59 + this.SuccessCount.GetHashCode();
                if (this.FailedCount != null) hashCode = hashCode * 59 + this.FailedCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
