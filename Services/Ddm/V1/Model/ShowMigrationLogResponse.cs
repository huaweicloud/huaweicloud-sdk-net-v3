using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMigrationLogResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  分片变更任务日志的集合。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("task_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskLogsVO> TaskLogs { get; set; }

        /// <summary>
        /// **参数解释**：  当前页。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("cur_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurPage { get; set; }

        /// <summary>
        /// **参数解释**：  每页条数。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// **参数解释**：  总量。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMigrationLogResponse {\n");
            sb.Append("  taskLogs: ").Append(TaskLogs).Append("\n");
            sb.Append("  curPage: ").Append(CurPage).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMigrationLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMigrationLogResponse input)
        {
            if (input == null) return false;
            if (this.TaskLogs != input.TaskLogs || (this.TaskLogs != null && input.TaskLogs != null && !this.TaskLogs.SequenceEqual(input.TaskLogs))) return false;
            if (this.CurPage != input.CurPage || (this.CurPage != null && !this.CurPage.Equals(input.CurPage))) return false;
            if (this.PerPage != input.PerPage || (this.PerPage != null && !this.PerPage.Equals(input.PerPage))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.TaskLogs != null) hashCode = hashCode * 59 + this.TaskLogs.GetHashCode();
                if (this.CurPage != null) hashCode = hashCode * 59 + this.CurPage.GetHashCode();
                if (this.PerPage != null) hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
