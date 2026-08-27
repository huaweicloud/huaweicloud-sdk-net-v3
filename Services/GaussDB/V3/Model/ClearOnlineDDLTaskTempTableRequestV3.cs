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
    /// **参数解释**：  清理实例无锁变更任务临时表请求体。
    /// </summary>
    public class ClearOnlineDDLTaskTempTableRequestV3 
    {

        /// <summary>
        /// **参数解释**：   无锁变更任务唯一标识。  获取方法参见[查询无锁变更任务记录列表](https://support.huaweicloud.com/api-taurusdb/ListOnlineDdlTaskRecords.html)。   **约束限制**：   不涉及。   **取值范围**：   不涉及。  **默认取值**：   不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务详细内容，包含目标数据库和临时表名。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("task_content", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskContentItem> TaskContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClearOnlineDDLTaskTempTableRequestV3 {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskContent: ").Append(TaskContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClearOnlineDDLTaskTempTableRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClearOnlineDDLTaskTempTableRequestV3 input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskContent != input.TaskContent || (this.TaskContent != null && input.TaskContent != null && !this.TaskContent.SequenceEqual(input.TaskContent))) return false;

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
                return hashCode;
            }
        }
    }
}
