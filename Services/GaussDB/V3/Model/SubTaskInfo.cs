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
    /// 子任务信息。
    /// </summary>
    public class SubTaskInfo 
    {

        /// <summary>
        /// **参数解释**：  子任务名。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("sub_task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubTaskName { get; set; }

        /// <summary>
        /// **参数解释**：  子任务进度百分比。  **取值范围**：  0-100。
        /// </summary>
        [JsonProperty("percent", NullValueHandling = NullValueHandling.Ignore)]
        public string Percent { get; set; }

        /// <summary>
        /// **参数解释**：  子任务状态。  **取值范围**：  - Pending：表示待执行。 - Running：表示运行中。 - Completed：表示已完成。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：  剩余时间，单位为秒。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTaskInfo {\n");
            sb.Append("  subTaskName: ").Append(SubTaskName).Append("\n");
            sb.Append("  percent: ").Append(Percent).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  remainingTime: ").Append(RemainingTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubTaskInfo input)
        {
            if (input == null) return false;
            if (this.SubTaskName != input.SubTaskName || (this.SubTaskName != null && !this.SubTaskName.Equals(input.SubTaskName))) return false;
            if (this.Percent != input.Percent || (this.Percent != null && !this.Percent.Equals(input.Percent))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RemainingTime != input.RemainingTime || (this.RemainingTime != null && !this.RemainingTime.Equals(input.RemainingTime))) return false;

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
                if (this.SubTaskName != null) hashCode = hashCode * 59 + this.SubTaskName.GetHashCode();
                if (this.Percent != null) hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RemainingTime != null) hashCode = hashCode * 59 + this.RemainingTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
