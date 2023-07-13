using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NotificationConfigReq 
    {

        /// <summary>
        /// 事件通知模板信息 
        /// </summary>
        [JsonProperty("notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> Notifications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationConfigReq {\n");
            sb.Append("  notifications: ").Append(Notifications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotificationConfigReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
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
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                return hashCode;
            }
        }
    }
}
