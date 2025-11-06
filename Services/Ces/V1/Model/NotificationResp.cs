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
    public class NotificationResp 
    {

        /// <summary>
        /// **参数解释**： 告警通知类型。 **取值范围**： 取值如下： notification：SMN通知； autoscaling：AS通知。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 告警状态发生变化时，被通知对象的列表。 
        /// </summary>
        [JsonProperty("notificationList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationResp {\n");
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
            return this.Equals(input as NotificationResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotificationResp input)
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
