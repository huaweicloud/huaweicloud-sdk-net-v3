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
    /// 请求参数。
    /// </summary>
    public class CreateEventsRequestBody 
    {

        /// <summary>
        /// **参数解释**： 事件名称。 **约束限制**： 不涉及。 **取值范围**： 必须以字母开头，只能包含0-9/a-z/A-Z/_，长度为[1,64]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EventName { get; set; }

        /// <summary>
        /// **参数解释**： 事件来源。 **约束限制**： 不涉及。 **取值范围**： 格式为service.item，根据实际情况自定义配置。 service和item必须是字符串，必须以字母开头，只能包含0-9/a-z/A-Z/_，service.item，长度为[3,32]个字符。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("event_source", NullValueHandling = NullValueHandling.Ignore)]
        public string EventSource { get; set; }

        /// <summary>
        /// **参数解释**： 事件发生时间。UNIX时间戳，单位毫秒。 **约束限制**： 因为客户端到服务器端有延时，因此插入数据的时间戳应该在[当前时间-1小时+10秒，当前时间+10分钟-10秒]区间内，保证到达服务器时不会因为传输时延造成数据不能插入数据库。 **取值范围**： 插入数据的时间戳应该在[当前时间-1小时+10秒，当前时间+10分钟-10秒]区间内。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public EventItemDetail Detail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEventsRequestBody {\n");
            sb.Append("  eventName: ").Append(EventName).Append("\n");
            sb.Append("  eventSource: ").Append(EventSource).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEventsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEventsRequestBody input)
        {
            if (input == null) return false;
            if (this.EventName != input.EventName || (this.EventName != null && !this.EventName.Equals(input.EventName))) return false;
            if (this.EventSource != input.EventSource || (this.EventSource != null && !this.EventSource.Equals(input.EventSource))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Detail != input.Detail || (this.Detail != null && !this.Detail.Equals(input.Detail))) return false;

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
                if (this.EventSource != null) hashCode = hashCode * 59 + this.EventSource.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Detail != null) hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
