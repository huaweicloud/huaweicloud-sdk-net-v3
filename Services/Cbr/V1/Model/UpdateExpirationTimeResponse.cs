using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateExpirationTimeResponse : SdkResponse
    {

        /// <summary>
        /// 成功修改过期时间的备份数量。
        /// </summary>
        [JsonProperty("affected_backups_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AffectedBackupsCount { get; set; }

        /// <summary>
        /// 修改后的备份过期时间，格式：YYYY-MM-DD。
        /// </summary>
        [JsonProperty("new_expiration_day", NullValueHandling = NullValueHandling.Ignore)]
        public string NewExpirationDay { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("operation_log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationLogId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExpirationTimeResponse {\n");
            sb.Append("  affectedBackupsCount: ").Append(AffectedBackupsCount).Append("\n");
            sb.Append("  newExpirationDay: ").Append(NewExpirationDay).Append("\n");
            sb.Append("  operationLogId: ").Append(OperationLogId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateExpirationTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateExpirationTimeResponse input)
        {
            if (input == null) return false;
            if (this.AffectedBackupsCount != input.AffectedBackupsCount || (this.AffectedBackupsCount != null && !this.AffectedBackupsCount.Equals(input.AffectedBackupsCount))) return false;
            if (this.NewExpirationDay != input.NewExpirationDay || (this.NewExpirationDay != null && !this.NewExpirationDay.Equals(input.NewExpirationDay))) return false;
            if (this.OperationLogId != input.OperationLogId || (this.OperationLogId != null && !this.OperationLogId.Equals(input.OperationLogId))) return false;

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
                if (this.AffectedBackupsCount != null) hashCode = hashCode * 59 + this.AffectedBackupsCount.GetHashCode();
                if (this.NewExpirationDay != null) hashCode = hashCode * 59 + this.NewExpirationDay.GetHashCode();
                if (this.OperationLogId != null) hashCode = hashCode * 59 + this.OperationLogId.GetHashCode();
                return hashCode;
            }
        }
    }
}
