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
    /// **参数解释**：  设置事件执行策略参数体。  **约束限制**：  不涉及。
    /// </summary>
    public class SetInstanceScheduleEventsRequestBody 
    {

        /// <summary>
        /// **参数解释**：  事件操作类型。  **约束限制**：  不涉及。  **取值范围**：  - execute：授权立即执行。 - cancel：授权取消执行。 - reservation：授权预约执行。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// **参数解释**：  事件信息。  **约束限制**：  批量事件个数不得超过20个。
        /// </summary>
        [JsonProperty("event_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventInstances> EventInstances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("event_schedule_window", NullValueHandling = NullValueHandling.Ignore)]
        public EventScheduleWindow EventScheduleWindow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetInstanceScheduleEventsRequestBody {\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  eventInstances: ").Append(EventInstances).Append("\n");
            sb.Append("  eventScheduleWindow: ").Append(EventScheduleWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetInstanceScheduleEventsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetInstanceScheduleEventsRequestBody input)
        {
            if (input == null) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.EventInstances != input.EventInstances || (this.EventInstances != null && input.EventInstances != null && !this.EventInstances.SequenceEqual(input.EventInstances))) return false;
            if (this.EventScheduleWindow != input.EventScheduleWindow || (this.EventScheduleWindow != null && !this.EventScheduleWindow.Equals(input.EventScheduleWindow))) return false;

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
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.EventInstances != null) hashCode = hashCode * 59 + this.EventInstances.GetHashCode();
                if (this.EventScheduleWindow != null) hashCode = hashCode * 59 + this.EventScheduleWindow.GetHashCode();
                return hashCode;
            }
        }
    }
}
