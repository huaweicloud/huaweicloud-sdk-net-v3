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
    public class CancelColdTableWaitingTasksReq 
    {

        /// <summary>
        /// **参数解释**：  取消目标列表。  **约束限制**：  列表长度不超过50。
        /// </summary>
        [JsonProperty("cancel_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<CancelColdTableWaitingTask> CancelTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelColdTableWaitingTasksReq {\n");
            sb.Append("  cancelTasks: ").Append(CancelTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelColdTableWaitingTasksReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelColdTableWaitingTasksReq input)
        {
            if (input == null) return false;
            if (this.CancelTasks != input.CancelTasks || (this.CancelTasks != null && input.CancelTasks != null && !this.CancelTasks.SequenceEqual(input.CancelTasks))) return false;

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
                if (this.CancelTasks != null) hashCode = hashCode * 59 + this.CancelTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
