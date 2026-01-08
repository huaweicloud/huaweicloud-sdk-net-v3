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
    /// 更换桌面关联用户名请求。
    /// </summary>
    public class UpdateDesktopUsernameReq 
    {

        /// <summary>
        /// 桌面关联原用户名，只传用户名，不带域信息。
        /// </summary>
        [JsonProperty("old_username", NullValueHandling = NullValueHandling.Ignore)]
        public string OldUsername { get; set; }

        /// <summary>
        /// 桌面关联原用户名的域。
        /// </summary>
        [JsonProperty("old_user_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string OldUserDomain { get; set; }

        /// <summary>
        /// 桌面关联新用户名，只传用户名，不带域信息。
        /// </summary>
        [JsonProperty("new_username", NullValueHandling = NullValueHandling.Ignore)]
        public string NewUsername { get; set; }

        /// <summary>
        /// 桌面关联新用户名的域。
        /// </summary>
        [JsonProperty("new_user_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string NewUserDomain { get; set; }

        /// <summary>
        /// 桌面关联新用户名后是否重启虚拟机，默认不重启。
        /// </summary>
        [JsonProperty("is_reboot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReboot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDesktopUsernameReq {\n");
            sb.Append("  oldUsername: ").Append(OldUsername).Append("\n");
            sb.Append("  oldUserDomain: ").Append(OldUserDomain).Append("\n");
            sb.Append("  newUsername: ").Append(NewUsername).Append("\n");
            sb.Append("  newUserDomain: ").Append(NewUserDomain).Append("\n");
            sb.Append("  isReboot: ").Append(IsReboot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDesktopUsernameReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDesktopUsernameReq input)
        {
            if (input == null) return false;
            if (this.OldUsername != input.OldUsername || (this.OldUsername != null && !this.OldUsername.Equals(input.OldUsername))) return false;
            if (this.OldUserDomain != input.OldUserDomain || (this.OldUserDomain != null && !this.OldUserDomain.Equals(input.OldUserDomain))) return false;
            if (this.NewUsername != input.NewUsername || (this.NewUsername != null && !this.NewUsername.Equals(input.NewUsername))) return false;
            if (this.NewUserDomain != input.NewUserDomain || (this.NewUserDomain != null && !this.NewUserDomain.Equals(input.NewUserDomain))) return false;
            if (this.IsReboot != input.IsReboot || (this.IsReboot != null && !this.IsReboot.Equals(input.IsReboot))) return false;

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
                if (this.OldUsername != null) hashCode = hashCode * 59 + this.OldUsername.GetHashCode();
                if (this.OldUserDomain != null) hashCode = hashCode * 59 + this.OldUserDomain.GetHashCode();
                if (this.NewUsername != null) hashCode = hashCode * 59 + this.NewUsername.GetHashCode();
                if (this.NewUserDomain != null) hashCode = hashCode * 59 + this.NewUserDomain.GetHashCode();
                if (this.IsReboot != null) hashCode = hashCode * 59 + this.IsReboot.GetHashCode();
                return hashCode;
            }
        }
    }
}
