using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数解释**：  事件对象信息。
    /// </summary>
    public class EventEntity 
    {

        /// <summary>
        /// **参数解释**：  事件对象ID。  **取值范围**：  实例ID或者节点ID。只能由英文字母、数字组成，后缀为in07或no07，长度为36个字符。
        /// </summary>
        [JsonProperty("event_entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EventEntityId { get; set; }

        /// <summary>
        /// **参数解释**：  事件对象的执行状态。  **取值范围**：    - inquiring：待授权。   - scheduled：待执行。   - executing：执行中。   - completed：执行完成。   - canceled：事件关闭。   - failed：执行失败。
        /// </summary>
        [JsonProperty("event_entity_status", NullValueHandling = NullValueHandling.Ignore)]
        public string EventEntityStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventEntity {\n");
            sb.Append("  eventEntityId: ").Append(EventEntityId).Append("\n");
            sb.Append("  eventEntityStatus: ").Append(EventEntityStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EventEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EventEntity input)
        {
            if (input == null) return false;
            if (this.EventEntityId != input.EventEntityId || (this.EventEntityId != null && !this.EventEntityId.Equals(input.EventEntityId))) return false;
            if (this.EventEntityStatus != input.EventEntityStatus || (this.EventEntityStatus != null && !this.EventEntityStatus.Equals(input.EventEntityStatus))) return false;

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
                if (this.EventEntityId != null) hashCode = hashCode * 59 + this.EventEntityId.GetHashCode();
                if (this.EventEntityStatus != null) hashCode = hashCode * 59 + this.EventEntityStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
