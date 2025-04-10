using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EventResponseSource 
    {

        /// <summary>
        /// 计划事件来源类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 主机计划事件ID
        /// </summary>
        [JsonProperty("host_scheduled_event_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostScheduledEventId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventResponseSource {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  hostScheduledEventId: ").Append(HostScheduledEventId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventResponseSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventResponseSource input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.HostScheduledEventId != input.HostScheduledEventId || (this.HostScheduledEventId != null && !this.HostScheduledEventId.Equals(input.HostScheduledEventId))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HostScheduledEventId != null) hashCode = hashCode * 59 + this.HostScheduledEventId.GetHashCode();
                return hashCode;
            }
        }
    }
}
