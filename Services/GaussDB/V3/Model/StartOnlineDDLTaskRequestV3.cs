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
    /// **参数解释**：  开启无锁变更任务请求体。
    /// </summary>
    public class StartOnlineDDLTaskRequestV3 
    {

        /// <summary>
        /// **参数解释**：  是否开启自动清理临时表。  **约束限制**：  不涉及。  **取值范围**： - true：开启自动清理临时表。 - false：关闭自动清理临时表。  **默认取值**：  false。
        /// </summary>
        [JsonProperty("auto_clear", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoClear { get; set; }

        /// <summary>
        /// **参数解释**：  无锁变更任务详细内容。  **约束限制**：  不涉及。
        /// </summary>
        [JsonProperty("task_content", NullValueHandling = NullValueHandling.Ignore)]
        public List<StartOnlineTaskContentItem> TaskContent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartOnlineDDLTaskRequestV3 {\n");
            sb.Append("  autoClear: ").Append(AutoClear).Append("\n");
            sb.Append("  taskContent: ").Append(TaskContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartOnlineDDLTaskRequestV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartOnlineDDLTaskRequestV3 input)
        {
            if (input == null) return false;
            if (this.AutoClear != input.AutoClear || (this.AutoClear != null && !this.AutoClear.Equals(input.AutoClear))) return false;
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
                if (this.AutoClear != null) hashCode = hashCode * 59 + this.AutoClear.GetHashCode();
                if (this.TaskContent != null) hashCode = hashCode * 59 + this.TaskContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
