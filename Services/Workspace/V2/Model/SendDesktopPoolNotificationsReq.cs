using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 发送桌面池消息通知请求体。
    /// </summary>
    public class SendDesktopPoolNotificationsReq 
    {

        /// <summary>
        /// 消息通知内容。
        /// </summary>
        [JsonProperty("notifications", NullValueHandling = NullValueHandling.Ignore)]
        public string Notifications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendDesktopPoolNotificationsReq {\n");
            sb.Append("  notifications: ").Append(Notifications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendDesktopPoolNotificationsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendDesktopPoolNotificationsReq input)
        {
            if (input == null) return false;
            if (this.Notifications != input.Notifications || (this.Notifications != null && !this.Notifications.Equals(input.Notifications))) return false;

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
                if (this.Notifications != null) hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                return hashCode;
            }
        }
    }
}
