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
        /// 指定上报的事件或者告警产生的时间。仅支持UTC毫秒级时间戳。  例如：2024-10-16 16:03:01需要通过工具转换成UTC毫秒级时间戳：1702759381000  当action值为空时，即上报事件或告警时需要时指定该参数。
        /// </summary>
        [JsonProperty("starts_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartsAt { get; set; }

        /// <summary>
        /// 指定清除的事件或者告警清除的时间。仅支持UTC毫秒级时间戳。默认值为0，表示没有清除告警。  例如：2024-10-16 16:03:01需要通过工具转换成UTC毫秒级时间戳：1702759381000  当action值为clear时，即清除告警时需要时指定该参数。
        /// </summary>
        [JsonProperty("ends_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndsAt { get; set; }

        /// <summary>
        /// 指定AOM自动清除超期告警的时间，最长清除时间不超过15天。单位：毫秒数，一分钟则填写为60000。例如该时间设置为5天的告警，对应毫秒数：7200 * 60000（即：5天 * 24小时 * 60分钟 * 60000毫秒）。如果上报告警时没指定该时间，则默认清除时间为15天。 当action值为clear时，即清除告警时不需要指定该参数。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timeout { get; set; }

        /// <summary>
        /// 待上报的事件或者告警的详细信息，为key:value键值对形式。支持如下必填字段： - event_name：事件或者告警名称，类型为String； - event_severity：事件或告警级别。类型为String，支持四种级别：    - Critical：紧急    - Major：重要    - Minor：次要    - Info：提示 - event_type：事件或告警类别。类型为String，支持两种类别：   - event：告警事件   - alarm：普通告警 - resource_provider：事件对应云服务名称。类型为String；  - resource_type：事件对应资源类型。类型为String；  - resource_id：事件对应资源信息。类型为String。 metadata中的value长度为1到2048字符串。
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 事件或者告警附加字段，可以为空。
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Annotations { get; set; }

        /// <summary>
        /// 事件或者告警预留字段，可以为空。
        /// </summary>
        [JsonProperty("attach_rule", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> AttachRule { get; set; }

        /// <summary>
        /// 事件或者告警id，产生事件或告警时，系统会自动生成。  当action值为clear时，即清除告警时需要时指定该参数。上报事件或告警时无需传入该参数。
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
            if (input == null) return false;
            if (this.StartsAt != input.StartsAt || (this.StartsAt != null && !this.StartsAt.Equals(input.StartsAt))) return false;
            if (this.EndsAt != input.EndsAt || (this.EndsAt != null && !this.EndsAt.Equals(input.EndsAt))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && input.Metadata != null && !this.Metadata.SequenceEqual(input.Metadata))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && input.Annotations != null && !this.Annotations.SequenceEqual(input.Annotations))) return false;
            if (this.AttachRule != input.AttachRule || (this.AttachRule != null && input.AttachRule != null && !this.AttachRule.SequenceEqual(input.AttachRule))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.StartsAt != null) hashCode = hashCode * 59 + this.StartsAt.GetHashCode();
                if (this.EndsAt != null) hashCode = hashCode * 59 + this.EndsAt.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                if (this.AttachRule != null) hashCode = hashCode * 59 + this.AttachRule.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
