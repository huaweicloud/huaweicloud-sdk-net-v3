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
    /// 批量修改用户权限组请求。
    /// </summary>
    public class ChangeUserPrivilegeGroupReq 
    {

        /// <summary>
        /// 桌面信息列表。
        /// </summary>
        [JsonProperty("desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChangeUserPrivilegeGroupDesktopInfo> Desktops { get; set; }

        /// <summary>
        /// 桌面用户所属的用户权限组。desktops参数中，各个桌面所属的未传的桌面用户将应用该权限组。 - sudo：Linux管理员组。 - default：Linux默认用户组。 - administrators：Windows管理员组。管理员拥有对该桌面的完全访问权，可以做任何需要的更改（禁用操作除外）。 - users：Windows标准用户组。标准用户可以使用大多数软件，并可以更改不影响其他用户的系统设置。
        /// </summary>
        [JsonProperty("user_privilege_group", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrivilegeGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeUserPrivilegeGroupReq {\n");
            sb.Append("  desktops: ").Append(Desktops).Append("\n");
            sb.Append("  userPrivilegeGroup: ").Append(UserPrivilegeGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeUserPrivilegeGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeUserPrivilegeGroupReq input)
        {
            if (input == null) return false;
            if (this.Desktops != input.Desktops || (this.Desktops != null && input.Desktops != null && !this.Desktops.SequenceEqual(input.Desktops))) return false;
            if (this.UserPrivilegeGroup != input.UserPrivilegeGroup || (this.UserPrivilegeGroup != null && !this.UserPrivilegeGroup.Equals(input.UserPrivilegeGroup))) return false;

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
                if (this.Desktops != null) hashCode = hashCode * 59 + this.Desktops.GetHashCode();
                if (this.UserPrivilegeGroup != null) hashCode = hashCode * 59 + this.UserPrivilegeGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
