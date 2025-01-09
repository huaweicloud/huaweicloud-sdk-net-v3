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
    /// Request Object
    /// </summary>
    public class ResetRandomPasswordRequest 
    {

        /// <summary>
        /// 用户ID。
        /// </summary>
        [SDKProperty("user_id", IsPath = true)]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 通知用户类型，现在有“email”和“phone”两种，用\&quot;,\&quot;分开，用户为用户激活模式时必须要带上通知类型，以便接收到密码通知。
        /// </summary>
        [SDKProperty("notification_type", IsQuery = true)]
        [JsonProperty("notification_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetRandomPasswordRequest {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  notificationType: ").Append(NotificationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetRandomPasswordRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetRandomPasswordRequest input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.NotificationType != input.NotificationType || (this.NotificationType != null && !this.NotificationType.Equals(input.NotificationType))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.NotificationType != null) hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
