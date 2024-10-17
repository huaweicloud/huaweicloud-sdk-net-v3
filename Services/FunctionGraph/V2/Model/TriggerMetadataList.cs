using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TriggerMetadataList 
    {

        /// <summary>
        /// 触发名称
        /// </summary>
        [JsonProperty("trigger_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// 触发器类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 事件数据
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public string EventData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerMetadataList {\n");
            sb.Append("  triggerName: ").Append(TriggerName).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventData: ").Append(EventData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriggerMetadataList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerMetadataList input)
        {
            if (input == null) return false;
            if (this.TriggerName != input.TriggerName || (this.TriggerName != null && !this.TriggerName.Equals(input.TriggerName))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.EventData != input.EventData || (this.EventData != null && !this.EventData.Equals(input.EventData))) return false;

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
                if (this.TriggerName != null) hashCode = hashCode * 59 + this.TriggerName.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventData != null) hashCode = hashCode * 59 + this.EventData.GetHashCode();
                return hashCode;
            }
        }
    }
}
