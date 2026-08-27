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
    /// **参数解释**：  单个无锁变更任务信息。  **取值范围**：  不涉及。
    /// </summary>
    public class RecordItem 
    {

        /// <summary>
        /// **参数解释**：  无锁变更任务记录标识。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务详细内容。
        /// </summary>
        [JsonProperty("task_content", NullValueHandling = NullValueHandling.Ignore)]
        public List<OnlineDDLTaskContentItem> TaskContent { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务创建时间，13位毫秒时间戳。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务结束时间，13位毫秒时间戳。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ended_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndedAt { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务执行状态。  **取值范围**：   - checking：表示正在执行预检查步骤。   - check successful： 表示预检查步骤执行成功。   - check failed： 表示预检查步骤执行失败。   - altering： 表示正在任务正在执行变更步骤。   - alter successful： 表示变更步骤执行成功。   - alter failed： 表示变更步骤执行失败。   - stopping：表示正在执行停止任务步骤。   - stop successful： 表示执行停止步骤成功。   - stop failed： 表示执行停止步骤失败。   - cleaning： 表示正在执行清理临时表步骤。   - clean successful： 表示清理临时表步骤执行成功。   - clean failed： 表示清理临时表步骤执行失败。
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// **参数解释**：  表示数据库内核层面无锁变更任务运行阶段。  **取值范围**：   - 0：表示无锁变更任务未开始。  - 1：表示无锁变更任务已完成资源初始化。  - 2：表示无锁变更任务正在运行。  - 3：表示无锁变更任务已完成。
        /// </summary>
        [JsonProperty("alter_stage", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlterStage { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务百分比进度，1位小数精度。  **取值范围**：  0.0-100.0。
        /// </summary>
        [JsonProperty("percentage", NullValueHandling = NullValueHandling.Ignore)]
        public float? Percentage { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务失败原因，任务执行失败时有返回值。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("error_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务临时表名称，关闭临时表自动清理时有返回值。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("temp_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TempTableName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordItem {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskContent: ").Append(TaskContent).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  endedAt: ").Append(EndedAt).Append("\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  alterStage: ").Append(AlterStage).Append("\n");
            sb.Append("  percentage: ").Append(Percentage).Append("\n");
            sb.Append("  errorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  tempTableName: ").Append(TempTableName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordItem input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskContent != input.TaskContent || (this.TaskContent != null && input.TaskContent != null && !this.TaskContent.SequenceEqual(input.TaskContent))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.EndedAt != input.EndedAt || (this.EndedAt != null && !this.EndedAt.Equals(input.EndedAt))) return false;
            if (this.TaskStatus != input.TaskStatus || (this.TaskStatus != null && !this.TaskStatus.Equals(input.TaskStatus))) return false;
            if (this.AlterStage != input.AlterStage || (this.AlterStage != null && !this.AlterStage.Equals(input.AlterStage))) return false;
            if (this.Percentage != input.Percentage || (this.Percentage != null && !this.Percentage.Equals(input.Percentage))) return false;
            if (this.ErrorReason != input.ErrorReason || (this.ErrorReason != null && !this.ErrorReason.Equals(input.ErrorReason))) return false;
            if (this.TempTableName != input.TempTableName || (this.TempTableName != null && !this.TempTableName.Equals(input.TempTableName))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskContent != null) hashCode = hashCode * 59 + this.TaskContent.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EndedAt != null) hashCode = hashCode * 59 + this.EndedAt.GetHashCode();
                if (this.TaskStatus != null) hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.AlterStage != null) hashCode = hashCode * 59 + this.AlterStage.GetHashCode();
                if (this.Percentage != null) hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                if (this.ErrorReason != null) hashCode = hashCode * 59 + this.ErrorReason.GetHashCode();
                if (this.TempTableName != null) hashCode = hashCode * 59 + this.TempTableName.GetHashCode();
                return hashCode;
            }
        }
    }
}
