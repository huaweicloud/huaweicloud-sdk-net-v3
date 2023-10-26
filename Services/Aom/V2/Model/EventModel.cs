using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 事件或者告警元数据。
    /// </summary>
    public class EventModel 
    {

        /// <summary>
        /// 事件或者告警产生的时间，CST毫秒级时间戳。
        /// </summary>
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartsAt { get; set; }

        /// <summary>
        /// 事件或者告警清除的时间，CST毫秒级时间戳，为0时表示未删除。
        /// </summary>
        [JsonProperty("ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndsAt { get; set; }

        /// <summary>
        /// 告警自动清除时间。毫秒数，例如一分钟则填写为60000。默认清除时间为3天,对应数字为 4320 * 1000（即：3天 * 24小时 * 60分钟 * 1000毫秒）。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timeout { get; set; }

        /// <summary>
        /// 事件或者告警的详细信息，为键值对形式。必须字段为： - event_name：事件或者告警名称,类型为String； - event_severity：事件级别枚举值。类型为String，四种类型 \&quot;Critical\&quot;, \&quot;Major\&quot;, \&quot;Minor\&quot;, \&quot;Info\&quot;； - event_type：事件类别枚举值。类型为String，event为普通告警，alarm为告警事件； - resource_provider：事件对应云服务名称。类型为String； - resource_type：事件对应资源类型。类型为String； - resource_id：事件对应资源信息。类型为String。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Object Metadata { get; set; }

        /// <summary>
        /// 事件或者告警附加字段，可以为空。
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Object Annotations { get; set; }

        /// <summary>
        /// 事件或者告警预留字段，为空。
        /// </summary>
        [JsonProperty("attach_rule", NullValueHandling = NullValueHandling.Ignore)]
        public Object AttachRule { get; set; }

        /// <summary>
        /// 事件或者告警id，系统会自动生成，上报无须填写该字段。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventModel {\n");
            sb.Append("  startsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  endsAt: ").Append(EndsAt).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("  attachRule: ").Append(AttachRule).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.StartsAt == input.StartsAt ||
                    (this.StartsAt != null &&
                    this.StartsAt.Equals(input.StartsAt))
                ) && 
                (
                    this.EndsAt == input.EndsAt ||
                    (this.EndsAt != null &&
                    this.EndsAt.Equals(input.EndsAt))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Annotations == input.Annotations ||
                    (this.Annotations != null &&
                    this.Annotations.Equals(input.Annotations))
                ) && 
                (
                    this.AttachRule == input.AttachRule ||
                    (this.AttachRule != null &&
                    this.AttachRule.Equals(input.AttachRule))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.StartsAt != null)
                    hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                if (this.EndsAt != null)
                    hashCode = hashCode * 59 + this.EndsAt.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Annotations != null)
                    hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.AttachRule != null)
                    hashCode = hashCode * 59 + this.AttachRule.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
