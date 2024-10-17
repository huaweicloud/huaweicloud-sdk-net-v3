using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 一条事件监控信息
    /// </summary>
    public class EventInfo 
    {

        /// <summary>
        /// 事件名称。
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// 事件类型。
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// 选择查询的时间范围内，此事件发生的数量。
        /// </summary>
        [JsonProperty("event_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventCount { get; set; }

        /// <summary>
        /// 此事件最近一次发生的时间。
        /// </summary>
        [JsonProperty("latest_occur_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestOccurTime { get; set; }

        /// <summary>
        /// 事件来源，如果是系统事件则值为各服务的命名空间，各服务的命名空间可查看：“[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”；如果是自定义事件，则为用户自定义上报定义。
        /// </summary>
        [JsonProperty("latest_event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestEventSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventInfo {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  eventCount: ").Append(EventCount).Append("\n");
            sb.Append("  latestOccurTime: ").Append(LatestOccurTime).Append("\n");
            sb.Append("  latestEventSource: ").Append(LatestEventSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventInfo input)
        {
            if (input == null) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.EventCount != input.EventCount || (this.EventCount != null && !this.EventCount.Equals(input.EventCount))) return false;
            if (this.LatestOccurTime != input.LatestOccurTime || (this.LatestOccurTime != null && !this.LatestOccurTime.Equals(input.LatestOccurTime))) return false;
            if (this.LatestEventSource != input.LatestEventSource || (this.LatestEventSource != null && !this.LatestEventSource.Equals(input.LatestEventSource))) return false;

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
                if (this.EventName != null) hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.EventCount != null) hashCode = hashCode * 59 + this.EventCount.GetHashCode();
                if (this.LatestOccurTime != null) hashCode = hashCode * 59 + this.LatestOccurTime.GetHashCode();
                if (this.LatestEventSource != null) hashCode = hashCode * 59 + this.LatestEventSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
