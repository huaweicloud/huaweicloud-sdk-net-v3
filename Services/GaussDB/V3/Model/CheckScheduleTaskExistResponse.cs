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
    public class CheckScheduleTaskExistResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  定时任务类型是否存在。 **取值范围**： - true：指定的定时任务类型已存在。 - false：指定的定时任务类型不存在。
        /// </summary>
        [JsonProperty("exist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exist { get; set; }

        /// <summary>
        /// **参数解释**：  定时任务详情列表。当 &#x60;exist&#x60; 为 true 时，此列表包含已存在的任务信息。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("scheduled_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduledTaskV3> ScheduledTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckScheduleTaskExistResponse {\n");
            sb.Append("  exist: ").Append(Exist).Append("\n");
            sb.Append("  scheduledTasks: ").Append(ScheduledTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckScheduleTaskExistResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckScheduleTaskExistResponse input)
        {
            if (input == null) return false;
            if (this.Exist != input.Exist || (this.Exist != null && !this.Exist.Equals(input.Exist))) return false;
            if (this.ScheduledTasks != input.ScheduledTasks || (this.ScheduledTasks != null && input.ScheduledTasks != null && !this.ScheduledTasks.SequenceEqual(input.ScheduledTasks))) return false;

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
                if (this.Exist != null) hashCode = hashCode * 59 + this.Exist.GetHashCode();
                if (this.ScheduledTasks != null) hashCode = hashCode * 59 + this.ScheduledTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
