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
    /// 修改桌面用户权限请求桌面信息。
    /// </summary>
    public class ChangeUserPrivilegeGroupDesktopInfo 
    {

        /// <summary>
        /// 待修改的桌面ID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 待修改用户权限组的用户信息。未传该参数的桌面的用于将应用上层结构的参数user_privilege_group作为其用户的用户权限组。
        /// </summary>
        [JsonProperty("attach_user_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChangeUserPrivilegeGroupUserInfo> AttachUserInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeUserPrivilegeGroupDesktopInfo {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  attachUserInfos: ").Append(AttachUserInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeUserPrivilegeGroupDesktopInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeUserPrivilegeGroupDesktopInfo input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.AttachUserInfos != input.AttachUserInfos || (this.AttachUserInfos != null && input.AttachUserInfos != null && !this.AttachUserInfos.SequenceEqual(input.AttachUserInfos))) return false;

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
                if (this.AttachUserInfos != null) hashCode = hashCode * 59 + this.AttachUserInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
