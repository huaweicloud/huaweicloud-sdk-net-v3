using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 直播通知配置。通过短信，邮件，站内信通知用户直播中断。用户可在华为云消息中心配置接受者信息
    /// </summary>
    public class LiveNotifyConfig 
    {

        /// <summary>
        /// **参数解释**： 启用通知事件列表。 **约束限制**： 不涉及 **默认取值**： 无。
        /// </summary>
        [JsonProperty("notify_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotifyEventEnum> NotifyEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveNotifyConfig {\n");
            sb.Append("  notifyEvents: ").Append(NotifyEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveNotifyConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveNotifyConfig input)
        {
            if (input == null) return false;
            if (this.NotifyEvents != input.NotifyEvents || (this.NotifyEvents != null && input.NotifyEvents != null && !this.NotifyEvents.SequenceEqual(input.NotifyEvents))) return false;

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
                if (this.NotifyEvents != null) hashCode = hashCode * 59 + this.NotifyEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
