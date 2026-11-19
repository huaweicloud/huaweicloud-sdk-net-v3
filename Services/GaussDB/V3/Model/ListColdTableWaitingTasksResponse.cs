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
    public class ListColdTableWaitingTasksResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  任务总数。  **取值范围**：  非负整数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**：  冷热分离待下发任务列表，没有任务时默认为空数组。
        /// </summary>
        [JsonProperty("waiting_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColdTableWaitingTask> WaitingTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListColdTableWaitingTasksResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  waitingTasks: ").Append(WaitingTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListColdTableWaitingTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListColdTableWaitingTasksResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.WaitingTasks != input.WaitingTasks || (this.WaitingTasks != null && input.WaitingTasks != null && !this.WaitingTasks.SequenceEqual(input.WaitingTasks))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.WaitingTasks != null) hashCode = hashCode * 59 + this.WaitingTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
