using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 事件描述信息。
    /// </summary>
    public class EventModel 
    {

        /// <summary>
        /// **参数描述**：API版本。 **取值范围**：可选值如下： - v1
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// **参数描述**：资源类型。 **取值范围**：可选值如下： - Event：事件
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// **参数描述**：事件类型。 **取值范围**：可选值如下： - Normal：正常 - Warning：异常
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数描述**：事件第一次出现时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("firstTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstTimestamp { get; set; }

        /// <summary>
        /// **参数描述**：事件最后一次出现时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("lastTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTimestamp { get; set; }

        /// <summary>
        /// **参数描述**：事件连续出现次数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数描述**：事件产生的原因。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数描述**：事件详细信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventModel {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  firstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  lastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventModel input)
        {
            if (input == null) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.FirstTimestamp != input.FirstTimestamp || (this.FirstTimestamp != null && !this.FirstTimestamp.Equals(input.FirstTimestamp))) return false;
            if (this.LastTimestamp != input.LastTimestamp || (this.LastTimestamp != null && !this.LastTimestamp.Equals(input.LastTimestamp))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FirstTimestamp != null) hashCode = hashCode * 59 + this.FirstTimestamp.GetHashCode();
                if (this.LastTimestamp != null) hashCode = hashCode * 59 + this.LastTimestamp.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
