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
    /// 
    /// </summary>
    public class ServicePodEventResponse 
    {

        /// <summary>
        /// **参数解释：** 事件发生次数。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释：** 首次发生时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("first_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FirstTimestamp { get; set; }

        /// <summary>
        /// **参数解释：** 最近发生时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastTimestamp { get; set; }

        /// <summary>
        /// **参数解释：** 事件信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释：** 事件名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数解释：** 上报该事件的k8s组件名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("reporting_component", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportingComponent { get; set; }

        /// <summary>
        /// **参数解释：** 事件类型。 **取值范围：** Normal/Warning。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePodEventResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  firstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  lastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  reportingComponent: ").Append(ReportingComponent).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServicePodEventResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServicePodEventResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.FirstTimestamp != input.FirstTimestamp || (this.FirstTimestamp != null && !this.FirstTimestamp.Equals(input.FirstTimestamp))) return false;
            if (this.LastTimestamp != input.LastTimestamp || (this.LastTimestamp != null && !this.LastTimestamp.Equals(input.LastTimestamp))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.ReportingComponent != input.ReportingComponent || (this.ReportingComponent != null && !this.ReportingComponent.Equals(input.ReportingComponent))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.FirstTimestamp != null) hashCode = hashCode * 59 + this.FirstTimestamp.GetHashCode();
                if (this.LastTimestamp != null) hashCode = hashCode * 59 + this.LastTimestamp.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ReportingComponent != null) hashCode = hashCode * 59 + this.ReportingComponent.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
