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
    public class DeleteDesktopRequest 
    {

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [SDKProperty("desktop_id", IsPath = true)]
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 删除桌面后，如果当前用户没有其它桌面，可以删除桌面用户。true：删除用户，false：不删除用户，默认为false。
        /// </summary>
        [SDKProperty("delete_users", IsQuery = true)]
        [JsonProperty("delete_users", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteUsers { get; set; }

        /// <summary>
        /// 删除桌面后，是否给桌面用户发送系统通知邮件。true：发送，false：不发送。默认为true。
        /// </summary>
        [SDKProperty("email_notification", IsQuery = true)]
        [JsonProperty("email_notification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailNotification { get; set; }

        /// <summary>
        /// 是否强制删除。
        /// </summary>
        [SDKProperty("is_force_delete", IsQuery = true)]
        [JsonProperty("is_force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForceDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDesktopRequest {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  deleteUsers: ").Append(DeleteUsers).Append("\n");
            sb.Append("  emailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  isForceDelete: ").Append(IsForceDelete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDesktopRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDesktopRequest input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DeleteUsers != input.DeleteUsers || (this.DeleteUsers != null && !this.DeleteUsers.Equals(input.DeleteUsers))) return false;
            if (this.EmailNotification != input.EmailNotification || (this.EmailNotification != null && !this.EmailNotification.Equals(input.EmailNotification))) return false;
            if (this.IsForceDelete != input.IsForceDelete || (this.IsForceDelete != null && !this.IsForceDelete.Equals(input.IsForceDelete))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DeleteUsers != null) hashCode = hashCode * 59 + this.DeleteUsers.GetHashCode();
                if (this.EmailNotification != null) hashCode = hashCode * 59 + this.EmailNotification.GetHashCode();
                if (this.IsForceDelete != null) hashCode = hashCode * 59 + this.IsForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
