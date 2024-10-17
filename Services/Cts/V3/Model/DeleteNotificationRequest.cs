using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteNotificationRequest 
    {

        /// <summary>
        /// 标识关键操作通知id。 批量删除请使用逗号隔开，notification_id&#x3D;\&quot;xxx1,cccc2\&quot;
        /// </summary>
        [SDKProperty("notification_id", IsQuery = true)]
        [JsonProperty("notification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNotificationRequest {\n");
            sb.Append("  notificationId: ").Append(NotificationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNotificationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNotificationRequest input)
        {
            if (input == null) return false;
            if (this.NotificationId != input.NotificationId || (this.NotificationId != null && !this.NotificationId.Equals(input.NotificationId))) return false;

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
                if (this.NotificationId != null) hashCode = hashCode * 59 + this.NotificationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
