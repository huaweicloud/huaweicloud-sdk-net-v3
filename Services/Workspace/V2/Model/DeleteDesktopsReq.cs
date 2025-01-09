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
    /// 批量删除桌面请求。
    /// </summary>
    public class DeleteDesktopsReq 
    {

        /// <summary>
        /// 待删除的桌面ID列表。
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 删除桌面后，如果当前用户没有其它桌面，可以删除桌面用户。true：删除用户，false：不删除用户，默认为false。
        /// </summary>
        [JsonProperty("delete_users", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteUsers { get; set; }

        /// <summary>
        /// 是否邮件通知，true：邮件通知，false：不通知，默认值true。
        /// </summary>
        [JsonProperty("email_notification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailNotification { get; set; }

        /// <summary>
        /// 是否强制删除，true：强制删除，false：不强制删除
        /// </summary>
        [JsonProperty("is_force_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForceDelete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDesktopsReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
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
            return this.Equals(input as DeleteDesktopsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDesktopsReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.DeleteUsers != null) hashCode = hashCode * 59 + this.DeleteUsers.GetHashCode();
                if (this.EmailNotification != null) hashCode = hashCode * 59 + this.EmailNotification.GetHashCode();
                if (this.IsForceDelete != null) hashCode = hashCode * 59 + this.IsForceDelete.GetHashCode();
                return hashCode;
            }
        }
    }
}
