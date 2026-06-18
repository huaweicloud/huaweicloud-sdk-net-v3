using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WebHookEventCfgDto 
    {

        /// <summary>
        /// **参数解释：** 事件类型。 **取值范围：** 最小1个字节，最大255字节
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// **参数解释：** 配置信息。 **取值范围：** 最小1个字节，最大255字节
        /// </summary>
        [JsonProperty("cfgs", NullValueHandling = NullValueHandling.Ignore)]
        public string Cfgs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookEventCfgDto {\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  cfgs: ").Append(Cfgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebHookEventCfgDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebHookEventCfgDto input)
        {
            if (input == null) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.Cfgs != input.Cfgs || (this.Cfgs != null && !this.Cfgs.Equals(input.Cfgs))) return false;

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
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Cfgs != null) hashCode = hashCode * 59 + this.Cfgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
