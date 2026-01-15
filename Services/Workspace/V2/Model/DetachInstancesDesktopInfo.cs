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
    /// 分配用户请求桌面信息。
    /// </summary>
    public class DetachInstancesDesktopInfo 
    {

        /// <summary>
        /// 分配的桌面ID。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 表示解关联所有用户：true，如果指定那么detach_user_infos会失效；指定解关联用户：false，通过detach_user_infos指定解关联的用户。
        /// </summary>
        [JsonProperty("is_detach_all_users", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDetachAllUsers { get; set; }

        /// <summary>
        /// 解分配的用户信息列表。
        /// </summary>
        [JsonProperty("detach_user_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetachInstancesUserInfo> DetachUserInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachInstancesDesktopInfo {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  isDetachAllUsers: ").Append(IsDetachAllUsers).Append("\n");
            sb.Append("  detachUserInfos: ").Append(DetachUserInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachInstancesDesktopInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachInstancesDesktopInfo input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.IsDetachAllUsers != input.IsDetachAllUsers || (this.IsDetachAllUsers != null && !this.IsDetachAllUsers.Equals(input.IsDetachAllUsers))) return false;
            if (this.DetachUserInfos != input.DetachUserInfos || (this.DetachUserInfos != null && input.DetachUserInfos != null && !this.DetachUserInfos.SequenceEqual(input.DetachUserInfos))) return false;

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
                if (this.IsDetachAllUsers != null) hashCode = hashCode * 59 + this.IsDetachAllUsers.GetHashCode();
                if (this.DetachUserInfos != null) hashCode = hashCode * 59 + this.DetachUserInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
