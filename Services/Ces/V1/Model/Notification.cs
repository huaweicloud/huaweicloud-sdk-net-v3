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
    /// 
    /// </summary>
    public class Notification 
    {

        /// <summary>
        /// **参数解释**： 告警通知类型。 **约束限制**： 不涉及。 **取值范围**： 取值如下： notification、autoscaling - notification：通知组或主题订阅 - autoscaling：AS通知，只在AS中使用 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 告警状态发生变化时，被通知对象的列表。 **约束限制**： 通知对象ID最多可以配置20个。 topicUrn可从SMN获取，具体操作请参考“查询Topic列表”。 说明：若alarm_action_enabled为true，对应的alarm_actions、ok_actions至少有一个不能为空。若alarm_actions、ok_actions同时存在时，notificationList值保持一致。 
        /// </summary>
        [JsonProperty("notificationList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  notificationList: ").Append(NotificationList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Notification input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.NotificationList != input.NotificationList || (this.NotificationList != null && input.NotificationList != null && !this.NotificationList.SequenceEqual(input.NotificationList))) return false;

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
                if (this.NotificationList != null) hashCode = hashCode * 59 + this.NotificationList.GetHashCode();
                return hashCode;
            }
        }
    }
}
