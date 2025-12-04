using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OperateEventReq 
    {

        /// <summary>
        /// **参数解释**：  事件列表  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("event_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<EventInstance> EventInstances { get; set; }

        /// <summary>
        /// **参数解释**：  事件操作类型：cancel|execute|reservation  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

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
            sb.Append("class OperateEventReq {\n");
            sb.Append("  eventInstances: ").Append(EventInstances).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  eventScheduleWindow: ").Append(EventScheduleWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateEventReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateEventReq input)
        {
            if (input == null) return false;
            if (this.EventInstances != input.EventInstances || (this.EventInstances != null && input.EventInstances != null && !this.EventInstances.SequenceEqual(input.EventInstances))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
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
                if (this.EventInstances != null) hashCode = hashCode * 59 + this.EventInstances.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.EventScheduleWindow != null) hashCode = hashCode * 59 + this.EventScheduleWindow.GetHashCode();
                return hashCode;
            }
        }
    }
}
