using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Metadata 
    {

        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventId { get; set; }

        /// <summary>
        /// 告警级别
        /// </summary>
        [JsonProperty("event_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSeverity { get; set; }

        /// <summary>
        /// 告警名称
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 日志组/流名称
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 告警源
        /// </summary>
        [JsonProperty("resource_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// 告警规则类型(SQL/关键词)
        /// </summary>
        [JsonProperty("lts_alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsAlarmType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Metadata {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventId: ").Append(EventId).Append("\n");
            sb.Append("  eventSeverity: ").Append(EventSeverity).Append("\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceProvider: ").Append(ResourceProvider).Append("\n");
            sb.Append("  ltsAlarmType: ").Append(LtsAlarmType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Metadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Metadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.EventSeverity == input.EventSeverity ||
                    (this.EventSeverity != null &&
                    this.EventSeverity.Equals(input.EventSeverity))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceProvider == input.ResourceProvider ||
                    (this.ResourceProvider != null &&
                    this.ResourceProvider.Equals(input.ResourceProvider))
                ) && 
                (
                    this.LtsAlarmType == input.LtsAlarmType ||
                    (this.LtsAlarmType != null &&
                    this.LtsAlarmType.Equals(input.LtsAlarmType))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventId != null)
                    hashCode = hashCode * 59 + this.EventId.GetHashCode();
                if (this.EventSeverity != null)
                    hashCode = hashCode * 59 + this.EventSeverity.GetHashCode();
                if (this.EventName != null)
                    hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceProvider != null)
                    hashCode = hashCode * 59 + this.ResourceProvider.GetHashCode();
                if (this.LtsAlarmType != null)
                    hashCode = hashCode * 59 + this.LtsAlarmType.GetHashCode();
                return hashCode;
            }
        }
    }
}
